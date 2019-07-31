Public Class GuiaNew
    Private Sub GuiaNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ContactostfDataSet2.contactosf' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'ContactostfDataSet.contactosf' Puede moverla o quitarla según sea necesario.

        CBoxPrioridad.Items.Add("Muy Alta")
        CBoxPrioridad.Items.Add("Alta")
        CBoxPrioridad.Items.Add("Normal")
        CBoxPrioridad.Items.Add("Baja")



    End Sub

    Private Sub ContactosfBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        'Aqui van las condiciones de que si no hay nada escrito en los Cuadros de Texto no prosiga a guardar el contacto'
        'If (NombreTextBox.Text = "") And (CalleTextBox.Text = "") And
        '   (Número_ExteriorTextBox.Text = "") And (Número_InteriorTextBox.Text = "") And
        '  (Código_PostalTextBox.Text = "") And (ColoniaTextBox.Text = "") And (MunicipioTextBox.Text = "") And
        ' (EstadoTextBox.Text = "") And (PaísTextBox.Text = "") And (TeléfonoTextBox.Text = "") And
        '(CelularTextBox.Text = "") And (Correo_ElectrónicoTextBox.Text = "") Then

        'MsgBox("Error, validar los datos") '

        'Else
        'Me.Validate()
        'Me.ContactosfBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.ContactostfDataSet1)
        'End If



    End Sub

    Private Sub btnSGuia_Click(sender As Object, e As EventArgs) Handles btnSGuia.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBoxPrioridad.SelectedIndexChanged

    End Sub

    Private Sub IdTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class