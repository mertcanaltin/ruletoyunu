Public Class Form1 'farklı formlarda gösterir
    Private Hak As SByte = 5 'özel bu formun class ına  özel değişkenler
    Private Puan As Short = 0

    Private Sub OynaButton_Click(sender As Object, e As EventArgs) Handles OynaButton.Click

        If Hak > 0 Then

            Hak -= 1
            HakProgressBar.Value = Hak

            Dim Sans1, Sans2, Sans3 As Integer
            Dim Rast As New Random
            Sans1 = Rast.Next(0, 3)
            Sans2 = Rast.Next(0, 3)
            Sans3 = Rast.Next(0, 3)
            Sans1Button.ImageIndex = Sans1
            Sans2Button.ImageIndex = Sans2
            Sans3Button.ImageIndex = Sans3

            If Sans1 = Sans2 And Sans2 = Sans3 Then

                Puan += (Sans1 + 1) * 3
                PuanLabel.Text = "puanın krdşm " & Puan

            End If

            If Hak <= 0 Then
                If MsgBox("Oyun Hakkınız  Bitti Jeton AT OROSPUÇOCUĞU . Jeton ATTINMI ? BU ARADA PUANIN KRDŞM" & Puan, MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1, "OYUN BİTTİ") = MsgBoxResult.Yes Then

                    Hak = 5
                    Puan = 0 + 100
                    HakProgressBar.Value = Hak
                    PuanLabel.Text = "puanın krdşm " & Puan
                Else
                    Me.Close()


                End If

            End If


        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        HakProgressBar.Maximum = 5
        HakProgressBar.Minimum = 0
        HakProgressBar.Step = 1

        HakProgressBar.Value = 5







    End Sub
End Class
