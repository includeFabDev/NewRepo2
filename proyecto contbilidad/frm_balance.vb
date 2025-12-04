Public Class frm_balance

    Private Sub frm_balance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BalanceTableAdapter.Fill(Me.DataSetBalance.balance)
        txtdebe.Text = frm_libro_diario.total(Me.DataGridView1, 1)
        txthaber.Text = frm_libro_diario.total(Me.DataGridView1, 2)
        txtdeudor.Text = frm_libro_diario.total(Me.DataGridView1, 3)
        txtacreedor.Text = frm_libro_diario.total(Me.DataGridView1, 4)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Proceso As New Process()
        Proceso.StartInfo.FileName = "calc.exe"
        Proceso.StartInfo.Arguments = ""
        Proceso.Start()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frm_reporte_balance.Show()
    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub
End Class