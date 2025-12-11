Public Class frm_libro_diario

    Private Sub frm_libro_diario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Data.t_cuentas' Puede moverla o quitarla según sea necesario.
        Me.T_cuentasTableAdapter.Fill(Me.Data.t_cuentas)
        Me.T_libro_diarioTableAdapter.Fill(Me.DataSetLibroDiario.t_libro_diario)
        txtdebe.Text = total(dg_libro_diario, 4)
        txthaber.Text = total(dg_libro_diario, 5)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_ingresar_glosa.Click
        'boton que ingresa la glosa
        If txt_glosa.Text <> "" Then
            Me.T_libro_diarioTableAdapter.insertar_glosa(dtp_fecha.Value.Date, "GLOSA : " + txt_glosa.Text)
            Me.T_libro_diarioTableAdapter.Fill(Me.DataSetLibroDiario.t_libro_diario)
            limpiar()
        Else
            MessageBox.Show("La glosa esta vacia, vereifique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub btn_guadar_asiento_Click(sender As Object, e As EventArgs) Handles btn_guadar_asiento.Click
        'boton que ingresa el asiento contable
        Try
            Dim monto As Double = Double.Parse(txt_monto.Text)
            If ck_it.Checked Then
                Me.T_libro_diarioTableAdapter.insertar_diario(dtp_fecha.Value.Date, "IT por Pagar", (Double.Parse(txt_monto.Text) * 0.03).ToString.Replace(",", "."), "")
                Me.T_libro_diarioTableAdapter.Fill(Me.DataSetLibroDiario.t_libro_diario)
                Me.T_libro_diarioTableAdapter.insertar_diario(dtp_fecha.Value.Date, "IT Gastos", "", (Double.Parse(txt_monto.Text) * 0.03).ToString.Replace(",", "."))
                Me.T_libro_diarioTableAdapter.Fill(Me.DataSetLibroDiario.t_libro_diario)
            End If
            If ck_ivacf.Checked Then
                Me.T_libro_diarioTableAdapter.insertar_diario(dtp_fecha.Value.Date, cmb_cuenta.Text, (monto - (monto * 0.13)).ToString.Replace(",", "."), "")
                Me.T_libro_diarioTableAdapter.Fill(Me.DataSetLibroDiario.t_libro_diario)
                Me.T_libro_diarioTableAdapter.insertar_diario(dtp_fecha.Value.Date, "IVA Credito Fiscal", (Double.Parse(txt_monto.Text) * 0.13).ToString.Replace(",", "."), "")
                Me.T_libro_diarioTableAdapter.Fill(Me.DataSetLibroDiario.t_libro_diario)
                limpiar()
                txtdebe.Text = total(dg_libro_diario, 4)
                txthaber.Text = total(dg_libro_diario, 5)
                Exit Sub
            End If
            If ck_ivadf.Checked Then
                Me.T_libro_diarioTableAdapter.insertar_diario(dtp_fecha.Value.Date, cmb_cuenta.Text, "", (monto - (monto * 0.13)).ToString.Replace(",", "."))
                Me.T_libro_diarioTableAdapter.Fill(Me.DataSetLibroDiario.t_libro_diario)
                Me.T_libro_diarioTableAdapter.insertar_diario(dtp_fecha.Value.Date, "IVA Debito Fiscal", "", (Double.Parse(txt_monto.Text) * 0.13).ToString.Replace(",", "."))
                Me.T_libro_diarioTableAdapter.Fill(Me.DataSetLibroDiario.t_libro_diario)
                limpiar()
                txtdebe.Text = total(dg_libro_diario, 4)
                txthaber.Text = total(dg_libro_diario, 5)
                Exit Sub
            End If

            If rb_debe.Checked Then
                'si la opcion debe esta tiqueada el monto se ingresa a la columna "debe" y la columna haber se queda vacia
                Me.T_libro_diarioTableAdapter.insertar_diario(dtp_fecha.Value.Date, cmb_cuenta.Text, txt_monto.Text, "")
            Else
                'si la opcion haber esta tiqueada se hace lo contrario
                Me.T_libro_diarioTableAdapter.insertar_diario(dtp_fecha.Value.Date, cmb_cuenta.Text, "", txt_monto.Text)
            End If
            'refresca los datos en el datagridview
            Me.T_libro_diarioTableAdapter.Fill(Me.DataSetLibroDiario.t_libro_diario)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        limpiar()
        txtdebe.Text = total(dg_libro_diario, 4)
        txthaber.Text = total(dg_libro_diario, 5)
    End Sub
    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Try
            Me.T_libro_diarioTableAdapter.eliminar_diario(Me.dg_libro_diario.Item(0, Me.dg_libro_diario.CurrentRow.Index).Value)
            Me.T_libro_diarioTableAdapter.Fill(Me.DataSetLibroDiario.t_libro_diario)
            txtdebe.Text = total(dg_libro_diario, 4)
            txthaber.Text = total(dg_libro_diario, 5)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_cuentas.ShowDialog()
    End Sub
    Private Sub rb_debe_CheckedChanged(sender As Object, e As EventArgs) Handles rb_debe.CheckedChanged
        ck_ivacf.Visible = True
        ck_ivacf.Checked = True
        ck_ivadf.Visible = False
        ck_ivadf.Checked = False
        ck_it.Visible = False
        ck_it.Checked = False
    End Sub

    Private Sub rb_haber_CheckedChanged(sender As Object, e As EventArgs) Handles rb_haber.CheckedChanged
        ck_ivacf.Visible = False
        ck_ivacf.Checked = False
        ck_ivadf.Visible = True
        ck_ivadf.Checked = True
        ck_it.Visible = True
        ck_it.Checked = True
    End Sub

    'funcion que calcula el folio
    Function folio(ByVal cuenta As String) As Integer
        ' 1. VALIDACIÓN INICIAL: Si lo que intentamos registrar es una GLOSA, retornamos 0 o vacío
        ' (Ajusta esto si en tu base de datos usas NULL, pero generalmente es 0 o "")
        If cuenta.ToUpper().Contains("GLOSA") Then
            Return 0
        End If

        Dim maximoFolio As Integer = 0

        With dg_libro_diario
            ' Recorremos todas las filas
            ' Usamos una resta segura para evitar errores si la grilla está vacía
            Dim limite As Integer = .RowCount - 1
            If .AllowUserToAddRows Then limite = .RowCount - 2

            For i As Integer = 0 To limite
                ' Obtenemos el nombre de la cuenta y el folio de la fila actual de forma segura
                Dim filaCuenta As String = .Item(2, i).Value.ToString()

                ' Usamos Val() en lugar de Parse. Val() convierte "" a 0 automáticamente y no da error.
                Dim filaFolio As Integer = Val(.Item(3, i).Value)

                ' REGLA 1: Si la fila es una Glosa (folio 0), la ignoramos completamente
                If filaFolio = 0 Then
                    Continue For
                End If

                ' REGLA 2: Si encontramos la MISMA cuenta, devolvemos su folio existente
                If cuenta.Trim().ToUpper() = filaCuenta.Trim().ToUpper() Then
                    Return filaFolio
                End If

                ' REGLA 3: Rastreamos cuál es el número más alto que hemos visto hasta ahora
                If filaFolio > maximoFolio Then
                    maximoFolio = filaFolio
                End If
            Next
        End With

        ' REGLA 4: Si no encontramos la cuenta, devolvemos el máximo encontrado + 1
        Return maximoFolio + 1
    End Function
    Sub limpiar()
        txt_monto.Clear()
        txt_glosa.Clear()
    End Sub

    Private Sub BalanceDeAperturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BalanceDeAperturaToolStripMenuItem.Click
        Try
            Me.T_libro_diarioTableAdapter.insertar_diario(dtp_fecha.Value.Date, "Capital", "", total(Me.dg_libro_diario, 4) - total(Me.dg_libro_diario, 5))
            Me.T_libro_diarioTableAdapter.Fill(Me.DataSetLibroDiario.t_libro_diario)
            txtdebe.Text = total(dg_libro_diario, 4)
            txthaber.Text = total(dg_libro_diario, 5)
            ContextMenuStrip1.Items(1).Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function total(ByVal data As DataGridView, ByVal columna As Integer) As Double
        Dim valor As Double = 0
        Try
            For i As Integer = 0 To data.RowCount - 2
                If (data.Item(columna, i).Value.ToString <> "") Then
                    valor = valor + Double.Parse(data.Item(columna, i).Value.ToString.Replace(".", ","))
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return valor
    End Function

    Private Sub EliminarTodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarTodoToolStripMenuItem.Click

        Me.T_libro_diarioTableAdapter.Fill(Me.DataSetLibroDiario.t_libro_diario)
        txtdebe.Text = total(dg_libro_diario, 4)
        txthaber.Text = total(dg_libro_diario, 5)
        ContextMenuStrip1.Items(1).Enabled = True
    End Sub

    Private Sub ck_it_CheckedChanged(sender As Object, e As EventArgs) Handles ck_it.CheckedChanged

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Proceso As New Process()
        Proceso.StartInfo.FileName = "calc.exe"
        Proceso.StartInfo.Arguments = ""
        Proceso.Start()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frm_reporte_diario.Show()
    End Sub


    Private Sub dg_libro_diario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_libro_diario.CellContentClick

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Me.T_libro_diarioTableAdapter.nuevo()
        Me.T_libro_diarioTableAdapter.Fill(Me.DataSetLibroDiario.t_libro_diario)

    End Sub

    Private Sub txt_glosa_TextChanged(sender As Object, e As EventArgs) Handles txt_glosa.TextChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub ck_ivacf_CheckedChanged(sender As Object, e As EventArgs) Handles ck_ivacf.CheckedChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub
End Class