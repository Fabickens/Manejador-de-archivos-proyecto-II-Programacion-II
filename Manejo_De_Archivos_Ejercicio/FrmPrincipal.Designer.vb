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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
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
        Label9 = New Label()
        Panel4 = New Panel()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnCrearTxt
        ' 
        BtnCrearTxt.BackColor = SystemColors.ButtonFace
        BtnCrearTxt.DialogResult = DialogResult.Cancel
        BtnCrearTxt.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        BtnCrearTxt.Image = CType(resources.GetObject("BtnCrearTxt.Image"), Image)
        BtnCrearTxt.Location = New Point(34, 16)
        BtnCrearTxt.Name = "BtnCrearTxt"
        BtnCrearTxt.Size = New Size(55, 72)
        BtnCrearTxt.TabIndex = 0
        BtnCrearTxt.Text = "Crear"
        BtnCrearTxt.TextAlign = ContentAlignment.BottomCenter
        BtnCrearTxt.TextImageRelation = TextImageRelation.ImageAboveText
        BtnCrearTxt.UseVisualStyleBackColor = False
        ' 
        ' TxtNombres
        ' 
        TxtNombres.BorderStyle = BorderStyle.FixedSingle
        TxtNombres.Location = New Point(83, 30)
        TxtNombres.Name = "TxtNombres"
        TxtNombres.Size = New Size(115, 23)
        TxtNombres.TabIndex = 1
        ' 
        ' BtnEliminar
        ' 
        BtnEliminar.BackColor = SystemColors.ButtonFace
        BtnEliminar.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        BtnEliminar.Image = CType(resources.GetObject("BtnEliminar.Image"), Image)
        BtnEliminar.Location = New Point(301, 16)
        BtnEliminar.Name = "BtnEliminar"
        BtnEliminar.Size = New Size(65, 72)
        BtnEliminar.TabIndex = 2
        BtnEliminar.Text = "Eliminar "
        BtnEliminar.TextImageRelation = TextImageRelation.ImageAboveText
        BtnEliminar.UseVisualStyleBackColor = False
        ' 
        ' BtnGuardartodo
        ' 
        BtnGuardartodo.BackColor = SystemColors.ButtonFace
        BtnGuardartodo.Image = CType(resources.GetObject("BtnGuardartodo.Image"), Image)
        BtnGuardartodo.Location = New Point(204, 16)
        BtnGuardartodo.Name = "BtnGuardartodo"
        BtnGuardartodo.Size = New Size(75, 72)
        BtnGuardartodo.TabIndex = 3
        BtnGuardartodo.Text = "Guardar Todo"
        BtnGuardartodo.TextImageRelation = TextImageRelation.ImageAboveText
        BtnGuardartodo.UseVisualStyleBackColor = False
        ' 
        ' BtnSobrescribir
        ' 
        BtnSobrescribir.BackColor = SystemColors.ButtonFace
        BtnSobrescribir.Image = CType(resources.GetObject("BtnSobrescribir.Image"), Image)
        BtnSobrescribir.Location = New Point(116, 16)
        BtnSobrescribir.Name = "BtnSobrescribir"
        BtnSobrescribir.Size = New Size(63, 72)
        BtnSobrescribir.TabIndex = 4
        BtnSobrescribir.Text = "Sobre Escribir"
        BtnSobrescribir.TextImageRelation = TextImageRelation.ImageAboveText
        BtnSobrescribir.UseVisualStyleBackColor = False
        ' 
        ' ListBoxClientes
        ' 
        ListBoxClientes.BorderStyle = BorderStyle.FixedSingle
        ListBoxClientes.FormattingEnabled = True
        ListBoxClientes.ItemHeight = 15
        ListBoxClientes.Location = New Point(20, 38)
        ListBoxClientes.Name = "ListBoxClientes"
        ListBoxClientes.Size = New Size(538, 167)
        ListBoxClientes.TabIndex = 5
        ' 
        ' lblTotalReg
        ' 
        lblTotalReg.AutoSize = True
        lblTotalReg.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblTotalReg.Location = New Point(506, 50)
        lblTotalReg.Name = "lblTotalReg"
        lblTotalReg.Size = New Size(12, 15)
        lblTotalReg.TabIndex = 6
        lblTotalReg.Text = "*"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(BtnCrearTxt)
        Panel1.Controls.Add(BtnGuardartodo)
        Panel1.Controls.Add(BtnEliminar)
        Panel1.Controls.Add(BtnSobrescribir)
        Panel1.ForeColor = Color.Black
        Panel1.Location = New Point(24, 139)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(383, 94)
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
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(44, 128)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 17)
        Label3.TabIndex = 5
        Label3.Text = "Operaciones"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaption
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(TxtApellidos)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(TxtNombres)
        Panel2.Controls.Add(lblTotalReg)
        Panel2.Location = New Point(24, 262)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(582, 99)
        Panel2.TabIndex = 8
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(469, 24)
        Label7.Name = "Label7"
        Label7.Size = New Size(89, 15)
        Label7.TabIndex = 7
        Label7.Text = "Total Registros"
        ' 
        ' TxtApellidos
        ' 
        TxtApellidos.BorderStyle = BorderStyle.FixedSingle
        TxtApellidos.Location = New Point(316, 30)
        TxtApellidos.Name = "TxtApellidos"
        TxtApellidos.Size = New Size(100, 23)
        TxtApellidos.TabIndex = 4
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(233, 30)
        Label6.Name = "Label6"
        Label6.Size = New Size(60, 15)
        Label6.TabIndex = 3
        Label6.Text = "Apellidos:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(16, 32)
        Label5.Name = "Label5"
        Label5.Size = New Size(61, 15)
        Label5.TabIndex = 2
        Label5.Text = "Nombres:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(44, 251)
        Label2.Name = "Label2"
        Label2.Size = New Size(114, 17)
        Label2.TabIndex = 0
        Label2.Text = "Datos del Cliente"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(ListBoxClientes)
        Panel3.Location = New Point(24, 374)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(594, 236)
        Panel3.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(44, 364)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 17)
        Label4.TabIndex = 0
        Label4.Text = "Resultado"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.ForeColor = Color.White
        Label9.Location = New Point(23, 25)
        Label9.Name = "Label9"
        Label9.Size = New Size(619, 37)
        Label9.TabIndex = 11
        Label9.Text = ":::Tutorial Manejo de Archivos TXT en Vb.Net::: "
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.DeepSkyBlue
        Panel4.Controls.Add(Label9)
        Panel4.Location = New Point(1, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(675, 82)
        Panel4.TabIndex = 12
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(417, 128)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(125, 128)
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(548, 128)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(115, 128)
        PictureBox2.TabIndex = 14
        PictureBox2.TabStop = False
        ' 
        ' FrmPrincipal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(675, 622)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Panel4)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Panel3)
        Controls.Add(Label2)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        ForeColor = SystemColors.ActiveCaptionText
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "FrmPrincipal"
        Text = " ::: Aprendamos de Programación:::"
        WindowState = FormWindowState.Minimized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
