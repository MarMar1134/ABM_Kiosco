<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProductos
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
        Label4 = New Label()
        BtnActualizar = New Button()
        Label3 = New Label()
        TxtPrecio = New TextBox()
        Label2 = New Label()
        BtnEliminar = New Button()
        Label1 = New Label()
        TxtProductoID = New TextBox()
        BtnAgregar = New Button()
        TxtCantidad = New TextBox()
        TxtNombre = New TextBox()
        GroupBox2 = New GroupBox()
        Label6 = New Label()
        BtnConsultarStock = New Button()
        Label5 = New Label()
        TxtConsultaID = New TextBox()
        DataGridView1 = New DataGridView()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(BtnActualizar)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(TxtPrecio)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(BtnEliminar)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(TxtProductoID)
        GroupBox1.Controls.Add(BtnAgregar)
        GroupBox1.Controls.Add(TxtCantidad)
        GroupBox1.Controls.Add(TxtNombre)
        GroupBox1.Location = New Point(12, 46)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(409, 193)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Gestión de Productos"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(27, 121)
        Label4.Name = "Label4"
        Label4.Size = New Size(40, 15)
        Label4.TabIndex = 4
        Label4.Text = "Precio"
        ' 
        ' BtnActualizar
        ' 
        BtnActualizar.Location = New Point(244, 154)
        BtnActualizar.Name = "BtnActualizar"
        BtnActualizar.Size = New Size(113, 33)
        BtnActualizar.TabIndex = 2
        BtnActualizar.Text = "Actualizar"
        BtnActualizar.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(23, 92)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 15)
        Label3.TabIndex = 3
        Label3.Text = "Cantidad"
        ' 
        ' TxtPrecio
        ' 
        TxtPrecio.Location = New Point(125, 113)
        TxtPrecio.Name = "TxtPrecio"
        TxtPrecio.Size = New Size(100, 23)
        TxtPrecio.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(27, 63)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 2
        Label2.Text = "Nombre"
        ' 
        ' BtnEliminar
        ' 
        BtnEliminar.Location = New Point(125, 154)
        BtnEliminar.Name = "BtnEliminar"
        BtnEliminar.Size = New Size(113, 33)
        BtnEliminar.TabIndex = 1
        BtnEliminar.Text = "Eliminar"
        BtnEliminar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 15)
        Label1.TabIndex = 1
        Label1.Text = "ID del Producto"
        ' 
        ' TxtProductoID
        ' 
        TxtProductoID.Location = New Point(125, 26)
        TxtProductoID.Name = "TxtProductoID"
        TxtProductoID.Size = New Size(100, 23)
        TxtProductoID.TabIndex = 3
        ' 
        ' BtnAgregar
        ' 
        BtnAgregar.Location = New Point(6, 154)
        BtnAgregar.Name = "BtnAgregar"
        BtnAgregar.Size = New Size(113, 33)
        BtnAgregar.TabIndex = 0
        BtnAgregar.Text = "Agregar"
        BtnAgregar.UseVisualStyleBackColor = True
        ' 
        ' TxtCantidad
        ' 
        TxtCantidad.Location = New Point(125, 84)
        TxtCantidad.Name = "TxtCantidad"
        TxtCantidad.Size = New Size(100, 23)
        TxtCantidad.TabIndex = 5
        ' 
        ' TxtNombre
        ' 
        TxtNombre.Location = New Point(125, 55)
        TxtNombre.Name = "TxtNombre"
        TxtNombre.Size = New Size(100, 23)
        TxtNombre.TabIndex = 4
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(BtnConsultarStock)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(TxtConsultaID)
        GroupBox2.Location = New Point(427, 46)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(240, 136)
        GroupBox2.TabIndex = 7
        GroupBox2.TabStop = False
        GroupBox2.Text = "Consulta de Stock"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(137, 74)
        Label6.Name = "Label6"
        Label6.Size = New Size(28, 15)
        Label6.TabIndex = 8
        Label6.Text = "Text"
        ' 
        ' BtnConsultarStock
        ' 
        BtnConsultarStock.Location = New Point(6, 60)
        BtnConsultarStock.Name = "BtnConsultarStock"
        BtnConsultarStock.Size = New Size(75, 42)
        BtnConsultarStock.TabIndex = 9
        BtnConsultarStock.Text = "Mostrar Stock"
        BtnConsultarStock.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 34)
        Label5.Name = "Label5"
        Label5.Size = New Size(89, 15)
        Label5.TabIndex = 9
        Label5.Text = "ID del Producto"
        ' 
        ' TxtConsultaID
        ' 
        TxtConsultaID.Location = New Point(101, 31)
        TxtConsultaID.Name = "TxtConsultaID"
        TxtConsultaID.Size = New Size(100, 23)
        TxtConsultaID.TabIndex = 8
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(427, 188)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(240, 150)
        DataGridView1.TabIndex = 8
        ' 
        ' FrmProductos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "FrmProductos"
        Text = "FrmProductos"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents TxtProductoID As TextBox
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtConsultaID As TextBox
    Friend WithEvents BtnConsultarStock As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
