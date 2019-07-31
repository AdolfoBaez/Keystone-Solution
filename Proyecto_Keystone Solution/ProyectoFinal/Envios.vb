Imports System.Data.SqlClient

Public Class Envios


    Private Sub btnCerrarForm_Click(sender As Object, e As EventArgs) Handles btnCerrarForm.Click
        Me.Close()
    End Sub

    Private Sub btnRegistrarG_Click(sender As Object, e As EventArgs) Handles btnRegistrarG.Click

        Dim Conexion As String
        Conexion = "Data Source=ADOLFOPC\SQLEXPRESS;Initial Catalog=ProyectoFinal;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = Conexion


        Dim Adaptador As New SqlCommand("insert into TblGuias (NombreGuia, CEnvia, CRecibe, CdOrigen, CdDestino, Contenido, Prioridad)
        values('" & txtNombreG.Text & "', '" & txtDeG.Text & "', '" & txtParaG.Text & "', '" & txtCiudadOG.Text & "'
        , '" & txtCiudadDG.Text & "', '" & txtContenidoG.Text & "', '" & ComboBoxPrioridad.Text & "' )", cn)
        cn.Open()
        Adaptador.ExecuteNonQuery()
        MsgBox("Se registro correctamente")

        txtNombreG.Text = ""
        txtDeG.Text = ""
        txtParaG.Text = ""
        txtCiudadOG.Text = ""
        txtCiudadDG.Text = ""
        txtContenidoG.Text = ""
        ComboBoxPrioridad.Text = ""

    End Sub

    Private Sub btnBuscarG_Click(sender As Object, e As EventArgs) Handles btnBuscarG.Click

        Dim Conexion As String
        Conexion = "Data Source=ADOLFOPC\SQLEXPRESS;Initial Catalog=ProyectoFinal;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = Conexion

        Dim adaptador As New SqlDataAdapter("select*from TblGuias where NombreGuia='" & txtNombreGA.Text & "'", cn)
        Dim ds As New DataSet
        adaptador.Fill(ds, "datos")

        If ds.Tables("datos").Rows.Count > 0 Then


            txtDeGA.Text = ds.Tables("datos").Rows(0).Item(2).ToString
            txtParaGA.Text = ds.Tables("datos").Rows(0).Item(3).ToString
            txtCiudadOGA.Text = ds.Tables("datos").Rows(0).Item(4).ToString
            txtCiudadDGA.Text = ds.Tables("datos").Rows(0).Item(5).ToString
            txtContenidoGA.Text = ds.Tables("datos").Rows(0).Item(6).ToString
            ComboBoxPrioridadA.Text = ds.Tables("datos").Rows(0).Item(7).ToString

        Else
            MsgBox("No existe el Usuario")


        End If

    End Sub

    Private Sub btnActualizarG_Click(sender As Object, e As EventArgs) Handles btnActualizarG.Click

        Dim Conexion As String
        Conexion = "Data Source=ADOLFOPC\SQLEXPRESS;Initial Catalog=ProyectoFinal;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = Conexion

        Dim adaptador As New SqlCommand("update TblGuias set NombreGuia= '" & txtNombreGA.Text & "', CEnvia= '" & txtDeGA.Text & "',
                                        CRecibe= '" & txtParaGA.Text & "', CdOrigen= '" & txtCiudadOGA.Text & "', CdDestino= '" & txtCiudadDGA.Text & "',
                                        Contenido= '" & txtContenidoGA.Text & "', Prioridad= '" & ComboBoxPrioridadA.Text & "' where NombreGuia= '" & txtNombreGA.Text & "' ", cn)
        cn.Open()
        adaptador.ExecuteNonQuery()
        MsgBox("Los datos fueron actualizados")

    End Sub

    Private Sub btnBuscarGE_Click(sender As Object, e As EventArgs) Handles btnBuscarGE.Click

        Dim Conexion As String
        Conexion = "Data Source=ADOLFOPC\SQLEXPRESS;Initial Catalog=ProyectoFinal;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = Conexion

        Dim adaptador As New SqlDataAdapter("select*from TblGuias where NombreGuia='" & txtNombreGE.Text & "'", cn)
        Dim ds As New DataSet
        adaptador.Fill(ds, "datos")

        If ds.Tables("datos").Rows.Count > 0 Then


            txtDeGE.Text = ds.Tables("datos").Rows(0).Item(2).ToString
            txtParaGE.Text = ds.Tables("datos").Rows(0).Item(3).ToString
            txtCiudadOGE.Text = ds.Tables("datos").Rows(0).Item(4).ToString
            txtCiudadDGE.Text = ds.Tables("datos").Rows(0).Item(5).ToString
            txtContenidoGE.Text = ds.Tables("datos").Rows(0).Item(6).ToString
            ComboBoxPrioridadE.Text = ds.Tables("datos").Rows(0).Item(7).ToString

        Else
            MsgBox("No existe el Usuario")


        End If

    End Sub

    Private Sub btnEliminarG_Click(sender As Object, e As EventArgs) Handles btnEliminarG.Click

        Dim Conexion As String
        Conexion = "Data Source=ADOLFOPC\SQLEXPRESS;Initial Catalog=ProyectoFinal;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = Conexion
        cn.Open()

        Dim comando As New SqlCommand("delete TblGuias where NombreGuia='" & txtNombreGE.Text & "'", cn)
        comando.ExecuteNonQuery()
        MsgBox("Se elimino correctamente")


        txtNombreGE.Text = ""
        txtDeGE.Text = ""
        txtParaGE.Text = ""
        txtCiudadOGE.Text = ""
        txtCiudadDGE.Text = ""
        txtContenidoGE.Text = ""
        ComboBoxPrioridadE.Text = ""
        cn.Close()

    End Sub

    Private Sub btnListaGuias_Click(sender As Object, e As EventArgs) Handles btnListaGuias.Click


        Dim FormularioLC As Form
        FormularioLC = New ListaGuias()
        FormularioLC.Show()


    End Sub
End Class