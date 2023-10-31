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
        tbxAgregarInfo = New TextBox()
        BtnEliminar = New Button()
        BtnAgregar = New Button()
        BtnSobrescribir = New Button()
        listaDatos = New ListBox()
        lblTotalReg = New Label()
        SuspendLayout()
        ' 
        ' BtnCrear
        ' 
        BtnCrear.Location = New Point(44, 302)
        BtnCrear.Name = "BtnCrear"
        BtnCrear.Size = New Size(82, 23)
        BtnCrear.TabIndex = 0
        BtnCrear.Text = "Crear txt"
        BtnCrear.UseVisualStyleBackColor = True
        ' 
        ' tbxAgregarInfo
        ' 
        tbxAgregarInfo.Location = New Point(12, 40)
        tbxAgregarInfo.Name = "tbxAgregarInfo"
        tbxAgregarInfo.Size = New Size(282, 23)
        tbxAgregarInfo.TabIndex = 1
        ' 
        ' BtnEliminar
        ' 
        BtnEliminar.Location = New Point(172, 302)
        BtnEliminar.Name = "BtnEliminar"
        BtnEliminar.Size = New Size(75, 23)
        BtnEliminar.TabIndex = 2
        BtnEliminar.Text = "Eliminar txt"
        BtnEliminar.UseVisualStyleBackColor = True
        ' 
        ' BtnAgregar
        ' 
        BtnAgregar.Location = New Point(44, 69)
        BtnAgregar.Name = "BtnAgregar"
        BtnAgregar.Size = New Size(75, 23)
        BtnAgregar.TabIndex = 3
        BtnAgregar.Text = "Agregar"
        BtnAgregar.UseVisualStyleBackColor = True
        ' 
        ' BtnSobrescribir
        ' 
        BtnSobrescribir.Location = New Point(172, 69)
        BtnSobrescribir.Name = "BtnSobrescribir"
        BtnSobrescribir.Size = New Size(86, 23)
        BtnSobrescribir.TabIndex = 4
        BtnSobrescribir.Text = "Sobrescribir"
        BtnSobrescribir.UseVisualStyleBackColor = True
        ' 
        ' listaDatos
        ' 
        listaDatos.FormattingEnabled = True
        listaDatos.ItemHeight = 15
        listaDatos.Location = New Point(12, 120)
        listaDatos.Name = "listaDatos"
        listaDatos.Size = New Size(282, 154)
        listaDatos.TabIndex = 5
        ' 
        ' lblTotalReg
        ' 
        lblTotalReg.AutoSize = True
        lblTotalReg.Location = New Point(12, 277)
        lblTotalReg.Name = "lblTotalReg"
        lblTotalReg.Size = New Size(12, 15)
        lblTotalReg.TabIndex = 6
        lblTotalReg.Text = "*"
        ' 
        ' FrmPrincipal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(311, 350)
        Controls.Add(lblTotalReg)
        Controls.Add(listaDatos)
        Controls.Add(BtnSobrescribir)
        Controls.Add(BtnAgregar)
        Controls.Add(BtnEliminar)
        Controls.Add(tbxAgregarInfo)
        Controls.Add(BtnCrear)
        Name = "FrmPrincipal"
        Text = "Manejo de Archivos"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnCrear As Button
    Friend WithEvents tbxAgregarInfo As TextBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnSobrescribir As Button
    Friend WithEvents listaDatos As ListBox
    Friend WithEvents lblTotalReg As Label
End Class
