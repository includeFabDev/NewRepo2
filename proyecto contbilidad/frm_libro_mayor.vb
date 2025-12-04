Public Class frm_libro_mayor

    Private Sub frm_libro_mayor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.dg1.Visible = True
        Me.dg2.Visible = False
        Me.Libro_mayorTableAdapter.Fill(Me.DataSetLibroMayor.libro_mayor)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Me.dg1.Visible = False
        Me.dg2.Visible = True
        Me.dg2.Rows.Clear()
        For i As Integer = 0 To dg1.RowCount - 2
            dg2.Rows.Add(dg1.Item(0, i).Value, dg1.Item(1, i).Value, dg1.Item(2, i).Value)
            If (Double.Parse(dg1.Item(1, i).Value) - Double.Parse(dg1.Item(2, i).Value)) > 0 Then
                dg2.Rows.Add("", "", dg1.Item(1, i).Value - Double.Parse(dg1.Item(2, i).Value))
                dg2.Rows.Add("", dg1.Item(1, i).Value, dg1.Item(1, i).Value)
            End If
            If (Double.Parse(dg1.Item(1, i).Value) - Double.Parse(dg1.Item(2, i).Value)) < 0 Then
                dg2.Rows.Add("", dg1.Item(2, i).Value - Double.Parse(dg1.Item(1, i).Value), "")
                dg2.Rows.Add("", dg1.Item(2, i).Value, dg1.Item(2, i).Value)
            End If
            dg2.Rows.Add("------------------------", "------------------------", "------------------------")
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frm_reporte_mayor.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Proceso As New Process()
        Proceso.StartInfo.FileName = "calc.exe"
        Proceso.StartInfo.Arguments = ""
        Proceso.Start()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class