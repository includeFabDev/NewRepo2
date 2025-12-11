Public Class frm_libro_mayor

    Private Sub frm_libro_mayor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.dg1.Visible = True
        Me.dg2.Visible = False
        Me.Libro_mayorTableAdapter.Fill(Me.DataSetLibroMayor.libro_mayor)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.dg2.Visible = True
        Me.dg2.Rows.Clear()

        ' CONFIGURACIÓN BASADA EN TU IMAGEN
        ' Columna 0 = Detalle (Texto)
        ' Columna 1 = Debe (Número)
        ' Columna 2 = Haber (Número)
        Dim col_Detalle As Integer = 0
        Dim col_Debe As Integer = 1
        Dim col_Haber As Integer = 2

        ' VERIFICACIÓN DE SEGURIDAD
        ' Si la tabla oculta (dg1) tiene menos de 3 columnas, avisamos y detenemos para evitar el crash.
        If dg1.ColumnCount < 3 Then
            MessageBox.Show("Error: La tabla de datos (dg1) tiene menos columnas de las esperadas. Columnas actuales: " & dg1.ColumnCount)
            Exit Sub
        End If

        ' CICLO SEGURO
        ' Usamos 'RowCount - 1' si la tabla tiene la fila de asterisco (*) al final.
        ' Si AllowUserToAddRows es False, usa 'RowCount - 1' de todos modos para asegurar indices validos.
        Dim limite As Integer = dg1.RowCount - 1
        If dg1.AllowUserToAddRows Then limite = dg1.RowCount - 2

        For i As Integer = 0 To limite
            Try
                ' Obtenemos los valores. Usamos Val() para convertir vacíos o texto a 0 automáticamente.
                ' Asumimos que la columna 0 es el Detalle (Texto)
                Dim detalle As String = dg1.Item(col_Detalle, i).Value.ToString()
                Dim debe As Double = Val(dg1.Item(col_Debe, i).Value)
                Dim haber As Double = Val(dg1.Item(col_Haber, i).Value)

                ' 1. Copiamos la fila original a la tabla visible (dg2)
                dg2.Rows.Add(detalle, debe, haber)

                ' 2. Calculamos la diferencia
                Dim saldo As Double = debe - haber

                ' 3. Si hay diferencia, agregamos la fila de ajuste
                If saldo > 0 Then ' Saldo Deudor (Falta en el Haber)
                    dg2.Rows.Add("Cierre/Ajuste", "", saldo)
                    dg2.Rows.Add("Sumas Iguales", debe, debe)
                    dg2.Rows.Add("-----------------", "------", "------")
                ElseIf saldo < 0 Then ' Saldo Acreedor (Falta en el Debe)
                    dg2.Rows.Add("Cierre/Ajuste", Math.Abs(saldo), "")
                    dg2.Rows.Add("Sumas Iguales", haber, haber)
                    dg2.Rows.Add("-----------------", "------", "------")
                Else
                    ' Si saldo es 0, solo separamos
                    dg2.Rows.Add("-----------------", "------", "------")
                End If

            Catch ex As Exception
                ' Si una fila específica falla, la saltamos sin cerrar el programa
                Console.WriteLine("Fila " & i & " ignorada por error de formato.")
            End Try
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub dg2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg2.CellContentClick

    End Sub
End Class