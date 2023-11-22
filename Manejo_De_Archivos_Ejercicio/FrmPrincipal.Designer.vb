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
        BtnCrearTxt = New Button()
        TxtNombres = New TextBox()
        BtnEliminar = New Button()
        BtnGuardartodo = New Button()
        BtnSobrescribir = New Button()
        ListBoxClientes = New ListBox()
        lblTotalReg = New Label()
        Panel1 = New Panel()
        Label1 = New Label()
        Label3 = New Label()
        Panel2 = New Panel()
        Label7 = New Label()
        TxtApellidos = New TextBox()
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
        ' BtnCrearTxt
        ' 
        BtnCrearTxt.Location = New Point(20, 30)
        BtnCrearTxt.Name = "BtnCrearTxt"
        BtnCrearTxt.Size = New Size(82, 23)
        BtnCrearTxt.TabIndex = 0
        BtnCrearTxt.Text = "Crear"
        BtnCrearTxt.UseVisualStyleBackColor = True
        ' 
        ' TxtNombres
        ' 
        TxtNombres.Location = New Point(87, 24)
        TxtNombres.Name = "TxtNombres"
        TxtNombres.Size = New Size(115, 23)
        TxtNombres.TabIndex = 1
        ' 
        ' BtnEliminar
        ' 
        BtnEliminar.BackColor = SystemColors.ButtonFace
        BtnEliminar.Location = New Point(355, 30)
        BtnEliminar.Name = "BtnEliminar"
        BtnEliminar.Size = New Size(75, 23)
        BtnEliminar.TabIndex = 2
        BtnEliminar.Text = "Eliminar "
        BtnEliminar.UseVisualStyleBackColor = False
        ' 
        ' BtnGuardartodo
        ' 
        BtnGuardartodo.Location = New Point(243, 20)
        BtnGuardartodo.Name = "BtnGuardartodo"
        BtnGuardartodo.Size = New Size(75, 42)
        BtnGuardartodo.TabIndex = 3
        BtnGuardartodo.Text = "Guardar Todo"
        BtnGuardartodo.UseVisualStyleBackColor = True
        ' 
        ' BtnSobrescribir
        ' 
        BtnSobrescribir.Location = New Point(139, 20)
        BtnSobrescribir.Name = "BtnSobrescribir"
        BtnSobrescribir.Size = New Size(63, 42)
        BtnSobrescribir.TabIndex = 4
        BtnSobrescribir.Text = "Sobre Escribir"
        BtnSobrescribir.UseVisualStyleBackColor = True
        ' 
        ' ListBoxClientes
        ' 
        ListBoxClientes.FormattingEnabled = True
        ListBoxClientes.ItemHeight = 15
        ListBoxClientes.Location = New Point(51, 23)
        ListBoxClientes.Name = "ListBoxClientes"
        ListBoxClientes.Size = New Size(315, 109)
        ListBoxClientes.TabIndex = 5
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
        Panel1.Controls.Add(BtnCrearTxt)
        Panel1.Controls.Add(BtnGuardartodo)
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
        Panel2.Controls.Add(TxtApellidos)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(TxtNombres)
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
        ' TxtApellidos
        ' 
        TxtApellidos.Location = New Point(315, 24)
        TxtApellidos.Name = "TxtApellidos"
        TxtApellidos.Size = New Size(100, 23)
        TxtApellidos.TabIndex = 4
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
        Panel3.Controls.Add(ListBoxClientes)
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

    Friend WithEvents BtnCrearTxt As Button
    Friend WithEvents TxtNombres As TextBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnGuardartodo As Button
    Friend WithEvents BtnSobrescribir As Button
    Friend WithEvents ListBoxClientes As ListBox
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
    Friend WithEvents TxtApellidos As TextBox
End Class
