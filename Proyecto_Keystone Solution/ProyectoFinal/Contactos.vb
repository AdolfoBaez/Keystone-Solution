Imports System.Data.SqlClient

Public Class Contactos


    Private Sub Contactos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btnRegistrarC_Click(sender As Object, e As EventArgs) Handles btnRegistrarC.Click
        Dim Conexion As String
        Conexion = "Data Source=ADOLFOPC\SQLEXPRESS;Initial Catalog=ProyectoFinal;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = Conexion

        Dim Adaptador As New SqlCommand("insert into TblContactosGA (Nombre, Calle, [Numero Exterior], [Numero Interior], [Codigo Postal], Colonia, Municipio, Estado, Pais, Telefono, Celular, Correo)
        values('" & txtNombreC.Text & "', '" & txtCalleC.Text & "' 
        , '" & txtNumExC.Text & "', '" & txtNumIntC.Text & "', '" & txtCPC.Text & "', '" & txtColoniaC.Text & "', '" & txtMunicipioC.Text & "'
        , '" & txtEstadoC.Text & "', '" & txtPaisC.Text & "', '" & txtTelefonoC.Text & "', '" & txtCelC.Text & "'
        , '" & txtCorreoC.Text & "' )", cn)
        cn.Open()
        Adaptador.ExecuteNonQuery()
        MsgBox("Se registro correctamente")

        txtNombreC.Text = ""
        txtCalleC.Text = ""
        txtNumExC.Text = ""
        txtNumIntC.Text = ""
        txtCPC.Text = ""
        txtColoniaC.Text = ""
        txtMunicipioC.Text = ""
        txtEstadoC.Text = ""
        txtPaisC.Text = ""
        txtTelefonoC.Text = ""
        txtCelC.Text = ""
        txtCorreoC.Text = ""

    End Sub

    Private Sub btnBuscarCA_Click(sender As Object, e As EventArgs) Handles btnBuscarCA.Click

        Dim Conexion As String
        Conexion = "Data Source=ADOLFOPC\SQLEXPRESS;Initial Catalog=ProyectoFinal;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = Conexion

        Dim adaptador As New SqlDataAdapter("select*from TblContactosGA where Nombre='" & txtNombreCA.Text & "'", cn)
        Dim ds As New DataSet
        adaptador.Fill(ds, "datos")

        If ds.Tables("datos").Rows.Count > 0 Then


            txtCalleCA.Text = ds.Tables("datos").Rows(0).Item(2).ToString
            txtNumExCA.Text = ds.Tables("datos").Rows(0).Item(3).ToString
            txtNumIntCA.Text = ds.Tables("datos").Rows(0).Item(4).ToString
            txtCPCA.Text = ds.Tables("datos").Rows(0).Item(5).ToString
            txtColoniaCA.Text = ds.Tables("datos").Rows(0).Item(6).ToString
            txtMunicipioCA.Text = ds.Tables("datos").Rows(0).Item(7).ToString
            txtEstadoCA.Text = ds.Tables("datos").Rows(0).Item(8).ToString
            txtPaisCA.Text = ds.Tables("datos").Rows(0).Item(9).ToString
            txtTelefonoCA.Text = ds.Tables("datos").Rows(0).Item(10).ToString
            txtCelCA.Text = ds.Tables("datos").Rows(0).Item(11).ToString
            txtCorreoCA.Text = ds.Tables("datos").Rows(0).Item(12).ToString
        Else
            MsgBox("No existe el Usuario")


        End If

    End Sub

    Private Sub btnActualizarC_Click(sender As Object, e As EventArgs) Handles btnActualizarC.Click

        Dim Conexion As String
        Conexion = "Data Source=ADOLFOPC\SQLEXPRESS;Initial Catalog=ProyectoFinal;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = Conexion

        Dim adaptador As New SqlCommand("update TblContactosGA set Nombre= '" & txtNombreCA.Text & "', Calle= '" & txtCalleCA.Text & "',
                                        [Numero Exterior]= '" & txtNumExCA.Text & "', [Numero Interior]= '" & txtNumIntCA.Text & "', [Codigo Postal]= '" & txtCPCA.Text & "',
                                        Colonia= '" & txtColoniaCA.Text & "', Municipio= '" & txtMunicipioCA.Text & "', Estado= '" & txtEstadoCA.Text & "',
                                        Pais= '" & txtPaisCA.Text & "', Telefono= '" & txtTelefonoCA.Text & "', Celular= '" & txtCelCA.Text & "',
                                        Correo= '" & txtCorreoCA.Text & "' where Nombre= '" & txtNombreCA.Text & "' ", cn)
        cn.Open()
        adaptador.ExecuteNonQuery()
        MsgBox("Los datos fueron actualizados")

    End Sub

    Private Sub txtIdC_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles txtCalleCE.TextChanged

    End Sub

    Private Sub btnBuscarCE_Click(sender As Object, e As EventArgs) Handles btnBuscarCE.Click

        Dim Conexion As String
        Conexion = "Data Source=ADOLFOPC\SQLEXPRESS;Initial Catalog=ProyectoFinal;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = Conexion

        Dim adaptador As New SqlDataAdapter("select*from TblContactosGA where Nombre='" & txtNombreCE.Text & "'", cn)
        Dim ds As New DataSet
        adaptador.Fill(ds, "datos")

        If ds.Tables("datos").Rows.Count > 0 Then


            txtCalleCE.Text = ds.Tables("datos").Rows(0).Item(2).ToString
            txtNumExCE.Text = ds.Tables("datos").Rows(0).Item(3).ToString
            txtNumIntCE.Text = ds.Tables("datos").Rows(0).Item(4).ToString
            txtCPCE.Text = ds.Tables("datos").Rows(0).Item(5).ToString
            txtColoniaCE.Text = ds.Tables("datos").Rows(0).Item(6).ToString
            txtMunicipioCE.Text = ds.Tables("datos").Rows(0).Item(7).ToString
            txtEstadoCE.Text = ds.Tables("datos").Rows(0).Item(8).ToString
            txtPaisCE.Text = ds.Tables("datos").Rows(0).Item(9).ToString
            txtTelefonoCE.Text = ds.Tables("datos").Rows(0).Item(10).ToString
            txtCelCE.Text = ds.Tables("datos").Rows(0).Item(11).ToString
            txtCorreoCE.Text = ds.Tables("datos").Rows(0).Item(12).ToString
        Else
            MsgBox("No existe el Usuario")


        End If

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles txtCPCE.TextChanged

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles txtColoniaCE.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtPaisCE.TextChanged

    End Sub

    Private Sub btnEliminarC_Click(sender As Object, e As EventArgs) Handles btnEliminarC.Click

        Dim Conexion As String
        Conexion = "Data Source=ADOLFOPC\SQLEXPRESS;Initial Catalog=ProyectoFinal;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = Conexion
        cn.Open()

        Dim comando As New SqlCommand("delete TblContactosGA where Nombre='" & txtNombreCA.Text & "'", cn)
        comando.ExecuteNonQuery()
        MsgBox("Se elimino correctamente")



        txtNombreCE.Text = ""
        txtCalleCE.Text = ""
        txtNumExCE.Text = ""
        txtNumIntCE.Text = ""
        txtCPCE.Text = ""
        txtColoniaCE.Text = ""
        txtMunicipioCE.Text = ""
        txtEstadoCE.Text = ""
        txtPaisCE.Text = ""
        txtTelefonoCE.Text = ""
        txtCelCE.Text = ""
        txtCorreoCE.Text = ""
        cn.Close()

    End Sub


    Private Sub btnCerrarForm_Click(sender As Object, e As EventArgs) Handles btnCerrarForm.Click
        Me.Close()
    End Sub

    Private Sub btnListaContactos_Click(sender As Object, e As EventArgs) Handles btnListaContactos.Click

        Dim FormularioLC As Form
        FormularioLC = New ListaContactos()
        FormularioLC.Show()

    End Sub


End Class