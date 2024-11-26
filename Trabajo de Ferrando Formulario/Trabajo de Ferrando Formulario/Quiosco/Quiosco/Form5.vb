Public Class FrmMain
    Private Sub BtnUsuarios_Click(sender As Object, e As EventArgs) Handles BtnUsuarios.Click
        Dim usuariosForm As New FrmUsuarios()
        usuariosForm.Show()
    End Sub

    Private Sub BtnQuiosco_Click(sender As Object, e As EventArgs) Handles BtnQuiosco.Click
        Dim quioscoForm As New FrmQuiosco()
        quioscoForm.Show()
    End Sub

    Private Sub BtnProductos_Click(sender As Object, e As EventArgs) Handles BtnProductos.Click
        Dim productosForm As New FrmProductos()
        productosForm.Show()
    End Sub

    Private Sub BtnVentas_Click(sender As Object, e As EventArgs) Handles BtnVentas.Click
        Dim ventasForm As New FrmVentas()
        ventasForm.Show()
    End Sub

End Class
