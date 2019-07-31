Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Public Class ListaContactos
    Private Sub ListaContactos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListaDeContactos.DataSource = GetListaContactos()
    End Sub

    Private Function GetListaContactos() As DataTable
        Dim DatosContactos As New DataTable


        Dim ConexionString As String = ConfigurationManager.ConnectionStrings("ProyectoFinal").ConnectionString

        Using Conexion As New SqlConnection(ConexionString)
            Using cmd As New SqlCommand("SELECT * FROM dbo.TblContactosGA", Conexion)
                Conexion.Open()

                Dim reader As SqlDataReader = cmd.ExecuteReader()
                DatosContactos.Load(reader)
            End Using
        End Using

        Return DatosContactos
    End Function

    Private Sub ListaDeContactos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListaDeContactos.CellContentClick

    End Sub

    Private Sub LabelLista_Click(sender As Object, e As EventArgs) Handles LabelLista.Click

    End Sub
End Class