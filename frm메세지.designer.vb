<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm메세지
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm메세지))
        Me.l메세지 = New DevExpress.XtraEditors.LabelControl()
        Me.b예 = New DevExpress.XtraEditors.SimpleButton()
        Me.b아니오 = New DevExpress.XtraEditors.SimpleButton()
        Me.b확인 = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'l메세지
        '
        Me.l메세지.AllowHtmlString = True
        Me.l메세지.Appearance.Options.UseTextOptions = True
        Me.l메세지.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.l메세지.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.l메세지.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.l메세지.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.l메세지.LineColor = System.Drawing.Color.Gray
        Me.l메세지.Location = New System.Drawing.Point(93, 4)
        Me.l메세지.Name = "l메세지"
        Me.l메세지.Size = New System.Drawing.Size(692, 109)
        Me.l메세지.TabIndex = 283
        Me.l메세지.Text = "<size=12><red><b>환경설정정보 등록이 완료되었습니다.</b></color><br><br><size=10><black>※ 주의</col" &
    "or>"
        '
        'b예
        '
        Me.b예.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.b예.Appearance.BackColor = System.Drawing.Color.White
        Me.b예.Appearance.BorderColor = System.Drawing.Color.Gray
        Me.b예.Appearance.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.b예.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.b예.Appearance.Options.UseBackColor = True
        Me.b예.Appearance.Options.UseBorderColor = True
        Me.b예.Appearance.Options.UseFont = True
        Me.b예.Appearance.Options.UseForeColor = True
        Me.b예.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.b예.AppearanceHovered.BorderColor = System.Drawing.Color.Red
        Me.b예.AppearanceHovered.Options.UseBackColor = True
        Me.b예.AppearanceHovered.Options.UseBorderColor = True
        Me.b예.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.b예.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b예.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.b예.ImageOptions.Image = CType(resources.GetObject("b예.ImageOptions.Image"), System.Drawing.Image)
        Me.b예.Location = New System.Drawing.Point(558, 115)
        Me.b예.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.b예.Name = "b예"
        Me.b예.Size = New System.Drawing.Size(101, 24)
        Me.b예.TabIndex = 398
        Me.b예.Text = "Yes(&Y)"
        Me.b예.Visible = False
        '
        'b아니오
        '
        Me.b아니오.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.b아니오.Appearance.BackColor = System.Drawing.Color.White
        Me.b아니오.Appearance.BorderColor = System.Drawing.Color.Gray
        Me.b아니오.Appearance.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.b아니오.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.b아니오.Appearance.Options.UseBackColor = True
        Me.b아니오.Appearance.Options.UseBorderColor = True
        Me.b아니오.Appearance.Options.UseFont = True
        Me.b아니오.Appearance.Options.UseForeColor = True
        Me.b아니오.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.b아니오.AppearanceHovered.BorderColor = System.Drawing.Color.Red
        Me.b아니오.AppearanceHovered.Options.UseBackColor = True
        Me.b아니오.AppearanceHovered.Options.UseBorderColor = True
        Me.b아니오.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.b아니오.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b아니오.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.b아니오.ImageOptions.Image = CType(resources.GetObject("b아니오.ImageOptions.Image"), System.Drawing.Image)
        Me.b아니오.Location = New System.Drawing.Point(662, 115)
        Me.b아니오.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.b아니오.Name = "b아니오"
        Me.b아니오.Size = New System.Drawing.Size(101, 24)
        Me.b아니오.TabIndex = 397
        Me.b아니오.Text = "No(&N)"
        Me.b아니오.Visible = False
        '
        'b확인
        '
        Me.b확인.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.b확인.Appearance.BackColor = System.Drawing.Color.White
        Me.b확인.Appearance.BorderColor = System.Drawing.Color.Gray
        Me.b확인.Appearance.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.b확인.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.b확인.Appearance.Options.UseBackColor = True
        Me.b확인.Appearance.Options.UseBorderColor = True
        Me.b확인.Appearance.Options.UseFont = True
        Me.b확인.Appearance.Options.UseForeColor = True
        Me.b확인.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.b확인.AppearanceHovered.BorderColor = System.Drawing.Color.Red
        Me.b확인.AppearanceHovered.Options.UseBackColor = True
        Me.b확인.AppearanceHovered.Options.UseBorderColor = True
        Me.b확인.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.b확인.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b확인.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.b확인.ImageOptions.Image = CType(resources.GetObject("b확인.ImageOptions.Image"), System.Drawing.Image)
        Me.b확인.Location = New System.Drawing.Point(454, 115)
        Me.b확인.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.b확인.Name = "b확인"
        Me.b확인.Size = New System.Drawing.Size(101, 24)
        Me.b확인.TabIndex = 399
        Me.b확인.Text = "OK(&O)"
        Me.b확인.Visible = False
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(15, 21)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Size = New System.Drawing.Size(78, 89)
        Me.PictureEdit1.TabIndex = 400
        Me.PictureEdit1.TabStop = True
        '
        'frm메세지
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(797, 154)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.b확인)
        Me.Controls.Add(Me.b예)
        Me.Controls.Add(Me.b아니오)
        Me.Controls.Add(Me.l메세지)
        Me.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "frm메세지"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "메세지"
        Me.TopMost = True
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents l메세지 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents b예 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents b아니오 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents b확인 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
End Class
