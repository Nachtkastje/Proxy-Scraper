Imports System.IO

Public Class Form1
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        TimeoutLabel.Text = "" + vbCrLf + TrackBar1.Value.ToString()
    End Sub

    Private Sub ScrapeButton_Click(sender As Object, e As EventArgs) Handles ScrapeButton.Click
        Dim str As String = Nothing
        If httpradio.Checked Then
            str = "http"
        ElseIf socks4radio.Checked Then
            str = "socks4"
        ElseIf socks5radio.Checked Then
            str = "socks5"
        End If


        Dim webclient As New Net.WebClient
        Dim proxies As String = webclient.DownloadString(String.Format("https://api.proxyscrape.com?request=displayproxies&proxytype={0}&timeout={1}", str, TrackBar1.Value))
        Threading.Thread.Sleep(500)
        Dim curtime As String = Date.Now.ToString
        curtime = curtime.Replace(":", "-")
        Dim sw As StreamWriter = File.AppendText(String.Format("{0} [Timeout-{1}] [{2}]" & ".txt", str, TrackBar1.Value.ToString, curtime))
        sw.WriteLine(proxies)

        Threading.Thread.Sleep(500)

        Dim result As Integer = MessageBox.Show("Finished scraping proxies" & vbCrLf & "The .txt file is saved in the directory" & vbCrLf & "Although the file has been saved, you still want to open the .txt file?", "Proxy Scraper by EatMyHitzz", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Process.Start(String.Format("{0} [Timeout-{1}] [{2}].txt", str, TrackBar1.Value.ToString, curtime))
        End If
    End Sub

End Class
