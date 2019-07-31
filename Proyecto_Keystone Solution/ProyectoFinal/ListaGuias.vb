Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient

Public Class ListaGuias

    Private Sub ListaGuias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListaDeGuias.DataSource = GetListaGuias()
    End Sub

    Private Function GetListaGuias() As DataTable
        Dim DatosGuias As New DataTable


        Dim ConexionString As String = ConfigurationManager.ConnectionStrings("ProyectoFinal").ConnectionString

        Using Conexion As New SqlConnection(ConexionString)
            Using cmd As New SqlCommand("SELECT * FROM dbo.TblGuias", Conexion)
                Conexion.Open()

                Dim reader As SqlDataReader = cmd.ExecuteReader()
                DatosGuias.Load(reader)
            End Using
        End Using

        Return DatosGuias
    End Function

End Class