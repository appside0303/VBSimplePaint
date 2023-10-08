Imports System.IO
Imports System.Text

Public Class common

    Public Function LoadFile(ByVal fileName As String) As Image

        Dim image As Image = Nothing

        Try

            image = Image.FromFile(fileName)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "LoadFile")
        End Try

        Return image

    End Function

    Public Sub SaveFile(ByVal fileName As String, pic As PictureBox)

        Try

            Dim image As Image

            image = pic.Image

            image.Save(fileName)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SaveFile")

        End Try
    End Sub

End Class
