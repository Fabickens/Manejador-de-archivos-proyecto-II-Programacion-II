
Imports System.IO

Public Class FrmPrincipal
    Dim cantidad As Integer = 0
    Dim rutaArchivo As String = "D:\ArchivoPrueba.txt"
    Dim swEscritor As StreamWriter
    Dim srLector As StreamReader

    Private Sub BtnCrear_Click(sender As Object, e As EventArgs) Handles BtnCrear.Click
        'Metodo que genera un archivo txt en la ruta especifica, comprueba si el archivo no existe en el directorio y de ser así lo crea.
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
            listaDatos.Items.Clear()
        Catch ex As Exception
            MessageBox.Show("Error al eliminar el archivo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        'Metodo que lee datos ingresados por usuario en text box lo almacena en una variable, lo escribe en el archivo txt
        'Llama al metodo Cargar Datos en ListBox para mostrar en el form principal.
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
        'Metodo que lee datos del text box ingresados por usuario, los almacena en una variable, lee el archivo txt si contiene datos los almacena en
        'un arreglo, cuenta sus espacios e indices luego reemplaza el ultimo por los datos actualizados (sobrescritura)
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
        'comprueba existencia de archivo lo lee y almacena sus registros en un arreglo a mostrar en ListBox donde se cuentan registros que se imprimen 
        'en un label.
        If File.Exists(rutaArchivo) Then
            Dim contenido As String() = File.ReadAllLines(rutaArchivo)
            listaDatos.Items.Clear() ' Limpia el ListBox antes de agregar los datos
            listaDatos.Items.AddRange(contenido)
            cantidad = listaDatos.Items.Count
            lblTotalReg.Text = "Total " & cantidad

        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class

