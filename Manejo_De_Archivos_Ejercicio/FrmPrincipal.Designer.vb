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
        Panel1 = New Panel()
        Label1 = New Label()
        Label3 = New Label()
        Panel2 = New Panel()
        Label7 = New Label()
        TextBox1 = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label2 = New Label()
        Panel3 = New Panel()
        Label4 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' BtnCrear
        ' 
        BtnCrear.Location = New Point(20, 30)
        BtnCrear.Name = "BtnCrear"
        BtnCrear.Size = New Size(82, 23)
        BtnCrear.TabIndex = 0
        BtnCrear.Text = "Crear txt"
        BtnCrear.UseVisualStyleBackColor = True
        ' 
        ' tbxAgregarInfo
        ' 
        tbxAgregarInfo.Location = New Point(87, 24)
        tbxAgregarInfo.Name = "tbxAgregarInfo"
        tbxAgregarInfo.Size = New Size(115, 23)
        tbxAgregarInfo.TabIndex = 1
        ' 
        ' BtnEliminar
        ' 
        BtnEliminar.Location = New Point(355, 30)
        BtnEliminar.Name = "BtnEliminar"
        BtnEliminar.Size = New Size(75, 23)
        BtnEliminar.TabIndex = 2
        BtnEliminar.Text = "Eliminar txt"
        BtnEliminar.UseVisualStyleBackColor = True
        ' 
        ' BtnAgregar
        ' 
        BtnAgregar.Location = New Point(133, 30)
        BtnAgregar.Name = "BtnAgregar"
        BtnAgregar.Size = New Size(75, 23)
        BtnAgregar.TabIndex = 3
        BtnAgregar.Text = "Agregar"
        BtnAgregar.UseVisualStyleBackColor = True
        ' 
        ' BtnSobrescribir
        ' 
        BtnSobrescribir.Location = New Point(239, 30)
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
        listaDatos.Location = New Point(51, 23)
        listaDatos.Name = "listaDatos"
        listaDatos.Size = New Size(315, 109)
        listaDatos.TabIndex = 5
        ' 
        ' lblTotalReg
        ' 
        lblTotalReg.AutoSize = True
        lblTotalReg.Location = New Point(506, 50)
        lblTotalReg.Name = "lblTotalReg"
        lblTotalReg.Size = New Size(12, 15)
        lblTotalReg.TabIndex = 6
        lblTotalReg.Text = "*"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(BtnCrear)
        Panel1.Controls.Add(BtnAgregar)
        Panel1.Controls.Add(BtnEliminar)
        Panel1.Controls.Add(BtnSobrescribir)
        Panel1.Location = New Point(37, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(439, 75)
        Panel1.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(22, -15)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 15)
        Label1.TabIndex = 0
        Label1.Text = "Operaciones"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(18, -3)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 17)
        Label3.TabIndex = 5
        Label3.Text = "Operaciones"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(tbxAgregarInfo)
        Panel2.Controls.Add(lblTotalReg)
        Panel2.Location = New Point(37, 110)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(582, 85)
        Panel2.TabIndex = 8
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(469, 24)
        Label7.Name = "Label7"
        Label7.Size = New Size(83, 15)
        Label7.TabIndex = 7
        Label7.Text = "Total Registros"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(315, 24)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 4
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(233, 30)
        Label6.Name = "Label6"
        Label6.Size = New Size(56, 15)
        Label6.TabIndex = 3
        Label6.Text = "Apellidos"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(16, 32)
        Label5.Name = "Label5"
        Label5.Size = New Size(56, 15)
        Label5.TabIndex = 2
        Label5.Text = "Nombres"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(57, 99)
        Label2.Name = "Label2"
        Label2.Size = New Size(114, 17)
        Label2.TabIndex = 0
        Label2.Text = "Datos del Cliente"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(listaDatos)
        Panel3.Location = New Point(37, 222)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(413, 167)
        Panel3.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(57, 212)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 17)
        Label4.TabIndex = 0
        Label4.Text = "Resultado"
        ' 
        ' FrmPrincipal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(654, 419)
        Controls.Add(Label4)
        Controls.Add(Panel3)
        Controls.Add(Label2)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "FrmPrincipal"
        Text = "Manejo de Archivos"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
