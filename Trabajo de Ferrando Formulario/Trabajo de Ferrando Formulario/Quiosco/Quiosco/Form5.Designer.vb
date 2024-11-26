<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        BtnUsuarios = New Button()
        BtnQuiosco = New Button()
        BtnProductos = New Button()
        BtnVentas = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' BtnUsuarios
        ' 
        BtnUsuarios.Location = New Point(12, 249)
        BtnUsuarios.Name = "BtnUsuarios"
        BtnUsuarios.Size = New Size(145, 45)
        BtnUsuarios.TabIndex = 0
        BtnUsuarios.Text = "Inicio de Sesion "
        BtnUsuarios.UseVisualStyleBackColor = True
        ' 
        ' BtnQuiosco
        ' 
        BtnQuiosco.Location = New Point(222, 249)
        BtnQuiosco.Name = "BtnQuiosco"
        BtnQuiosco.Size = New Size(145, 45)
        BtnQuiosco.TabIndex = 1
        BtnQuiosco.Text = "Quiosco"
        BtnQuiosco.UseVisualStyleBackColor = True
        ' 
        ' BtnProductos
        ' 
        BtnProductos.Location = New Point(429, 249)
        BtnProductos.Name = "BtnProductos"
        BtnProductos.Size = New Size(145, 45)
        BtnProductos.TabIndex = 2
        BtnProductos.Text = "Productos"
        BtnProductos.UseVisualStyleBackColor = True
        ' 
        ' BtnVentas
        ' 
        BtnVentas.Location = New Point(643, 249)
        BtnVentas.Name = "BtnVentas"
        BtnVentas.Size = New Size(145, 45)
        BtnVentas.TabIndex = 3
        BtnVentas.Text = "Ventas"
        BtnVentas.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.BackColor = SystemColors.ControlLightLight
        Label1.Font = New Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(149, 89)
        Label1.Name = "Label1"
        Label1.Size = New Size(507, 52)
        Label1.TabIndex = 4
        Label1.Text = "Quiosco"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FrmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DimGray
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(BtnVentas)
        Controls.Add(BtnProductos)
        Controls.Add(BtnQuiosco)
        Controls.Add(BtnUsuarios)
        Name = "FrmMain"
        Text = " FrmMain"
        ResumeLayout(False)
    End Sub

    Friend WithEvents BtnUsuarios As Button
    Friend WithEvents BtnQuiosco As Button
    Friend WithEvents BtnProductos As Button
    Friend WithEvents BtnVentas As Button
    Friend WithEvents Label1 As Label
End Class
