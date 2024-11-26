Public Class FrmQuiosco
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnAgregarProducto_Click(sender As Object, e As EventArgs) Handles BtnAgregarProducto.Click
        If TxtNombre.Text = "" Or TxtCantidad.Text = "" Or TxtPrecio.Text = "" Then
            MessageBox.Show("Por favor, complete todos los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim query As String = "INSERT INTO Productos (Nombre, Descripcion, Cantidad, Precio) VALUES (@Nombre, @Descripcion, @Cantidad, @Precio)"
        Dim conexion As MySqlConnection = conexion.ObtenerConexion()
        Dim comando As New MySqlCommand(query, conexion)

        comando.Parameters.AddWithValue("@Nombre", TxtNombre.Text)
        comando.Parameters.AddWithValue("@Descripcion", TxtDescripcion.Text)
        comando.Parameters.AddWithValue("@Cantidad", CInt(TxtCantidad.Text))
        comando.Parameters.AddWithValue("@Precio", CDbl(TxtPrecio.Text))

        Try
            conexion.Open()
            comando.ExecuteNonQuery()
            MessageBox.Show("Producto agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al agregar el producto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conexion.Close()
        End Try

        CargarProductos()
    End Sub

    Private Sub BtnEliminarProducto_Click(sender As Object, e As EventArgs) Handles BtnEliminarProducto.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Por favor, seleccione un producto para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim productoID As Integer = CInt(DataGridView1.SelectedRows(0).Cells("ProductoID").Value)
        Dim query As String = "DELETE FROM Productos WHERE ProductoID = @ProductoID"
        Dim conexion As MySqlConnection = conexion.ObtenerConexion()
        Dim comando As New MySqlCommand(query, conexion)

        comando.Parameters.AddWithValue("@ProductoID", productoID)

        Try
            conexion.Open()
            comando.ExecuteNonQuery()
            MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al eliminar el producto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conexion.Close()
        End Try

        CargarProductos()
    End Sub

    Private Sub BtnActualizarProducto_Click(sender As Object, e As EventArgs) Handles BtnActualizarProducto.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Por favor, seleccione un producto para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If TxtNombre.Text = "" Or TxtCantidad.Text = "" Or TxtPrecio.Text = "" Then
            MessageBox.Show("Complete todos los campos antes de actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim productoID As Integer = CInt(DataGridView1.SelectedRows(0).Cells("ProductoID").Value)
        Dim query As String = "UPDATE Productos SET Nombre = @Nombre, Descripcion = @Descripcion, Cantidad = @Cantidad, Precio = @Precio WHERE ProductoID = @ProductoID"
        Dim conexion As MySqlConnection = conexion.ObtenerConexion()
        Dim comando As New MySqlCommand(query, conexion)

        comando.Parameters.AddWithValue("@ProductoID", productoID)
        comando.Parameters.AddWithValue("@Nombre", TxtNombre.Text)
        comando.Parameters.AddWithValue("@Descripcion", TxtDescripcion.Text)
        comando.Parameters.AddWithValue("@Cantidad", CInt(TxtCantidad.Text))
        comando.Parameters.AddWithValue("@Precio", CDbl(TxtPrecio.Text))

        Try
            conexion.Open()
            comando.ExecuteNonQuery()
            MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al actualizar el producto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conexion.Close()
        End Try

        CargarProductos()
    End Sub
    Private Sub CargarProductos()
        Dim query As String = "SELECT ProductoID, Nombre, Descripcion, Cantidad, Precio FROM Productos"
        Dim conexion As MySqlConnection = conexion.ObtenerConexion()
        Dim adaptador As New MySqlDataAdapter(query, conexion)
        Dim tabla As New DataTable()

        Try
            conexion.Open()
            adaptador.Fill(tabla)
            DataGridView1.DataSource = tabla
        Catch ex As Exception
            MessageBox.Show("Error al cargar los productos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub BtnListarProductos_Click(sender As Object, e As EventArgs) Handles BtnListarProductos.Click
        CargarProductos()
    End Sub
End Class