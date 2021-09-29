Public Class Form1
    Dim target As Integer
    Dim a1 As Integer = 255 'untuk nilai alpha pada color
    Dim a2 As Integer = 255
    Dim a3 As Integer = 255
    Dim a4 As Integer = 255
    Dim a5 As Integer = 255
    Dim a6 As Integer = 255
    Dim r As Integer = 0
    Dim g As Integer = 0
    Dim b As Integer = 0
    Dim t1 As Integer = 0
    Dim t2 As Integer = 0
    Dim t3 As Integer = 0
    Dim t4 As Integer = 0
    Dim t5 As Integer = 0
    Dim t6 As Integer = 0
    Dim t7 As Integer = 0
    Dim random As Random

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub

    Sub keadaanawal()
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()
        Timer4.Stop()
        Timer5.Stop()
        Timer6.Stop()
        circle1.FillColor = Color.FromArgb(255, 0, 0, 0)
        circle2.FillColor = Color.FromArgb(255, 0, 0, 0)
        circle3.FillColor = Color.FromArgb(255, 0, 0, 0)
        circle4.FillColor = Color.FromArgb(255, 0, 0, 0)
        circle5.FillColor = Color.FromArgb(255, 0, 0, 0)
        circle6.FillColor = Color.FromArgb(255, 0, 0, 0)
        circle1.Enabled = False
        circle2.Enabled = False
        circle3.Enabled = False
        circle4.Enabled = False
        circle5.Enabled = False
        circle6.Enabled = False
        label0.Visible = True
        label0.Text = "Klik START untuk memulai!"
        start.Visible = True
        waktuanda.Visible = False
        penghitungwaktu.Visible = False
        playagain.Visible = False
        penghitungwaktu.Text = 0
        t7 = 0
        a1 = 255
        a2 = 255
        a3 = 255
        a4 = 255
        a5 = 255
        a6 = 255
    End Sub

    Sub acak()
        random = New Random
        target = random.Next(1, 6)

        If target = 1 Then
            Timer1.Start()
        ElseIf target = 2 Then
            Timer2.Start()
        ElseIf target = 3 Then
            Timer3.Start()
        ElseIf target = 4 Then
            Timer4.Start()
        ElseIf target = 5 Then
            Timer5.Start()
        ElseIf target = 6 Then
            Timer6.Start()
        End If
    End Sub

    Private Sub start_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles start.Click
        Call acak()
        Timer7.Start()
        circle1.Enabled = True
        circle2.Enabled = True
        circle3.Enabled = True
        circle4.Enabled = True
        circle5.Enabled = True
        circle6.Enabled = True
        label0.Text = "Silahkan pilih lingkaran yang berbeda warna!"
        start.Visible = False
        penghitungwaktu.Visible = True
        waktuanda.Visible = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As EventArgs) Handles Timer1.Tick
        t1 = t1 + 1
        a1 = a1 - 1
        circle1.FillColor = Color.FromArgb(a1, r, g, b)

        If a1 = 214 Then
            Timer1.Stop()
            t1 = 0
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        t2 = t2 + 1
        a2 = a2 - 1
        circle2.FillColor = Color.FromArgb(a2, r, g, b)

        If a2 = 214 Then
            Timer2.Stop()
            t1 = 0
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        t3 = t3 + 1
        a3 = a3 - 1
        circle3.FillColor = Color.FromArgb(a3, r, g, b)

        If a3 = 214 Then
            Timer3.Stop()
            t1 = 0
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        t4 = t4 + 1
        a4 = a4 - 1
        circle4.FillColor = Color.FromArgb(a4, r, g, b)

        If a4 = 214 Then
            Timer4.Stop()
            t1 = 0
        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        t5 = t5 + 1
        a5 = a5 - 1
        circle5.FillColor = Color.FromArgb(a5, r, g, b)

        If a5 = 214 Then
            Timer5.Stop()
            t1 = 0
        End If
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        t6 = t6 + 1
        a6 = a6 - 1
        circle6.FillColor = Color.FromArgb(a6, r, g, b)

        If a6 = 214 Then
            Timer6.Stop()
            t1 = 0
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call keadaanawal()

    End Sub
    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        t7 = t7 + 1
        penghitungwaktu.Text = t7
    End Sub
    Private Sub circle1_Click(sender As Object, e As EventArgs) Handles circle1.Click
        If a1 = 255 Then
            Form3.Show()
        ElseIf a1 < 255 Then
            Form2.Show()
        End If
        Timer7.Stop()
        playagain.Visible = True
        label0.Text = "Klik PLAY AGAIN untuk memulai!"
    End Sub

    Private Sub circle2_Click(sender As Object, e As EventArgs) Handles circle2.Click
        If a2 = 255 Then
            Form3.Show()
        ElseIf a2 < 255 Then
            Form2.Show()
        End If
        Timer7.Stop()
        playagain.Visible = True
        label0.Text = "Klik PLAY AGAIN untuk memulai!"
    End Sub
    Private Sub circle3_Click(sender As Object, e As EventArgs) Handles circle3.Click
        If a3 = 255 Then
            Form3.Show()
        ElseIf a3 < 255 Then
            Form2.Show()
        End If
        Timer7.Stop()
        playagain.Visible = True
        label0.Text = "Klik PLAY AGAIN untuk memulai!"
    End Sub
    Private Sub circle4_Click(sender As Object, e As EventArgs) Handles circle4.Click
        If a4 = 255 Then
            Form3.Show()
        ElseIf a4 < 255 Then
            Form2.Show()
        End If
        Timer7.Stop()
        playagain.Visible = True
        label0.Text = "Klik PLAY AGAIN untuk memulai!"
    End Sub
    Private Sub circle5_Click(sender As Object, e As EventArgs) Handles circle5.Click
        If a5 = 255 Then
            Form3.Show()
        ElseIf a5 < 255 Then
            Form2.Show()
        End If
        Timer7.Stop()
        playagain.Visible = True
        label0.Text = "Klik PLAY AGAIN untuk memulai!"
    End Sub
    Private Sub circle6_Click(sender As Object, e As EventArgs) Handles circle6.Click
        If a6 = 255 Then
            Form3.Show()
        ElseIf a6 < 255 Then
            Form2.Show()
        End If
        Timer7.Stop()
        playagain.Visible = True
        label0.Text = "Klik PLAY AGAIN untuk memulai!"
    End Sub
    Private Sub playagain_Click(sender As Object, e As EventArgs) Handles playagain.Click
        Call keadaanawal()
    End Sub
End Class