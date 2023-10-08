Option Explicit On

Public Class Main

    Private FileName As String = ""
    Private TitleName As String
    Private Modified As Boolean

    Private c As New common

    Private paths As New List(Of Drawing2D.GraphicsPath)

    Private drawMode As Integer = 0

    Private beforeX As Integer
    Private beforeY As Integer

    Private mode As Integer = 0 '0:点,1:線
    Private mouseClickCount As Integer = 0
    Private submode As Integer = 0 '0:円,1:長方形

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

            Dim image As Image = c.LoadFile(FileName)

            pictureBox.Image = image

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

        c.SaveFile(FileName, pictureBox.Image, paths)

        Modified = False

        Return True

    End Function

    Private Function SaveAsFile() As Boolean

        Dim sfd As New SaveFileDialog
        sfd.FileName = FileName
        sfd.DefaultExt = "png"
        sfd.Filter = "テキストファイル|*.png|すべてのファイル|*.*"
        If sfd.ShowDialog() <> DialogResult.OK Then
            Return False
        End If
        FileName = sfd.FileName

        c.SaveFile(FileName, pictureBox.Image, paths)

        Modified = False

        Return True

    End Function

    Private Sub 開くOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 開くOToolStripMenuItem.Click
        ReadFile()
    End Sub

    Private Sub 上書き保存SToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 上書き保存SToolStripMenuItem.Click
        SaveFile()
    End Sub

    Private Sub 名前を付けて保存AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 名前を付けて保存AToolStripMenuItem.Click
        SaveAsFile()
    End Sub

    Private Sub 終了XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 終了XToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub commonProcess(submode As Integer, e As MouseEventArgs)
        Dim path As New Drawing2D.GraphicsPath

        If mouseClickCount = 0 Or mouseClickCount = 1 Then

            drawMode = 1

            mouseClickCount += 1

            If mouseClickCount = 2 Then

                path = New Drawing2D.GraphicsPath
                If submode = 0 Then
                    path.AddLine(beforeX, beforeY, e.X, e.Y)
                ElseIf submode = 1 Then
                    path.AddArc(beforeX, beforeY, e.X - beforeX, e.Y - beforeY, 0, 360)
                Else
                    Dim rect As Rectangle = New Rectangle(beforeX, beforeY, e.X - beforeX, e.Y - beforeY)
                    path.AddRectangle(rect)
                End If
                paths.Add(path)
                    pictureBox.Invalidate()
                    mouseClickCount = 0
                End If

                beforeX = e.X
            beforeY = e.Y
        End If
    End Sub

    Private Sub pictureBox_MouseDown(sender As Object, e As MouseEventArgs) Handles pictureBox.MouseDown

        Dim path As New Drawing2D.GraphicsPath

        If mode = 0 Then

            path.AddEllipse(e.X, e.Y, 1, 1)
            paths.Add(path)

            beforeX = e.X
            beforeY = e.Y

            pictureBox.Invalidate()

            drawMode = 1

        ElseIf mode = 1 Then

            commonProcess(0, e)

        ElseIf mode = 2 Then

            commonProcess(1, e)

        ElseIf mode = 3 Then

            commonProcess(2, e)
        End If

    End Sub

    Private Sub pictureBox_Paint(sender As Object, e As PaintEventArgs) Handles pictureBox.Paint

        For Each path As Drawing2D.GraphicsPath In paths
            e.Graphics.DrawPath(Pens.Red, path)
        Next

    End Sub

    Private Sub pictureBox_MouseMove(sender As Object, e As MouseEventArgs) Handles pictureBox.MouseMove
        If mode = 0 And drawMode = 1 Then
            Dim g As Graphics = CreateGraphics()

            Dim path As New Drawing2D.GraphicsPath

            path.AddLine(beforeX, beforeY, e.X, e.Y)
            paths.Add(path)

            beforeX = e.X
            beforeY = e.Y

            pictureBox.Invalidate()
        ElseIf mode = 1 And drawMode = 1 Then

        End If
    End Sub

    Private Sub pictureBox_MouseUp(sender As Object, e As MouseEventArgs) Handles pictureBox.MouseUp
        drawMode = 0
    End Sub

    Private Sub 点PToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 点PToolStripMenuItem.Click
        mode = 0
    End Sub

    Private Sub 線LToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 線LToolStripMenuItem.Click
        mode = 1
    End Sub

    Private Sub 円CToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 円CToolStripMenuItem.Click
        mode = 2
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim image As Image = New Bitmap(Me.Width, Me.Height)
        pictureBox.Image = Image
    End Sub

    Private Sub 長方形RToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 長方形RToolStripMenuItem.Click
        mode = 3
    End Sub
End Class
