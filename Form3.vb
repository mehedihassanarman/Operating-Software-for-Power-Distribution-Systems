Public Class Form3

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label5.Text = TimeOfDay & "  ||  " & Date.Today

       
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Label4.Text = ""
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        Label4.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            Label4.Show()
            Label4.Text = "Enter User-ID"
        ElseIf TextBox2.Text = "" Then
            Label4.Show()
            Label4.Text = "Enter Password"
        ElseIf TextBox1.Text = My.Settings.Username And TextBox2.Text = My.Settings.Password Then
            Me.Hide()
            Operation_Panel.Show()
        Else
            Label4.Show()
            Label4.Text = "Invalid User-Id or Password"

        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Label1.ForeColor = Color.White Then
            Label1.ForeColor = Color.Green
        ElseIf Label1.ForeColor = Color.Green Then
            Label1.ForeColor = Color.Blue
        ElseIf Label1.ForeColor = Color.Blue Then
            Label1.ForeColor = Color.Yellow
        ElseIf Label1.ForeColor = Color.Yellow Then
            Label1.ForeColor = Color.Cyan
        ElseIf Label1.ForeColor = Color.Cyan Then
            Label1.ForeColor = Color.White
        End If
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label4.Hide()

    End Sub
End Class