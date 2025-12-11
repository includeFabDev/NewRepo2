<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_reporte_diario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.t_libro_diarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetLibroDiario = New proyecto_contbilidad.DataSetLibroDiario()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.t_libro_diarioTableAdapter = New proyecto_contbilidad.DataSetLibroDiarioTableAdapters.t_libro_diarioTableAdapter()
        CType(Me.t_libro_diarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetLibroDiario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        't_libro_diarioBindingSource
        '
        Me.t_libro_diarioBindingSource.DataMember = "t_libro_diario"
        Me.t_libro_diarioBindingSource.DataSource = Me.DataSetLibroDiario
        '
        'DataSetLibroDiario
        '
        Me.DataSetLibroDiario.DataSetName = "DataSetLibroDiario"
        Me.DataSetLibroDiario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSetReporteDiario"
        ReportDataSource2.Value = Me.t_libro_diarioBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "proyecto_contbilidad.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(801, 461)
        Me.ReportViewer1.TabIndex = 0
        '
        't_libro_diarioTableAdapter
        '
        Me.t_libro_diarioTableAdapter.ClearBeforeFill = True
        '
        'frm_reporte_diario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 461)
        Me.Controls.Add(Me.ReportViewer1)
        Me.MaximumSize = New System.Drawing.Size(817, 500)
        Me.MinimumSize = New System.Drawing.Size(817, 500)
        Me.Name = "frm_reporte_diario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Libro Diario"
        CType(Me.t_libro_diarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetLibroDiario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents t_libro_diarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetLibroDiario As proyecto_contbilidad.DataSetLibroDiario
    Friend WithEvents t_libro_diarioTableAdapter As proyecto_contbilidad.DataSetLibroDiarioTableAdapters.t_libro_diarioTableAdapter
End Class
