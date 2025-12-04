Public Class frm_cuentas

    Private Sub frm_cuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetCuentas.t_cuentas' Puede moverla o quitarla según sea necesario.
        Me.T_cuentasTableAdapter.Fill(Me.DataSetCuentas.t_cuentas)
        txt_cuenta.Clear()
        txt_detalle_cuenta.Clear()
    End Sub

    Private Sub btn_guardar_cuenta_Click(sender As Object, e As EventArgs) Handles btn_guardar_cuenta.Click
        If txt_cuenta.Text = "" Or txt_cuenta.Text = "" Then
            MessageBox.Show("Datos mal ingresado, Verifique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Me.T_cuentasTableAdapter.insertar_cuenta(txt_cuenta.Text, txt_cuenta.Text)
            frm_libro_diario.T_cuentasTableAdapter.Fill(frm_libro_diario.Data.t_cuentas)
            Me.T_cuentasTableAdapter.Fill(Me.DataSetCuentas.t_cuentas)
            txt_cuenta.Clear()
            txt_detalle_cuenta.Clear()
        End If
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Me.T_cuentasTableAdapter.eliminar_cuenta(Me.dg_cuentas.Item(0, Me.dg_cuentas.CurrentRow.Index).Value)
        frm_libro_diario.T_cuentasTableAdapter.Fill(frm_libro_diario.Data.t_cuentas)
        Me.T_cuentasTableAdapter.Fill(Me.DataSetCuentas.t_cuentas)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()


    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class