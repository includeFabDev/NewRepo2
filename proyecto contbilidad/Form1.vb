Imports System.Runtime.InteropServices

Public Class Form1

    ' Declaraciones para arrastrar el formulario
    <DllImport("user32.dll", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.dll", EntryPoint:="SendMessage")>
    Private Shared Function SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function

    Private Sub LibroDiarioToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frm_libro_diario.Show()
        Me.Hide()
    End Sub

    Private Sub LibroMayorToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frm_libro_mayor.Show()
        Me.Hide()
    End Sub

    Private Sub BalanceDeSumasYSaldosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frm_balance.Show()
        Me.Hide()
    End Sub

    Private Sub IniciarSeciónToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ' Registrar manejador para permitir arrastrar el formulario
        ' 1) Panel de título (nombre según el diseñador: PanelTittleBar)
        If Me.Controls.ContainsKey("PanelTittleBar") AndAlso TypeOf Me.Controls("PanelTittleBar") Is Panel Then
            AddHandler CType(Me.Controls("PanelTittleBar"), Panel).MouseDown, AddressOf panelTitleBar_MouseDown
        End If

        ' 2) PanelDesktop (si quieres arrastrar desde el área de contenido)
        If Me.Controls.ContainsKey("PanelDesktop") AndAlso TypeOf Me.Controls("PanelDesktop") Is Panel Then
            AddHandler CType(Me.Controls("PanelDesktop"), Panel).MouseDown, AddressOf panelTitleBar_MouseDown
        End If

        ' 3) Fallback: arrastrar desde el formulario mismo
        AddHandler Me.MouseDown, AddressOf panelTitleBar_MouseDown
    End Sub

    ' Manejador que simula arrastrar la ventana
    Private Sub panelTitleBar_MouseDown(sender As Object, e As MouseEventArgs)
        ReleaseCapture()
        SendMessage(Me.Handle, &H112, &HF012, 0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        frm_libro_diario.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        frm_libro_mayor.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        frm_balance.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        frm_cuentas.Show()
        Me.Hide()
    End Sub

    Private Sub PlanDeCuentasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frm_cuentas.Show()
        Me.Hide()
    End Sub

    Private Sub LibroDiarioToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        frm_reporte_diario.Show()
        Me.Hide()
    End Sub

    Private Sub LibroMayorToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        frm_reporte_mayor.Show()
        Me.Hide()
    End Sub

    Private Sub BalanceDeSumasYSaldosToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        frm_reporte_balance.Show()
        Me.Hide()
    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim Proceso As New Process()
        Proceso.StartInfo.FileName = "calc.exe"
        Proceso.StartInfo.Arguments = ""
        Proceso.Start()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ReportesToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        frm_libro_diario.Show()
        Me.Hide()
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        frm_libro_mayor.Show()
        Me.Hide()
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        frm_cuentas.Show()
        Me.Hide()
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        frm_cuentas.Show()
        Me.Hide()
    End Sub

    Private Sub PanelDesktop_Paint(sender As Object, e As PaintEventArgs) Handles PanelDesktop.Paint

    End Sub

    Private Sub IconButton6_Click(sender As Object, e As EventArgs) Handles IconButton6.Click
        Application.Exit()
    End Sub
End Class