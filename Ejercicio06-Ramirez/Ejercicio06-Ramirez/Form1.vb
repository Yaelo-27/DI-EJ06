Public Class Peliculas
    Private Sub btmSalir_Click(sender As Object, e As EventArgs) Handles btmSalir.Click
        Me.Close()
    End Sub

    Private Sub btmAgegar_Click(sender As Object, e As EventArgs) Handles btmAgegar.Click
        If txtAgTitulos.Text = "" Then
            epAgTitulos.SetError(Me.txtAgTitulos, "No se ha introducido ningún titulo")
        Else
            lbTitulos.Items.Add(txtAgTitulos.Text)
            txtAgTitulos.Clear()
            txtAgTitulos.Focus()
        End If
    End Sub

    Private Sub lbTitulos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbTitulos.SelectedIndexChanged
        Dim titulo As String
        titulo = lbTitulos.SelectedItem
        Select Case titulo
            Case "El señor de los anillos"
                pbCaratula.Image = My.Resources.lrgs
            Case "El hobbit"
                pbCaratula.Image = My.Resources.hobbit
            Case "El niño y la bestia"
                pbCaratula.Image = My.Resources.kidbeast
            Case "Halloween kills"
                pbCaratula.Image = My.Resources.halloweenkills
            Case "Baby Driver"
                pbCaratula.Image = My.Resources.babydriver
            Case "Nada"
                pbCaratula.Image = My.Resources._default
            Case Else
                pbCaratula.Image = My.Resources._default

        End Select

    End Sub

    Private Sub btmExportar_Click(sender As Object, e As EventArgs) Handles btmExportar.Click
        Dim save As New SaveFileDialog
        Dim limpiar As MsgBoxResult
        save.Filter = "Archivo Texto |*.txt"
        If save.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim escritura As New System.IO.StreamWriter(save.FileName)

            For Each item In lbTitulos.Items
                escritura.WriteLine(item.ToString())
            Next
            escritura.Close()
        End If

        limpiar = MessageBox.Show("¿Limpiar la bandeja de titulos?", "Notificación", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If limpiar = vbYes Then
            lbTitulos.Items.Clear()
        End If

    End Sub

    Private Sub btmImportar_Click(sender As Object, e As EventArgs) Handles btmImportar.Click
        Dim ruta As String = ""
        Dim OFD As New OpenFileDialog
        With OFD
            .Title = "Seleccionar Archivos"
            .Filter = "Archivos txt(*.Txt,*.txt) |*.Txt;*.txt|Todos los archivos(*.*)|*.*"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                ruta = .FileName
            End If
        End With
        Dim fr As New System.IO.StreamReader(ruta)
        While Not fr.EndOfStream
            lbTitulos.Items.Add(fr.ReadLine())
        End While
        fr.Close()
    End Sub
End Class
