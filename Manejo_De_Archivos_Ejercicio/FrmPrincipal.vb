
Imports System.IO

Public Class FrmPrincipal
    Dim cantidad As Integer = 0
    Dim nombreArchivo As String
    Dim rutaArchivo As String = "D:\ArchivoPrueba"
    Dim swEscritor As StreamWriter
    Dim srLector As StreamReader
    Private Sub BtnCrear_Click(sender As Object, e As EventArgs) Handles BtnCrear.Click
        nombreArchivo = InputBox("Ingrese el nombre del archivo de texto sin la extension txt:", "Crear archivo de texto")
        If Not String.IsNullOrEmpty(nombreArchivo) Then
            nombreArchivo &= ".txt"

            Dim rutaArchivo As String = "D:\ArchivoPrueba"

            Try
                System.IO.File.Create(rutaArchivo).Close()
                MessageBox.Show("Archivo de texto creado" & rutaArchivo, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error al crear el archivo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        nombreArchivo = InputBox("Ingrese el nombre del archivo que desea eliminar sin la extension txt", "Eliminar archivo de texto")
        If Not String.IsNullOrEmpty(nombreArchivo) Then
            nombreArchivo &= ".txt"



            Try
                If File.Exists(rutaArchivo) Then
                    File.Delete(rutaArchivo)
                    MessageBox.Show("Archivo de texto eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("El archivo es inexistente en la ubicacion especificada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Catch ex As Exception
                MessageBox.Show("Error al eliminar el archivo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim agregarInfo As String = tbxAgregarInfo.Text
        If agregarInfo <> "" Then
            swEscritor = New StreamWriter(rutaArchivo, True)
            swEscritor.WriteLine(agregarInfo)
            tbxAgregarInfo.Clear()
            swEscritor.Close()

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

<<<<<<< HEAD
=======
    Private Sub BtnCrear_Click(sender As Object, e As EventArgs) Handles BtnCrear.Click
        Dim nombreArchivo As String = "Prueba.txt"
        Dim rutaArchivo As String = "C:\Users\Fabián\Documents\Ruta Archivo" & nombreArchivo
        Try
            System.IO.File.Create(rutaArchivo).Close()
            MessageBox.Show("Archivo de texto creado" & rutaArchivo, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al crear el archivo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim nombreArchivo As String = "Prueba.txt"
        Dim rutaArchivo As String = "C:\Users\Fabián\Documents\Ruta Archivo" & nombreArchivo
        Try
            If File.Exists(rutaArchivo) Then
                File.Delete(rutaArchivo)
                MessageBox.Show("Archivo de texto eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("El archivo es inexistente en la ubicacion especificada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al eliminar el archivo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
>>>>>>> 9878b649ce90b6b292274bd883081e331be5e563
End Class

