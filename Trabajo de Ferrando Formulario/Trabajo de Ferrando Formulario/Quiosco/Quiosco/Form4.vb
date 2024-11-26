Public Class FrmVentas
    Private Sub CargarProductos()
        Dim query As String = "SELECT ProductoID, Nombre FROM Productos"
        Dim conexion As MySqlConnection = conexion.ObtenerConexion()
        Dim adaptador As New MySqlDataAdapter(query, conexion)
        Dim tabla As New DataTable()

        Try
            conexion.Open()
            adaptador.Fill(tabla)
            CmbProductos.DataSource = tabla
            CmbProductos.DisplayMember = "Nombre"
            CmbProductos.ValueMember = "ProductoID"
        Catch ex As Exception
            MessageBox.Show("Error al cargar productos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub FrmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarProductos()
        CargarVentas()
    End Sub

    Private Sub CmbProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbProductos.SelectedIndexChanged
        If CmbProductos.SelectedValue IsNot Nothing AndAlso IsNumeric(CmbProductos.SelectedValue) Then
            Dim productoID As Integer = CInt(CmbProductos.SelectedValue)
            Dim query As String = "SELECT Precio FROM Productos WHERE ProductoID = @ProductoID"
            Dim conexion As MySqlConnection = conexion.ObtenerConexion()
            Dim comando As New MySqlCommand(query, conexion)

            comando.Parameters.AddWithValue("@ProductoID", productoID)

            Try
                conexion.Open()
                Dim precio As Object = comando.ExecuteScalar()

                If precio IsNot Nothing Then
                    TxtPrecioUnitario.Text = precio.ToString()
                End If
            Catch ex As Exception
                MessageBox.Show("Error al cargar precio: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conexion.Close()
            End Try
        End If
    End Sub

    Private Sub BtnCalcularTotal_Click(sender As Object, e As EventArgs) Handles BtnCalcularTotal.Click
        If TxtCantidad.Text = "" Or Not IsNumeric(TxtCantidad.Text) Then
            MessageBox.Show("Ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim cantidad As Integer = CInt(TxtCantidad.Text)
        Dim precioUnitario As Double = CDbl(TxtPrecioUnitario.Text)
        Dim total As Double = cantidad * precioUnitario

        TxtTotal.Text = total.ToString("F2")
    End Sub

    Private Sub BtnAgregarVenta_Click(sender As Object, e As EventArgs) Handles BtnAgregarVenta.Click
        If TxtCantidad.Text = "" Or TxtTotal.Text = "" Then
            MessageBox.Show("Por favor, calcule el total antes de registrar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim productoID As Integer = CInt(CmbProductos.SelectedValue)
        Dim cantidad As Integer = CInt(TxtCantidad.Text)
        Dim total As Double = CDbl(TxtTotal.Text)
        Dim query As String = "INSERT INTO Ventas (ProductoID, Cantidad, Total, Fecha) VALUES (@ProductoID, @Cantidad, @Total, NOW())"
        Dim conexion As MySqlConnection = conexion.ObtenerConexion()
        Dim comando As New MySqlCommand(query, conexion)

        comando.Parameters.AddWithValue("@ProductoID", productoID)
        comando.Parameters.AddWithValue("@Cantidad", cantidad)
        comando.Parameters.AddWithValue("@Total", total)

        Try
            conexion.Open()
            comando.ExecuteNonQuery()
            MessageBox.Show("Venta registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al registrar venta: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conexion.Close()
        End Try

        CargarVentas()
    End Sub
    Private Sub CargarVentas()
        Dim query As String = "SELECT VentaID, ProductoID, Cantidad, Total, Fecha FROM Ventas"
        Dim conexion As MySqlConnection = conexion.ObtenerConexion()
        Dim adaptador As New MySqlDataAdapter(query, conexion)
        Dim tabla As New DataTable()

        Try
            conexion.Open()
            adaptador.Fill(tabla)
            DgvVentas.DataSource = tabla
        Catch ex As Exception
            MessageBox.Show("Error al cargar ventas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conexion.Close()
        End Try
    End Sub

End Class