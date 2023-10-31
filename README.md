# *Universidad Internacional San Isidro Labrador*


### *(ISB-13) PROGRAMACIÓN II*

## *Manejo de Archivos*
### *Documentación técnica*

#### *Profesor*
##### *Ing. Jairo Segura Vargas.*
#### *Alumnos*
##### *Daniel Sequeira Gaitan - Fabian Arredondo Arce.*

# Descripción General________________

## Objetivo General

Analizar, desarrollar e implementar un Manejador de archivos que puedan agregar en una lista y se pueda visualizar los datos.

### Objetivos específicos

-   Analizar los requerimientos necesarios para la elaboración de un manejador de archivos.
-   Desarrollar en el lenguaje visual basic .net un programa que pueda visualizar actualizar y agregar información en un archivo.
-   Implementar el sistema y que sea funcional.
## Criterios de aceptación:


-   El sistema debe crear un archivo de nombre opcional PRUEBA en la ubicación determinada.
-   Debe ser capaz de guardar información y luego sobre escribirlo.
-   Debe ser capaz de agregar más información al archivo creado.
-   El archivo se puede eliminar y crear uno nuevo.
-   Si el archivo ya fue creado debe validar que no se pueda crear otro.
-   La información se mostrará en un ListBox que llevara un contador de los registro que se han agregado.
## Requerimientos________________________________
Proyecto desarrollado mediante aplicación de Windows Forms en lenguaje Visual Basic, con Visual Studio Community 2022, NetCore 7, este proyecto fue desarrollado en entorno estudiantil universitario, en su versión original y unica, no forma parte de otros desarrollos al ser propiamente un proyecto universitario, no requiere medios de instalación específicos mas allá de su entorno de desarrollo y ejecución mencionado.
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
## Arquitectura del proyecto 
Proyecto de WIndows Forms en Visual Basic, cuenta con 4 funcionalidades por medio de botones que responden a eventos a ejecutar, generando un archivo txt, agregando información al mismo u modificándola, la cual es leida  y mostrada mediente un listbox en el form principal, asociado al mismo una funcionalidad de contador de registros, y finalmente con opción de eliminar al mismo.

> Inicio
 Generar archivo
Añadir datos-|-Sobrescribir datos
Leer y mostrar contenido de archivo txt
Eliminar archivo 
Fin

## Generar Archivo .txt
`BtnCrear_Click` 
Se ejecuta cuando se hace clic en el botón "Crear txt". El procedimiento consiste a una respuesta al evento (pulsar el botón) y genera un archivo .txt en una ruta D:/ con el nombre de archivo ArchivoPrueba.txt, previamente valida si ya existe.
 Mediante la tecnología Try/ Catch manejamos las exepciones o errores que podrían surgir y dentro de esta mediante la estructura condicional If validamos si en la ruta no existe el archivo, bien crear sino muestra un mensaje de error indicando que ya el archivo existe, esto previene que sea reemplazado, luego de crearlo se realiza cierre del mismo para que sea posible su modificación con las otras opciones o en su caso la eliminación.
    
 Private Sub BtnCrear_Click(sender As Object, e As EventArgs) Handles BtnCrear.Click

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

 ## Eliminar Archivo
Se realiza una comprobación como la anterior pero con el fin de que si el archivo existe en la ruta especificada, se elimine, si no se maneje la excepción informando que no se encuentra y evite que se nos cierre la aplicación.

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

## Mostrar Datos del Archivo Generado en una ListBox en el form principal.

Este método valida inicialmente la existencia del archivo y en caso afirmativo leerá el mismo linea a linea y almacenará esta información en una lista, luego limpia la vista del listbox y añade la información almacenada en la lista creada a partir de lectura del archivo txt, a la ves dentro de este método con el uso de la propiedad Items.count se realiza una cuenta de registros de datos, aprovechando que el archivo ya fue leido y almacenado una vez y con esa información alimenta el contador que se mostrara en su respectivo Label.

Private Sub CargarDatosEnListBox()

        If File.Exists(rutaArchivo) Then
            Dim contenido As String() = File.ReadAllLines(rutaArchivo)
            listaDatos.Items.Clear() ' Limpia el ListBox antes de agregar los datos
            listaDatos.Items.AddRange(contenido)
            cantidad = listaDatos.Items.Count
            lblTotalReg.Text = cantidad

        End If
    End Sub

    ## Agregar Datos
El proceso consiste en almacenar el contenido escrito en el text box en una variable, luego se valide que no sea un text box vacío y mediante la variable sw Escritor para almacenar la instancia del metodo StreamWriter permita a través de propiedades la escritura de un archico de texto previamente creado. luego de añadir la información limpia el text box y cierra el archivo, además aquí se llama el metodo CargaDatos que realiza conteo de registros ya leidos en este metodo y los muestra en un label.

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
 
## Sobrescribir Datos
Nuevamente se leen datos del text box (ingresados por el usuario), se almacenan en una variable, en la lista registros generada a partir de la lectura del archivo txt generado, cuenta sus espacios y se le resta uno para posicionarse en lo que sería su ultimo indice que contiene el registro reciente para sobrescribirlo o modificarlo, se realiza la sobrescritura del txt. y se llama al metodo para cargar datos actualizados a mostrar en list box del form principal.

    vate Sub BtnSobrescribir_Click(sender As Object, e As EventArgs) Handles BtnSobrescribir.Click

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









