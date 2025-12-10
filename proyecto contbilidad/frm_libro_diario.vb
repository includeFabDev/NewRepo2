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
        'variable para almacenar el folio
        Dim numero As Integer = 0
        With dg_libro_diario
            'recorremos todas las filas del datagridview
            Try
                For i As Integer = 0 To .RowCount - 2
                    'en caso de que encuentre un detalle con el mismo nombre
                    If cuenta = .Item(2, i).Value.ToString Then
                        'retorna ese valor
                        Return Integer.Parse(.Item(3, i).Value)
                        'se sale de la funcion
                        Exit Function
                    End If
                    'caso que no se cumpla el primer if busca el folio con valor superio
                    If numero < Integer.Parse(.Item(3, i).Value) Then
                        numero = Integer.Parse(.Item(3, i).Value)
                    End If
                Next
            Catch ex As Exception
            End Try
        End With
        'si no se cumple el primer if en ninguna iteraccion devuelve el folio mayor + 1
        Return numero + 1
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
End Class