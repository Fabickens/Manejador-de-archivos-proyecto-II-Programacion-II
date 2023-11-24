
Imports System.IO

Public Class FrmPrincipal
    Dim cantidad As Integer = 0
    Dim rutaArchivo As String
    Dim swEscritor As StreamWriter
    Dim srLector As StreamReader

    Private Sub BtnCrear_Click(sender As Object, e As EventArgs) Handles BtnCrearTxt.Click
        'Metodo que pregunta donde crear el archivo txt sobre el cual trabajamos.
        Dim saveFileDialog As New SaveFileDialog
        saveFileDialog.Filter = "Text files (*.txt)|*.txt"
        If saveFileDialog.ShowDialog() = DialogResult.OK Then

            rutaArchivo = saveFileDialog.FileName
            BtnEliminar.Enabled = True
            BtnSobrescribir.Enabled = True
            BtnGuardartodo.Enabled = True
            Try
                If Not System.IO.File.Exists(rutaArchivo) Then
                    System.IO.File.Create(rutaArchivo).Close()
                    MessageBox.Show("Archivo de texto creado" & rutaArchivo, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("El archivo ya existe en la ubicación especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Error al crear el archivo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        'Metodo que comprueba la existencia del archivo a eliminar en el directorio.

        Try
            If File.Exists(rutaArchivo) Then

                File.Delete(rutaArchivo)
                MessageBox.Show("Archivo de texto eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("El archivo es inexistente en la ubicacion especificada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            ListBoxClientes.Items.Clear()
        Catch ex As Exception
            MessageBox.Show("Error al eliminar el archivo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnGuardartodo_Click(sender As Object, e As EventArgs) Handles BtnGuardartodo.Click
        'Metodo que lee datos ingresados por usuario en text box lo almacena en una variable, lo escribe en el archivo txt
        'Llama al metodo Cargar Datos en ListBox para mostrar en el form principal.
        Dim agregarInfo As String = TxtNombres.Text & "," & TxtApellidos.Text
        If agregarInfo <> "" Then
            swEscritor = New StreamWriter(rutaArchivo, True)
            swEscritor.WriteLine(agregarInfo)
            TxtNombres.Clear()
            TxtApellidos.Clear()
            swEscritor.Close()

            CargarDatosEnListBox()
        End If

    End Sub

    Private Sub BtnSobrescribir_Click(sender As Object, e As EventArgs) Handles BtnSobrescribir.Click
        'Metodo que lee datos del text box ingresados por usuario, los almacena en una variable, lee el archivo txt si contiene datos los almacena en
        'un arreglo, cuenta sus espacios e indices luego reemplaza el ultimo por los datos actualizados (sobrescritura)
        Dim modificar As String = TxtNombres.Text & "," & TxtApellidos.Text
        If modificar <> "" Then
            Dim registros As String() = File.ReadAllLines(rutaArchivo)
            If registros.Length > 0 Then
                registros(registros.Length - 1) = modificar
                File.WriteAllLines(rutaArchivo, registros)
            End If
            TxtNombres.Clear()
            TxtApellidos.Clear()
            CargarDatosEnListBox()
        End If
    End Sub

    Private Sub CargarDatosEnListBox()
        'comprueba existencia de archivo lo lee y almacena sus registros en un arreglo a mostrar en ListBox donde se cuentan registros que se imprimen 
        'en un label.
        If File.Exists(rutaArchivo) Then
            Dim contenido As String() = File.ReadAllLines(rutaArchivo)
            ListBoxClientes.Items.Clear() ' Limpia el ListBox antes de agregar los datos
            ListBoxClientes.Items.AddRange(contenido)
            cantidad = ListBoxClientes.Items.Count
            lblTotalReg.Text = "Total " & cantidad

        End If
    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnEliminar.Enabled = False
        BtnSobrescribir.Enabled = False
        BtnGuardartodo.Enabled = False
    End Sub
End Class

