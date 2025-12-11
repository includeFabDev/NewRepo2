Imports System.Runtime.InteropServices
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Diagnostics
Imports System.ComponentModel

Public Class Form1

    ' -----------------------------
    ' Estado / bounds
    ' -----------------------------
    Private formSize As Size
    Private prevBounds As Rectangle = Rectangle.Empty
    Private savedBounds As Rectangle = Rectangle.Empty
    Private isBorderlessMaximized As Boolean = False

    ' Animación maximize
    Private animateTimer As Timer
    Private animStart As Stopwatch
    Private animFrom As Rectangle
    Private animTo As Rectangle
    Private animDurationMs As Integer = 220

    ' -----------------------------
    ' Interop para mover, redondeo y shadow
    ' -----------------------------
    <DllImport("user32.dll", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.dll", EntryPoint:="SendMessage", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function

    ' CreateRoundRectRgn / SetWindowRgn para esquinas redondeadas
    <DllImport("gdi32.dll")>
    Private Shared Function CreateRoundRectRgn(ByVal nLeftRect As Integer, ByVal nTopRect As Integer, ByVal nRightRect As Integer, ByVal nBottomRect As Integer, ByVal nWidthEllipse As Integer, ByVal nHeightEllipse As Integer) As IntPtr
    End Function
    <DllImport("user32.dll")>
    Private Shared Function SetWindowRgn(ByVal hWnd As IntPtr, ByVal hRgn As IntPtr, ByVal bRedraw As Boolean) As Integer
    End Function

    ' Para sombra de ventana mediante clase (CS_DROPSHADOW)
    Private Const CS_DROPSHADOW As Integer = &H20000
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property

    ' -----------------------------
    ' Detectar modo diseño
    ' -----------------------------
    Private Function IsDesignMode() As Boolean
        Return (Me.Site IsNot Nothing AndAlso Me.Site.DesignMode) OrElse LicenseManager.UsageMode = LicenseUsageMode.Designtime
    End Function

    ' -----------------------------
    ' Load
    ' -----------------------------
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IsDesignMode() Then Return

        ' Hacemos borderless y algunas propiedades
        Me.FormBorderStyle = FormBorderStyle.None
        Me.DoubleBuffered = True
        Me.Text = String.Empty
        Me.MaximizeBox = True
        Me.MinimizeBox = True

        ' Eventos de arrastre desde panels si existen
        If Me.Controls.ContainsKey("PanelTittleBar") AndAlso TypeOf Me.Controls("PanelTittleBar") Is Panel Then
            Dim panel As Panel = CType(Me.Controls("PanelTittleBar"), Panel)
            AddHandler panel.MouseDown, AddressOf panelTitleBar_MouseDown
        End If
        If Me.Controls.ContainsKey("PanelDesktop") AndAlso TypeOf Me.Controls("PanelDesktop") Is Panel Then
            AddHandler CType(Me.Controls("PanelDesktop"), Panel).MouseDown, AddressOf panelTitleBar_MouseDown
        End If

        AddHandler Me.MouseDown, AddressOf panelTitleBar_MouseDown
        AddHandler Me.Resize, AddressOf Form1_Resize

        formSize = Me.ClientSize
        prevBounds = New Rectangle(Me.Location, Me.Size)
        savedBounds = Rectangle.Empty
        isBorderlessMaximized = False

        ' Inicializar timer de animación
        animStart = New Stopwatch()
        animateTimer = New Timer()
        animateTimer.Interval = 15
        AddHandler animateTimer.Tick, AddressOf AnimateTimer_Tick

        ' Aplicar esquinas redondeadas al cargar
        ApplyRoundedCorners(14) ' radio en px

    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs)
        ' reaplicar radio al redimensionar para mantener forma
        ApplyRoundedCorners(14)
    End Sub

    ' -----------------------------
    ' REDONDEO: ApplyRoundedCorners
    ' -----------------------------
    Private Sub ApplyRoundedCorners(radius As Integer)
        Try
            If radius <= 0 Then
                ' restaurar region nula
                SetWindowRgn(Me.Handle, IntPtr.Zero, True)
                Return
            End If
            Dim r As IntPtr = CreateRoundRectRgn(0, 0, Me.Width + 1, Me.Height + 1, radius, radius)
            SetWindowRgn(Me.Handle, r, True)
        Catch ex As Exception
            ' ignore
        End Try
    End Sub

    ' -----------------------------
    ' MOVER desde cualquier panel
    ' -----------------------------
    Private Sub panelTitleBar_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, &H112, &HF012, 0)
        End If
    End Sub

    ' -----------------------------
    ' Abrir modal (seguro) - y abrir formulario DENTRO de PanelDesktop (MDI moderno)
    ' -----------------------------
    Private Sub OpenModalByType(example As Form)
        Try
            If example Is Nothing Then Exit Sub
            Dim tType As Type = example.GetType()
            Dim frm As Form = CType(Activator.CreateInstance(tType), Form)
            frm.StartPosition = FormStartPosition.CenterParent
            frm.ShowInTaskbar = False
            frm.ShowDialog(Me)
            frm.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error al abrir formulario modal: " & ex.Message)
        End Try
    End Sub

    ' Abre un form dentro de PanelDesktop (MDI moderno)
    Public Sub OpenChildInPanel(childForm As Form)
        If childForm Is Nothing Then Return
        If Not Me.Controls.ContainsKey("PanelDesktop") Then
            MessageBox.Show("No existe PanelDesktop en este formulario.")
            Return
        End If

        Try
            childForm.TopLevel = False
            childForm.FormBorderStyle = FormBorderStyle.None
            childForm.Dock = DockStyle.Fill
            CType(Me.Controls("PanelDesktop"), Panel).Controls.Clear()
            CType(Me.Controls("PanelDesktop"), Panel).Controls.Add(childForm)
            childForm.Show()
            childForm.BringToFront()
        Catch ex As Exception
            MessageBox.Show("Error al abrir child: " & ex.Message)
        End Try
    End Sub

    ' ---------- Botones de ejemplo ----------
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        ' Modal
        OpenModalByType(frm_libro_diario)
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        ' Modal
        OpenModalByType(frm_libro_mayor)
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        ' Abrir dentro del panel desktop (MDI moderno)
        Dim f As New frm_cuentas()
        OpenChildInPanel(f)
    End Sub

    Private Sub IconButton4_Click_1(sender As Object, e As EventArgs) Handles IconButton4.Click
        ' Abrir dentro del panel desktop (MDI moderno)
        Dim f As New frm_balance()
        OpenChildInPanel(f)
    End Sub

    ' -----------------------------
    ' WndProc: redimensionado + maximize animation handling
    ' -----------------------------
    Protected Overrides Sub WndProc(ByRef m As Message)
        Const WM_NCCALCSIZE As Integer = &H83
        Const WM_SYSCOMMAND As Integer = &H112
        Const SC_MINIMIZE As Integer = &HF020
        Const SC_RESTORE As Integer = &HF120
        Const SC_MAXIMIZE As Integer = &HF030
        Const WM_NCHITTEST As Integer = &H84
        Const resizeAreaSize As Integer = 8

        Const HTCLIENT As Integer = 1
        Const HTLEFT As Integer = 10
        Const HTRIGHT As Integer = 11
        Const HTTOP As Integer = 12
        Const HTTOPLEFT As Integer = 13
        Const HTTOPRIGHT As Integer = 14
        Const HTBOTTOM As Integer = 15
        Const HTBOTTOMLEFT As Integer = 16
        Const HTBOTTOMRIGHT As Integer = 17

        If m.Msg = WM_NCHITTEST Then
            MyBase.WndProc(m)
            If Me.WindowState = FormWindowState.Normal Then
                If m.Result.ToInt32() = HTCLIENT Then
                    ' coordenadas
                    Dim lp As Integer = m.LParam.ToInt32()
                    Dim x As Integer = lp And &HFFFF
                    Dim y As Integer = (lp >> 16) And &HFFFF
                    Dim screenPoint As New Point(x, y)
                    Dim clientPoint As Point = Me.PointToClient(screenPoint)

                    If clientPoint.Y <= resizeAreaSize Then
                        If clientPoint.X <= resizeAreaSize Then
                            m.Result = New IntPtr(HTTOPLEFT)
                        ElseIf clientPoint.X < (Me.ClientSize.Width - resizeAreaSize) Then
                            m.Result = New IntPtr(HTTOP)
                        Else
                            m.Result = New IntPtr(HTTOPRIGHT)
                        End If
                    ElseIf clientPoint.Y <= (Me.ClientSize.Height - resizeAreaSize) Then
                        If clientPoint.X <= resizeAreaSize Then
                            m.Result = New IntPtr(HTLEFT)
                        ElseIf clientPoint.X > (Me.ClientSize.Width - resizeAreaSize) Then
                            m.Result = New IntPtr(HTRIGHT)
                        End If
                    Else
                        If clientPoint.X <= resizeAreaSize Then
                            m.Result = New IntPtr(HTBOTTOMLEFT)
                        ElseIf clientPoint.X < (Me.ClientSize.Width - resizeAreaSize) Then
                            m.Result = New IntPtr(HTBOTTOM)
                        Else
                            m.Result = New IntPtr(HTBOTTOMRIGHT)
                        End If
                    End If
                End If
            End If
            Return
        End If

        If m.Msg = WM_NCCALCSIZE AndAlso m.WParam.ToInt32() = 1 Then
            ' para borderless snap
            Return
        End If

        If m.Msg = WM_SYSCOMMAND Then
            Dim wParam As Integer = (m.WParam.ToInt32() And &HFFF0)
            If wParam = SC_MINIMIZE Then
                savedBounds = Me.Bounds
                formSize = Me.ClientSize
            ElseIf wParam = SC_MAXIMIZE Then
                If Me.FormBorderStyle = FormBorderStyle.None Then
                    If Not isBorderlessMaximized Then
                        prevBounds = Me.Bounds
                        Dim wa = Screen.FromHandle(Me.Handle).WorkingArea
                        ' animar desde prevBounds -> wa
                        StartAnimate(prevBounds, wa)
                        isBorderlessMaximized = True
                        Return
                    End If
                End If
            ElseIf wParam = SC_RESTORE Then
                If isBorderlessMaximized Then
                    ' animar desde bounds actuales -> prevBounds
                    StartAnimate(Me.Bounds, prevBounds)
                    isBorderlessMaximized = False
                    Me.WindowState = FormWindowState.Normal
                    Return
                ElseIf Not savedBounds.IsEmpty Then
                    Me.Bounds = savedBounds
                    savedBounds = Rectangle.Empty
                    Me.WindowState = FormWindowState.Normal
                    Return
                Else
                    Me.Size = formSize
                End If
            End If
        End If

        MyBase.WndProc(m)
    End Sub

    ' -----------------------------
    ' Animación: StartAnimate / AnimateTimer_Tick
    ' -----------------------------
    Private Sub StartAnimate(fromRect As Rectangle, toRect As Rectangle)
        animFrom = fromRect
        animTo = toRect
        animStart.Restart()
        animateTimer.Start()
    End Sub

    Private Sub AnimateTimer_Tick(sender As Object, e As EventArgs)
        Dim t As Double = animStart.ElapsedMilliseconds / animDurationMs
        If t >= 1.0 Then
            animateTimer.Stop()
            animStart.Stop()
            Me.Bounds = animTo
            ApplyRoundedCorners(14)
            Return
        End If

        ' interpolación suave (ease)
        Dim s As Double = 1 - Math.Pow(1 - t, 3) ' ease out cubic
        Dim nx As Integer = CInt(animFrom.X + (animTo.X - animFrom.X) * s)
        Dim ny As Integer = CInt(animFrom.Y + (animTo.Y - animFrom.Y) * s)
        Dim nw As Integer = CInt(animFrom.Width + (animTo.Width - animFrom.Width) * s)
        Dim nh As Integer = CInt(animFrom.Height + (animTo.Height - animFrom.Height) * s)

        Me.Bounds = New Rectangle(nx, ny, nw, nh)
        ApplyRoundedCorners(14)
    End Sub

    ' -----------------------------
    ' MDI utilities / debug utilities
    ' -----------------------------
    Public Sub ShowOpenFormsInfo()
        Dim sb As New System.Text.StringBuilder()
        sb.AppendLine("=== OpenForms ===")
        For Each f As Form In Application.OpenForms
            Dim ownerName As String = If(f.Owner IsNot Nothing, f.Owner.Name, "null")
            sb.AppendLine(String.Format("Name={0}, Visible={1}, Enabled={2}, Owner={3}, TopMost={4}", f.Name, f.Visible, f.Enabled, ownerName, f.TopMost))
        Next
        MessageBox.Show(sb.ToString(), "OpenForms Info")
    End Sub

    Public Sub ForceEnableAllForms()
        For Each f As Form In Application.OpenForms
            Try
                f.Enabled = True
            Catch
            End Try
        Next
        MessageBox.Show("Todos los formularios forzados a Enabled = True", "Patch")
    End Sub

    ' -----------------------------
    ' Botones minimizar / maximizar (si no usas WndProc SC handlers directos)
    ' -----------------------------
    Private Sub IconButton7_Click(sender As Object, e As EventArgs) Handles IconButton7.Click
        If Me.FormBorderStyle = FormBorderStyle.None Then
            If isBorderlessMaximized Then
                If Not prevBounds.IsEmpty Then
                    StartAnimate(Me.Bounds, prevBounds)
                End If
                isBorderlessMaximized = False
                Me.WindowState = FormWindowState.Normal
            Else
                prevBounds = Me.Bounds
                Dim wa = Screen.FromHandle(Me.Handle).WorkingArea
                StartAnimate(Me.Bounds, wa)
                isBorderlessMaximized = True
                Me.WindowState = FormWindowState.Normal
            End If
        Else
            If Me.WindowState = FormWindowState.Normal Then
                savedBounds = Me.Bounds
                Me.WindowState = FormWindowState.Maximized
            Else
                Me.WindowState = FormWindowState.Normal
            End If
        End If
    End Sub

    Private Sub IconButton8_Click(sender As Object, e As EventArgs) Handles IconButton8.Click
        savedBounds = Me.Bounds
        formSize = Me.ClientSize
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PanelTittleBar_Paint(sender As Object, e As PaintEventArgs) Handles PanelTittleBar.Paint
        ' opcional: dibujar sombra o elementos
    End Sub

    Private Sub IconButton6_Click(sender As Object, e As EventArgs) Handles IconButton6.Click
        Me.Close()
    End Sub
End Class
