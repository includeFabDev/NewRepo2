<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_balance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_balance))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DetalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DebeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HaberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeudorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcreedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BalanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetBalance = New proyecto_contbilidad.DataSetBalance()
        Me.BalanceTableAdapter = New proyecto_contbilidad.DataSetBalanceTableAdapters.balanceTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtdebe = New System.Windows.Forms.TextBox()
        Me.txthaber = New System.Windows.Forms.TextBox()
        Me.txtdeudor = New System.Windows.Forms.TextBox()
        Me.txtacreedor = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BalanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetBalance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DetalleDataGridViewTextBoxColumn, Me.DebeDataGridViewTextBoxColumn, Me.HaberDataGridViewTextBoxColumn, Me.DeudorDataGridViewTextBoxColumn, Me.AcreedorDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BalanceBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(28, 79)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(676, 340)
        Me.DataGridView1.TabIndex = 0
        '
        'DetalleDataGridViewTextBoxColumn
        '
        Me.DetalleDataGridViewTextBoxColumn.DataPropertyName = "detalle"
        Me.DetalleDataGridViewTextBoxColumn.HeaderText = "detalle"
        Me.DetalleDataGridViewTextBoxColumn.Name = "DetalleDataGridViewTextBoxColumn"
        '
        'DebeDataGridViewTextBoxColumn
        '
        Me.DebeDataGridViewTextBoxColumn.DataPropertyName = "debe"
        Me.DebeDataGridViewTextBoxColumn.HeaderText = "debe"
        Me.DebeDataGridViewTextBoxColumn.Name = "DebeDataGridViewTextBoxColumn"
        '
        'HaberDataGridViewTextBoxColumn
        '
        Me.HaberDataGridViewTextBoxColumn.DataPropertyName = "haber"
        Me.HaberDataGridViewTextBoxColumn.HeaderText = "haber"
        Me.HaberDataGridViewTextBoxColumn.Name = "HaberDataGridViewTextBoxColumn"
        '
        'DeudorDataGridViewTextBoxColumn
        '
        Me.DeudorDataGridViewTextBoxColumn.DataPropertyName = "deudor"
        Me.DeudorDataGridViewTextBoxColumn.HeaderText = "deudor"
        Me.DeudorDataGridViewTextBoxColumn.Name = "DeudorDataGridViewTextBoxColumn"
        Me.DeudorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AcreedorDataGridViewTextBoxColumn
        '
        Me.AcreedorDataGridViewTextBoxColumn.DataPropertyName = "acreedor"
        Me.AcreedorDataGridViewTextBoxColumn.HeaderText = "acreedor"
        Me.AcreedorDataGridViewTextBoxColumn.Name = "AcreedorDataGridViewTextBoxColumn"
        Me.AcreedorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BalanceBindingSource
        '
        Me.BalanceBindingSource.DataMember = "balance"
        Me.BalanceBindingSource.DataSource = Me.DataSetBalance
        '
        'DataSetBalance
        '
        Me.DataSetBalance.DataSetName = "DataSetBalance"
        Me.DataSetBalance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BalanceTableAdapter
        '
        Me.BalanceTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(184, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sumas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(344, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 39)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Saldos"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtdebe
        '
        Me.txtdebe.Location = New System.Drawing.Point(200, 425)
        Me.txtdebe.Name = "txtdebe"
        Me.txtdebe.ReadOnly = True
        Me.txtdebe.Size = New System.Drawing.Size(122, 20)
        Me.txtdebe.TabIndex = 3
        '
        'txthaber
        '
        Me.txthaber.Location = New System.Drawing.Point(328, 425)
        Me.txthaber.Name = "txthaber"
        Me.txthaber.ReadOnly = True
        Me.txthaber.Size = New System.Drawing.Size(119, 20)
        Me.txthaber.TabIndex = 4
        '
        'txtdeudor
        '
        Me.txtdeudor.Location = New System.Drawing.Point(453, 425)
        Me.txtdeudor.Name = "txtdeudor"
        Me.txtdeudor.ReadOnly = True
        Me.txtdeudor.Size = New System.Drawing.Size(124, 20)
        Me.txtdeudor.TabIndex = 5
        '
        'txtacreedor
        '
        Me.txtacreedor.Location = New System.Drawing.Point(583, 425)
        Me.txtacreedor.Name = "txtacreedor"
        Me.txtacreedor.ReadOnly = True
        Me.txtacreedor.Size = New System.Drawing.Size(116, 20)
        Me.txtacreedor.TabIndex = 6
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(200, 501)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(124, 89)
        Me.GroupBox4.TabIndex = 52
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Calculadora"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(6, 17)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 65)
        Me.Button2.TabIndex = 47
        Me.Button2.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13)
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.Button3)
        Me.GroupBox5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox5.Location = New System.Drawing.Point(367, 501)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(110, 89)
        Me.GroupBox5.TabIndex = 53
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Ver reporte"
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(6, 17)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(98, 65)
        Me.Button3.TabIndex = 50
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.proyecto_contbilidad.My.Resources.Resources.arrow_left_15601
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(58, 23)
        Me.Button1.TabIndex = 54
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frm_balance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(732, 621)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.txtacreedor)
        Me.Controls.Add(Me.txtdeudor)
        Me.Controls.Add(Me.txthaber)
        Me.Controls.Add(Me.txtdebe)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_balance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Balance de Sumas y Saldos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BalanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetBalance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataSetBalance As proyecto_contbilidad.DataSetBalance
    Friend WithEvents BalanceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BalanceTableAdapter As proyecto_contbilidad.DataSetBalanceTableAdapters.balanceTableAdapter
    Friend WithEvents DetalleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DebeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HaberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeudorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AcreedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtdebe As System.Windows.Forms.TextBox
    Friend WithEvents txthaber As System.Windows.Forms.TextBox
    Friend WithEvents txtdeudor As System.Windows.Forms.TextBox
    Friend WithEvents txtacreedor As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
