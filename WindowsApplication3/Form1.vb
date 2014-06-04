Public Class Form1

   
    Dim yes As Boolean = False


    Dim beta As Double
    Dim q As Double
    Dim I As Double
    Dim t As Double
    Dim p As Double
    Dim sigma As Double
    Dim epsilon As Double
    Dim alpha As Double
    Dim a As Double
    Dim b As Double
    Dim R As Double
    


    Public Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False

        Dim w As Double
        Dim pr As Double
        Dim tr As Double
        Dim si As Double
        Dim ohm As Double

        Dim AA As Double
        Dim BB As Double
        Dim CC As Double
        Dim DD As Double



        If String.IsNullOrEmpty(TextBox1.Text) Or String.IsNullOrEmpty(TextBox2.Text) Or ListBox1.SelectedItem = Nothing Then



            MsgBox("!!INVALID ENTRY!! Please check your input", MsgBoxStyle.Critical, "Null/Empty Input Error")

            Me.TextBox3.Text = Nothing
            Me.TextBox4.Text = Nothing
            Me.TextBox5.Text = Nothing
            Me.TextBox6.Text = Nothing
            Me.TextBox7.Text = Nothing
            Me.TextBox8.Text = Nothing

            yes = False

        Else

            yes = True

            R = 83.14

            t = TextBox1.Text
            p = TextBox2.Text

            Select Case ListBox1.SelectedIndex
                Case 0
                    w = 0.012
                    tr = t / 190.6
                    pr = p / 45.99
                Case 1
                    w = 0.1
                    tr = t / 305.3
                    pr = p / 48.72
                Case 2
                    w = 0.152
                    tr = t / 369.8
                    pr = p / 42.48
                Case 3
                    w = 0.2
                    tr = t / 425.1
                    pr = p / 37.96
                Case 4
                    w = 0.252
                    tr = t / 469.7
                    pr = p / 33.7
                Case 5
                    w = 0.301
                    tr = t / 507.6
                    pr = p / 30.25
                Case 6
                    w = 0.35
                    tr = t / 540.2
                    pr = p / 27.4
                Case 7
                    w = 0.4
                    tr = t / 568.7
                    pr = p / 24.9
                Case 8
                    w = 0.444
                    tr = t / 594.6
                    pr = p / 22.9
                Case 9
                    w = 0.492
                    tr = t / 617.7
                    pr = p / 21.1
                Case 10
                    w = 0.181
                    tr = t / 408.1
                    pr = p / 36.48
                Case 11
                    w = 0.302
                    tr = t / 544
                    pr = p / 25.68
                Case 12
                    w = 0.196
                    tr = t / 511.8
                    pr = p / 45.02
                Case 13
                    w = 0.21
                    tr = t / 553.6
                    pr = p / 40.73
                Case 14
                    w = 0.23
                    tr = t / 532.8
                    pr = p / 37.85
                Case 15
                    w = 0.235
                    tr = t / 572.2
                    pr = p / 34.71
                Case 16
                    w = 0.087
                    tr = t / 282.3
                    pr = p / 50.4
                Case 17
                    w = 0.14
                    tr = t / 365.6
                    pr = p / 46.65
                Case 18
                    w = 0.191
                    tr = t / 420
                    pr = p / 40.43
                Case 19
                    w = 0.205
                    tr = t / 435.6
                    pr = p / 42.43
                Case 20
                    w = 0.218
                    tr = t / 428.6
                    pr = p / 41
                Case 21
                    w = 0.28
                    tr = t / 504
                    pr = p / 31.4
                Case 22
                    w = 0.194
                    tr = t / 417.9
                    pr = p / 40
                Case 23
                    w = 0.19
                    tr = t / 425.2
                    pr = p / 42.77
                Case 24
                    w = 0.212
                    tr = t / 560.4
                    pr = p / 43.5
                Case 25
                    w = 0.187
                    tr = t / 308.3
                    pr = p / 61.39
                Case 26
                    w = 0.21
                    tr = t / 562.2
                    pr = p / 48.98
                Case 27
                    w = 0.262
                    tr = t / 591.8
                    pr = p / 41.06
                Case 28
                    w = 0.303
                    tr = t / 617.2
                    pr = p / 36.06
                Case 29
                    w = 0.326
                    tr = t / 631.1
                    pr = p / 32.09
                Case 30
                    w = 0.31
                    tr = t / 630.3
                    pr = p / 37.34
                Case 31
                    w = 0.326
                    tr = t / 617.1
                    pr = p / 35.36
                Case 32
                    w = 0.322
                    tr = t / 616.2
                    pr = p / 35.11
                Case 33
                    w = 0.297
                    tr = t / 636
                    pr = p / 38.4
                Case 34
                    w = 0.302
                    tr = t / 748.4
                    pr = p / 40.51
                Case 35
                    w = 0.365
                    tr = t / 789.3
                    pr = p / 38.5
                Case 36
                    w = 0.282
                    tr = t / 408
                    pr = p / 65.9
                Case 37
                    w = 0.291
                    tr = t / 466
                    pr = p / 55.5
                Case 38
                    w = 0.331
                    tr = t / 506.6
                    pr = p / 47.5
                Case 39
                    w = 0.366
                    tr = t / 523.3
                    pr = p / 38.8
                Case 40
                    w = 0.307
                    tr = t / 508.2
                    pr = p / 47.01
                Case 41
                    w = 0.323
                    tr = t / 535.5
                    pr = p / 41.5
                Case 42
                    w = 0.281
                    tr = t / 466.7
                    pr = p / 36.4
                Case 43
                    w = 0.266
                    tr = t / 497.1
                    pr = p / 34.3
                Case 44
                    w = 0.564
                    tr = t / 512.6
                    pr = p / 80.97
                Case 45
                    w = 0.645
                    tr = t / 513.9
                    pr = p / 61.48
                Case 46
                    w = 0.622
                    tr = t / 536.8
                    pr = p / 51.75
                Case 47
                    w = 0.594
                    tr = t / 563.1
                    pr = p / 44.23
                Case 48
                    w = 0.579
                    tr = t / 611.4
                    pr = p / 35.1
                Case 49
                    w = 0.668
                    tr = t / 508.3
                    pr = p / 47.62
                Case 50
                    w = 0.444
                    tr = t / 694.3
                    pr = p / 61.3
                Case 51
                    w = 0.487
                    tr = t / 719.7
                    pr = p / 77
                Case 52
                    w = 0.467
                    tr = t / 592
                    pr = p / 57.86
                Case 53
                    w = 0.681
                    tr = t / 615.7
                    pr = p / 40.64
                Case 54
                    w = 0.603
                    tr = t / 751
                    pr = p / 44.7
                Case 55
                    w = 0.338
                    tr = t / 545.5
                    pr = p / 48.3
                Case 56
                    w = 0.281
                    tr = t / 430.1
                    pr = p / 74.6
                Case 57
                    w = 0.285
                    tr = t / 456.2
                    pr = p / 56.2
                Case 58
                    w = 0.348
                    tr = t / 588.2
                    pr = p / 63.1
                Case 59
                    w = 0.193
                    tr = t / 556.4
                    pr = p / 45.6
                Case 60
                    w = 0.22
                    tr = t / 536.4
                    pr = p / 54.72
                Case 61
                    w = 0.199
                    tr = t / 510
                    pr = p / 60.8
                Case 62
                    w = 0.153
                    tr = t / 416.3
                    pr = p / 66.8
                Case 63
                    w = 0.19
                    tr = t / 460.4
                    pr = p / 52.7
                Case 64
                    w = 0.25
                    tr = t / 632.4
                    pr = p / 45.2
                Case 65
                    w = 0.327
                    tr = t / 374.2
                    pr = p / 40.6
                Case 66
                    w = 0.0
                    tr = t / 150.9
                    pr = p / 48.98
                Case 67
                    w = 0.0
                    tr = t / 209.4
                    pr = p / 55.02
                Case 68
                    w = 0.0
                    tr = t / 289.7
                    pr = p / 58.4
                Case 69
                    w = -0.039
                    tr = t / 5.2
                    pr = p / 2.28
                Case 70
                    w = -0.216
                    tr = t / 33.19
                    pr = p / 13.13
                Case 71
                    w = 0.022
                    tr = t / 154.6
                    pr = p / 50.43
                Case 72
                    w = 0.038
                    tr = t / 126.2
                    pr = p / 34
                Case 73
                    w = 0.035
                    tr = t / 132.2
                    pr = p / 37.45
                Case 74
                    w = 0.069
                    tr = t / 417.2
                    pr = p / 77.1
                Case 75
                    w = 0.048
                    tr = t / 132.9
                    pr = p / 34.99
                Case 76
                    w = 0.224
                    tr = t / 304.2
                    pr = p / 73.83
                Case 77
                    w = 0.111
                    tr = t / 552.0
                    pr = p / 79
                Case 78
                    w = 0.094
                    tr = t / 373.5
                    pr = p / 89.63
                Case 79
                    w = 0.245
                    tr = t / 430.8
                    pr = p / 78.84
                Case 80
                    w = 0.424
                    tr = t / 190.9
                    pr = p / 82.1
                Case 81
                    w = 0.583
                    tr = t / 180.2
                    pr = p / 64.8
                Case 82
                    w = 0.141
                    tr = t / 309.6
                    pr = p / 72.45
                Case 83
                    w = 0.132
                    tr = t / 324.7
                    pr = p / 83.1
                Case 84
                    w = 0.41
                    tr = t / 456.7
                    pr = p / 53.9
                Case 85
                    w = 0.345
                    tr = t / 647.1
                    pr = p / 220.55
                Case 86
                    w = 0.253
                    tr = t / 405.7
                    pr = p / 112.8
                Case 87
                    w = 0.714
                    tr = t / 520
                    pr = p / 68.9
                Case 88
                    w = 0
                    tr = t / 924
                    pr = p / 64


            End Select

            Select Case ComboBox1.SelectedIndex

                Case 0
                    si = 27 / 64
                    ohm = 1 / 8
                    epsilon = 0
                    sigma = 0
                    alpha = 1

                    a = si * (alpha * (R ^ 2) * ((t / tr) ^ 2) / (p / pr))
                    b = ohm * R * (t / tr) / (p / pr)

                    beta = (b * p) / (R * t)
                    q = a / (b * R * t)


                Case 1
                    si = 0.42748
                    ohm = 0.08664
                    epsilon = 0
                    sigma = 1
                    alpha = tr ^ (-0.5)

                    a = si * (alpha * (R ^ 2) * ((t / tr) ^ 2) / (p / pr))
                    b = ohm * R * (t / tr) / (p / pr)


                    beta = (b * p) / (R * t)
                    q = a / (b * R * t)

                Case 2
                    si = 0.42748
                    ohm = 0.08664
                    epsilon = 0
                    sigma = 1
                    alpha = ((1 + (0.48 + (1.574 * w) - (0.176 * (w ^ 2))) * (1 - tr ^ (0.5)))) ^ 2
                    a = si * (alpha * (R ^ 2) * ((t / tr) ^ 2) / (p / pr))
                    b = ohm * R * (t / tr) / (p / pr)


                    beta = (b * p) / (R * t)
                    q = a / (b * R * t)

                Case 3
                    si = 0.45724
                    ohm = 0.0778
                    epsilon = 1 - (2) ^ (0.5)
                    sigma = 1 + (2) ^ (0.5)
                    alpha = ((1 + (0.37464 + (1.54226 * w) - (0.26992 * (w ^ 2))) * (1 - tr ^ (0.5)))) ^ 2

                    a = si * (alpha * (R ^ 2) * ((t / tr) ^ 2) / (p / pr))
                    b = ohm * R * (t / tr) / (p / pr)


                    beta = (b * p) / (R * t)
                    q = a / (b * R * t)

            End Select

            AA = p
            BB = -1 * ((R * t) + ((b * p) * (1 - (sigma + epsilon))))
            CC = (sigma * epsilon * p * (b ^ 2)) - ((sigma + epsilon) * b * ((R * t) + (b * p))) + a
            DD = -1 * (sigma * epsilon * b * b * ((R * t) + (b * p))) - (a * b)


            Dim f As Double
            Dim g As Double
            Dim h As Double

            f = ((3 * CC / AA) - ((BB ^ 2) / (AA ^ 2))) / 3

            g = ((2 * (BB ^ 3) / (AA ^ 3)) - ((9 * BB * CC) / (AA ^ 2)) + (27 * DD / AA)) / 27

            h = ((g ^ 2) / 4) + ((f ^ 3) / 27)

            TextBox6.Text = f
            TextBox7.Text = g
            TextBox8.Text = h


            Dim rx1 As Double = 0
            Dim rx2 As Double = 0
            Dim rx3 As Double = 0
            Dim ix1 As Double = 0
            Dim ix2 As Double = 0
            Dim ix3 As Double = 0

            If h = 0 And f = 0 And g = 0 Then

                If DD / AA > 0 Then
                    rx1 = -1 * ((DD / AA) ^ (1 / 3))
                ElseIf DD / AA <= 0 Then
                    rx1 = ((-1 * (DD / AA)) ^ (1 / 3))
                End If

                rx2 = rx1
                rx3 = rx1

            ElseIf h <= 0 Then

                Dim i As Double
                Dim j As Double
                Dim k As Double
                Dim l As Double
                Dim m As Double
                Dim n As Double
                Dim p1 As Double

                i = (((g ^ 2) / 4) - h) ^ 0.5
                j = i ^ (1 / 3)
                k = Math.Acos(-g / (2 * i))
                l = -1 * j
                m = Math.Cos(k / 3)
                n = (3 ^ 0.5) * Math.Sin(k / 3)
                p1 = -BB / (3 * AA)

                rx1 = (2 * j * m) + (p1)
                rx2 = l * (m + n) + p1
                rx3 = l * (m - n) + p1

            ElseIf h > 0 Then

                Dim RR As Double
                Dim SS As Double
                Dim TT As Double
                Dim VV As Double

                RR = -1 * (g / 2) + (h) ^ 0.5
                If RR > 0 Then
                    SS = RR ^ (1 / 3)
                ElseIf RR <= 0 Then
                    SS = ((-1 * RR) ^ (1 / 3)) * -1
                End If

                TT = ((-1 * (g / 2)) - (h ^ 0.5))

                If TT > 0 Then
                    VV = (TT ^ (1 / 3))
                ElseIf TT <= 0 Then
                    TT = -1 * TT
                    VV = -1 * (TT ^ (1 / 3))
                End If
                rx1 = (SS + VV) - (BB / (3 * AA))
                ix1 = 0

                rx2 = -1 * ((SS + VV) / 2) - (BB / (3 * AA))
                ix2 = (SS - VV) * (3 ^ 0.5) / 2

                rx3 = -1 * ((SS + VV) / 2) - (BB / (3 * AA))
                ix3 = -1 * ((SS - VV) * (3 ^ 0.5) / 2)


            End If

            TextBox3.Text = rx1
            TextBox4.Text = ix1
            TextBox5.Text = rx2
            TextBox6.Text = ix2
            TextBox7.Text = rx3
            TextBox8.Text = ix3




            TextBox3.Show()
            TextBox4.Show()
            TextBox5.Show()
            TextBox6.Show()
            TextBox7.Show()
            TextBox8.Show()
            Label8.Show()
            Label7.Show()
            Label6.Show()
            Label13.Show()
            Label12.Show()
            Label10.Show()
            Label11.Show()
            RadioButton1.Show()
            RadioButton2.Show()
            RadioButton3.Show()

         
            End If
        If (Not TextBox6.Text = 0 Or TextBox5.Text < 0) Then
            RadioButton2.Checked = False
            RadioButton2.Hide()
        End If

        If (Not TextBox8.Text = 0 Or TextBox7.Text < 0) Then
            RadioButton3.Checked = False
            RadioButton3.Hide()

        End If


    End Sub




   


    Private Sub AboutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem1.Click
        MessageBox.Show("This tool has been developed by Vineet Kumar Doshi and Rajan Kumar as a project for the course of thermodynamics", "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub HowToUseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HowToUseToolStripMenuItem.Click
        MessageBox.Show("STEP 1" & vbCrLf & " Select an EoS from the drop down list." & vbCrLf & "" & vbCrLf & "STEP 2" & vbCrLf & "  Select a compound from the list box." & vbCrLf & "" & vbCrLf & "STEP 3" & vbCrLf & "  Enter temperature(K) and pressure(bar) and click solve button to get your desired values of volume.", "How To Use", MessageBoxButtons.OK)
    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If Not IsNumeric(TextBox1.Text) Then
            Me.TextBox1.Text = Nothing
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        If Not IsNumeric(TextBox2.Text) Then
            Me.TextBox2.Text = Nothing
        End If

    End Sub

    Private Sub CompressibilityFactorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompressibilityFactorToolStripMenuItem.Click
        If yes = True Then
           
            If (RadioButton2.Checked = True And (Not TextBox6.Text = 0 Or TextBox5.Text < 0)) Or (RadioButton3.Checked = True And (Not TextBox8.Text = 0 Or TextBox7.Text < 0)) Then

                MsgBox("Incorrect volume selected. Please select correct data.", MsgBoxStyle.Critical, "ERROR")

            Else
                Form2.ShowDialog()
                Form2.Button1.Show()

            End If

        Else
            MsgBox("Please check your input before proceeding", MsgBoxStyle.Critical, "ERROR")
        End If

    End Sub

    Public Sub FugacityCoefficientToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FugacityCoefficientToolStripMenuItem.Click

        Dim v As Double
        Dim z As Double
        Dim I As Double
        Dim fc As Double

        If RadioButton1.Checked Then
            v = TextBox3.Text

        ElseIf RadioButton2.Checked Then
            v = TextBox5.Text

        Else
            v = TextBox7.Text

        End If

        z = p * v / (83.14 * t)

        If ComboBox1.SelectedIndex = 0 Then

            I = beta / z

            fc = Math.Exp(z - 1 - Math.Log(z - beta) - (q * I))

            TextBox9.Text = fc


            Form3.ShowDialog()
            Form3.Button1.Show()

        Else


            I = (1 / (sigma - epsilon)) * Math.Log(((R * t * z) + (sigma * p * b)) / ((R * t * z) + (epsilon * p * b)))

            fc = Math.Exp(z - 1 - Math.Log(z - beta) - (q * I))

            TextBox9.Text = fc

            Form3.ShowDialog()
            Form3.Button1.Show()

        End If

    End Sub



    Private Sub HowToUseExtensionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HowToUseExtensionsToolStripMenuItem.Click
        MsgBox("Step 1: Go through the 'How to use section' before learning about extension." & vbCrLf & "" & vbCrLf & "Step 2: Select the any one of the volume(s), obtained after clicking the 'Solve' Button" & vbCrLf & "" & vbCrLf & "STEP 3: Click on 'Extension' box and select the required extension", MsgBoxStyle.Information, "How to use extension")

    End Sub

End Class
