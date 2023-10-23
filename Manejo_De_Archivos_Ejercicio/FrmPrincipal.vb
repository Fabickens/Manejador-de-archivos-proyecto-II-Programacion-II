Imports System.IO
Public Class FrmPrincipal
    Dim swEscritor As StreamWriter
    Dim swLector As StreamReader
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        swEscritor = New StreamWriter("D:\Archivo.txt", False)
        swEscritor.WriteLine(TextBox1.Text)
        swEscritor.Close()
    End Sub
End Class
