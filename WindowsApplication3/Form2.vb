Public Class Form2

    

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim pressure As Double
        Dim temperature As Double
        Dim volume As Double

        pressure = Form1.TextBox2.Text
        temperature = Form1.TextBox1.Text
        If Form1.RadioButton1.Checked Then
            volume = Form1.TextBox3.Text
        ElseIf Form1.RadioButton2.Checked Then
            volume = Form1.TextBox5.Text
        Else
            volume = Form1.TextBox7.Text
        End If
    
            Label2.Text = ("Z = ") & (pressure * volume) / (temperature * 83.14)
            Button1.Hide()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()

    End Sub

End Class