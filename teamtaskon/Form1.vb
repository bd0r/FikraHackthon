Public Class Form1
    Public Function getalive(ByVal l As List(Of Integer)) As List(Of Integer)
start:

        Dim ind As Integer
        Dim temp As List(Of Integer) = New List(Of Integer)

  

        If (l.Count) = 1 Then
            temp = l
            GoTo a
        End If
        If (l.Count) = 2 Then
            temp.Add(l(0))

            GoTo a
        End If
        If (l.Count) = 3 Then
            temp.Add(l(2))

            GoTo a
        End If
        ind = 0
    
b:

        If (l.Count - 1) >= ind + 2 Then
            temp.Add(l(ind))
            ind = ind + 2
            GoTo b
        Else
            If ind + 1 = (l.Count - 1) Then
                temp.Add(l(ind))
                l = temp

                GoTo start

            End If
            If ind = (l.Count - 1) Then
                temp.Add(l(ind))
                temp.RemoveAt(0)
                l = temp

                GoTo start
            End If


        End If




a:

        Return temp

    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim army As New List(Of Integer)
        Dim r As New List(Of Integer)
        Dim i = 1
        Dim len As Integer
        len = Val(TextBox1.Text)
        While (i <= len)
            army.Add(i)
            i = i + 1

        End While
        r = getalive(army)
        Button1.Text = r(0).ToString

     
    End Sub
End Class
