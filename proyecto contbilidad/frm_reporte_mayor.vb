Public Class frm_reporte_mayor

    Private Sub frm_reporte_mayor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetLibroMayor.libro_mayor' Puede moverla o quitarla según sea necesario.
        Me.libro_mayorTableAdapter.Fill(Me.DataSetLibroMayor.libro_mayor)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class