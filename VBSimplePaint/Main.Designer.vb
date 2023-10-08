<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pictureBox = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ファイルFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.開くOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.上書き保存SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.名前を付けて保存AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.終了XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.pictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pictureBox
        '
        Me.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pictureBox.Location = New System.Drawing.Point(0, 24)
        Me.pictureBox.Name = "pictureBox"
        Me.pictureBox.Size = New System.Drawing.Size(800, 426)
        Me.pictureBox.TabIndex = 0
        Me.pictureBox.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ファイルFToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ファイルFToolStripMenuItem
        '
        Me.ファイルFToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.開くOToolStripMenuItem, Me.上書き保存SToolStripMenuItem, Me.名前を付けて保存AToolStripMenuItem, Me.終了XToolStripMenuItem})
        Me.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem"
        Me.ファイルFToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.ファイルFToolStripMenuItem.Text = "ファイル(&F)"
        '
        '開くOToolStripMenuItem
        '
        Me.開くOToolStripMenuItem.Name = "開くOToolStripMenuItem"
        Me.開くOToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.開くOToolStripMenuItem.Text = "開く(&O)"
        '
        '上書き保存SToolStripMenuItem
        '
        Me.上書き保存SToolStripMenuItem.Name = "上書き保存SToolStripMenuItem"
        Me.上書き保存SToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.上書き保存SToolStripMenuItem.Text = "上書き保存(&S)"
        '
        '名前を付けて保存AToolStripMenuItem
        '
        Me.名前を付けて保存AToolStripMenuItem.Name = "名前を付けて保存AToolStripMenuItem"
        Me.名前を付けて保存AToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.名前を付けて保存AToolStripMenuItem.Text = "名前を付けて保存(&A)"
        '
        '終了XToolStripMenuItem
        '
        Me.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem"
        Me.終了XToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.終了XToolStripMenuItem.Text = "終了(&X)"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pictureBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.Text = "Paint"
        CType(Me.pictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pictureBox As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ファイルFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 開くOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 上書き保存SToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 名前を付けて保存AToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 終了XToolStripMenuItem As ToolStripMenuItem
End Class
