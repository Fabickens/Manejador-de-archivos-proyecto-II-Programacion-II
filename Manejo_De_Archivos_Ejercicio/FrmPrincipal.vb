
Imports System.IO

Public Class FrmPrincipal
    Dim cantidad As Integer = 0
    Dim rutaArchivo As String = "D:\ArchivoPrueba.txt"
    Dim swEscritor As StreamWriter
    Dim srLector As StreamReader
    Private Sub BtnCrear_Click(sender As Object, e As EventArgs) Handles BtnCrear.Click

        Try
            System.IO.File.Create(rutaArchivo).Close()
            MessageBox.Show("Archivo de texto creado" & rutaArchivo, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al crear el archivo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

        Try
            If File.Exists(rutaArchivo) Then
                File.Delete(rutaArchivo)
                MessageBox.Show("Archivo de texto eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("El archivo es inexistente en la ubicacion especificada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            listaDatos.Items.Clear()
        Catch ex As Exception
            MessageBox.Show("Error al eliminar el archivo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click

        Dim agregarInfo As String = tbxAgregarInfo.Text
        If agregarInfo <> "" Then
            swEscritor = New StreamWriter(rutaArchivo, True)
            swEscritor.WriteLine(agregarInfo)
            tbxAgregarInfo.Clear()
            swEscritor.Close()

            CargarDatosEnListBox()
        End If

    End Sub

    Private Sub BtnSobrescribir_Click(sender As Object, e As EventArgs) Handles BtnSobrescribir.Click

        Dim modificar As String = tbxAgregarInfo.Text
        If modificar <> "" Then
            Dim registros As String() = File.ReadAllLines(rutaArchivo)
            If registros.Length > 0 Then
                registros(registros.Length - 1) = modificar
                File.WriteAllLines(rutaArchivo, registros)
            End If
            tbxAgregarInfo.Clear()

            CargarDatosEnListBox()
        End If
    End Sub

    Private Sub CargarDatosEnListBox()

        If File.Exists(rutaArchivo) Then
            Dim contenido As String() = File.ReadAllLines(rutaArchivo)
            listaDatos.Items.Clear() ' Limpia el ListBox antes de agregar los datos
            listaDatos.Items.AddRange(contenido)
            cantidad = listaDatos.Items.Count
            lblTotalReg.Text = cantidad

        End If
    End Sub

End Class

