<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_libro_diario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_libro_diario))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_ingresar_glosa = New System.Windows.Forms.Button()
        Me.txt_glosa = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ck_it = New System.Windows.Forms.CheckBox()
        Me.ck_ivadf = New System.Windows.Forms.CheckBox()
        Me.ck_ivacf = New System.Windows.Forms.CheckBox()
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.cmb_cuenta = New System.Windows.Forms.ComboBox()
        Me.TcuentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Data = New proyecto_contbilidad.Data()
        Me.txt_monto = New System.Windows.Forms.TextBox()
        Me.btn_guadar_asiento = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rb_debe = New System.Windows.Forms.RadioButton()
        Me.rb_haber = New System.Windows.Forms.RadioButton()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.dg_libro_diario = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FolioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DebeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HaberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BalanceDeAperturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarTodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TlibrodiarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetLibroDiario = New proyecto_contbilidad.DataSetLibroDiario()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txthaber = New System.Windows.Forms.TextBox()
        Me.txtdebe = New System.Windows.Forms.TextBox()
        Me.T_libro_diarioTableAdapter = New proyecto_contbilidad.DataSetLibroDiarioTableAdapters.t_libro_diarioTableAdapter()
        Me.T_cuentasTableAdapter = New proyecto_contbilidad.DataTableAdapters.t_cuentasTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TcuentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Data, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_libro_diario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.TlibrodiarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetLibroDiario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.btn_ingresar_glosa)
        Me.GroupBox2.Controls.Add(Me.txt_glosa)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(22, 330)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(323, 99)
        Me.GroupBox2.TabIndex = 45
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Glosa"
        '
        'btn_ingresar_glosa
        '
        Me.btn_ingresar_glosa.BackColor = System.Drawing.Color.Transparent
        Me.btn_ingresar_glosa.BackgroundImage = CType(resources.GetObject("btn_ingresar_glosa.BackgroundImage"), System.Drawing.Image)
        Me.btn_ingresar_glosa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_ingresar_glosa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ingresar_glosa.ForeColor = System.Drawing.Color.Black
        Me.btn_ingresar_glosa.Location = New System.Drawing.Point(246, 19)
        Me.btn_ingresar_glosa.Name = "btn_ingresar_glosa"
        Me.btn_ingresar_glosa.Size = New System.Drawing.Size(46, 45)
        Me.btn_ingresar_glosa.TabIndex = 27
        Me.btn_ingresar_glosa.UseVisualStyleBackColor = False
        '
        'txt_glosa
        '
        Me.txt_glosa.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txt_glosa.Location = New System.Drawing.Point(15, 19)
        Me.txt_glosa.Multiline = True
        Me.txt_glosa.Name = "txt_glosa"
        Me.txt_glosa.Size = New System.Drawing.Size(194, 68)
        Me.txt_glosa.TabIndex = 26
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.ck_it)
        Me.GroupBox1.Controls.Add(Me.ck_ivadf)
        Me.GroupBox1.Controls.Add(Me.ck_ivacf)
        Me.GroupBox1.Controls.Add(Me.dtp_fecha)
        Me.GroupBox1.Controls.Add(Me.cmb_cuenta)
        Me.GroupBox1.Controls.Add(Me.txt_monto)
        Me.GroupBox1.Controls.Add(Me.btn_guadar_asiento)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.rb_debe)
        Me.GroupBox1.Controls.Add(Me.rb_haber)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(22, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(323, 259)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Asiento Contable"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 239)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 17)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "LIMPIAR"
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Location = New System.Drawing.Point(51, 181)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(53, 52)
        Me.Button4.TabIndex = 42
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(125, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 17)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "ACEPTAR"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(235, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 56)
        Me.Button1.TabIndex = 40
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ck_it
        '
        Me.ck_it.AutoSize = True
        Me.ck_it.Location = New System.Drawing.Point(225, 181)
        Me.ck_it.Name = "ck_it"
        Me.ck_it.Size = New System.Drawing.Size(41, 21)
        Me.ck_it.TabIndex = 39
        Me.ck_it.Text = "IT"
        Me.ck_it.UseVisualStyleBackColor = True
        '
        'ck_ivadf
        '
        Me.ck_ivadf.AutoSize = True
        Me.ck_ivadf.Location = New System.Drawing.Point(225, 154)
        Me.ck_ivadf.Name = "ck_ivadf"
        Me.ck_ivadf.Size = New System.Drawing.Size(77, 21)
        Me.ck_ivadf.TabIndex = 38
        Me.ck_ivadf.Text = "IVA DF"
        Me.ck_ivadf.UseVisualStyleBackColor = True
        '
        'ck_ivacf
        '
        Me.ck_ivacf.AutoSize = True
        Me.ck_ivacf.Location = New System.Drawing.Point(225, 126)
        Me.ck_ivacf.Name = "ck_ivacf"
        Me.ck_ivacf.Size = New System.Drawing.Size(77, 21)
        Me.ck_ivacf.TabIndex = 37
        Me.ck_ivacf.Text = "IVA CF"
        Me.ck_ivacf.UseVisualStyleBackColor = True
        '
        'dtp_fecha
        '
        Me.dtp_fecha.Location = New System.Drawing.Point(66, 22)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(226, 25)
        Me.dtp_fecha.TabIndex = 17
        Me.dtp_fecha.Value = New Date(2025, 12, 11, 0, 0, 0, 0)
        '
        'cmb_cuenta
        '
        Me.cmb_cuenta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmb_cuenta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_cuenta.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.cmb_cuenta.DataSource = Me.TcuentasBindingSource
        Me.cmb_cuenta.DisplayMember = "nombre"
        Me.cmb_cuenta.FormattingEnabled = True
        Me.cmb_cuenta.Location = New System.Drawing.Point(66, 60)
        Me.cmb_cuenta.Name = "cmb_cuenta"
        Me.cmb_cuenta.Size = New System.Drawing.Size(155, 25)
        Me.cmb_cuenta.TabIndex = 18
        Me.cmb_cuenta.ValueMember = "id_cuenta"
        '
        'TcuentasBindingSource
        '
        Me.TcuentasBindingSource.DataMember = "t_cuentas"
        Me.TcuentasBindingSource.DataSource = Me.Data
        '
        'Data
        '
        Me.Data.DataSetName = "Data"
        Me.Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txt_monto
        '
        Me.txt_monto.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txt_monto.Location = New System.Drawing.Point(66, 101)
        Me.txt_monto.Name = "txt_monto"
        Me.txt_monto.Size = New System.Drawing.Size(129, 25)
        Me.txt_monto.TabIndex = 19
        '
        'btn_guadar_asiento
        '
        Me.btn_guadar_asiento.BackColor = System.Drawing.Color.Transparent
        Me.btn_guadar_asiento.BackgroundImage = CType(resources.GetObject("btn_guadar_asiento.BackgroundImage"), System.Drawing.Image)
        Me.btn_guadar_asiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_guadar_asiento.ForeColor = System.Drawing.Color.Transparent
        Me.btn_guadar_asiento.Location = New System.Drawing.Point(136, 181)
        Me.btn_guadar_asiento.Name = "btn_guadar_asiento"
        Me.btn_guadar_asiento.Size = New System.Drawing.Size(54, 52)
        Me.btn_guadar_asiento.TabIndex = 33
        Me.btn_guadar_asiento.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Fecha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 17)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Detalle"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 17)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Monto"
        '
        'rb_debe
        '
        Me.rb_debe.AutoSize = True
        Me.rb_debe.Location = New System.Drawing.Point(66, 145)
        Me.rb_debe.Name = "rb_debe"
        Me.rb_debe.Size = New System.Drawing.Size(64, 21)
        Me.rb_debe.TabIndex = 1
        Me.rb_debe.TabStop = True
        Me.rb_debe.Text = "Debe"
        Me.rb_debe.UseVisualStyleBackColor = True
        '
        'rb_haber
        '
        Me.rb_haber.AutoSize = True
        Me.rb_haber.Location = New System.Drawing.Point(136, 145)
        Me.rb_haber.Name = "rb_haber"
        Me.rb_haber.Size = New System.Drawing.Size(71, 21)
        Me.rb_haber.TabIndex = 29
        Me.rb_haber.TabStop = True
        Me.rb_haber.Text = "Haber"
        Me.rb_haber.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(762, 270)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(73, 25)
        Me.TextBox2.TabIndex = 30
        '
        'dg_libro_diario
        '
        Me.dg_libro_diario.AllowUserToOrderColumns = True
        Me.dg_libro_diario.AutoGenerateColumns = False
        Me.dg_libro_diario.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dg_libro_diario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_libro_diario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.FechaDataGridViewTextBoxColumn, Me.DetalleDataGridViewTextBoxColumn, Me.FolioDataGridViewTextBoxColumn, Me.DebeDataGridViewTextBoxColumn, Me.HaberDataGridViewTextBoxColumn})
        Me.dg_libro_diario.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dg_libro_diario.DataSource = Me.TlibrodiarioBindingSource
        Me.dg_libro_diario.GridColor = System.Drawing.Color.Black
        Me.dg_libro_diario.Location = New System.Drawing.Point(21, 29)
        Me.dg_libro_diario.Name = "dg_libro_diario"
        Me.dg_libro_diario.Size = New System.Drawing.Size(576, 389)
        Me.dg_libro_diario.TabIndex = 24
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "id_asiento"
        Me.Column1.HeaderText = "id"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        Me.Column1.Width = 10
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "fecha"
        Me.FechaDataGridViewTextBoxColumn.FillWeight = 92.24493!
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.Width = 98
        '
        'DetalleDataGridViewTextBoxColumn
        '
        Me.DetalleDataGridViewTextBoxColumn.DataPropertyName = "detalle"
        Me.DetalleDataGridViewTextBoxColumn.FillWeight = 255.2063!
        Me.DetalleDataGridViewTextBoxColumn.HeaderText = "detalle"
        Me.DetalleDataGridViewTextBoxColumn.Name = "DetalleDataGridViewTextBoxColumn"
        Me.DetalleDataGridViewTextBoxColumn.Width = 250
        '
        'FolioDataGridViewTextBoxColumn
        '
        Me.FolioDataGridViewTextBoxColumn.DataPropertyName = "folio"
        Me.FolioDataGridViewTextBoxColumn.FillWeight = 25.38071!
        Me.FolioDataGridViewTextBoxColumn.HeaderText = "folio"
        Me.FolioDataGridViewTextBoxColumn.Name = "FolioDataGridViewTextBoxColumn"
        Me.FolioDataGridViewTextBoxColumn.Width = 33
        '
        'DebeDataGridViewTextBoxColumn
        '
        Me.DebeDataGridViewTextBoxColumn.DataPropertyName = "debe"
        Me.DebeDataGridViewTextBoxColumn.FillWeight = 73.83122!
        Me.DebeDataGridViewTextBoxColumn.HeaderText = "debe"
        Me.DebeDataGridViewTextBoxColumn.Name = "DebeDataGridViewTextBoxColumn"
        Me.DebeDataGridViewTextBoxColumn.Width = 75
        '
        'HaberDataGridViewTextBoxColumn
        '
        Me.HaberDataGridViewTextBoxColumn.DataPropertyName = "haber"
        Me.HaberDataGridViewTextBoxColumn.FillWeight = 53.33686!
        Me.HaberDataGridViewTextBoxColumn.HeaderText = "haber"
        Me.HaberDataGridViewTextBoxColumn.Name = "HaberDataGridViewTextBoxColumn"
        Me.HaberDataGridViewTextBoxColumn.Width = 75
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarToolStripMenuItem, Me.BalanceDeAperturaToolStripMenuItem, Me.EliminarTodoToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(179, 70)
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'BalanceDeAperturaToolStripMenuItem
        '
        Me.BalanceDeAperturaToolStripMenuItem.Name = "BalanceDeAperturaToolStripMenuItem"
        Me.BalanceDeAperturaToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.BalanceDeAperturaToolStripMenuItem.Text = "Balance de apertura"
        '
        'EliminarTodoToolStripMenuItem
        '
        Me.EliminarTodoToolStripMenuItem.Name = "EliminarTodoToolStripMenuItem"
        Me.EliminarTodoToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.EliminarTodoToolStripMenuItem.Text = "Eliminar todo"
        '
        'TlibrodiarioBindingSource
        '
        Me.TlibrodiarioBindingSource.DataMember = "t_libro_diario"
        Me.TlibrodiarioBindingSource.DataSource = Me.DataSetLibroDiario
        '
        'DataSetLibroDiario
        '
        Me.DataSetLibroDiario.DataSetName = "DataSetLibroDiario"
        Me.DataSetLibroDiario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txthaber)
        Me.GroupBox3.Controls.Add(Me.txtdebe)
        Me.GroupBox3.Controls.Add(Me.dg_libro_diario)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(373, 60)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(642, 476)
        Me.GroupBox3.TabIndex = 46
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Libro Diario"
        '
        'txthaber
        '
        Me.txthaber.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txthaber.Location = New System.Drawing.Point(315, 435)
        Me.txthaber.Name = "txthaber"
        Me.txthaber.ReadOnly = True
        Me.txthaber.Size = New System.Drawing.Size(75, 25)
        Me.txthaber.TabIndex = 32
        '
        'txtdebe
        '
        Me.txtdebe.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtdebe.Location = New System.Drawing.Point(220, 435)
        Me.txtdebe.Name = "txtdebe"
        Me.txtdebe.ReadOnly = True
        Me.txtdebe.Size = New System.Drawing.Size(73, 25)
        Me.txtdebe.TabIndex = 31
        '
        'T_libro_diarioTableAdapter
        '
        Me.T_libro_diarioTableAdapter.ClearBeforeFill = True
        '
        'T_cuentasTableAdapter
        '
        Me.T_cuentasTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Transparent
        Me.Button2.Location = New System.Drawing.Point(20, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(64, 64)
        Me.Button2.TabIndex = 47
        Me.Button2.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13)
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Snap ITC", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 505)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 19)
        Me.Label4.TabIndex = 48
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(38, 20)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(102, 91)
        Me.GroupBox4.TabIndex = 49
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Calculadora"
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(25, 16)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(64, 64)
        Me.Button3.TabIndex = 50
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button3)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Black
        Me.GroupBox5.Location = New System.Drawing.Point(200, 20)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(112, 91)
        Me.GroupBox5.TabIndex = 51
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Ver reporte"
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.GroupBox4)
        Me.GroupBox6.Controls.Add(Me.GroupBox5)
        Me.GroupBox6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Black
        Me.GroupBox6.Location = New System.Drawing.Point(24, 442)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(321, 129)
        Me.GroupBox6.TabIndex = 52
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Herramientas"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImage = Global.proyecto_contbilidad.My.Resources.Resources.arrow_left_15601
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button5.Location = New System.Drawing.Point(22, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(58, 23)
        Me.Button5.TabIndex = 53
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(158, 439)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 17)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Debe"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(407, 439)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 17)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Haber"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(235, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 17)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Insertar"
        '
        'frm_libro_diario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1027, 596)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_libro_diario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Libro Diario"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TcuentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_libro_diario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.TlibrodiarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetLibroDiario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_ingresar_glosa As System.Windows.Forms.Button
    Friend WithEvents txt_glosa As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmb_cuenta As System.Windows.Forms.ComboBox
    Friend WithEvents txt_monto As System.Windows.Forms.TextBox
    Friend WithEvents btn_guadar_asiento As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rb_debe As System.Windows.Forms.RadioButton
    Friend WithEvents rb_haber As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents dg_libro_diario As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DataSetLibroDiario As proyecto_contbilidad.DataSetLibroDiario
    Friend WithEvents TlibrodiarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T_libro_diarioTableAdapter As proyecto_contbilidad.DataSetLibroDiarioTableAdapters.t_libro_diarioTableAdapter
    Friend WithEvents ck_it As System.Windows.Forms.CheckBox
    Friend WithEvents ck_ivadf As System.Windows.Forms.CheckBox
    Friend WithEvents ck_ivacf As System.Windows.Forms.CheckBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Data As proyecto_contbilidad.Data
    Friend WithEvents TcuentasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T_cuentasTableAdapter As proyecto_contbilidad.DataTableAdapters.t_cuentasTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BalanceDeAperturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txthaber As System.Windows.Forms.TextBox
    Friend WithEvents txtdebe As System.Windows.Forms.TextBox
    Friend WithEvents EliminarTodoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DetalleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FolioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DebeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HaberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
End Class
