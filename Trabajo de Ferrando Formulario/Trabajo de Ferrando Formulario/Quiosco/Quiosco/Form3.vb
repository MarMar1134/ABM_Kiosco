Public Class FrmProductos
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If TxtNombre.Text = "" Or TxtCantidad.Text = "" Or TxtPrecio.Text = "" Then
            MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim query As String = "INSERT INTO Productos (Nombre, Cantidad, Precio) VALUES (@Nombre, @Cantidad, @Precio)"
        Dim conexion As MySqlConnection = conexion.ObtenerConexion()
        Dim comando As New MySqlCommand(query, conexion)

        comando.Parameters.AddWithValue("@Nombre", TxtNombre.Text)
        comando.Parameters.AddWithValue("@Cantidad", CInt(TxtCantidad.Text))
        comando.Parameters.AddWithValue("@Precio", CDbl(TxtPrecio.Text))

        Try
            conexion.Open()
            comando.ExecuteNonQuery()
            MessageBox.Show("Producto agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al agregar producto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conexion.Close()
        End Try

        CargarProductos()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If TxtProductoID.Text = "" Then
            MessageBox.Show("Por favor, ingrese el ID del producto a eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim query As String = "DELETE FROM Productos WHERE ProductoID = @ProductoID"
        Dim conexion As MySqlConnection = conexion.ObtenerConexion()
        Dim comando As New MySqlCommand(query, conexion)

        comando.Parameters.AddWithValue("@ProductoID", CInt(TxtProductoID.Text))

        Try
            conexion.Open()
            comando.ExecuteNonQuery()
            MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al eliminar producto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conexion.Close()
        End Try

        CargarProductos()
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If TxtProductoID.Text = "" Or TxtNombre.Text = "" Or TxtCantidad.Text = "" Or TxtPrecio.Text = "" Then
            MessageBox.Show("Complete todos los campos antes de actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim query As String = "UPDATE Productos SET Nombre = @Nombre, Cantidad = @Cantidad, Precio = @Precio WHERE ProductoID = @ProductoID"
        Dim conexion As MySqlConnection = conexion.ObtenerConexion()
        Dim comando As New MySqlCommand(query, conexion)

        comando.Parameters.AddWithValue("@ProductoID", CInt(TxtProductoID.Text))
        comando.Parameters.AddWithValue("@Nombre", TxtNombre.Text)
        comando.Parameters.AddWithValue("@Cantidad", CInt(TxtCantidad.Text))
        comando.Parameters.AddWithValue("@Precio", CDbl(TxtPrecio.Text))

        Try
            conexion.Open()
            comando.ExecuteNonQuery()
            MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al actualizar producto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conexion.Close()
        End Try

        CargarProductos()
    End Sub

    Private Sub BtnConsultarStock_Click(sender As Object, e As EventArgs) Handles BtnConsultarStock.Click
        If TxtProductoID.Text = "" Or TxtNombre.Text = "" Or TxtCantidad.Text = "" Or TxtPrecio.Text = "" Then
            MessageBox.Show("Complete todos los campos antes de actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim query As String = "UPDATE Productos SET Nombre = @Nombre, Cantidad = @Cantidad, Precio = @Precio WHERE ProductoID = @ProductoID"
        Dim conexion As MySqlConnection = conexion.ObtenerConexion()
        Dim comando As New MySqlCommand(query, conexion)

        comando.Parameters.AddWithValue("@ProductoID", CInt(TxtProductoID.Text))
        comando.Parameters.AddWithValue("@Nombre", TxtNombre.Text)
        comando.Parameters.AddWithValue("@Cantidad", CInt(TxtCantidad.Text))
        comando.Parameters.AddWithValue("@Precio", CDbl(TxtPrecio.Text))

        Try
            conexion.Open()
            comando.ExecuteNonQuery()
            MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al actualizar producto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conexion.Close()
        End Try

        CargarProductos()
    End Sub

    Private Sub CargarProductos()
        Dim query As String = "SELECT ProductoID, Nombre, Cantidad, Precio FROM Productos"
        Dim conexion As MySqlConnection = conexion.ObtenerConexion()
        Dim adaptador As New MySqlDataAdapter(query, conexion)
        Dim tabla As New DataTable()

        Try
            conexion.Open()
            adaptador.Fill(tabla)
            DataGridView1.DataSource = tabla
        Catch ex As Exception
            MessageBox.Show("Error al cargar productos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub FrmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarProductos()
    End Sub
End Class