Imports System.Text.RegularExpressions
Imports Newtonsoft.Json

Public Class Form1
    Dim PATH As String = "C:/Users/Anne/Desktop/Details"

    Class formInput
        Public name As String
        Public age As Int32
        Public address As String
    End Class

    Private Sub TextAge_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles inputAge.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextAge_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles inputAge.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        inputAge.Text = digitsOnly.Replace(inputAge.Text, "")
    End Sub

    Private Sub SaveTxt_Click(sender As Object, e As EventArgs) Handles txt.Click
        My.Computer.FileSystem.WriteAllText(PATH & ".txt", "", True)
        Dim objWriter As New System.IO.StreamWriter(PATH & ".txt")

        objWriter.WriteLine("Name:" & ControlChars.Tab & ControlChars.Tab & inputName.Text)
        objWriter.WriteLine("Age:" & ControlChars.Tab & ControlChars.Tab & inputAge.Text)
        objWriter.WriteLine("Address:" & ControlChars.Tab & inputAddress.Text)

        objWriter.Close()
    End Sub

    Private Sub SaveXml_Click(sender As Object, e As EventArgs) Handles xml.Click
        Dim xmlDeclaration As New XDeclaration("1.0", "UTF-8", "yes")
        Dim doc As XDocument =
            New XDocument(xmlDeclaration,
                          New XElement("Form",
                                       New XElement("name", "" & inputName.Text),
                                       New XElement("age", "" & inputAge.Text),
                                       New XElement("address", "" & inputAddress.Text)
                                      )
                          )

        doc.Save(PATH & ".xml")
    End Sub

    Private Sub SaveJson_Click(sender As Object, e As EventArgs) Handles json.Click
        Dim inp As formInput = New formInput()
        inp.name = inputName.Text
        inp.age = Convert.ToInt32(inputAge.Text)
        inp.address = inputAddress.Text

        My.Computer.FileSystem.WriteAllText(PATH & "JSON.txt", JsonConvert.SerializeObject(inp, Newtonsoft.Json.Formatting.Indented), False)
    End Sub
End Class
