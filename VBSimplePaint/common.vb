Imports System.IO
Imports System.Text

Public Class common

    Public Function LoadFile(ByVal fileName As String) As Image

        Dim image As Image = Nothing

        Try
            Dim fs As FileStream
            fs = New FileStream(fileName, FileMode.Open, FileAccess.Read)
            image = System.Drawing.Image.FromStream(fs)
            fs.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "LoadFile")
        End Try

        Return image

    End Function

    Public Sub SaveFile(ByVal fileName As String, pic As Image, paths As List(Of Drawing2D.GraphicsPath))

        Try

            Dim g As Graphics = Graphics.FromImage(pic)

            For Each path As Drawing2D.GraphicsPath In paths
                g.DrawPath(Pens.Red, path)
            Next

            pic.Save(fileName)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SaveFile")

        End Try
    End Sub

End Class
