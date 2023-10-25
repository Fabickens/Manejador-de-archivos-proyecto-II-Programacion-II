
Public Class FrmPrincipal
    Dim cantidad As Integer = 0
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim agregarInfo As String = tbxAgregarInfo.Text
        If agregarInfo <> "" Then
            listaDatos.Items.Add(agregarInfo)
            cantidad += 1
            tbxAgregarInfo.Clear()
            lblTotalReg.Text = $"Total Registros {cantidad}"

        End If
    End Sub

    Private Sub BtnSobrescribir_Click(sender As Object, e As EventArgs) Handles BtnSobrescribir.Click
        Dim modificar As String = tbxAgregarInfo.Text
        If modificar <> "" Then

            Dim ultimoIndice As Integer = listaDatos.Items.Count - 1
            listaDatos.Items(ultimoIndice) = modificar
            tbxAgregarInfo.Clear()

        End If

    End Sub
End Class

