
Partial Class DemoSeite1
    Inherits System.Web.UI.Page

    Protected Sub DemoStartenButton_Click(sender As Object, e As EventArgs) Handles DemoStartenButton.Click
        If (Me.WhatIsYourNameTextBox.Text = Nothing) Then ' Fehler 1: Keine Daten eingegeben.
            Return
        End If
        Me.GivenNamenLabel.Text = (Me.WhatIsYourNameTextBox.Text)
        Me.WhatIsYourNameTextBox.Text = Nothing
    End Sub
    Protected Sub Resultat_Click(sender As Object, e As EventArgs) Handles Resultat.Click
        Try 'TDO: Fehlerbehandlung richtig durch Prävenzion.
            Dim a As Integer
            Dim b As Integer
            a = CInt(Me.Wert1.Text)
            b = CInt(Me.Wert2.Text)
            Dim c As Integer
            c = a + b
            Me.Resultat.Text = CStr(c)
        Catch ex As Exception
            Me.Resultat.Text = "Fehler"
        End Try
    End Sub
End Class
