Imports System.IO
Public Class FrmPrincipal
    Dim cantidad As Integer = 0
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim agregarInfo As String = tbxAgregarInfo.Text
        If agregarInfo <> "" Then
            listaDatos.Items.Add(agregarInfo)
            cantidad += 1
            tbxAgregarInfo.Clear()


        End If
    End Sub
End Class
