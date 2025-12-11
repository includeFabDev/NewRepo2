<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cuentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cuentas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cuenta = New System.Windows.Forms.TextBox()
        Me.txt_detalle_cuenta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dg_cuentas = New System.Windows.Forms.DataGridView()
        Me.IdcuentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TcuentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetCuentas = New proyecto_contbilidad.DataSetCuentas()
        Me.btn_guardar_cuenta = New System.Windows.Forms.Button()
        Me.T_cuentasTableAdapter = New proyecto_contbilidad.DataSetCuentasTableAdapters.t_cuentasTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dg_cuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.TcuentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(156, 60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre de Cuenta :"
        '
        'txt_cuenta
        '
        Me.txt_cuenta.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txt_cuenta.Location = New System.Drawing.Point(443, 68)
        Me.txt_cuenta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_cuenta.Name = "txt_cuenta"
        Me.txt_cuenta.Size = New System.Drawing.Size(205, 22)
        Me.txt_cuenta.TabIndex = 1
        '
        'txt_detalle_cuenta
        '
        Me.txt_detalle_cuenta.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txt_detalle_cuenta.Location = New System.Drawing.Point(443, 119)
        Me.txt_detalle_cuenta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_detalle_cuenta.Multiline = True
        Me.txt_detalle_cuenta.Name = "txt_detalle_cuenta"
        Me.txt_detalle_cuenta.Size = New System.Drawing.Size(205, 56)
        Me.txt_detalle_cuenta.TabIndex = 3
        Me.txt_detalle_cuenta.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(172, 119)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 31)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Detalle de cuenta :"
        Me.Label2.Visible = False
        '
        'dg_cuentas
        '
        Me.dg_cuentas.AutoGenerateColumns = False
        Me.dg_cuentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_cuentas.BackgroundColor = System.Drawing.Color.LightSlateGray
        Me.dg_cuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_cuentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdcuentaDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn})
        Me.dg_cuentas.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dg_cuentas.DataSource = Me.TcuentasBindingSource
        Me.dg_cuentas.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dg_cuentas.Location = New System.Drawing.Point(128, 272)
        Me.dg_cuentas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dg_cuentas.Name = "dg_cuentas"
        Me.dg_cuentas.RowHeadersWidth = 51
        Me.dg_cuentas.Size = New System.Drawing.Size(521, 347)
        Me.dg_cuentas.TabIndex = 4
        '
        'IdcuentaDataGridViewTextBoxColumn
        '
        Me.IdcuentaDataGridViewTextBoxColumn.DataPropertyName = "id_cuenta"
        Me.IdcuentaDataGridViewTextBoxColumn.HeaderText = "id_cuenta"
        Me.IdcuentaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdcuentaDataGridViewTextBoxColumn.Name = "IdcuentaDataGridViewTextBoxColumn"
        Me.IdcuentaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdcuentaDataGridViewTextBoxColumn.Visible = False
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(133, 28)
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(132, 24)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'TcuentasBindingSource
        '
        Me.TcuentasBindingSource.DataMember = "t_cuentas"
        Me.TcuentasBindingSource.DataSource = Me.DataSetCuentas
        '
        'DataSetCuentas
        '
        Me.DataSetCuentas.DataSetName = "DataSetCuentas"
        Me.DataSetCuentas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btn_guardar_cuenta
        '
        Me.btn_guardar_cuenta.BackColor = System.Drawing.Color.Black
        Me.btn_guardar_cuenta.ForeColor = System.Drawing.Color.Transparent
        Me.btn_guardar_cuenta.Image = CType(resources.GetObject("btn_guardar_cuenta.Image"), System.Drawing.Image)
        Me.btn_guardar_cuenta.Location = New System.Drawing.Point(24, 31)
        Me.btn_guardar_cuenta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_guardar_cuenta.Name = "btn_guardar_cuenta"
        Me.btn_guardar_cuenta.Size = New System.Drawing.Size(92, 80)
        Me.btn_guardar_cuenta.TabIndex = 5
        Me.btn_guardar_cuenta.UseVisualStyleBackColor = False
        '
        'T_cuentasTableAdapter
        '
        Me.T_cuentasTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btn_guardar_cuenta)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(295, 154)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(140, 121)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Guardar"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.proyecto_contbilidad.My.Resources.Resources.arrow_left_15601
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Location = New System.Drawing.Point(17, 16)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 28)
        Me.Button1.TabIndex = 7
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frm_cuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(744, 674)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dg_cuentas)
        Me.Controls.Add(Me.txt_detalle_cuenta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_cuenta)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frm_cuentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Plan de Cuentas"
        CType(Me.dg_cuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.TcuentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_cuenta As System.Windows.Forms.TextBox
    Friend WithEvents txt_detalle_cuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dg_cuentas As System.Windows.Forms.DataGridView
    Friend WithEvents DataSetCuentas As proyecto_contbilidad.DataSetCuentas
    Friend WithEvents TcuentasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T_cuentasTableAdapter As proyecto_contbilidad.DataSetCuentasTableAdapters.t_cuentasTableAdapter
    Friend WithEvents btn_guardar_cuenta As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents IdcuentaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
