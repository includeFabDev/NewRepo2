<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_reporte_mayor
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.libro_mayorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetLibroMayor = New proyecto_contbilidad.DataSetLibroMayor()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.libro_mayorTableAdapter = New proyecto_contbilidad.DataSetLibroMayorTableAdapters.libro_mayorTableAdapter()
        CType(Me.libro_mayorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetLibroMayor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'libro_mayorBindingSource
        '
        Me.libro_mayorBindingSource.DataMember = "libro_mayor"
        Me.libro_mayorBindingSource.DataSource = Me.DataSetLibroMayor
        '
        'DataSetLibroMayor
        '
        Me.DataSetLibroMayor.DataSetName = "DataSetLibroMayor"
        Me.DataSetLibroMayor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetReporteMayor"
        ReportDataSource1.Value = Me.libro_mayorBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "proyecto_contbilidad.reporte_mayor.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(796, 462)
        Me.ReportViewer1.TabIndex = 0
        '
        'libro_mayorTableAdapter
        '
        Me.libro_mayorTableAdapter.ClearBeforeFill = True
        '
        'frm_reporte_mayor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 462)
        Me.Controls.Add(Me.ReportViewer1)
        Me.MaximumSize = New System.Drawing.Size(817, 500)
        Me.MinimumSize = New System.Drawing.Size(798, 500)
        Me.Name = "frm_reporte_mayor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Libro Mayor"
        CType(Me.libro_mayorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetLibroMayor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents libro_mayorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetLibroMayor As proyecto_contbilidad.DataSetLibroMayor
    Friend WithEvents libro_mayorTableAdapter As proyecto_contbilidad.DataSetLibroMayorTableAdapters.libro_mayorTableAdapter
End Class
