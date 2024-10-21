Public Class Form2

    
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
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

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Label2.Text = TimeOfDay & "  ||  " & Date.Today
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Me.Chart3.Series("Series1").Points.AddXY("Area 1", 15)
        Me.Chart3.Series("Series1").Points.AddXY("Area 2", 12.5)
        Me.Chart3.Series("Series1").Points.AddXY("Area 3", 20)
        Me.Chart3.Series("Series1").Points.AddXY("Area 4", 17.5)
        Me.Chart3.Series("Series1").Points.AddXY("Area 5", 10)
        Me.Chart3.Series("Series1").Points.AddXY("Area 6", 5)
        Me.Chart3.Series("Series1").Points.AddXY("Area 7", 11.25)
        Me.Chart3.Series("Series1").Points.AddXY("Area 8", 8.75)


        




     

    End Sub
End Class