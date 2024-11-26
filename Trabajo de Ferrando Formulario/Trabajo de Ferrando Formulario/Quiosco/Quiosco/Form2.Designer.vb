<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQuiosco
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
        GroupBox1 = New GroupBox()
        TxtPrecio = New TextBox()
        BtnActualizarProducto = New Button()
        BtnEliminarProducto = New Button()
        BtnAgregarProducto = New Button()
        Label4 = New Label()
        TxtCantidad = New TextBox()
        BtnListarProductos = New Button()
        TxtDescripcion = New TextBox()
        Label3 = New Label()
        TxtNombre = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TxtPrecio)
        GroupBox1.Controls.Add(BtnActualizarProducto)
        GroupBox1.Controls.Add(BtnEliminarProducto)
        GroupBox1.Controls.Add(BtnAgregarProducto)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(TxtCantidad)
        GroupBox1.Controls.Add(BtnListarProductos)
        GroupBox1.Controls.Add(TxtDescripcion)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(TxtNombre)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(517, 213)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Gestion de Productos"
        ' 
        ' TxtPrecio
        ' 
        TxtPrecio.Location = New Point(112, 108)
        TxtPrecio.Name = "TxtPrecio"
        TxtPrecio.Size = New Size(100, 23)
        TxtPrecio.TabIndex = 11
        ' 
        ' BtnActualizarProducto
        ' 
        BtnActualizarProducto.Location = New Point(267, 146)
        BtnActualizarProducto.Name = "BtnActualizarProducto"
        BtnActualizarProducto.Size = New Size(112, 61)
        BtnActualizarProducto.TabIndex = 2
        BtnActualizarProducto.Text = "Actualizar la información de un producto"
        BtnActualizarProducto.UseVisualStyleBackColor = True
        ' 
        ' BtnEliminarProducto
        ' 
        BtnEliminarProducto.Location = New Point(145, 146)
        BtnEliminarProducto.Name = "BtnEliminarProducto"
        BtnEliminarProducto.Size = New Size(116, 61)
        BtnEliminarProducto.TabIndex = 1
        BtnEliminarProducto.Text = "Eliminar un producto"
        BtnEliminarProducto.UseVisualStyleBackColor = True
        ' 
        ' BtnAgregarProducto
        ' 
        BtnAgregarProducto.Location = New Point(26, 146)
        BtnAgregarProducto.Name = "BtnAgregarProducto"
        BtnAgregarProducto.Size = New Size(113, 61)
        BtnAgregarProducto.TabIndex = 0
        BtnAgregarProducto.Text = "Agregar producto al inventario"
        BtnAgregarProducto.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(35, 112)
        Label4.Name = "Label4"
        Label4.Size = New Size(40, 15)
        Label4.TabIndex = 7
        Label4.Text = "Precio"
        ' 
        ' TxtCantidad
        ' 
        TxtCantidad.Location = New Point(112, 80)
        TxtCantidad.Name = "TxtCantidad"
        TxtCantidad.Size = New Size(100, 23)
        TxtCantidad.TabIndex = 10
        ' 
        ' BtnListarProductos
        ' 
        BtnListarProductos.Location = New Point(385, 146)
        BtnListarProductos.Name = "BtnListarProductos"
        BtnListarProductos.Size = New Size(112, 61)
        BtnListarProductos.TabIndex = 3
        BtnListarProductos.Text = "Mostrar todos los productos"
        BtnListarProductos.UseVisualStyleBackColor = True
        ' 
        ' TxtDescripcion
        ' 
        TxtDescripcion.Location = New Point(112, 51)
        TxtDescripcion.Name = "TxtDescripcion"
        TxtDescripcion.Size = New Size(100, 23)
        TxtDescripcion.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(31, 83)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 15)
        Label3.TabIndex = 6
        Label3.Text = "Cantidad"
        ' 
        ' TxtNombre
        ' 
        TxtNombre.Location = New Point(112, 22)
        TxtNombre.Name = "TxtNombre"
        TxtNombre.Size = New Size(100, 23)
        TxtNombre.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(26, 54)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 15)
        Label2.TabIndex = 5
        Label2.Text = "Descripción"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(35, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 15)
        Label1.TabIndex = 4
        Label1.Text = "Nombre"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(535, 18)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(240, 207)
        DataGridView1.TabIndex = 1
        ' 
        ' FrmQuiosco
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(GroupBox1)
        Name = "FrmQuiosco"
        Text = "FrmQuiosco"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnAgregarProducto As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnListarProductos As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnActualizarProducto As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnEliminarProducto As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
