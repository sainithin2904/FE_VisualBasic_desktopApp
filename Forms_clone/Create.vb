Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Imports System.Diagnostics

Public Class Submission
    Public Property Name As String
    Public Property Email As String
    Public Property Phone As String

    <JsonProperty("github_link")>
    Public Property GitHub As String

    Public Property StopwatchTime As String
End Class
Public Class Create
    Private Const apiUrl As String = "http://localhost:3000/submissions"

    Dim tick As Boolean
    Private timer As Boolean = False
    Private Sub Create_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If timer Then
            Timer1.Stop()
            Button2.Text = "Start Stopwatch ( CTRL + T )"
        Else
            Timer1.Start()
            Button2.Text = "Pause Stopwatch ( CTRL + T )"

        End If
        timer = Not timer

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label10.Text = Label10.Text + 1

        If Label10.Text = "60" Then
            Label10.Text = "0"
            Label8.Text = Label8.Text + 1
        End If

        If Label8.Text = "60" Then
            Label8.Text = "0"
            Label6.Text = Label6.Text + 1
        End If

        If Label6.Text = "24" Then
            Label10.Text = "0"
            Label8.Text = "0"
            Label6.Text = "0"
        End If
        If Label6.Text = "60" Then
            Label10.Text = "0"
            Label8.Text = "0"
            Label6.Text = "0"
        End If

    End Sub

    Private Sub Create_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            Button1.PerformClick()


        End If
        If e.Control AndAlso e.KeyCode = Keys.T Then
            Button2.PerformClick()

        End If
    End Sub

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Create the submission object with the form data
        Dim newSubmission As New Submission() With {
            .Name = TextBox1.Text,
            .Email = TextBox2.Text,
            .Phone = TextBox3.Text,
            .GitHub = TextBox4.Text,
            .StopwatchTime = "00:01:23" ' Hardcoded or dynamically set as needed
        }

        ' Debug: Check the Submission object properties
        MsgBox("Submission Data: " & vbCrLf &
               "Name: " & newSubmission.Name & vbCrLf &
               "Email: " & newSubmission.Email & vbCrLf &
               "Phone: " & newSubmission.Phone & vbCrLf &
               "GitHub: " & newSubmission.GitHub & vbCrLf &
               "StopwatchTime: " & newSubmission.StopwatchTime)

        ' Serialize the object to JSON
        Dim jsonContent As String = JsonConvert.SerializeObject(newSubmission)

        ' Debug: Check the serialized JSON
        MsgBox("Serialized JSON: " & jsonContent)

        ' Create the content for the HTTP request
        Dim content = New StringContent(jsonContent, Encoding.UTF8, "application/json")

        Using client As New HttpClient()

            Dim response = Await client.PostAsync("http://localhost:3000/submit", content)

            ' Check the response status
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission saved!")
                Me.Close()
            Else
                Dim errorResponse = Await response.Content.ReadAsStringAsync()
                MessageBox.Show("Error saving submission: " & response.StatusCode & " - " & response.ReasonPhrase & vbCrLf & "Response: " & errorResponse)
            End If
        End Using
    End Sub


End Class
