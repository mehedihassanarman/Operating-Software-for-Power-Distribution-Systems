Public Class Operation_Panel


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Timer444.Enabled = True
        Timer1010.Enabled = True
        Timer911.Enabled = False




        Label6.Hide()
        Label7.Hide()
        Label8.Hide()
        Label9.Hide()
        Label10.Hide()
        Label11.Hide()
        Label12.Hide()
        Label13.Hide()
        Label14.Hide()
        Label15.Hide()
        Label16.Hide()
        Label17.Hide()
        Label18.Hide()
        Label19.Hide()
        Label20.Hide()
        Label21.Hide()
        Label22.Hide()
        Label23.Hide()
        Label24.Hide()
        Label25.Hide()
        Label26.Hide()
        Label27.Hide()
        Label28.Hide()
        Label29.Hide()
        Label30.Hide()
        Label31.Hide()
        Label32.Hide()
        Label33.Hide()
        Label34.Hide()
        Label35.Hide()
        Label36.Hide()
        Label37.Hide()
        Label38.Hide()
        Label39.Hide()
        Label5551.Hide()
        Label5552.Hide()

        GroupBox1.Hide()



        Label3.Text = ""
        Label4.Text = ""

      
        Button101.Hide()
        Button102.Hide()
        Button103.Hide()
        Button500.Hide()



        Button11.Enabled = False
        Button12.Enabled = False
        Button13.Enabled = False
        Button14.Enabled = False
        Button15.Enabled = False
        Button16.Enabled = False
        Button17.Enabled = False
        Button18.Enabled = False


    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        If Not Button101.Visible Then

        
            GroupBox1.Show()
            Label6.Show()
            Label9.Show()
            Label15.Show()
            Label16.Show()
            Label19.Show()
            Label23.Show()
            Label24.Show()
            Label27.Show()
            Label31.Show()
            Label32.Show()
            Label33.Show()

            Label4.Text = Label4.Text & vbNewLine & "Power Plant 1 is Connected." & vbNewLine & "Load Area 1,2,5 are Connected." & vbNewLine & "Generation : 1500 MW. Load Demand : 1500 MW." & vbNewLine
            Label23.Text = vbNewLine & "Connected Successfully"
            Label24.Text = vbNewLine & "Connected Successfully"
            Label27.Text = vbNewLine & "Connected Successfully"


            Button101.Show()
            Button101.Text = "0000"

            Button11.Enabled = True
            Button12.Enabled = True
            Button15.Enabled = True

        End If


        If Button101.Visible And Button102.Visible And Button103.Visible Then
            Timer888.Enabled = True
        End If


    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        If Not Button102.Visible Then

         

            GroupBox1.Show()
            Label7.Show()
            Label10.Show()
            Label17.Show()
            Label18.Show()
            Label25.Show()
            Label26.Show()
            Label34.Show()
            Label35.Show()
            Label36.Show()

            Label4.Text = Label4.Text & vbNewLine & "Power Plant 2 is Connected." & vbNewLine & "Load Area 3,4 are Connected." & vbNewLine & "Generation : 1500 MW. Load Demand : 1500 MW." & vbNewLine
            Label25.Text = vbNewLine & "Connected Successfully"
            Label26.Text = vbNewLine & "Connected Successfully"



            Button102.Show()
            Button102.Text = "0000"

            Button13.Enabled = True
            Button14.Enabled = True

        End If

        If Button101.Visible And Button102.Visible And Button103.Visible Then
            Timer888.Enabled = True
        End If


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click


        If Not Button103.Visible Then

        

            GroupBox1.Show()
            Label8.Show()
            Label11.Show()
            Label20.Show()
            Label21.Show()
            Label22.Show()
            Label28.Show()
            Label29.Show()
            Label30.Show()
            Label37.Show()
            Label38.Show()
            Label39.Show()

            Label4.Text = Label4.Text & vbNewLine & "Power Plant 3 is Connected." & vbNewLine & "Load Area 6,7,8 are Connected." & vbNewLine & "Generation : 1000 MW. Load Demand : 1000 MW." & vbNewLine
            Label28.Text = vbNewLine & "Connected Successfully"
            Label29.Text = vbNewLine & "Connected Successfully"
            Label30.Text = vbNewLine & "Connected Successfully"



            Button103.Show()
            Button103.Text = "0000"

            Button16.Enabled = True
            Button17.Enabled = True
            Button18.Enabled = True

        End If


        If Button101.Visible And Button102.Visible And Button103.Visible Then
            Timer888.Enabled = True
        End If

        
    End Sub

    Private Sub Timer40_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer40.Tick


        If Label23.ForeColor = Color.Cyan Then
            Label23.ForeColor = Color.White
        ElseIf Label23.ForeColor = Color.White Then
            Label23.ForeColor = Color.Cyan
        End If

        If Label24.ForeColor = Color.Cyan Then
            Label24.ForeColor = Color.White
        ElseIf Label24.ForeColor = Color.White Then
            Label24.ForeColor = Color.Cyan
        End If

        If Label25.ForeColor = Color.Cyan Then
            Label25.ForeColor = Color.White
        ElseIf Label25.ForeColor = Color.White Then
            Label25.ForeColor = Color.Cyan
        End If

        If Label26.ForeColor = Color.Cyan Then
            Label26.ForeColor = Color.White
        ElseIf Label26.ForeColor = Color.White Then
            Label26.ForeColor = Color.Cyan
        End If

        If Label27.ForeColor = Color.Cyan Then
            Label27.ForeColor = Color.White
        ElseIf Label27.ForeColor = Color.White Then
            Label27.ForeColor = Color.Cyan
        End If

        If Label28.ForeColor = Color.Cyan Then
            Label28.ForeColor = Color.White
        ElseIf Label28.ForeColor = Color.White Then
            Label28.ForeColor = Color.Cyan
        End If

        If Label29.ForeColor = Color.Cyan Then
            Label29.ForeColor = Color.White
        ElseIf Label29.ForeColor = Color.White Then
            Label29.ForeColor = Color.Cyan
        End If

        If Label30.ForeColor = Color.Cyan Then
            Label30.ForeColor = Color.White
        ElseIf Label30.ForeColor = Color.White Then
            Label30.ForeColor = Color.Cyan
        End If


    End Sub

    Private Sub Timer41_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer41.Tick
        If Label3.ForeColor = Color.Red Then
            Label3.ForeColor = Color.White
        ElseIf Label3.ForeColor = Color.White Then
            Label3.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Timer42_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer42.Tick


        If Label3.ForeColor = Color.Red Then
            Label3.ForeColor = Color.White
        ElseIf Label3.ForeColor = Color.White Then
            Label3.ForeColor = Color.Red
        End If

        If Label6.ForeColor = Color.Blue Then
            Label6.ForeColor = Color.White
        ElseIf Label6.ForeColor = Color.White Then
            Label6.ForeColor = Color.Blue
        End If

        If Label7.ForeColor = Color.Blue Then
            Label7.ForeColor = Color.White
        ElseIf Label7.ForeColor = Color.White Then
            Label7.ForeColor = Color.Blue
        End If

        If Label8.ForeColor = Color.Blue Then
            Label8.ForeColor = Color.White
        ElseIf Label8.ForeColor = Color.White Then
            Label8.ForeColor = Color.Blue
        End If


        If Label15.ForeColor = Color.Blue Then
            Label15.ForeColor = Color.White
        ElseIf Label15.ForeColor = Color.White Then
            Label15.ForeColor = Color.Blue
        End If

        If Label16.ForeColor = Color.Blue Then
            Label16.ForeColor = Color.White
        ElseIf Label16.ForeColor = Color.White Then
            Label16.ForeColor = Color.Blue
        End If

        If Label17.ForeColor = Color.Blue Then
            Label17.ForeColor = Color.White
        ElseIf Label17.ForeColor = Color.White Then
            Label17.ForeColor = Color.Blue
        End If

        If Label18.ForeColor = Color.Blue Then
            Label18.ForeColor = Color.White
        ElseIf Label18.ForeColor = Color.White Then
            Label18.ForeColor = Color.Blue
        End If

        If Label19.ForeColor = Color.Blue Then
            Label19.ForeColor = Color.White
        ElseIf Label19.ForeColor = Color.White Then
            Label19.ForeColor = Color.Blue
        End If

        If Label20.ForeColor = Color.Blue Then
            Label20.ForeColor = Color.White
        ElseIf Label20.ForeColor = Color.White Then
            Label20.ForeColor = Color.Blue
        End If

        If Label21.ForeColor = Color.Blue Then
            Label21.ForeColor = Color.White
        ElseIf Label21.ForeColor = Color.White Then
            Label21.ForeColor = Color.Blue
        End If

        If Label22.ForeColor = Color.Blue Then
            Label22.ForeColor = Color.White
        ElseIf Label22.ForeColor = Color.White Then
            Label22.ForeColor = Color.Blue
        End If


    End Sub

    Private Sub Timer444_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer444.Tick


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


        If Label2.ForeColor = Color.White Then
            Label2.ForeColor = Color.Green
        ElseIf Label2.ForeColor = Color.Green Then
            Label2.ForeColor = Color.Blue
        ElseIf Label2.ForeColor = Color.Blue Then
            Label2.ForeColor = Color.Yellow
        ElseIf Label2.ForeColor = Color.Yellow Then
            Label2.ForeColor = Color.Cyan
        ElseIf Label2.ForeColor = Color.Cyan Then
            Label2.ForeColor = Color.White
        End If


    End Sub

    Private Sub Timer1010_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1010.Tick

        Label5.Text = TimeOfDay & "  ||  " & Date.Today

    End Sub

    Private Sub Timer911_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer911.Tick


        Dim generation1 As New System.IO.StreamReader("D:\THESIS\MATLAB\THESIS FINAL\" + "PP1.txt")
        Dim generation111 As String
        generation111 = generation1.ReadLine
        generation1.Read()
        generation1.Close()

        Dim generation11 As String
        generation11 = Val(generation111) / 1

        Button101.Text = generation11


        Dim generation2 As New System.IO.StreamReader("D:\THESIS\MATLAB\THESIS FINAL\" + "PP2.txt")
        Dim generation221 As String
        generation221 = generation2.ReadLine
        generation2.Read()
        generation2.Close()

        Dim generation21 As String
        generation21 = Val(generation221) / 1

        Button102.Text = generation21

        Dim generation3 As New System.IO.StreamReader("D:\THESIS\MATLAB\THESIS FINAL\" + "PP3.txt")
        Dim generation331 As String
        generation331 = generation3.ReadLine
        generation3.Read()
        generation3.Close()

        Dim generation31 As String
        generation31 = Val(generation331) / 1

        Button103.Text = generation31


        If Button101.Text <= 1500 And Button101.Text >= 1000 Then
            Button1.Enabled = True
            Button101.ForeColor = Color.White

            Label6.ForeColor = Color.Cyan
            Label9.Show()
            Label12.Hide()

        Else
            Button1.Enabled = False
            Button101.ForeColor = Color.Red
            Label6.ForeColor = Color.Blue
            Label12.Show()
            Label9.Hide()
        End If

        If Button102.Text <= 1500 And Button102.Text >= 1000 Then
            Button2.Enabled = True
            Button102.ForeColor = Color.White

            Label7.ForeColor = Color.Cyan
            Label10.Show()
            Label13.Hide()

        Else
            Button2.Enabled = False
            Button102.ForeColor = Color.Red

            Label7.ForeColor = Color.Blue
            Label13.Show()
            Label10.Hide()
        End If
        

        If Button103.Text <= 1000 And Button103.Text >= 500 Then
            Button3.Enabled = True
            Button103.ForeColor = Color.White

            Label8.ForeColor = Color.Cyan
            Label11.Show()
            Label14.Hide()

        Else
            Button3.Enabled = False
            Button103.ForeColor = Color.Red

            Label8.ForeColor = Color.Blue
            Label14.Show()
            Label11.Hide()
        End If
        


    End Sub

    Private Sub Button101_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button101.TextChanged


        If Timer911.Enabled = True Then

            Dim totalgen As String
            totalgen = Val(Button101.Text) + Val(Button102.Text) + Val(Button103.Text)


            Dim redpowp1 As Integer
            redpowp1 = 1500 - Val(Button101.Text)

            Dim redpowp2 As Integer
            redpowp2 = 1500 - Val(Button102.Text)

            Dim redpowp3 As Integer
            redpowp3 = 1000 - Val(Button103.Text)


            Label4.Text = vbNewLine & "Power Plant Informations : " & vbNewLine & "    Power Plant 1 Generation : " & Button101.Text & " MW." & vbNewLine & "    Power Plant 1 Generation Reduced : " & redpowp1 & " MW." & vbNewLine & vbNewLine & "    Power Plant 2 Generation : " & Button102.Text & " MW." & vbNewLine & "    Power Plant 2 Generation Reduced : " & redpowp2 & " MW." & vbNewLine & vbNewLine & "    Power Plant 3 Generation : " & Button103.Text & " MW." & vbNewLine & "    Power Plant 3 Generation Reduced : " & redpowp3 & " MW." & vbNewLine & vbNewLine & "    Total Generation : " & totalgen & " MW."

            Dim maxdemd As String
            maxdemd = 4000

            Dim loada1 As String
            loada1 = 600

            Dim loada2 As String
            loada2 = 500

            Dim loada3 As String
            loada3 = 800

            Dim loada4 As String
            loada4 = 700

            Dim loada5 As String
            loada5 = 400

            Dim loada6 As String
            loada6 = 200

            Dim loada7 As String
            loada7 = 450

            Dim loada8 As String
            loada8 = 350



            Dim percloaddecrsd As String
            percloaddecrsd = (Val(maxdemd) - Val(totalgen)) / 4000



            Dim decrsdloada1 As String
            decrsdloada1 = Val(loada1) * Val(percloaddecrsd)

            Dim decrsdloada2 As String
            decrsdloada2 = Val(loada2) * Val(percloaddecrsd)

            Dim decrsdloada3 As String
            decrsdloada3 = Val(loada3) * Val(percloaddecrsd)

            Dim decrsdloada4 As String
            decrsdloada4 = Val(loada4) * Val(percloaddecrsd)

            Dim decrsdloada5 As String
            decrsdloada5 = Val(loada5) * Val(percloaddecrsd)

            Dim decrsdloada6 As String
            decrsdloada6 = Val(loada6) * Val(percloaddecrsd)

            Dim decrsdloada7 As String
            decrsdloada7 = Val(loada7) * Val(percloaddecrsd)

            Dim decrsdloada8 As String
            decrsdloada8 = Val(loada8) * Val(percloaddecrsd)



            Dim psntloada1 As String
            psntloada1 = Val(loada1) - Val(decrsdloada1)

            Dim psntloada2 As String
            psntloada2 = Val(loada2) - Val(decrsdloada2)

            Dim psntloada3 As String
            psntloada3 = Val(loada3) - Val(decrsdloada3)

            Dim psntloada4 As String
            psntloada4 = Val(loada4) - Val(decrsdloada4)

            Dim psntloada5 As String
            psntloada5 = Val(loada5) - Val(decrsdloada5)

            Dim psntloada6 As String
            psntloada6 = Val(loada6) - Val(decrsdloada6)

            Dim psntloada7 As String
            psntloada7 = Val(loada7) - Val(decrsdloada7)

            Dim psntloada8 As String
            psntloada8 = Val(loada8) - Val(decrsdloada8)

            Dim totalpsntdem As String
            totalpsntdem = Val(psntloada1) + Val(psntloada2) + Val(psntloada3) + Val(psntloada4) + Val(psntloada5) + Val(psntloada6) + Val(psntloada7) + Val(psntloada8)

           

            If totalgen >= 500 And totalgen <= 4000 Then
                Label23.Text = "Status : Active" & vbNewLine & "Present Load : " & psntloada1 & " MW" & vbNewLine & "Load Decreased : " & decrsdloada1 & " MW"
                Label24.Text = "Status : Active" & vbNewLine & "Present Load : " & psntloada2 & " MW" & vbNewLine & "Load Decreased : " & decrsdloada2 & " MW"
                Label25.Text = "Status : Active" & vbNewLine & "Present Load : " & psntloada3 & " MW" & vbNewLine & "Load Decreased : " & decrsdloada3 & " MW"
                Label26.Text = "Status : Active" & vbNewLine & "Present Load : " & psntloada4 & " MW" & vbNewLine & "Load Decreased : " & decrsdloada4 & " MW"
                Label27.Text = "Status : Active" & vbNewLine & "Present Load : " & psntloada5 & " MW" & vbNewLine & "Load Decreased : " & decrsdloada5 & " MW"
                Label28.Text = "Status : Active" & vbNewLine & "Present Load : " & psntloada6 & " MW" & vbNewLine & "Load Decreased : " & decrsdloada6 & " MW"
                Label29.Text = "Status : Active" & vbNewLine & "Present Load : " & psntloada7 & " MW" & vbNewLine & "Load Decreased : " & decrsdloada7 & " MW"
                Label30.Text = "Status : Active" & vbNewLine & "Present Load : " & psntloada8 & " MW" & vbNewLine & "Load Decreased : " & decrsdloada8 & " MW"

                Label4.Text = Label4.Text & vbNewLine & vbNewLine & vbNewLine & "Load Area Informations :" & vbNewLine & "     Max Demand : 4000 MW" & vbNewLine & "     Present Load Demand : " & totalpsntdem & " MW" & vbNewLine & "     Load Decreased : " & Val(percloaddecrsd) * 100 & " %"

                 
                Label15.ForeColor = Color.Lime
                Label16.ForeColor = Color.Lime
                Label17.ForeColor = Color.Lime
                Label18.ForeColor = Color.Lime
                Label19.ForeColor = Color.Lime
                Label20.ForeColor = Color.Lime
                Label21.ForeColor = Color.Lime
                Label22.ForeColor = Color.Lime

                Label23.ForeColor = Color.Cyan
                Label24.ForeColor = Color.Cyan
                Label25.ForeColor = Color.Cyan
                Label26.ForeColor = Color.Cyan
                Label27.ForeColor = Color.Cyan
                Label28.ForeColor = Color.Cyan
                Label29.ForeColor = Color.Cyan
                Label30.ForeColor = Color.Cyan


            Else

                Label23.Text = "Status : Inactive" & vbNewLine & "Present Load : " & psntloada1 & " MW" & vbNewLine & "Load Decreased : " & decrsdloada1 & " MW"
                Label24.Text = "Status : Inactive" & vbNewLine & "Present Load : " & psntloada2 & " MW" & vbNewLine & "Load Decreased : " & decrsdloada2 & " MW"
                Label25.Text = "Status : Inactive" & vbNewLine & "Present Load : " & psntloada3 & " MW" & vbNewLine & "Load Decreased : " & decrsdloada3 & " MW"
                Label26.Text = "Status : Inactive" & vbNewLine & "Present Load : " & psntloada4 & " MW" & vbNewLine & "Load Decreased : " & decrsdloada4 & " MW"
                Label27.Text = "Status : Inactive" & vbNewLine & "Present Load : " & psntloada5 & " MW" & vbNewLine & "Load Decreased : " & decrsdloada5 & " MW"
                Label28.Text = "Status : Inactive" & vbNewLine & "Present Load : " & psntloada6 & " MW" & vbNewLine & "Load Decreased : " & decrsdloada6 & " MW"
                Label29.Text = "Status : Inactive" & vbNewLine & "Present Load : " & psntloada7 & " MW" & vbNewLine & "Load Decreased : " & decrsdloada7 & " MW"
                Label30.Text = "Status : Inactive" & vbNewLine & "Present Load : " & psntloada8 & " MW" & vbNewLine & "Load Decreased : " & decrsdloada8 & " MW"

                Label4.Text = Label4.Text & vbNewLine & vbNewLine & vbNewLine & "Load Area Informations :" & vbNewLine & "     Max Demand : 4000 MW" & vbNewLine & "     Present Load Demand : " & totalpsntdem & " MW" & vbNewLine & "     Load Decreased : " & Val(percloaddecrsd) * 100 & " %"

                Label15.ForeColor = Color.Blue
                Label16.ForeColor = Color.Blue
                Label17.ForeColor = Color.Blue
                Label18.ForeColor = Color.Blue
                Label19.ForeColor = Color.Blue
                Label20.ForeColor = Color.Blue
                Label21.ForeColor = Color.Blue
                Label22.ForeColor = Color.Blue



                Label23.ForeColor = Color.Red
                Label24.ForeColor = Color.Red
                Label25.ForeColor = Color.Red
                Label26.ForeColor = Color.Red
                Label27.ForeColor = Color.Red
                Label28.ForeColor = Color.Red
                Label29.ForeColor = Color.Red
                Label30.ForeColor = Color.Red

            End If

           



            If Button101.Text < 1000 And Button102.Text < 1000 And Button103.Text < 500 Then

                Label3.Text = "!!!Warnings!!!" & vbNewLine & "All power Plants are failed"
                Label3.ForeColor = Color.Red


            ElseIf Button101.Text >= 1000 And Button102.Text >= 1000 And Button103.Text < 500 Then

                Label3.Text = "!!!Warnings!!!" & vbNewLine & "Power Plant 3 is failed"
                Label3.ForeColor = Color.Red

            ElseIf Button101.Text >= 1000 And Button102.Text < 1000 And Button103.Text >= 500 Then

                Label3.Text = "!!!Warnings!!!" & vbNewLine & "Power Plant 2 is failed"
                Label3.ForeColor = Color.Red

            ElseIf Button101.Text >= 1000 And Button102.Text < 1000 And Button103.Text < 500 Then

                Label3.Text = "!!!Warnings!!!" & vbNewLine & "Power Plant 2, 3 are failed"
                Label3.ForeColor = Color.Red

            ElseIf Button101.Text < 1000 And Button102.Text >= 1000 And Button103.Text >= 500 Then

                Label3.Text = "!!!Warnings!!!" & vbNewLine & "Power Plant 1 is failed"
                Label3.ForeColor = Color.Red

            ElseIf Button101.Text < 1000 And Button102.Text >= 1000 And Button103.Text < 500 Then

                Label3.Text = "!!!Warnings!!!" & vbNewLine & "Power Plant 1, 3 are failed"
                Label3.ForeColor = Color.Red

            ElseIf Button101.Text < 1000 And Button102.Text < 1000 And Button103.Text >= 500 Then

                Label3.Text = "!!!Warnings!!!" & vbNewLine & "Power Plant 1, 2 are failed"
                Label3.ForeColor = Color.Red

            ElseIf Button101.Text >= 1000 And Button102.Text >= 1000 And Button103.Text >= 500 Then

                Label3.Text = "Operating Mode : Normal"
                Label3.ForeColor = Color.Lime

            End If


            If totalgen >= 500 And totalgen <= 4000 Then
                Button11.Enabled = True
                Button12.Enabled = True
                Button13.Enabled = True
                Button14.Enabled = True
                Button15.Enabled = True
                Button16.Enabled = True
                Button17.Enabled = True
                Button18.Enabled = True

            Else

                Button11.Enabled = False
                Button12.Enabled = False
                Button13.Enabled = False
                Button14.Enabled = False
                Button15.Enabled = False
                Button16.Enabled = False
                Button17.Enabled = False
                Button18.Enabled = False

            End If


            If Button101.Text < 1000 And Button102.Text < 1000 And Button103.Text < 500 Then

                Timer123.Enabled = False
                Timer41.Enabled = True
            Else
                Timer41.Enabled = False
                Timer123.Enabled = True
            End If

            If Button101.Text >= 1000 And Button102.Text >= 1000 And Button103.Text < 500 Then

                Timer3.Enabled = False
                Timer41.Enabled = True
            Else
                Timer41.Enabled = False
                Timer3.Enabled = True
            End If



            If Button101.Text >= 1000 And Button102.Text < 1000 And Button103.Text >= 500 Then

                Timer2.Enabled = False
                Timer41.Enabled = True
            Else
                Timer41.Enabled = False
                Timer2.Enabled = True
            End If

            If Button101.Text >= 1000 And Button102.Text < 1000 And Button103.Text < 500 Then

                Timer23.Enabled = False
                Timer41.Enabled = True
            Else
                Timer41.Enabled = False
                Timer23.Enabled = True
            End If

            If Button101.Text < 1000 And Button102.Text >= 1000 And Button103.Text >= 500 Then

                Timer1.Enabled = False
                Timer41.Enabled = True
            Else
                Timer41.Enabled = False
                Timer1.Enabled = True
            End If


            If Button101.Text < 1000 And Button102.Text >= 1000 And Button103.Text < 500 Then

                Timer13.Enabled = False
                Timer41.Enabled = True
            Else
                Timer41.Enabled = False
                Timer13.Enabled = True
            End If

            If Button101.Text < 1000 And Button102.Text < 1000 And Button103.Text >= 500 Then

                Timer12.Enabled = False
                Timer41.Enabled = True
            Else
                Timer41.Enabled = False
                Timer12.Enabled = True
            End If

            If Button101.Text >= 1000 And Button102.Text >= 1000 And Button103.Text >= 500 Then

                Timer111.Enabled = False
                Timer41.Enabled = False
            Else
                Timer41.Enabled = True

                Timer111.Enabled = True
            End If

            If Timer123.Enabled = False Then
                My.Computer.Audio.Play(My.Resources.EMEL, AudioPlayMode.BackgroundLoop)

            ElseIf Timer1.Enabled = False Then
                My.Computer.Audio.Play(My.Resources.PP1, AudioPlayMode.BackgroundLoop)

            ElseIf Timer2.Enabled = False Then
                My.Computer.Audio.Play(My.Resources.PP2, AudioPlayMode.BackgroundLoop)

            ElseIf Timer3.Enabled = False Then
                My.Computer.Audio.Play(My.Resources.PP3, AudioPlayMode.BackgroundLoop)

            ElseIf Timer12.Enabled = False Then
                My.Computer.Audio.Play(My.Resources.PP12, AudioPlayMode.BackgroundLoop)

            ElseIf Timer13.Enabled = False Then
                My.Computer.Audio.Play(My.Resources.PP13, AudioPlayMode.BackgroundLoop)

            ElseIf Timer23.Enabled = False Then
                My.Computer.Audio.Play(My.Resources.PP23, AudioPlayMode.BackgroundLoop)

            ElseIf Timer111.Enabled = False Then
                My.Computer.Audio.Play(My.Resources.OMN, AudioPlayMode.Background)

            Else
                My.Computer.Audio.Stop()
            End If


            If totalgen >= 500 And totalgen <= 4000 Then
                Timer40.Enabled = True
                Timer41.Enabled = True
                Timer42.Enabled = False
            Else
                Timer40.Enabled = False
                Timer41.Enabled = False
                Timer42.Enabled = True
            End If

        End If

        If Button500.Visible = True Then
            Timer_Freq2.Enabled = True
        End If

    End Sub


    Private Sub Button102_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button102.TextChanged


        If Timer911.Enabled = True Then
            Dim totalgen As String
            totalgen = Val(Button101.Text) + Val(Button102.Text) + Val(Button103.Text)


            Dim redpowp1 As Integer
            redpowp1 = 1500 - Val(Button101.Text)

            Dim redpowp2 As Integer
            redpowp2 = 1500 - Val(Button102.Text)

            Dim redpowp3 As Integer
            redpowp3 = 1000 - Val(Button103.Text)


            Label4.Text = vbNewLine & "Power Plant Informations : " & vbNewLine & "    Power Plant 1 Generation : " & Button101.Text & " MW." & vbNewLine & "    Power Plant 1 Generation Reduced : " & redpowp1 & " MW." & vbNewLine & vbNewLine & "    Power Plant 2 Generation : " & Button102.Text & " MW." & vbNewLine & "    Power Plant 2 Generation Reduced : " & redpowp2 & " MW." & vbNewLine & vbNewLine & "    Power Plant 3 Generation : " & Button103.Text & " MW." & vbNewLine & "    Power Plant 3 Generation Reduced : " & redpowp3 & " MW." & vbNewLine & vbNewLine & "    Total Generation : " & totalgen & " MW."

            Dim maxdemd As String
            maxdemd = 4000

            Dim loada1 As String
            loada1 = 600

            Dim loada2 As String
            loada2 = 500

            Dim loada3 As String
            loada3 = 800

            Dim loada4 As String
            loada4 = 700

            Dim loada5 As String
            loada5 = 400

            Dim loada6 As String
            loada6 = 200

            Dim loada7 As String
            loada7 = 450

            Dim loada8 As String
            loada8 = 350



            Dim percloaddecrsd As String
            percloaddecrsd = (Val(maxdemd) - Val(totalgen)) / 4000



            Dim decrsdloada1 As String
            decrsdloada1 = Val(loada1) * Val(percloaddecrsd)

            Dim decrsdloada2 As String
            decrsdloada2 = Val(loada2) * Val(percloaddecrsd)

            Dim decrsdloada3 As String
            decrsdloada3 = Val(loada3) * Val(percloaddecrsd)

            Dim decrsdloada4 As String
            decrsdloada4 = Val(loada4) * Val(percloaddecrsd)

            Dim decrsdloada5 As String
            decrsdloada5 = Val(loada5) * Val(percloaddecrsd)

            Dim decrsdloada6 As String
            decrsdloada6 = Val(loada6) * Val(percloaddecrsd)

            Dim decrsdloada7 As String
            decrsdloada7 = Val(loada7) * Val(percloaddecrsd)

            Dim decrsdloada8 As String
            decrsdloada8 = Val(loada8) * Val(percloaddecrsd)



            Dim psntloada1 As String
            psntloada1 = Val(loada1) - Val(decrsdloada1)

            Dim psntloada2 As String
            psntloada2 = Val(loada2) - Val(decrsdloada2)

            Dim psntloada3 As String
            psntloada3 = Val(loada3) - Val(decrsdloada3)

            Dim psntloada4 As String
            psntloada4 = Val(loada4) - Val(decrsdloada4)

            Dim psntloada5 As String
            psntloada5 = Val(loada5) - Val(decrsdloada5)

            Dim psntloada6 As String
            psntloada6 = Val(loada6) - Val(decrsdloada6)

            Dim psntloada7 As String
            psntloada7 = Val(loada7) - Val(decrsdloada7)

            Dim psntloada8 As String
            psntloada8 = Val(loada8) - Val(decrsdloada8)

            Dim totalpsntdem As String
            totalpsntdem = Val(psntloada1) + Val(psntloada2) + Val(psntloada3) + Val(psntloada4) + Val(psntloada5) + Val(psntloada6) + Val(psntloada7) + Val(psntloada8)


            If totalgen >= 500 And totalgen <= 4000 Then
                Label23.Text = "Status : Active" & vbNewLine & "Present Load : " & psntloada1 & " MW" & vbNewLine & "Load Decreased : " & decrsdloada1 & " MW"
                Label24.Text = "Status : Active" & vbNewLine & "Present Load : " & psntloada2 & " MW" & vbNewLine & "Load Decreased : " & decrsdloada2 & " MW"
                Label25.Text = "Status : Active" & vbNewLine & "Present Load : " & psntloada3 & " MW" & vbNewLine & "Load Decreased : " & decrsdloada3 & " MW"
                Label26.Text = "Status : Active" & vbNewLine & "Present Load : " & psntloada4 & " MW" & vbNewLine & "Load Decreased : " & decrsdloada4 & " MW"
                Label27.Text = "Status : Active" & vbNewLine & "Present Load : " & psntloada5 & " MW" & vbNewLine & "Load Decreased : " & decrsdloada5 & " MW"
                Label28.Text = "Status : Active" & vbNewLine & "Present Load : " & psntloada6 & " MW" & vbNewLine & "Load Decreased : " & decrsdloada6 & " MW"
                Label29.Text = "Status : Active" & vbNewLine & "Present Load : " & psntloada7 & " MW" & vbNewLine & "Load Decreased : " & decrsdloada7 & " MW"
                Label30.Text = "Status : Active" & vbNewLine & "Present Load : " & psntloada8 & " MW" & vbNewLine & "Load Decreased : " & decrsdloada8 & " MW"

                Label4.Text = Label4.Text & vbNewLine & vbNewLine & vbNewLine & "Load Area Informations :" & vbNewLine & "     Max Demand : 4000 MW" & vbNewLine & "     Present Load Demand : " & totalpsntdem & " MW" & vbNewLine & "     Load Decreased : " & Val(percloaddecrsd) * 100 & " %"

                Label15.ForeColor = Color.Lime
                Label16.ForeColor = Color.Lime
                Label17.ForeColor = Color.Lime
                Label18.ForeColor = Color.Lime
                Label19.ForeColor = Color.Lime
                Label20.ForeColor = Color.Lime
                Label21.ForeColor = Color.Lime
                Label22.ForeColor = Color.Lime

                Label23.ForeColor = Color.Cyan
                Label24.ForeColor = Color.Cyan
                Label25.ForeColor = Color.Cyan
                Label26.ForeColor = Color.Cyan
                Label27.ForeColor = Color.Cyan
                Label28.ForeColor = Color.Cyan
                Label29.ForeColor = Color.Cyan
                Label30.ForeColor = Color.Cyan


            Else

                Label23.Text = "Status : Inactive" & vbNewLine & "Present Load : " & psntloada1 & " MW" & vbNewLine & "Load Decreased : " & decrsdloada1 & " MW"
                Label24.Text = "Status : Inactive" & vbNewLine & "Present Load : " & psntloada2 & " MW" & vbNewLine & "Load Decreased : " & decrsdloada2 & " MW"
                Label25.Text = "Status : Inactive" & vbNewLine & "Present Load : " & psntloada3 & " MW" & vbNewLine & "Load Decreased : " & decrsdloada3 & " MW"
                Label26.Text = "Status : Inactive" & vbNewLine & "Present Load : " & psntloada4 & " MW" & vbNewLine & "Load Decreased : " & decrsdloada4 & " MW"
                Label27.Text = "Status : Inactive" & vbNewLine & "Present Load : " & psntloada5 & " MW" & vbNewLine & "Load Decreased : " & decrsdloada5 & " MW"
                Label28.Text = "Status : Inactive" & vbNewLine & "Present Load : " & psntloada6 & " MW" & vbNewLine & "Load Decreased : " & decrsdloada6 & " MW"
                Label29.Text = "Status : Inactive" & vbNewLine & "Present Load : " & psntloada7 & " MW" & vbNewLine & "Load Decreased : " & decrsdloada7 & " MW"
                Label30.Text = "Status : Inactive" & vbNewLine & "Present Load : " & psntloada8 & " MW" & vbNewLine & "Load Decreased : " & decrsdloada8 & " MW"

                Label4.Text = Label4.Text & vbNewLine & vbNewLine & vbNewLine & "Load Area Informations :" & vbNewLine & "     Max Demand : 4000 MW" & vbNewLine & "     Present Load Demand : " & totalpsntdem & " MW" & vbNewLine & "     Load Decreased : " & Val(percloaddecrsd) * 100 & " %"

                Label15.ForeColor = Color.Blue
                Label16.ForeColor = Color.Blue
                Label17.ForeColor = Color.Blue
                Label18.ForeColor = Color.Blue
                Label19.ForeColor = Color.Blue
                Label20.ForeColor = Color.Blue
                Label21.ForeColor = Color.Blue
                Label22.ForeColor = Color.Blue



                Label23.ForeColor = Color.Red
                Label24.ForeColor = Color.Red
                Label25.ForeColor = Color.Red
                Label26.ForeColor = Color.Red
                Label27.ForeColor = Color.Red
                Label28.ForeColor = Color.Red
                Label29.ForeColor = Color.Red
                Label30.ForeColor = Color.Red

            End If




            If Button101.Text < 1000 And Button102.Text < 1000 And Button103.Text < 500 Then

                Label3.Text = "!!!Warnings!!!" & vbNewLine & "All power Plants are failed"
                Label3.ForeColor = Color.Red


            ElseIf Button101.Text >= 1000 And Button102.Text >= 1000 And Button103.Text < 500 Then

                Label3.Text = "!!!Warnings!!!" & vbNewLine & "Power Plant 3 is failed"
                Label3.ForeColor = Color.Red

            ElseIf Button101.Text >= 1000 And Button102.Text < 1000 And Button103.Text >= 500 Then

                Label3.Text = "!!!Warnings!!!" & vbNewLine & "Power Plant 2 is failed"
                Label3.ForeColor = Color.Red

            ElseIf Button101.Text >= 1000 And Button102.Text < 1000 And Button103.Text < 500 Then

                Label3.Text = "!!!Warnings!!!" & vbNewLine & "Power Plant 2, 3 are failed"
                Label3.ForeColor = Color.Red

            ElseIf Button101.Text < 1000 And Button102.Text >= 1000 And Button103.Text >= 500 Then

                Label3.Text = "!!!Warnings!!!" & vbNewLine & "Power Plant 1 is failed"
                Label3.ForeColor = Color.Red

            ElseIf Button101.Text < 1000 And Button102.Text >= 1000 And Button103.Text < 500 Then

                Label3.Text = "!!!Warnings!!!" & vbNewLine & "Power Plant 1, 3 are failed"
                Label3.ForeColor = Color.Red

            ElseIf Button101.Text < 1000 And Button102.Text < 1000 And Button103.Text >= 500 Then

                Label3.Text = "!!!Warnings!!!" & vbNewLine & "Power Plant 1, 2 are failed"
                Label3.ForeColor = Color.Red

            ElseIf Button101.Text >= 1000 And Button102.Text >= 1000 And Button103.Text >= 500 Then

                Label3.Text = "Operating Mode : Normal"
                Label3.ForeColor = Color.Lime

            End If


            If totalgen >= 500 And totalgen <= 4000 Then
                Button11.Enabled = True
                Button12.Enabled = True
                Button13.Enabled = True
                Button14.Enabled = True
                Button15.Enabled = True
                Button16.Enabled = True
                Button17.Enabled = True
                Button18.Enabled = True

            Else

                Button11.Enabled = False
                Button12.Enabled = False
                Button13.Enabled = False
                Button14.Enabled = False
                Button15.Enabled = False
                Button16.Enabled = False
                Button17.Enabled = False
                Button18.Enabled = False

            End If


            If Button101.Text < 1000 And Button102.Text < 1000 And Button103.Text < 500 Then

                Timer123.Enabled = False
                Timer41.Enabled = True
            Else
                Timer41.Enabled = False
                Timer123.Enabled = True
            End If

            If Button101.Text >= 1000 And Button102.Text >= 1000 And Button103.Text < 500 Then

                Timer3.Enabled = False
                Timer41.Enabled = True
            Else
                Timer41.Enabled = False
                Timer3.Enabled = True
            End If



            If Button101.Text >= 1000 And Button102.Text < 1000 And Button103.Text >= 500 Then

                Timer2.Enabled = False
                Timer41.Enabled = True
            Else
                Timer41.Enabled = False
                Timer2.Enabled = True
            End If

            If Button101.Text >= 1000 And Button102.Text < 1000 And Button103.Text < 500 Then

                Timer23.Enabled = False
                Timer41.Enabled = True
            Else
                Timer41.Enabled = False
                Timer23.Enabled = True
            End If

            If Button101.Text < 1000 And Button102.Text >= 1000 And Button103.Text >= 500 Then

                Timer1.Enabled = False
                Timer41.Enabled = True
            Else
                Timer41.Enabled = False
                Timer1.Enabled = True
            End If


            If Button101.Text < 1000 And Button102.Text >= 1000 And Button103.Text < 500 Then

                Timer13.Enabled = False
                Timer41.Enabled = True
            Else
                Timer41.Enabled = False
                Timer13.Enabled = True
            End If

            If Button101.Text < 1000 And Button102.Text < 1000 And Button103.Text >= 500 Then

                Timer12.Enabled = False
                Timer41.Enabled = True
            Else
                Timer41.Enabled = False
                Timer12.Enabled = True
            End If

            If Button101.Text >= 1000 And Button102.Text >= 1000 And Button103.Text >= 500 Then

                Timer111.Enabled = False
                Timer41.Enabled = False
            Else
                Timer41.Enabled = True

                Timer111.Enabled = True
            End If

            If Timer123.Enabled = False Then
                My.Computer.Audio.Play(My.Resources.EMEL, AudioPlayMode.BackgroundLoop)

            ElseIf Timer1.Enabled = False Then
                My.Computer.Audio.Play(My.Resources.PP1, AudioPlayMode.BackgroundLoop)

            ElseIf Timer2.Enabled = False Then
                My.Computer.Audio.Play(My.Resources.PP2, AudioPlayMode.BackgroundLoop)

            ElseIf Timer3.Enabled = False Then
                My.Computer.Audio.Play(My.Resources.PP3, AudioPlayMode.BackgroundLoop)

            ElseIf Timer12.Enabled = False Then
                My.Computer.Audio.Play(My.Resources.PP12, AudioPlayMode.BackgroundLoop)

            ElseIf Timer13.Enabled = False Then
                My.Computer.Audio.Play(My.Resources.PP13, AudioPlayMode.BackgroundLoop)

            ElseIf Timer23.Enabled = False Then
                My.Computer.Audio.Play(My.Resources.PP23, AudioPlayMode.BackgroundLoop)

            ElseIf Timer111.Enabled = False Then
                My.Computer.Audio.Play(My.Resources.OMN, AudioPlayMode.Background)

            Else
                My.Computer.Audio.Stop()
            End If


            If totalgen >= 500 And totalgen <= 4000 Then
                Timer40.Enabled = True
                Timer41.Enabled = True
                Timer42.Enabled = False
            Else
                Timer40.Enabled = False
                Timer41.Enabled = False
                Timer42.Enabled = True
            End If

        End If

        If Button500.Visible = True Then
            Timer_Freq2.Enabled = True
        End If


    End Sub


    Private Sub Button103_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button103.TextChanged


        If Timer911.Enabled = True Then
            Dim totalgen As String
            totalgen = Val(Button101.Text) + Val(Button102.Text) + Val(Button103.Text)


            Dim redpowp1 As Integer
            redpowp1 = 1500 - Val(Button101.Text)

            Dim redpowp2 As Integer
            redpowp2 = 1500 - Val(Button102.Text)

            Dim redpowp3 As Integer
            redpowp3 = 1000 - Val(Button103.Text)


            Label4.Text = vbNewLine & "Power Plant Informations : " & vbNewLine & "    Power Plant 1 Generation : " & Button101.Text & " MW." & vbNewLine & "    Power Plant 1 Generation Reduced : " & redpowp1 & " MW." & vbNewLine & vbNewLine & "    Power Plant 2 Generation : " & Button102.Text & " MW." & vbNewLine & "    Power Plant 2 Generation Reduced : " & redpowp2 & " MW." & vbNewLine & vbNewLine & "    Power Plant 3 Generation : " & Button103.Text & " MW." & vbNewLine & "    Power Plant 3 Generation Reduced : " & redpowp3 & " MW." & vbNewLine & vbNewLine & "    Total Generation : " & totalgen & " MW."

            Dim maxdemd As String
            maxdemd = 4000

            Dim loada1 As String
            loada1 = 600

            Dim loada2 As String
            loada2 = 500

            Dim loada3 As String
            loada3 = 800

            Dim loada4 As String
            loada4 = 700

            Dim loada5 As String
            loada5 = 400

            Dim loada6 As String
            loada6 = 200

            Dim loada7 As String
            loada7 = 450

            Dim loada8 As String
            loada8 = 350



            Dim percloaddecrsd As String
            percloaddecrsd = (Val(maxdemd) - Val(totalgen)) / 4000



            Dim decrsdloada1 As String
            decrsdloada1 = Val(loada1) * Val(percloaddecrsd)

            Dim decrsdloada2 As String
            decrsdloada2 = Val(loada2) * Val(percloaddecrsd)

            Dim decrsdloada3 As String
            decrsdloada3 = Val(loada3) * Val(percloaddecrsd)

            Dim decrsdloada4 As String
            decrsdloada4 = Val(loada4) * Val(percloaddecrsd)

            Dim decrsdloada5 As String
            decrsdloada5 = Val(loada5) * Val(percloaddecrsd)

            Dim decrsdloada6 As String
            decrsdloada6 = Val(loada6) * Val(percloaddecrsd)

            Dim decrsdloada7 As String
            decrsdloada7 = Val(loada7) * Val(percloaddecrsd)

            Dim decrsdloada8 As String
            decrsdloada8 = Val(loada8) * Val(percloaddecrsd)



            Dim psntloada1 As String
            psntloada1 = Val(loada1) - Val(decrsdloada1)

            Dim psntloada2 As String
            psntloada2 = Val(loada2) - Val(decrsdloada2)

            Dim psntloada3 As String
            psntloada3 = Val(loada3) - Val(decrsdloada3)

            Dim psntloada4 As String
            psntloada4 = Val(loada4) - Val(decrsdloada4)

            Dim psntloada5 As String
            psntloada5 = Val(loada5) - Val(decrsdloada5)

            Dim psntloada6 As String
            psntloada6 = Val(loada6) - Val(decrsdloada6)

            Dim psntloada7 As String
            psntloada7 = Val(loada7) - Val(decrsdloada7)

            Dim psntloada8 As String
            psntloada8 = Val(loada8) - Val(decrsdloada8)

            Dim totalpsntdem As String
            totalpsntdem = Val(psntloada1) + Val(psntloada2) + Val(psntloada3) + Val(psntloada4) + Val(psntloada5) + Val(psntloada6) + Val(psntloada7) + Val(psntloada8)


            If totalgen >= 500 And totalgen <= 4000 Then
                Label23.Text = "Status : Active" & vbNewLine & "Present Load : " & psntloada1 & " MW" & vbNewLine & "Load Decreased : " & decrsdloada1 & " MW"
                Label24.Text = "Status : Active" & vbNewLine & "Present Load : " & psntloada2 & " MW" & vbNewLine & "Load Decreased : " & decrsdloada2 & " MW"
                Label25.Text = "Status : Active" & vbNewLine & "Present Load : " & psntloada3 & " MW" & vbNewLine & "Load Decreased : " & decrsdloada3 & " MW"
                Label26.Text = "Status : Active" & vbNewLine & "Present Load : " & psntloada4 & " MW" & vbNewLine & "Load Decreased : " & decrsdloada4 & " MW"
                Label27.Text = "Status : Active" & vbNewLine & "Present Load : " & psntloada5 & " MW" & vbNewLine & "Load Decreased : " & decrsdloada5 & " MW"
                Label28.Text = "Status : Active" & vbNewLine & "Present Load : " & psntloada6 & " MW" & vbNewLine & "Load Decreased : " & decrsdloada6 & " MW"
                Label29.Text = "Status : Active" & vbNewLine & "Present Load : " & psntloada7 & " MW" & vbNewLine & "Load Decreased : " & decrsdloada7 & " MW"
                Label30.Text = "Status : Active" & vbNewLine & "Present Load : " & psntloada8 & " MW" & vbNewLine & "Load Decreased : " & decrsdloada8 & " MW"

                Label4.Text = Label4.Text & vbNewLine & vbNewLine & vbNewLine & "Load Area Informations :" & vbNewLine & "     Max Demand : 4000 MW" & vbNewLine & "     Present Load Demand : " & totalpsntdem & " MW" & vbNewLine & "     Load Decreased : " & Val(percloaddecrsd) * 100 & " %"

                Label15.ForeColor = Color.Lime
                Label16.ForeColor = Color.Lime
                Label17.ForeColor = Color.Lime
                Label18.ForeColor = Color.Lime
                Label19.ForeColor = Color.Lime
                Label20.ForeColor = Color.Lime
                Label21.ForeColor = Color.Lime
                Label22.ForeColor = Color.Lime

                Label23.ForeColor = Color.Cyan
                Label24.ForeColor = Color.Cyan
                Label25.ForeColor = Color.Cyan
                Label26.ForeColor = Color.Cyan
                Label27.ForeColor = Color.Cyan
                Label28.ForeColor = Color.Cyan
                Label29.ForeColor = Color.Cyan
                Label30.ForeColor = Color.Cyan


            Else

                Label23.Text = "Status : Inactive" & vbNewLine & "Present Load : " & psntloada1 & " MW" & vbNewLine & "Load Decreased : " & decrsdloada1 & " MW"
                Label24.Text = "Status : Inactive" & vbNewLine & "Present Load : " & psntloada2 & " MW" & vbNewLine & "Load Decreased : " & decrsdloada2 & " MW"
                Label25.Text = "Status : Inactive" & vbNewLine & "Present Load : " & psntloada3 & " MW" & vbNewLine & "Load Decreased : " & decrsdloada3 & " MW"
                Label26.Text = "Status : Inactive" & vbNewLine & "Present Load : " & psntloada4 & " MW" & vbNewLine & "Load Decreased : " & decrsdloada4 & " MW"
                Label27.Text = "Status : Inactive" & vbNewLine & "Present Load : " & psntloada5 & " MW" & vbNewLine & "Load Decreased : " & decrsdloada5 & " MW"
                Label28.Text = "Status : Inactive" & vbNewLine & "Present Load : " & psntloada6 & " MW" & vbNewLine & "Load Decreased : " & decrsdloada6 & " MW"
                Label29.Text = "Status : Inactive" & vbNewLine & "Present Load : " & psntloada7 & " MW" & vbNewLine & "Load Decreased : " & decrsdloada7 & " MW"
                Label30.Text = "Status : Inactive" & vbNewLine & "Present Load : " & psntloada8 & " MW" & vbNewLine & "Load Decreased : " & decrsdloada8 & " MW"

                Label4.Text = Label4.Text & vbNewLine & vbNewLine & vbNewLine & "Load Area Informations :" & vbNewLine & "     Max Demand : 4000 MW" & vbNewLine & "     Present Load Demand : " & totalpsntdem & " MW" & vbNewLine & "     Load Decreased : " & Val(percloaddecrsd) * 100 & " %"

                Label15.ForeColor = Color.Blue
                Label16.ForeColor = Color.Blue
                Label17.ForeColor = Color.Blue
                Label18.ForeColor = Color.Blue
                Label19.ForeColor = Color.Blue
                Label20.ForeColor = Color.Blue
                Label21.ForeColor = Color.Blue
                Label22.ForeColor = Color.Blue



                Label23.ForeColor = Color.Red
                Label24.ForeColor = Color.Red
                Label25.ForeColor = Color.Red
                Label26.ForeColor = Color.Red
                Label27.ForeColor = Color.Red
                Label28.ForeColor = Color.Red
                Label29.ForeColor = Color.Red
                Label30.ForeColor = Color.Red

            End If




            If Button101.Text < 1000 And Button102.Text < 1000 And Button103.Text < 500 Then

                Label3.Text = "!!!Warnings!!!" & vbNewLine & "All power Plants are failed"
                Label3.ForeColor = Color.Red


            ElseIf Button101.Text >= 1000 And Button102.Text >= 1000 And Button103.Text < 500 Then

                Label3.Text = "!!!Warnings!!!" & vbNewLine & "Power Plant 3 is failed"
                Label3.ForeColor = Color.Red

            ElseIf Button101.Text >= 1000 And Button102.Text < 1000 And Button103.Text >= 500 Then

                Label3.Text = "!!!Warnings!!!" & vbNewLine & "Power Plant 2 is failed"
                Label3.ForeColor = Color.Red

            ElseIf Button101.Text >= 1000 And Button102.Text < 1000 And Button103.Text < 500 Then

                Label3.Text = "!!!Warnings!!!" & vbNewLine & "Power Plant 2, 3 are failed"
                Label3.ForeColor = Color.Red

            ElseIf Button101.Text < 1000 And Button102.Text >= 1000 And Button103.Text >= 500 Then

                Label3.Text = "!!!Warnings!!!" & vbNewLine & "Power Plant 1 is failed"
                Label3.ForeColor = Color.Red

            ElseIf Button101.Text < 1000 And Button102.Text >= 1000 And Button103.Text < 500 Then

                Label3.Text = "!!!Warnings!!!" & vbNewLine & "Power Plant 1, 3 are failed"
                Label3.ForeColor = Color.Red

            ElseIf Button101.Text < 1000 And Button102.Text < 1000 And Button103.Text >= 500 Then

                Label3.Text = "!!!Warnings!!!" & vbNewLine & "Power Plant 1, 2 are failed"
                Label3.ForeColor = Color.Red

            ElseIf Button101.Text >= 1000 And Button102.Text >= 1000 And Button103.Text >= 500 Then

                Label3.Text = "Operating Mode : Normal"
                Label3.ForeColor = Color.Lime

            End If


            If totalgen >= 500 And totalgen <= 4000 Then
                Button11.Enabled = True
                Button12.Enabled = True
                Button13.Enabled = True
                Button14.Enabled = True
                Button15.Enabled = True
                Button16.Enabled = True
                Button17.Enabled = True
                Button18.Enabled = True

            Else

                Button11.Enabled = False
                Button12.Enabled = False
                Button13.Enabled = False
                Button14.Enabled = False
                Button15.Enabled = False
                Button16.Enabled = False
                Button17.Enabled = False
                Button18.Enabled = False

            End If


            If Button101.Text < 1000 And Button102.Text < 1000 And Button103.Text < 500 Then

                Timer123.Enabled = False
                Timer41.Enabled = True
            Else
                Timer41.Enabled = False
                Timer123.Enabled = True
            End If

            If Button101.Text >= 1000 And Button102.Text >= 1000 And Button103.Text < 500 Then

                Timer3.Enabled = False
                Timer41.Enabled = True
            Else
                Timer41.Enabled = False
                Timer3.Enabled = True
            End If



            If Button101.Text >= 1000 And Button102.Text < 1000 And Button103.Text >= 500 Then

                Timer2.Enabled = False
                Timer41.Enabled = True
            Else
                Timer41.Enabled = False
                Timer2.Enabled = True
            End If

            If Button101.Text >= 1000 And Button102.Text < 1000 And Button103.Text < 500 Then

                Timer23.Enabled = False
                Timer41.Enabled = True
            Else
                Timer41.Enabled = False
                Timer23.Enabled = True
            End If

            If Button101.Text < 1000 And Button102.Text >= 1000 And Button103.Text >= 500 Then

                Timer1.Enabled = False
                Timer41.Enabled = True
            Else
                Timer41.Enabled = False
                Timer1.Enabled = True
            End If


            If Button101.Text < 1000 And Button102.Text >= 1000 And Button103.Text < 500 Then

                Timer13.Enabled = False
                Timer41.Enabled = True
            Else
                Timer41.Enabled = False
                Timer13.Enabled = True
            End If

            If Button101.Text < 1000 And Button102.Text < 1000 And Button103.Text >= 500 Then

                Timer12.Enabled = False
                Timer41.Enabled = True
            Else
                Timer41.Enabled = False
                Timer12.Enabled = True
            End If

            If Button101.Text >= 1000 And Button102.Text >= 1000 And Button103.Text >= 500 Then

                Timer111.Enabled = False
                Timer41.Enabled = False
            Else
                Timer41.Enabled = True

                Timer111.Enabled = True
            End If

            If Timer123.Enabled = False Then
                My.Computer.Audio.Play(My.Resources.EMEL, AudioPlayMode.BackgroundLoop)

            ElseIf Timer1.Enabled = False Then
                My.Computer.Audio.Play(My.Resources.PP1, AudioPlayMode.BackgroundLoop)

            ElseIf Timer2.Enabled = False Then
                My.Computer.Audio.Play(My.Resources.PP2, AudioPlayMode.BackgroundLoop)

            ElseIf Timer3.Enabled = False Then
                My.Computer.Audio.Play(My.Resources.PP3, AudioPlayMode.BackgroundLoop)

            ElseIf Timer12.Enabled = False Then
                My.Computer.Audio.Play(My.Resources.PP12, AudioPlayMode.BackgroundLoop)

            ElseIf Timer13.Enabled = False Then
                My.Computer.Audio.Play(My.Resources.PP13, AudioPlayMode.BackgroundLoop)

            ElseIf Timer23.Enabled = False Then
                My.Computer.Audio.Play(My.Resources.PP23, AudioPlayMode.BackgroundLoop)

            ElseIf Timer111.Enabled = False Then
                My.Computer.Audio.Play(My.Resources.OMN, AudioPlayMode.Background)

            Else
                My.Computer.Audio.Stop()
            End If


            If totalgen >= 500 And totalgen <= 4000 Then
                Timer40.Enabled = True
                Timer41.Enabled = True
                Timer42.Enabled = False
            Else
                Timer40.Enabled = False
                Timer41.Enabled = False
                Timer42.Enabled = True
            End If

        End If

        If Button500.Visible = True Then
            Timer_Freq2.Enabled = True
        End If

    End Sub

    Private Sub Timer888_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer888.Tick
       
        If Label5552.Text <= 10 And Label5552.Text >= 1 Then
            Label5551.Show()
            Label5552.Show()
            Label5552.Text = Val(Label5552.Text) - 1

        ElseIf Label5552.Text < 1 Then
            Label5551.Hide()
            Label5552.Hide()
            Timer911.Enabled = True
            Timer_Freq.Enabled = True
            Button500.Show()
        End If


    End Sub


    Private Sub Timer_Freq_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Freq.Tick

        Dim totalgen As String
        totalgen = Val(Button101.Text) + Val(Button102.Text) + Val(Button103.Text)

        Dim frevr As String
        frevr = 50 - ((4000 - Val(totalgen)) / 200)

        If totalgen = 4000 Then
            Form2.Label3.Text = "Frequency Informations :" & vbNewLine & "     Present Frequency : 50 Hz" & vbNewLine & "     Frequency Variation w.r.t. Max Demand : 0 Hz" & vbNewLine
            Form2.Chart1.Series("Series1").Points.AddXY("", 50)
            Form2.Chart1.Series("Series2").Points.AddXY("", 0)
        ElseIf totalgen >= 500 And totalgen <= 4000 Then
            Form2.Label3.Text = "Frequency Informations :" & vbNewLine & "     Present Frequency : 50 Hz" & vbNewLine & "     Frequency Variation w.r.t. Max Demand : " & frevr & " Hz" & vbNewLine

            Form2.Chart1.Series("Series1").Points.AddXY("", 50)
            Form2.Chart1.Series("Series2").Points.AddXY("", frevr)
        Else
            Form2.Label3.Text = "Frequency Informations :" & vbNewLine & "     Present Frequency : 0 Hz" & vbNewLine & "     Frequency Variation w.r.t. Max Demand : 0 Hz" & vbNewLine
            Form2.Chart1.Series("Series1").Points.AddXY("", 0)
            Form2.Chart1.Series("Series2").Points.AddXY("", 0)
        End If

        Dim percloaddecrsd As String
        percloaddecrsd = ((Val(4000) - Val(totalgen)) / 4000)



        Dim maxdemd As String
        maxdemd = 4000

        Dim loada1 As String
        loada1 = 600

        Dim loada2 As String
        loada2 = 500

        Dim loada3 As String
        loada3 = 800

        Dim loada4 As String
        loada4 = 700

        Dim loada5 As String
        loada5 = 400

        Dim loada6 As String
        loada6 = 200

        Dim loada7 As String
        loada7 = 450

        Dim loada8 As String
        loada8 = 350


        Dim decrsdloada1 As String
        decrsdloada1 = Val(loada1) * Val(percloaddecrsd)

        Dim decrsdloada2 As String
        decrsdloada2 = Val(loada2) * Val(percloaddecrsd)

        Dim decrsdloada3 As String
        decrsdloada3 = Val(loada3) * Val(percloaddecrsd)

        Dim decrsdloada4 As String
        decrsdloada4 = Val(loada4) * Val(percloaddecrsd)

        Dim decrsdloada5 As String
        decrsdloada5 = Val(loada5) * Val(percloaddecrsd)

        Dim decrsdloada6 As String
        decrsdloada6 = Val(loada6) * Val(percloaddecrsd)

        Dim decrsdloada7 As String
        decrsdloada7 = Val(loada7) * Val(percloaddecrsd)

        Dim decrsdloada8 As String
        decrsdloada8 = Val(loada8) * Val(percloaddecrsd)



        Dim psntloada1 As String
        psntloada1 = Val(loada1) - Val(decrsdloada1)

        Dim psntloada2 As String
        psntloada2 = Val(loada2) - Val(decrsdloada2)

        Dim psntloada3 As String
        psntloada3 = Val(loada3) - Val(decrsdloada3)

        Dim psntloada4 As String
        psntloada4 = Val(loada4) - Val(decrsdloada4)

        Dim psntloada5 As String
        psntloada5 = Val(loada5) - Val(decrsdloada5)

        Dim psntloada6 As String
        psntloada6 = Val(loada6) - Val(decrsdloada6)

        Dim psntloada7 As String
        psntloada7 = Val(loada7) - Val(decrsdloada7)

        Dim psntloada8 As String
        psntloada8 = Val(loada8) - Val(decrsdloada8)

        Dim totalpsntdem As String
        totalpsntdem = Val(psntloada1) + Val(psntloada2) + Val(psntloada3) + Val(psntloada4) + Val(psntloada5) + Val(psntloada6) + Val(psntloada7) + Val(psntloada8)

        Form2.Label5.Text = "Load Area 1 Consumes  " & psntloada1 & " MW" & vbNewLine & "Load Area 2 Consumes  " & psntloada2 & " MW" & vbNewLine & "Load Area 3 Consumes  " & psntloada3 & " MW" & vbNewLine & "Load Area 4 Consumes  " & psntloada4 & " MW"
        Form2.Label6.Text = "Load Area 5 Consumes  " & psntloada5 & " MW" & vbNewLine & "Load Area 6 Consumes  " & psntloada6 & " MW" & vbNewLine & "Load Area 7 Consumes  " & psntloada7 & " MW" & vbNewLine & "Load Area 8 Consumes  " & psntloada8 & " MW"
    End Sub

    Private Sub Button500_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button500.Click
        Form2.Show()

    End Sub

    Private Sub Timer_Freq2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Freq2.Tick



        Dim totalgen As String
        totalgen = Val(Button101.Text) + Val(Button102.Text) + Val(Button103.Text)

        Dim percloaddecrsd As String
        percloaddecrsd = ((Val(4000) - Val(totalgen)) / 4000)

        Form2.Chart2.Series("Series1").Points.AddXY("", Val(percloaddecrsd) * 100)
        Form2.Label4.Text = "Load Area Informations :" & vbNewLine & "     Max Demand : 4000 MW" & vbNewLine & "     Present Load Demand : " & totalgen & " MW" & vbNewLine & "     Load Decreased : " & Val(percloaddecrsd) * 100 & " %"

        Timer_Freq2.Enabled = False



    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form2.Close()
        Me.Close()
        Form3.Show()
        Form3.TextBox1.Text = ""
        Form3.TextBox2.Text = ""


    End Sub
End Class
