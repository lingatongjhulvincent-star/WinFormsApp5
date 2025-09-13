Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim course As String = ""
        If ComboBox1.SelectedIndex <> -1 Then
            course = ComboBox1.SelectedItem.ToString()
        Else
        End If
        Dim hobbies As String = ""
        If CheckBox1.Checked Then
            hobbies &= "Me"
        End If
        If CheckBox2.Checked Then
            hobbies &= "MySelf"
        End If
        If CheckBox3.Checked Then
            hobbies &= "I"
        End If
        If hobbies = "" Then
            hobbies = "No hobbies selected"
        End If
        Dim gender As String = ""
        If RadioButton1.Checked Then
            gender = "Male"
        ElseIf RadioButton2.Checked Then
            gender = "Female"
        Else
            gender = "No gender selected"
        End If
        Label1.Text = "Course: " & course & hobbies & gender
    End Sub
End Class
