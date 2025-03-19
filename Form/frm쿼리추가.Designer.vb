<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm쿼리추가
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.t대분류 = New System.Windows.Forms.TextBox()
        Me.t소분류 = New System.Windows.Forms.TextBox()
        Me.t분류 = New System.Windows.Forms.TextBox()
        Me.t타이틀 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.t쿼리 = New System.Windows.Forms.TextBox()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.luDB = New DevExpress.XtraEditors.LookUpEdit()
        Me.t확인내용 = New System.Windows.Forms.TextBox()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.l서버연결 = New DevExpress.XtraEditors.LabelControl()
        Me.l서버연결해제 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.luDB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        't대분류
        '
        Me.t대분류.Location = New System.Drawing.Point(79, 22)
        Me.t대분류.Multiline = True
        Me.t대분류.Name = "t대분류"
        Me.t대분류.Size = New System.Drawing.Size(269, 29)
        Me.t대분류.TabIndex = 0
        '
        't소분류
        '
        Me.t소분류.Location = New System.Drawing.Point(474, 18)
        Me.t소분류.Multiline = True
        Me.t소분류.Name = "t소분류"
        Me.t소분류.Size = New System.Drawing.Size(258, 29)
        Me.t소분류.TabIndex = 2
        '
        't분류
        '
        Me.t분류.Location = New System.Drawing.Point(79, 66)
        Me.t분류.Multiline = True
        Me.t분류.Name = "t분류"
        Me.t분류.Size = New System.Drawing.Size(269, 29)
        Me.t분류.TabIndex = 3
        '
        't타이틀
        '
        Me.t타이틀.Location = New System.Drawing.Point(474, 64)
        Me.t타이틀.Multiline = True
        Me.t타이틀.Name = "t타이틀"
        Me.t타이틀.Size = New System.Drawing.Size(258, 29)
        Me.t타이틀.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("맑은 고딕", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(531, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 25)
        Me.Label4.TabIndex = 8
        '
        't쿼리
        '
        Me.t쿼리.Location = New System.Drawing.Point(79, 165)
        Me.t쿼리.Multiline = True
        Me.t쿼리.Name = "t쿼리"
        Me.t쿼리.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.t쿼리.Size = New System.Drawing.Size(653, 346)
        Me.t쿼리.TabIndex = 10
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.LabelControl6.Appearance.Options.UseBackColor = True
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Appearance.Options.UseForeColor = True
        Me.LabelControl6.Appearance.Options.UseTextOptions = True
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.LabelControl6.LineColor = System.Drawing.Color.Gray
        Me.LabelControl6.Location = New System.Drawing.Point(17, 12)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(59, 22)
        Me.LabelControl6.TabIndex = 465
        Me.LabelControl6.Text = "Database"
        '
        'luDB
        '
        Me.luDB.EditValue = "<Null>"
        Me.luDB.Location = New System.Drawing.Point(82, 12)
        Me.luDB.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.luDB.Name = "luDB"
        Me.luDB.Properties.Appearance.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.luDB.Properties.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.luDB.Properties.Appearance.Options.UseFont = True
        Me.luDB.Properties.Appearance.Options.UseForeColor = True
        Me.luDB.Properties.AppearanceDropDown.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.luDB.Properties.AppearanceDropDown.Options.UseFont = True
        Me.luDB.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luDB.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.luDB.Properties.NullText = ""
        Me.luDB.Properties.PopupWidth = 450
        Me.luDB.Size = New System.Drawing.Size(125, 22)
        Me.luDB.TabIndex = 466
        Me.luDB.ToolTip = "심사대상에 대한 입원정보를 선택합니다."
        Me.luDB.ToolTipTitle = "입원정보"
        '
        't확인내용
        '
        Me.t확인내용.Location = New System.Drawing.Point(79, 109)
        Me.t확인내용.Multiline = True
        Me.t확인내용.Name = "t확인내용"
        Me.t확인내용.Size = New System.Drawing.Size(269, 29)
        Me.t확인내용.TabIndex = 468
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.LabelControl1.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelControl1.ImageOptions.Image = Global.데이터쿼리뷰어.My.Resources.Resources.iconsettrafficlights3_16x16
        Me.LabelControl1.Location = New System.Drawing.Point(9, 31)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(60, 16)
        Me.LabelControl1.TabIndex = 470
        Me.LabelControl1.Text = "      대분류"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.LabelControl2.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelControl2.ImageOptions.Image = Global.데이터쿼리뷰어.My.Resources.Resources.iconsettrafficlights3_16x16
        Me.LabelControl2.Location = New System.Drawing.Point(10, 73)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(48, 16)
        Me.LabelControl2.TabIndex = 471
        Me.LabelControl2.Text = "      분류"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.LabelControl3.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelControl3.ImageOptions.Image = Global.데이터쿼리뷰어.My.Resources.Resources.iconsettrafficlights3_16x16
        Me.LabelControl3.Location = New System.Drawing.Point(397, 27)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(60, 16)
        Me.LabelControl3.TabIndex = 472
        Me.LabelControl3.Text = "      소분류"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.LabelControl4.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelControl4.ImageOptions.Image = Global.데이터쿼리뷰어.My.Resources.Resources.iconsettrafficlights3_16x16
        Me.LabelControl4.Location = New System.Drawing.Point(397, 70)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(60, 16)
        Me.LabelControl4.TabIndex = 473
        Me.LabelControl4.Text = "      타이틀"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.LabelControl7.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelControl7.ImageOptions.Image = Global.데이터쿼리뷰어.My.Resources.Resources.iconsettrafficlights3_16x16
        Me.LabelControl7.Location = New System.Drawing.Point(12, 166)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(48, 16)
        Me.LabelControl7.TabIndex = 475
        Me.LabelControl7.Text = "      쿼리"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.LabelControl5)
        Me.Panel1.Controls.Add(Me.LabelControl7)
        Me.Panel1.Controls.Add(Me.LabelControl4)
        Me.Panel1.Controls.Add(Me.LabelControl3)
        Me.Panel1.Controls.Add(Me.LabelControl2)
        Me.Panel1.Controls.Add(Me.LabelControl1)
        Me.Panel1.Controls.Add(Me.t확인내용)
        Me.Panel1.Controls.Add(Me.t쿼리)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.t타이틀)
        Me.Panel1.Controls.Add(Me.t분류)
        Me.Panel1.Controls.Add(Me.t소분류)
        Me.Panel1.Controls.Add(Me.t대분류)
        Me.Panel1.Location = New System.Drawing.Point(16, 57)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(766, 528)
        Me.Panel1.TabIndex = 476
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.LabelControl5.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelControl5.ImageOptions.Image = Global.데이터쿼리뷰어.My.Resources.Resources.iconsettrafficlights3_16x16
        Me.LabelControl5.Location = New System.Drawing.Point(11, 117)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(48, 16)
        Me.LabelControl5.TabIndex = 476
        Me.LabelControl5.Text = "      확인"
        '
        'l서버연결
        '
        Me.l서버연결.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l서버연결.Appearance.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.l서버연결.Appearance.Options.UseFont = True
        Me.l서버연결.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.l서버연결.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.l서버연결.Location = New System.Drawing.Point(536, 36)
        Me.l서버연결.Name = "l서버연결"
        Me.l서버연결.Size = New System.Drawing.Size(250, 15)
        Me.l서버연결.TabIndex = 477
        Me.l서버연결.Text = "      Now 엔지테크(ng&&t) 서버 Connecting...."
        Me.l서버연결.Visible = False
        '
        'l서버연결해제
        '
        Me.l서버연결해제.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l서버연결해제.Appearance.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.l서버연결해제.Appearance.ForeColor = System.Drawing.Color.Silver
        Me.l서버연결해제.Appearance.Options.UseFont = True
        Me.l서버연결해제.Appearance.Options.UseForeColor = True
        Me.l서버연결해제.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.l서버연결해제.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.l서버연결해제.Location = New System.Drawing.Point(-5, 36)
        Me.l서버연결해제.Name = "l서버연결해제"
        Me.l서버연결해제.Size = New System.Drawing.Size(235, 15)
        Me.l서버연결해제.TabIndex = 478
        Me.l서버연결해제.Text = "      엔지테크(ng&&t) DB Not Connected...."
        '
        'frm쿼리추가
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(798, 606)
        Me.Controls.Add(Me.l서버연결해제)
        Me.Controls.Add(Me.l서버연결)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.luDB)
        Me.Name = "frm쿼리추가"
        Me.Text = "frm쿼리추가"
        CType(Me.luDB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents t대분류 As TextBox
    Friend WithEvents t소분류 As TextBox
    Friend WithEvents t분류 As TextBox
    Friend WithEvents t타이틀 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents t쿼리 As TextBox
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents luDB As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents t확인내용 As TextBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents l서버연결 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents l서버연결해제 As DevExpress.XtraEditors.LabelControl
End Class
