Imports System.Drawing.Drawing2D

Public Class Main

    Private FileName As String = ""
    Private TitleName As String
    Private Modified As Boolean

    Private c As New common

    Private paths As New List(Of Drawing2D.GraphicsPath)

    Private pointMode As Integer = 0

    Private beforeX As Integer
    Private beforeY As Integer

    Private Sub SetTitle()

        Text = My.Application.Info.ProductName + "-" + FileName

    End Sub

    Private Sub ReadFile()

        Dim ofd As New OpenFileDialog

        If CheckFileProcess() = False Then
            Exit Sub
        End If

        Try

            ofd.DefaultExt = "png"
            ofd.Filter = "pngファイル|*.png|すべてのファイル|*.*"
            If ofd.ShowDialog() <> DialogResult.OK Then
                Return
            End If


            FileName = ofd.FileName

            pictureBox.Image = c.LoadFile(FileName)

            SetTitle()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Function CheckFileProcess() As Boolean

        If Modified = True Then
            Dim result As DialogResult = MessageBox.Show(Me, "ファイルは変更されています。" + vbNewLine + "の変更を保存しますか？", TitleName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Dim ret As Boolean
                ret = SaveFile()
                If ret = False Then
                    Return False
                End If
            Else
                If result = DialogResult.Cancel Then
                    Return False
                End If
            End If
        End If

        Return True

    End Function

    Private Function SaveFile() As Boolean


        If FileName = "" Then
            Dim sfd As New SaveFileDialog
            sfd.DefaultExt = "png"
            sfd.Filter = "テキストファイル|*.png|すべてのファイル|*.*"
            If sfd.ShowDialog() <> DialogResult.OK Then
                Return False
            End If
            FileName = sfd.FileName

        End If

        c.SaveFile(FileName, pictureBox)

        Modified = False

        Return True

    End Function

    Private Sub 開くOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 開くOToolStripMenuItem.Click
        ReadFile()
    End Sub

    Private Sub 上書き保存SToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 上書き保存SToolStripMenuItem.Click

    End Sub

    Private Sub 名前を付けて保存AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 名前を付けて保存AToolStripMenuItem.Click

    End Sub

    Private Sub 終了XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 終了XToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub pictureBox_MouseDown(sender As Object, e As MouseEventArgs) Handles pictureBox.MouseDown
        Dim g As Graphics = CreateGraphics()

        Dim path As New Drawing2D.GraphicsPath

        path.AddEllipse(e.X, e.Y, 1, 1)
        paths.Add(path)

        beforeX = e.X
        beforeY = e.Y

        pictureBox.Invalidate()

        pointMode = 1
    End Sub

    Private Sub pictureBox_Paint(sender As Object, e As PaintEventArgs) Handles pictureBox.Paint

        For Each path As Drawing2D.GraphicsPath In paths
            e.Graphics.DrawPath(Pens.Red, path)
        Next

    End Sub

    Private Sub pictureBox_MouseMove(sender As Object, e As MouseEventArgs) Handles pictureBox.MouseMove
        If pointMode = 1 Then
            Dim g As Graphics = CreateGraphics()

            Dim path As New Drawing2D.GraphicsPath

            path.AddLine(beforeX, beforeY, e.X, e.Y)
            paths.Add(path)

            beforeX = e.X
            beforeY = e.Y

            pictureBox.Invalidate()
        End If
    End Sub

    Private Sub pictureBox_MouseUp(sender As Object, e As MouseEventArgs) Handles pictureBox.MouseUp
        pointMode = 0
    End Sub
End Class
