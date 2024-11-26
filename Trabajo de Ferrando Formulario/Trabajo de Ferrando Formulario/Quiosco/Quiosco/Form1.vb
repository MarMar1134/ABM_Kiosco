Public Class FrmUsuarios
    Private Sub BtnIniciarSesion_Click(sender As Object, e As EventArgs) Handles BtnIniciarSesion.Click
        Dim query As String = "SELECT * FROM Usuarios WHERE Usuario = @Usuario AND Contraseña = @Contraseña"
        Dim conexion As MySqlConnection = conexion.ObtenerConexion()
        Dim comando As New MySqlCommand(query, conexion)

        comando.Parameters.AddWithValue("@Usuario", TxtUsuario.Text)
        comando.Parameters.AddWithValue("@Contraseña", TxtContraseña.Text)

        Try
            conexion.Open()
            Dim reader As MySqlDataReader = comando.ExecuteReader()

            If reader.HasRows Then
                MessageBox.Show("Inicio de sesión exitoso.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                reader.Close()
            Else
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error al iniciar sesión: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub BtnCerrarSesion_Click(sender As Object, e As EventArgs) Handles BtnCerrarSesion.Click
        TxtUsuario.Clear()
        TxtContraseña.Clear()
        MessageBox.Show("Sesión cerrada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtnModificarDatos_Click(sender As Object, e As EventArgs) Handles BtnModificarDatos.Click
        Dim query As String = "UPDATE Usuarios SET Contraseña = @NuevaContraseña WHERE Usuario = @Usuario"
        Dim conexion As MySqlConnection = conexion.ObtenerConexion()
        Dim comando As New MySqlCommand(query, conexion)

        Dim nuevaContraseña As String = InputBox("Ingrese la nueva contraseña:", "Modificar Contraseña")
        If String.IsNullOrEmpty(nuevaContraseña) Then
            MessageBox.Show("No se ingresó una nueva contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        comando.Parameters.AddWithValue("@Usuario", TxtUsuario.Text)
        comando.Parameters.AddWithValue("@NuevaContraseña", nuevaContraseña)

        Try
            conexion.Open()
            If comando.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Datos modificados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No se encontró el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al modificar datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub BtnVerVentas_Click(sender As Object, e As EventArgs) Handles BtnVerVentas.Click
        Dim query As String = "SELECT VentaID, ProductoID, Cantidad, Total, Fecha FROM Ventas WHERE Usuario = @Usuario"
        Dim conexion As MySqlConnection = conexion.ObtenerConexion()
        Dim adaptador As New MySqlDataAdapter(query, conexion)
        Dim tabla As New DataTable()

        adaptador.SelectCommand.Parameters.AddWithValue("@Usuario", TxtUsuario.Text)

        Try
            conexion.Open()
            adaptador.Fill(tabla)
            DgvVentas.DataSource = tabla
        Catch ex As Exception
            MessageBox.Show("Error al cargar las ventas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conexion.Close()
        End Try
    End Sub
End Class
