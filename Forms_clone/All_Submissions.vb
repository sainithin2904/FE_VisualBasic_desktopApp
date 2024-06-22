Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Imports System.Diagnostics

Public Class All_Submissions
    Private Sub All_Submissions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    ' Declare a global index variable
    Private currentIndex As Integer = 0

    Public Class Submission
        Public Property Name As String
        Public Property Email As String
        Public Property Phone As String
        <JsonProperty("github_link")>
        Public Property GitHub As String
        Public Property StopwatchTime As String
    End Class

    Private Sub All_Submissions_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            Button1.PerformClick()
        End If
        If e.Control AndAlso e.KeyCode = Keys.N Then
            Button2.PerformClick()
        End If

    End Sub

    Private Async Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            ' Construct the request URL with the current index
            Dim requestUrl As String = $"http://localhost:3000/read?index={currentIndex}"

            ' Create an HttpClient to send the request
            Using client As New HttpClient()
                ' Send the GET request
                Dim response As HttpResponseMessage = Await client.GetAsync(requestUrl)

                ' Check if the response is successful
                If response.IsSuccessStatusCode Then
                    ' Read the response content
                    Dim responseData As String = Await response.Content.ReadAsStringAsync()

                    ' Deserialize the JSON response into a Submission object
                    Dim submission As Submission = JsonConvert.DeserializeObject(Of Submission)(responseData)

                    ' Display the data in the form's controls
                    TextBox1.Text = submission.Name
                    TextBox2.Text = submission.Email
                    TextBox3.Text = submission.Phone
                    TextBox4.Text = submission.GitHub


                    ' Increment the index for the next click
                    currentIndex += 1
                Else
                    ' Handle unsuccessful response
                    MessageBox.Show("Error retrieving submission: " & response.StatusCode & " - " & response.ReasonPhrase)
                End If
            End Using

        Catch ex As Exception
            ' Handle any exceptions that occur
            MessageBox.Show("Exception occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ' Construct the request URL with the current index
            Dim requestUrl As String = $"http://localhost:3000/read?index={currentIndex}"

            ' Create an HttpClient to send the request
            Using client As New HttpClient()
                ' Send the GET request
                Dim response As HttpResponseMessage = Await client.GetAsync(requestUrl)

                ' Check if the response is successful
                If response.IsSuccessStatusCode Then
                    ' Read the response content
                    Dim responseData As String = Await response.Content.ReadAsStringAsync()

                    ' Deserialize the JSON response into a Submission object
                    Dim submission As Submission = JsonConvert.DeserializeObject(Of Submission)(responseData)

                    ' Display the data in the form's controls
                    TextBox1.Text = submission.Name
                    TextBox2.Text = submission.Email
                    TextBox3.Text = submission.Phone
                    TextBox4.Text = submission.GitHub
                    ' If you have a control for StopwatchTime, display it too

                    ' Increment the index for the next click
                    currentIndex -= 1
                Else
                    ' Handle unsuccessful response
                    MessageBox.Show("Error retrieving submission: " & response.StatusCode & " - " & response.ReasonPhrase)
                End If
            End Using

        Catch ex As Exception
            ' Handle any exceptions that occur
            MessageBox.Show("Exception occurred: " & ex.Message)
        End Try
    End Sub
End Class
