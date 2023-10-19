<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        BtnCrear = New Button()
        TextBox1 = New TextBox()
        BtnEliminar = New Button()
        BtnAgregar = New Button()
        BtnSobrescribir = New Button()
        ListBox1 = New ListBox()
        SuspendLayout()
        ' 
        ' BtnCrear
        ' 
        BtnCrear.Location = New Point(12, 303)
        BtnCrear.Name = "BtnCrear"
        BtnCrear.Size = New Size(82, 23)
        BtnCrear.TabIndex = 0
        BtnCrear.Text = "Crear txt"
        BtnCrear.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(12, 40)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(282, 23)
        TextBox1.TabIndex = 1
        ' 
        ' BtnEliminar
        ' 
        BtnEliminar.Location = New Point(115, 303)
        BtnEliminar.Name = "BtnEliminar"
        BtnEliminar.Size = New Size(75, 23)
        BtnEliminar.TabIndex = 2
        BtnEliminar.Text = "Eliminar txt"
        BtnEliminar.UseVisualStyleBackColor = True
        ' 
        ' BtnAgregar
        ' 
        BtnAgregar.Location = New Point(12, 69)
        BtnAgregar.Name = "BtnAgregar"
        BtnAgregar.Size = New Size(75, 23)
        BtnAgregar.TabIndex = 3
        BtnAgregar.Text = "Agregar"
        BtnAgregar.UseVisualStyleBackColor = True
        ' 
        ' BtnSobrescribir
        ' 
        BtnSobrescribir.Location = New Point(104, 69)
        BtnSobrescribir.Name = "BtnSobrescribir"
        BtnSobrescribir.Size = New Size(86, 23)
        BtnSobrescribir.TabIndex = 4
        BtnSobrescribir.Text = "Sobrescribir"
        BtnSobrescribir.UseVisualStyleBackColor = True
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(12, 120)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(282, 154)
        ListBox1.TabIndex = 5
        ' 
        ' FrmPrincipal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(311, 350)
        Controls.Add(ListBox1)
        Controls.Add(BtnSobrescribir)
        Controls.Add(BtnAgregar)
        Controls.Add(BtnEliminar)
        Controls.Add(TextBox1)
        Controls.Add(BtnCrear)
        Name = "FrmPrincipal"
        Text = "Manejo de Archivos"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnCrear As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnSobrescribir As Button
    Friend WithEvents ListBox1 As ListBox
End Class
