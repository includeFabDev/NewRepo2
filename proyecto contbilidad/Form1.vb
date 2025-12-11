Imports System.Runtime.InteropServices
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Diagnostics
Imports System.ComponentModel

Public Class Form1

    ' Tamaño/bounds guardados
    Private formSize As Size
    Private prevBounds As Rectangle = Rectangle.Empty           ' para maximizar sin borde
    Private savedBounds As Rectangle = Rectangle.Empty          ' para restaurar tras minimizar
    Private isBorderlessMaximized As Boolean = False

    ' Detectar modo diseño
    Private Function IsDesignMode() As Boolean
        Return (Me.Site IsNot Nothing AndAlso Me.Site.DesignMode) OrElse LicenseManager.UsageMode = LicenseUsageMode.Designtime
    End Function

    ' Declaraciones para arrastrar el formulario
    <DllImport("user32.dll", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.dll", EntryPoint:="SendMessage", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IsDesignMode() Then Return

        ' Opcional: Si no quieres que se muestre texto en caso de repintado accidental
        Me.Text = String.Empty

        ' Arrastrar desde PanelTittleBar o PanelDesktop si existen
        If Me.Controls.ContainsKey("PanelTittleBar") AndAlso TypeOf Me.Controls("PanelTittleBar") Is Panel Then
            Dim panel As Panel = CType(Me.Controls("PanelTittleBar"), Panel)
            AddHandler panel.MouseDown, AddressOf panelTitleBar_MouseDown
        End If
        If Me.Controls.ContainsKey("PanelDesktop") AndAlso TypeOf Me.Controls("PanelDesktop") Is Panel Then
            AddHandler CType(Me.Controls("PanelDesktop"), Panel).MouseDown, AddressOf panelTitleBar_MouseDown
        End If

        AddHandler Me.MouseDown, AddressOf panelTitleBar_MouseDown
        AddHandler Me.Resize, AddressOf Form1_Resize

        ' Inicializar estados
        formSize = Me.ClientSize
        prevBounds = New Rectangle(Me.Location, Me.Size)
        savedBounds = Rectangle.Empty
        isBorderlessMaximized = False
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs)
        ' aquí puedes añadir lógica si necesitas reposicionar controles al (re)dimensionar
    End Sub

    ' ---------- Open modal seguro: crea nueva instancia del tipo ----------
    Private Sub OpenModalByType(example As Form)
        Try
            If example Is Nothing Then Exit Sub

            Dim tType As Type = example.GetType()
            Dim frm As Form = CType(Activator.CreateInstance(tType), Form)

            ' Opcionales: configuración segura
            frm.StartPosition = FormStartPosition.CenterParent
            frm.ShowInTaskbar = False

            ' Mostrar modal con Form1 como dueño
            frm.ShowDialog(Me)
            frm.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error al abrir formulario modal: " & ex.Message)
        End Try
    End Sub

    ' ---------- Depuración / utilidades ----------
    ' Muestra el estado de los forms abiertos (Name, Visible, Enabled, Owner)
    Public Sub ShowOpenFormsInfo()
        Dim sb As New System.Text.StringBuilder()
        sb.AppendLine("=== OpenForms ===")
        For Each f As Form In Application.OpenForms
            Dim ownerName As String = If(f.Owner IsNot Nothing, f.Owner.Name, "null")
            sb.AppendLine(String.Format("Name={0}, Visible={1}, Enabled={2}, Owner={3}, TopMost={4}", f.Name, f.Visible, f.Enabled, ownerName, f.TopMost))
        Next
        MessageBox.Show(sb.ToString(), "OpenForms Info")
    End Sub

    ' Forzar todos los formularios a Enabled = True (PARCHE TEMPORAL)
    Public Sub ForceEnableAllForms()
        For Each f As Form In Application.OpenForms
            Try
                f.Enabled = True
            Catch
            End Try
        Next
        MessageBox.Show("Todos los formularios forzados a Enabled = True", "Patch")
    End Sub

    ' Arrastrar ventana desde título personalizado
    Private Sub panelTitleBar_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, &H112, &HF012, 0)
        End If
    End Sub

    ' ---------- Botones: abrir como modal (creando instancia nueva) ----------
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        OpenModalByType(frm_libro_diario)
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        OpenModalByType(frm_libro_mayor)
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        OpenModalByType(frm_cuentas)
    End Sub

    Private Sub IconButton4_Click_1(sender As Object, e As EventArgs) Handles IconButton4.Click
        OpenModalByType(frm_balance)
    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim Proceso As New Process()
        Proceso.StartInfo.FileName = "calc.exe"
        Proceso.StartInfo.Arguments = ""
        Proceso.Start()
    End Sub

    Private Sub IconButton6_Click(sender As Object, e As EventArgs) Handles IconButton6.Click
        Application.Exit()
    End Sub

    ' WndProc: redimensionado por bordes y mantener bounds en minimizar/restaurar/maximizar
    Protected Overrides Sub WndProc(ByRef m As Message)
        Const WM_NCCALCSIZE As Integer = &H83
        Const WM_SYSCOMMAND As Integer = &H112
        Const SC_MINIMIZE As Integer = &HF020
        Const SC_RESTORE As Integer = &HF120
        Const SC_MAXIMIZE As Integer = &HF030
        Const WM_NCHITTEST As Integer = &H84
        ' Const WM_NCPAINT As Integer = &H85
        ' Const WM_NCACTIVATE As Integer = &H86
        Const resizeAreaSize As Integer = 10

        Const HTCLIENT As Integer = 1
        Const HTLEFT As Integer = 10
        Const HTRIGHT As Integer = 11
        Const HTTOP As Integer = 12
        Const HTTOPLEFT As Integer = 13
        Const HTTOPRIGHT As Integer = 14
        Const HTBOTTOM As Integer = 15
        Const HTBOTTOMLEFT As Integer = 16
        Const HTBOTTOMRIGHT As Integer = 17

        ' ---------------------------
        ' NOTA: NO suprimimos WM_NCPAINT/WM_NCACTIVATE aquí.
        ' Suprimir esos mensajes provoca pérdida de foco / clicks en child forms.
        ' ---------------------------

        If m.Msg = WM_NCHITTEST Then
            ' Permitir redimensionado incluso con FormBorderStyle = None
            MyBase.WndProc(m)
            If Me.WindowState = FormWindowState.Normal Then
                If m.Result.ToInt32() = HTCLIENT Then
                    ' Extraer coordenadas del lParam
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

        ' Mantener compatibilidad de snap/maximize: llamamos al base y gestionamos SC_MAXIMIZE/RESTORE
        If m.Msg = WM_SYSCOMMAND Then
            Dim wParam As Integer = (m.WParam.ToInt32() And &HFFF0)
            If wParam = SC_MINIMIZE Then
                ' Guardar bounds actuales antes de minimizar para restaurar
                savedBounds = Me.Bounds
                formSize = Me.ClientSize
                ' dejar que el sistema minimice
            ElseIf wParam = SC_MAXIMIZE Then
                ' Maximizar para ventanas sin borde
                If Me.FormBorderStyle = FormBorderStyle.None Then
                    If Not isBorderlessMaximized Then
                        prevBounds = Me.Bounds
                        Dim wa = Screen.FromHandle(Me.Handle).WorkingArea
                        Me.Bounds = wa
                        isBorderlessMaximized = True
                        ' Evitar comportamiento por defecto
                        Return
                    End If
                End If
            ElseIf wParam = SC_RESTORE Then
                ' Restaurar desde minimizar o desde maximizar sin borde
                If isBorderlessMaximized Then
                    Me.Bounds = prevBounds
                    isBorderlessMaximized = False
                    ' forzar estado normal para que no se re-maximize
                    Me.WindowState = FormWindowState.Normal
                    Return
                ElseIf Not savedBounds.IsEmpty Then
                    ' Restaurar bounds guardados al minimizar
                    Me.Bounds = savedBounds
                    savedBounds = Rectangle.Empty
                    Me.WindowState = FormWindowState.Normal
                    Return
                Else
                    ' Fallback: restaurar tamaño cliente si no hay bounds guardados
                    Me.Size = formSize
                End If
            End If
        End If

        MyBase.WndProc(m)
    End Sub


    ' IconButton7 = Maximizar / Restaurar
    Private Sub IconButton7_Click(sender As Object, e As EventArgs) Handles IconButton7.Click
        If Me.FormBorderStyle = FormBorderStyle.None Then
            If isBorderlessMaximized Then
                If Not prevBounds.IsEmpty Then Me.Bounds = prevBounds
                isBorderlessMaximized = False
                Me.WindowState = FormWindowState.Normal
            Else
                prevBounds = Me.Bounds
                Dim wa = Screen.FromHandle(Me.Handle).WorkingArea
                Me.Bounds = wa
                isBorderlessMaximized = True
                Me.WindowState = FormWindowState.Normal
            End If
        Else
            If Me.WindowState = FormWindowState.Normal Then
                ' Guardar bounds para posible restauración después de minimizar
                savedBounds = Me.Bounds
                Me.WindowState = FormWindowState.Maximized
            Else
                Me.WindowState = FormWindowState.Normal
            End If
        End If

    End Sub

    ' IconButton8 = mINIMIZAR
    Private Sub IconButton8_Click(sender As Object, e As EventArgs) Handles IconButton8.Click
        ' Guardar bounds antes de minimizar
        savedBounds = Me.Bounds
        formSize = Me.ClientSize
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PanelTittleBar_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        Dim youtubeUrl As String = "https://www.youtube.com"

        ' Usar la clase Process para abrir el enlace en el navegador predeterminado
        Try
            Process.Start(youtubeUrl)
        Catch ex As Exception
            MessageBox.Show("Error al abrir el enlace: " & ex.Message)

        End Try
    End Sub
End Class
