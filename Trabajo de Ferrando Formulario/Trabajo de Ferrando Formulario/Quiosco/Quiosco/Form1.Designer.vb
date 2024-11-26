<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUsuarios
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
        GroupBox1 = New GroupBox()
        BtnModificarDatos = New Button()
        Label2 = New Label()
        BtnCerrarSesion = New Button()
        Label1 = New Label()
        BtnIniciarSesion = New Button()
        TxtContraseña = New TextBox()
        TxtUsuario = New TextBox()
        DgvVentas = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        BtnVerVentas = New Button()
        GroupBox1.SuspendLayout()
        CType(DgvVentas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(BtnModificarDatos)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(BtnCerrarSesion)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(BtnIniciarSesion)
        GroupBox1.Controls.Add(TxtContraseña)
        GroupBox1.Controls.Add(TxtUsuario)
        GroupBox1.Location = New Point(56, 100)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(363, 160)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Gestion de Usuario"
        ' 
        ' BtnModificarDatos
        ' 
        BtnModificarDatos.Location = New Point(247, 129)
        BtnModificarDatos.Name = "BtnModificarDatos"
        BtnModificarDatos.Size = New Size(102, 23)
        BtnModificarDatos.TabIndex = 3
        BtnModificarDatos.Text = "Modificar Datos"
        BtnModificarDatos.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(125, 89)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 15)
        Label2.TabIndex = 3
        Label2.Text = "Contraseña"
        ' 
        ' BtnCerrarSesion
        ' 
        BtnCerrarSesion.Location = New Point(125, 129)
        BtnCerrarSesion.Name = "BtnCerrarSesion"
        BtnCerrarSesion.Size = New Size(116, 23)
        BtnCerrarSesion.TabIndex = 2
        BtnCerrarSesion.Text = "Cerrar Sesión"
        BtnCerrarSesion.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(136, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 15)
        Label1.TabIndex = 1
        Label1.Text = "Usuario"
        ' 
        ' BtnIniciarSesion
        ' 
        BtnIniciarSesion.Location = New Point(6, 129)
        BtnIniciarSesion.Name = "BtnIniciarSesion"
        BtnIniciarSesion.Size = New Size(113, 23)
        BtnIniciarSesion.TabIndex = 1
        BtnIniciarSesion.Text = "Iniciar Sesion"
        BtnIniciarSesion.UseVisualStyleBackColor = True
        ' 
        ' TxtContraseña
        ' 
        TxtContraseña.Location = New Point(6, 86)
        TxtContraseña.Name = "TxtContraseña"
        TxtContraseña.Size = New Size(100, 23)
        TxtContraseña.TabIndex = 2
        TxtContraseña.UseSystemPasswordChar = True
        ' 
        ' TxtUsuario
        ' 
        TxtUsuario.Location = New Point(6, 22)
        TxtUsuario.Name = "TxtUsuario"
        TxtUsuario.Size = New Size(100, 23)
        TxtUsuario.TabIndex = 1
        ' 
        ' DgvVentas
        ' 
        DgvVentas.AllowUserToOrderColumns = True
        DgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvVentas.Columns.AddRange(New DataGridViewColumn() {Column1})
        DgvVentas.Location = New Point(477, 110)
        DgvVentas.Name = "DgvVentas"
        DgvVentas.Size = New Size(240, 150)
        DgvVentas.TabIndex = 4
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Ventas"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' BtnVerVentas
        ' 
        BtnVerVentas.Location = New Point(541, 266)
        BtnVerVentas.Name = "BtnVerVentas"
        BtnVerVentas.Size = New Size(116, 23)
        BtnVerVentas.TabIndex = 5
        BtnVerVentas.Text = "Ver Ventas"
        BtnVerVentas.UseVisualStyleBackColor = True
        ' 
        ' FrmUsuarios
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BtnVerVentas)
        Controls.Add(DgvVentas)
        Controls.Add(GroupBox1)
        Name = "FrmUsuarios"
        Text = " "
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DgvVentas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtContraseña As TextBox
    Friend WithEvents BtnModificarDatos As Button
    Friend WithEvents BtnCerrarSesion As Button
    Friend WithEvents BtnIniciarSesion As Button
    Friend WithEvents DgvVentas As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents BtnVerVentas As Button

End Class
