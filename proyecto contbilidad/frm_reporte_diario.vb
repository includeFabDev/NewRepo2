Public Class frm_reporte_diario

    Private Sub frm_reporte_diario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetLibroDiario.t_libro_diario' Puede moverla o quitarla según sea necesario.
        Me.t_libro_diarioTableAdapter.Fill(Me.DataSetLibroDiario.t_libro_diario)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class