<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVentas
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
        BtnCalcularTotal = New Button()
        BtnAgregarVenta = New Button()
        TxtTotal = New TextBox()
        TxtPrecioUnitario = New TextBox()
        TxtCantidad = New TextBox()
        CmbProductos = New ComboBox()
        DgvVentas = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        GroupBox1.SuspendLayout()
        CType(DgvVentas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(BtnCalcularTotal)
        GroupBox1.Controls.Add(BtnAgregarVenta)
        GroupBox1.Controls.Add(TxtTotal)
        GroupBox1.Controls.Add(TxtPrecioUnitario)
        GroupBox1.Controls.Add(TxtCantidad)
        GroupBox1.Controls.Add(CmbProductos)
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(457, 446)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Gestion de Ventas"
        ' 
        ' BtnCalcularTotal
        ' 
        BtnCalcularTotal.Location = New Point(232, 231)
        BtnCalcularTotal.Name = "BtnCalcularTotal"
        BtnCalcularTotal.Size = New Size(113, 48)
        BtnCalcularTotal.TabIndex = 6
        BtnCalcularTotal.Text = "Calcular Total"
        BtnCalcularTotal.UseVisualStyleBackColor = True
        ' 
        ' BtnAgregarVenta
        ' 
        BtnAgregarVenta.Location = New Point(115, 231)
        BtnAgregarVenta.Name = "BtnAgregarVenta"
        BtnAgregarVenta.Size = New Size(105, 48)
        BtnAgregarVenta.TabIndex = 5
        BtnAgregarVenta.Text = "Agregar Venta"
        BtnAgregarVenta.UseVisualStyleBackColor = True
        ' 
        ' TxtTotal
        ' 
        TxtTotal.Location = New Point(115, 178)
        TxtTotal.Name = "TxtTotal"
        TxtTotal.Size = New Size(230, 23)
        TxtTotal.TabIndex = 4
        ' 
        ' TxtPrecioUnitario
        ' 
        TxtPrecioUnitario.Location = New Point(115, 149)
        TxtPrecioUnitario.Name = "TxtPrecioUnitario"
        TxtPrecioUnitario.Size = New Size(230, 23)
        TxtPrecioUnitario.TabIndex = 3
        ' 
        ' TxtCantidad
        ' 
        TxtCantidad.Location = New Point(115, 120)
        TxtCantidad.Name = "TxtCantidad"
        TxtCantidad.Size = New Size(230, 23)
        TxtCantidad.TabIndex = 2
        ' 
        ' CmbProductos
        ' 
        CmbProductos.FormattingEnabled = True
        CmbProductos.Location = New Point(6, 64)
        CmbProductos.Name = "CmbProductos"
        CmbProductos.Size = New Size(339, 23)
        CmbProductos.TabIndex = 1
        ' 
        ' DgvVentas
        ' 
        DgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvVentas.Location = New Point(463, 9)
        DgvVentas.Name = "DgvVentas"
        DgvVentas.Size = New Size(325, 437)
        DgvVentas.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(25, 128)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 15)
        Label1.TabIndex = 7
        Label1.Text = "Cantidad"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 157)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 15)
        Label2.TabIndex = 8
        Label2.Text = "Precio x Unidad"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(39, 186)
        Label3.Name = "Label3"
        Label3.Size = New Size(32, 15)
        Label3.TabIndex = 9
        Label3.Text = "Total"
        ' 
        ' FrmVentas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DgvVentas)
        Controls.Add(GroupBox1)
        Name = "FrmVentas"
        Text = "FrmVentas"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DgvVentas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents TxtPrecioUnitario As TextBox
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents CmbProductos As ComboBox
    Friend WithEvents BtnCalcularTotal As Button
    Friend WithEvents BtnAgregarVenta As Button
    Friend WithEvents DgvVentas As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
