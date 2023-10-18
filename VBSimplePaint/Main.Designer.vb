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
        Me.編集EToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.点PToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.線LToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.円CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.長方形RToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.色ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.黒ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.赤ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.黄色ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.pictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pictureBox
        '
        Me.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pictureBox.Location = New System.Drawing.Point(0, 24)
        Me.pictureBox.Name = "pictureBox"
        Me.pictureBox.Size = New System.Drawing.Size(604, 287)
        Me.pictureBox.TabIndex = 0
        Me.pictureBox.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ファイルFToolStripMenuItem, Me.編集EToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(604, 24)
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
        '編集EToolStripMenuItem
        '
        Me.編集EToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.点PToolStripMenuItem, Me.線LToolStripMenuItem, Me.円CToolStripMenuItem, Me.長方形RToolStripMenuItem, Me.色ToolStripMenuItem})
        Me.編集EToolStripMenuItem.Name = "編集EToolStripMenuItem"
        Me.編集EToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.編集EToolStripMenuItem.Text = "編集(&E)"
        '
        '点PToolStripMenuItem
        '
        Me.点PToolStripMenuItem.Name = "点PToolStripMenuItem"
        Me.点PToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.点PToolStripMenuItem.Text = "点(&P)"
        '
        '線LToolStripMenuItem
        '
        Me.線LToolStripMenuItem.Name = "線LToolStripMenuItem"
        Me.線LToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.線LToolStripMenuItem.Text = "線(&L)"
        '
        '円CToolStripMenuItem
        '
        Me.円CToolStripMenuItem.Name = "円CToolStripMenuItem"
        Me.円CToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.円CToolStripMenuItem.Text = "円(&C)"
        '
        '長方形RToolStripMenuItem
        '
        Me.長方形RToolStripMenuItem.Name = "長方形RToolStripMenuItem"
        Me.長方形RToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.長方形RToolStripMenuItem.Text = "長方形(&R)"
        '
        '色ToolStripMenuItem
        '
        Me.色ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.黒ToolStripMenuItem, Me.赤ToolStripMenuItem, Me.黄色ToolStripMenuItem})
        Me.色ToolStripMenuItem.Name = "色ToolStripMenuItem"
        Me.色ToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.色ToolStripMenuItem.Text = "色"
        '
        '黒ToolStripMenuItem
        '
        Me.黒ToolStripMenuItem.Name = "黒ToolStripMenuItem"
        Me.黒ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.黒ToolStripMenuItem.Text = "黒"
        '
        '赤ToolStripMenuItem
        '
        Me.赤ToolStripMenuItem.Name = "赤ToolStripMenuItem"
        Me.赤ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.赤ToolStripMenuItem.Text = "赤"
        '
        '黄色ToolStripMenuItem
        '
        Me.黄色ToolStripMenuItem.Name = "黄色ToolStripMenuItem"
        Me.黄色ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.黄色ToolStripMenuItem.Text = "黄色"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 311)
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
    Friend WithEvents 編集EToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 点PToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 線LToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 円CToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 長方形RToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 色ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 黒ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 赤ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 黄色ToolStripMenuItem As ToolStripMenuItem
End Class
