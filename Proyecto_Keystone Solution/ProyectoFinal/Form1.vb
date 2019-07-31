Imports System.Runtime.InteropServices

Public Class Form1
#Region "Funcionalidades del Formulario"
    'RESIZE DEL FORMULARIO- CAMBIAR TAMAÑO
    Dim cGrip As Integer = 10

    Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = 132) Then
            Dim pos As Point = New Point((m.LParam.ToInt32 And 65535), (m.LParam.ToInt32 + 16))
            pos = Me.PointToClient(pos)
            If ((pos.X _
                        >= (Me.ClientSize.Width - cGrip)) _
                        AndAlso (pos.Y _
                        >= (Me.ClientSize.Height - cGrip))) Then
                m.Result = CType(17, IntPtr)
                Return
            End If
        End If
        MyBase.WndProc(m)
    End Sub
    '----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
    Dim sizeGripRectangle As Rectangle
    Dim tolerance As Integer = 15

    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        MyBase.OnSizeChanged(e)
        Dim region = New Region(New Rectangle(0, 0, Me.ClientRectangle.Width, Me.ClientRectangle.Height))
        sizeGripRectangle = New Rectangle((Me.ClientRectangle.Width - tolerance), (Me.ClientRectangle.Height - tolerance), tolerance, tolerance)
        region.Exclude(sizeGripRectangle)
        Me.PanelContenedor.Region = region
        Me.Invalidate()
    End Sub

    '----------------COLOR Y GRIP DE RECTANGULO INFERIOR
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim blueBrush As SolidBrush = New SolidBrush(Color.FromArgb(244, 244, 244))
        e.Graphics.FillRectangle(blueBrush, sizeGripRectangle)
        MyBase.OnPaint(e)
        ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle)
    End Sub

    'ARRASTRAR FORMULARIO
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PanelCabecera_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelCabecera.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub


    Private Sub PanelCabecera_Paint(sender As Object, e As PaintEventArgs) Handles PanelCabecera.Paint

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        'Application.Exit()

        If (MessageBox.Show("Desea Salir de la Aplicación?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes) Then
            'End
            Application.Exit()
        End If

    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        btnMaximizar.Visible = False
        btnRestaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        Me.WindowState = FormWindowState.Normal
        btnRestaurar.Visible = False
        btnMaximizar.Visible = True
    End Sub
#End Region

    'METODO PARA ABRIR FORMULARIO DENTRO DEL PANEL 
    Private Sub AbrirFormEnPanelP(Of MyForm As {Form, New})()
        Dim formulario As Form
        'Busca el formulario en la Coleccion
        formulario = PanelFormularios.Controls.OfType(Of MyForm)().FirstOrDefault

        If formulario Is Nothing Then
            formulario = New MyForm()
            formulario.TopLevel = False

            formulario.FormBorderStyle = FormBorderStyle.None
            formulario.Dock = DockStyle.Fill

            PanelFormularios.Controls.Add(formulario)
            PanelFormularios.Tag = formulario
            formulario.Show()
            formulario.BringToFront()

        Else
            formulario.BringToFront()

        End If

    End Sub


    Private Sub btnContactos_Click(sender As Object, e As EventArgs) Handles btnContactos.Click
        AbrirFormEnPanelP(Of Contactos)()
    End Sub

    Private Sub btnCalendario_Click(sender As Object, e As EventArgs) Handles btnCalendario.Click
        AbrirFormEnPanelP(Of Calendario)()
    End Sub

    Private Sub btnEnvios_Click(sender As Object, e As EventArgs) Handles btnEnvios.Click
        AbrirFormEnPanelP(Of Envios)()
    End Sub

    Private Sub btnHorario_Click(sender As Object, e As EventArgs) Handles btnHorario.Click
        AbrirFormEnPanelP(Of Horario)()
    End Sub

    Private Sub btnAcerca_Click(sender As Object, e As EventArgs) Handles btnAcerca.Click
        AbrirFormEnPanelP(Of AcercaDe)()
    End Sub

End Class
