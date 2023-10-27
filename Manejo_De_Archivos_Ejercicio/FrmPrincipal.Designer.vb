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
        BtnCrear.Location = New Point(67, 420)
        BtnCrear.Margin = New Padding(3, 4, 3, 4)
        BtnCrear.Name = "BtnCrear"
        BtnCrear.Size = New Size(94, 31)
        BtnCrear.TabIndex = 0
        BtnCrear.Text = "Crear txt"
        BtnCrear.UseVisualStyleBackColor = True
        ' 
        ' tbxAgregarInfo
        ' 
        tbxAgregarInfo.Location = New Point(14, 53)
        tbxAgregarInfo.Margin = New Padding(3, 4, 3, 4)
        tbxAgregarInfo.Name = "tbxAgregarInfo"
        tbxAgregarInfo.Size = New Size(322, 27)
        tbxAgregarInfo.TabIndex = 1
        ' 
        ' BtnEliminar
        ' 
        BtnEliminar.Location = New Point(205, 420)
        BtnEliminar.Margin = New Padding(3, 4, 3, 4)
        BtnEliminar.Name = "BtnEliminar"
        BtnEliminar.Size = New Size(86, 31)
        BtnEliminar.TabIndex = 2
        BtnEliminar.Text = "Eliminar txt"
        BtnEliminar.UseVisualStyleBackColor = True
        ' 
        ' BtnAgregar
        ' 
        BtnAgregar.Location = New Point(14, 92)
        BtnAgregar.Margin = New Padding(3, 4, 3, 4)
        BtnAgregar.Name = "BtnAgregar"
        BtnAgregar.Size = New Size(86, 31)
        BtnAgregar.TabIndex = 3
        BtnAgregar.Text = "Agregar"
        BtnAgregar.UseVisualStyleBackColor = True
        ' 
        ' BtnSobrescribir
        ' 
        BtnSobrescribir.Location = New Point(119, 92)
        BtnSobrescribir.Margin = New Padding(3, 4, 3, 4)
        BtnSobrescribir.Name = "BtnSobrescribir"
        BtnSobrescribir.Size = New Size(98, 31)
        BtnSobrescribir.TabIndex = 4
        BtnSobrescribir.Text = "Sobrescribir"
        BtnSobrescribir.UseVisualStyleBackColor = True
        ' 
        ' listaDatos
        ' 
        listaDatos.FormattingEnabled = True
        listaDatos.ItemHeight = 20
        listaDatos.Location = New Point(14, 160)
        listaDatos.Margin = New Padding(3, 4, 3, 4)
        listaDatos.Name = "listaDatos"
        listaDatos.Size = New Size(322, 204)
        listaDatos.TabIndex = 5
        ' 
        ' lblTotalReg
        ' 
        lblTotalReg.AutoSize = True
        lblTotalReg.Location = New Point(14, 369)
        lblTotalReg.Name = "lblTotalReg"
        lblTotalReg.Size = New Size(15, 20)
        lblTotalReg.TabIndex = 6
        lblTotalReg.Text = "*"
        ' 
        ' FrmPrincipal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(355, 467)
        Controls.Add(lblTotalReg)
        Controls.Add(listaDatos)
        Controls.Add(BtnSobrescribir)
        Controls.Add(BtnAgregar)
        Controls.Add(BtnEliminar)
        Controls.Add(tbxAgregarInfo)
        Controls.Add(BtnCrear)
        Margin = New Padding(3, 4, 3, 4)
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
