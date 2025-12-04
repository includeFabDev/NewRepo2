Public Class frm_reporte_balance

    Private Sub frm_reporte_balance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetBalance.balance' Puede moverla o quitarla según sea necesario.
        Me.balanceTableAdapter.Fill(Me.DataSetBalance.balance)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class