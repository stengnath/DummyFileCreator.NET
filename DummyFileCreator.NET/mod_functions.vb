Module mod_functions
    Private encoding As New System.Text.UTF8Encoding()
    Private crypt As System.Security.Cryptography.Aes
    Public Function calc_file_length(ByVal filesize As Long, ByVal unit As String) As Long
        Select Case unit
            Case "KB"
                calc_file_length = CLng(filesize) * 1024
            Case "MB"
                calc_file_length = CLng(filesize) * 1024 * 1024
            Case "GB"
                calc_file_length = CLng(filesize) * 1024 * 1024 * 1024
            Case Else
                calc_file_length = 0
        End Select
    End Function

    Public Function getRandomValue() As Integer
        Dim myRandom As New System.Random()
        Dim random As String = ""
        Do While True
            For i As Integer = 0 To 15 Step 1
                random = random & Convert.ToChar(myRandom.Next(1, 65535))
            Next
            ObjectHandler.DFC.randomValue = encoding.GetBytes(random)
            random = ""
        Loop
    End Function

    Public Sub killAllThreads()
        killWriteThread()
        killRandomThread()
    End Sub

    Public Sub killWriteThread()
        Try
            If TypeName(myWriteThread) <> "Nothing" Then
                myWriteThread.Abort()
                myWriteThread = Nothing
            End If
        Catch ex As System.Threading.ThreadAbortException
        End Try
    End Sub

    Public Sub killRandomThread()
        Try
            If TypeName(myRandomValueThread) <> "Nothing" Then
                myRandomValueThread.Abort()
                myRandomValueThread = Nothing
            End If
        Catch ex As System.Threading.ThreadAbortException
        End Try
    End Sub

    Public Function getLongerText(ByVal mytext As String, Optional ByVal Count As Integer = 16) As String
        Dim str As String = mytext
        If mytext.Length <= Count Then
            For x As Integer = str.Length To Count
                str = str + mytext
                x = str.Length
            Next
            Return Left(str, Count)
        Else
            Return str
        End If
    End Function

    Public Sub CloseFileStream(ByRef FS As System.IO.FileStream)
        Try
            FS.Close()
        Catch ex As Exception
        End Try
    End Sub
End Module
