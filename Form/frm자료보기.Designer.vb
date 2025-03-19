<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm자료보기
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm자료보기))
        Dim FlatScrollBarRenderer1 As FarPoint.Win.Spread.FlatScrollBarRenderer = New FarPoint.Win.Spread.FlatScrollBarRenderer()
        Dim NamedStyle1 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("Style1")
        Dim NamedStyle2 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("FilterBarMetallic")
        Dim FilterBarCellType1 As FarPoint.Win.Spread.CellType.FilterBarCellType = New FarPoint.Win.Spread.CellType.FilterBarCellType()
        Dim NamedStyle3 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("ColumnHeaderMetallic")
        Dim EnhancedColumnHeaderRenderer1 As FarPoint.Win.Spread.CellType.EnhancedColumnHeaderRenderer = New FarPoint.Win.Spread.CellType.EnhancedColumnHeaderRenderer()
        Dim NamedStyle4 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("RowHeaderMetallic")
        Dim EnhancedRowHeaderRenderer1 As FarPoint.Win.Spread.CellType.EnhancedRowHeaderRenderer = New FarPoint.Win.Spread.CellType.EnhancedRowHeaderRenderer()
        Dim NamedStyle5 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("CornerMetallic")
        Dim EnhancedCornerRenderer1 As FarPoint.Win.Spread.CellType.EnhancedCornerRenderer = New FarPoint.Win.Spread.CellType.EnhancedCornerRenderer()
        Dim NamedStyle6 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("DataAreaDefault")
        Dim GeneralCellType1 As FarPoint.Win.Spread.CellType.GeneralCellType = New FarPoint.Win.Spread.CellType.GeneralCellType()
        Dim FlatScrollBarRenderer2 As FarPoint.Win.Spread.FlatScrollBarRenderer = New FarPoint.Win.Spread.FlatScrollBarRenderer()
        Dim f결과_InputMapWhenFocusedNormal As FarPoint.Win.Spread.InputMap
        Dim f결과_InputMapWhenFocusedRowMode As FarPoint.Win.Spread.InputMap
        Dim f결과_InputMapWhenAncestorOfFocusedNormal As FarPoint.Win.Spread.InputMap
        Dim f결과_InputMapWhenAncestorOfFocusedRowMode As FarPoint.Win.Spread.InputMap
        Dim TextCellType1 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim TextCellType2 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim TextCellType3 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim TextCellType4 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim TextCellType5 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim TextCellType6 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim TextCellType7 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim TextCellType8 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim TextCellType9 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim NamedStyle7 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("Style1")
        Dim NamedStyle8 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("FilterBarMetallic")
        Dim FilterBarCellType2 As FarPoint.Win.Spread.CellType.FilterBarCellType = New FarPoint.Win.Spread.CellType.FilterBarCellType()
        Dim NamedStyle9 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("ColumnHeaderMetallic")
        Dim EnhancedColumnHeaderRenderer2 As FarPoint.Win.Spread.CellType.EnhancedColumnHeaderRenderer = New FarPoint.Win.Spread.CellType.EnhancedColumnHeaderRenderer()
        Dim NamedStyle10 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("RowHeaderMetallic")
        Dim EnhancedRowHeaderRenderer2 As FarPoint.Win.Spread.CellType.EnhancedRowHeaderRenderer = New FarPoint.Win.Spread.CellType.EnhancedRowHeaderRenderer()
        Dim NamedStyle11 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("CornerMetallic")
        Dim EnhancedCornerRenderer2 As FarPoint.Win.Spread.CellType.EnhancedCornerRenderer = New FarPoint.Win.Spread.CellType.EnhancedCornerRenderer()
        Dim NamedStyle12 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("ColumnHeaderFlatOffice2016White")
        Dim FlatColumnHeaderRenderer1 As FarPoint.Win.Spread.CellType.FlatColumnHeaderRenderer = New FarPoint.Win.Spread.CellType.FlatColumnHeaderRenderer()
        Dim NamedStyle13 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("FilterBarFlatOffice2016White")
        Dim FilterBarCellType3 As FarPoint.Win.Spread.CellType.FilterBarCellType = New FarPoint.Win.Spread.CellType.FilterBarCellType()
        Dim NamedStyle14 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("FilterBarHeaderFlatOffice2016White")
        Dim FlatFilterBarHeaderRenderer1 As FarPoint.Win.Spread.CellType.FlatFilterBarHeaderRenderer = New FarPoint.Win.Spread.CellType.FlatFilterBarHeaderRenderer()
        Dim NamedStyle15 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("ColumnFooterFlatOffice2016White")
        Dim FlatColumnFooterRenderer1 As FarPoint.Win.Spread.CellType.FlatColumnFooterRenderer = New FarPoint.Win.Spread.CellType.FlatColumnFooterRenderer()
        Dim NamedStyle16 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("RowHeaderFlatOffice2016White")
        Dim FlatRowHeaderRenderer1 As FarPoint.Win.Spread.CellType.FlatRowHeaderRenderer = New FarPoint.Win.Spread.CellType.FlatRowHeaderRenderer()
        Dim NamedStyle17 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("CornerHeaderFlatOffice2016White")
        Dim FlatCornerHeaderRenderer1 As FarPoint.Win.Spread.CellType.FlatCornerHeaderRenderer = New FarPoint.Win.Spread.CellType.FlatCornerHeaderRenderer()
        Dim NamedStyle18 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("CornerFooterFlatOffice2016White")
        Dim FlatCornerFooterRenderer1 As FarPoint.Win.Spread.CellType.FlatCornerFooterRenderer = New FarPoint.Win.Spread.CellType.FlatCornerFooterRenderer()
        Dim NamedStyle19 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("DataAreaDefault")
        Dim GeneralCellType2 As FarPoint.Win.Spread.CellType.GeneralCellType = New FarPoint.Win.Spread.CellType.GeneralCellType()
        Dim sprCodes_InputMapWhenFocusedNormal As FarPoint.Win.Spread.InputMap
        Dim sprCodes_InputMapWhenFocusedRowMode As FarPoint.Win.Spread.InputMap
        Dim sprCodes_InputMapWhenAncestorOfFocusedNormal As FarPoint.Win.Spread.InputMap
        Dim sprCodes_InputMapWhenAncestorOfFocusedRowMode As FarPoint.Win.Spread.InputMap
        Dim TextCellType10 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim TextCellType11 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim TextCellType12 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim TextCellType13 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim TextCellType14 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim ComplexBorder1 As FarPoint.Win.ComplexBorder = New FarPoint.Win.ComplexBorder(New FarPoint.Win.ComplexBorderSide(FarPoint.Win.ComplexBorderSideStyle.None))
        Dim TextCellType15 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim TextCellType16 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim TextCellType17 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim TextCellType18 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim NamedStyle20 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("Style1")
        Dim NamedStyle21 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("FilterBarMetallic")
        Dim FilterBarCellType4 As FarPoint.Win.Spread.CellType.FilterBarCellType = New FarPoint.Win.Spread.CellType.FilterBarCellType()
        Dim NamedStyle22 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("ColumnHeaderMetallic")
        Dim EnhancedColumnHeaderRenderer3 As FarPoint.Win.Spread.CellType.EnhancedColumnHeaderRenderer = New FarPoint.Win.Spread.CellType.EnhancedColumnHeaderRenderer()
        Dim NamedStyle23 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("RowHeaderMetallic")
        Dim EnhancedRowHeaderRenderer3 As FarPoint.Win.Spread.CellType.EnhancedRowHeaderRenderer = New FarPoint.Win.Spread.CellType.EnhancedRowHeaderRenderer()
        Dim NamedStyle24 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("CornerMetallic")
        Dim EnhancedCornerRenderer3 As FarPoint.Win.Spread.CellType.EnhancedCornerRenderer = New FarPoint.Win.Spread.CellType.EnhancedCornerRenderer()
        Dim NamedStyle25 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("DataAreaDefault")
        Dim GeneralCellType3 As FarPoint.Win.Spread.CellType.GeneralCellType = New FarPoint.Win.Spread.CellType.GeneralCellType()
        Dim f검색_InputMapWhenFocusedNormal As FarPoint.Win.Spread.InputMap
        Dim f검색_InputMapWhenFocusedRowMode As FarPoint.Win.Spread.InputMap
        Dim f검색_InputMapWhenAncestorOfFocusedNormal As FarPoint.Win.Spread.InputMap
        Dim f검색_InputMapWhenAncestorOfFocusedRowMode As FarPoint.Win.Spread.InputMap
        Dim TextCellType19 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim TextCellType20 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim TextCellType21 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim TextCellType22 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim TextCellType23 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim NamedStyle26 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("Style1")
        Dim NamedStyle27 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("FilterBarMetallic")
        Dim FilterBarCellType5 As FarPoint.Win.Spread.CellType.FilterBarCellType = New FarPoint.Win.Spread.CellType.FilterBarCellType()
        Dim NamedStyle28 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("ColumnHeaderMetallic")
        Dim EnhancedColumnHeaderRenderer4 As FarPoint.Win.Spread.CellType.EnhancedColumnHeaderRenderer = New FarPoint.Win.Spread.CellType.EnhancedColumnHeaderRenderer()
        Dim NamedStyle29 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("RowHeaderMetallic")
        Dim EnhancedRowHeaderRenderer4 As FarPoint.Win.Spread.CellType.EnhancedRowHeaderRenderer = New FarPoint.Win.Spread.CellType.EnhancedRowHeaderRenderer()
        Dim NamedStyle30 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("CornerMetallic")
        Dim EnhancedCornerRenderer4 As FarPoint.Win.Spread.CellType.EnhancedCornerRenderer = New FarPoint.Win.Spread.CellType.EnhancedCornerRenderer()
        Dim NamedStyle31 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("DataAreaDefault")
        Dim GeneralCellType4 As FarPoint.Win.Spread.CellType.GeneralCellType = New FarPoint.Win.Spread.CellType.GeneralCellType()
        Dim f결과sub_InputMapWhenFocusedNormal As FarPoint.Win.Spread.InputMap
        Dim f결과sub_InputMapWhenFocusedRowMode As FarPoint.Win.Spread.InputMap
        Dim f결과sub_InputMapWhenAncestorOfFocusedNormal As FarPoint.Win.Spread.InputMap
        Dim f결과sub_InputMapWhenAncestorOfFocusedRowMode As FarPoint.Win.Spread.InputMap
        Dim TextCellType24 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim TextCellType25 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim TextCellType26 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim TextCellType27 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim TextCellType28 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim TextCellType29 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim TextCellType30 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim TextCellType31 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim TextCellType32 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.t쿼리 = New System.Windows.Forms.TextBox()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.f결과 = New FarPoint.Win.Spread.FpSpread()
        Me.mnu결과 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnu결과엑셀변환 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuPDF출력하기 = New System.Windows.Forms.ToolStripMenuItem()
        Me.f결과_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.l확인방법 = New DevExpress.XtraEditors.LabelControl()
        Me.sprCodes = New FarPoint.Win.Spread.FpSpread()
        Me.sprCodes_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.b검색 = New DevExpress.XtraEditors.SimpleButton()
        Me.f검색 = New FarPoint.Win.Spread.FpSpread()
        Me.f검색_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.t검색어 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.tab쿼리 = New DevExpress.XtraTab.XtraTabControl()
        Me.tabQUERY = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.SplitContainer5 = New System.Windows.Forms.SplitContainer()
        Me.t쿼리sub = New System.Windows.Forms.TextBox()
        Me.f결과sub = New FarPoint.Win.Spread.FpSpread()
        Me.f결과sub_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.b종료 = New DevExpress.XtraEditors.SimpleButton()
        Me.b실행 = New DevExpress.XtraEditors.SimpleButton()
        Me.l서버연결 = New DevExpress.XtraEditors.LabelControl()
        Me.l서버연결해제 = New DevExpress.XtraEditors.LabelControl()
        Me.t챠트번호 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.t처방코드 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.d산출기간2 = New DevExpress.XtraEditors.DateEdit()
        Me.d산출기간1 = New DevExpress.XtraEditors.DateEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.l타이틀 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.t청구일련번호 = New DevExpress.XtraEditors.TextEdit()
        Me.luDB = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.b쿼리추가 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.t수진자명 = New DevExpress.XtraEditors.TextEdit()
        f결과_InputMapWhenFocusedNormal = New FarPoint.Win.Spread.InputMap()
        f결과_InputMapWhenFocusedRowMode = New FarPoint.Win.Spread.InputMap()
        f결과_InputMapWhenAncestorOfFocusedNormal = New FarPoint.Win.Spread.InputMap()
        f결과_InputMapWhenAncestorOfFocusedRowMode = New FarPoint.Win.Spread.InputMap()
        sprCodes_InputMapWhenFocusedNormal = New FarPoint.Win.Spread.InputMap()
        sprCodes_InputMapWhenFocusedRowMode = New FarPoint.Win.Spread.InputMap()
        sprCodes_InputMapWhenAncestorOfFocusedNormal = New FarPoint.Win.Spread.InputMap()
        sprCodes_InputMapWhenAncestorOfFocusedRowMode = New FarPoint.Win.Spread.InputMap()
        f검색_InputMapWhenFocusedNormal = New FarPoint.Win.Spread.InputMap()
        f검색_InputMapWhenFocusedRowMode = New FarPoint.Win.Spread.InputMap()
        f검색_InputMapWhenAncestorOfFocusedNormal = New FarPoint.Win.Spread.InputMap()
        f검색_InputMapWhenAncestorOfFocusedRowMode = New FarPoint.Win.Spread.InputMap()
        f결과sub_InputMapWhenFocusedNormal = New FarPoint.Win.Spread.InputMap()
        f결과sub_InputMapWhenFocusedRowMode = New FarPoint.Win.Spread.InputMap()
        f결과sub_InputMapWhenAncestorOfFocusedNormal = New FarPoint.Win.Spread.InputMap()
        f결과sub_InputMapWhenAncestorOfFocusedRowMode = New FarPoint.Win.Spread.InputMap()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.f결과, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnu결과.SuspendLayout()
        CType(Me.f결과_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        CType(Me.sprCodes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sprCodes_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.f검색, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.f검색_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t검색어.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tab쿼리, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab쿼리.SuspendLayout()
        Me.tabQUERY.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer5.Panel1.SuspendLayout()
        Me.SplitContainer5.Panel2.SuspendLayout()
        Me.SplitContainer5.SuspendLayout()
        CType(Me.f결과sub, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.f결과sub_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t챠트번호.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t처방코드.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.d산출기간2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.d산출기간2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.d산출기간1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.d산출기간1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t청구일련번호.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luDB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t수진자명.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.LightGray
        resources.ApplyResources(Me.SplitContainer1, "SplitContainer1")
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel1.Controls.Add(Me.t쿼리)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer3)
        '
        't쿼리
        '
        resources.ApplyResources(Me.t쿼리, "t쿼리")
        Me.t쿼리.Name = "t쿼리"
        Me.t쿼리.TabStop = False
        '
        'SplitContainer3
        '
        Me.SplitContainer3.BackColor = System.Drawing.Color.LightGray
        resources.ApplyResources(Me.SplitContainer3, "SplitContainer3")
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer3.Panel1.Controls.Add(Me.f결과)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.BackColor = System.Drawing.Color.White
        Me.SplitContainer3.Panel2.Controls.Add(Me.SplitContainer4)
        '
        'f결과
        '
        resources.ApplyResources(Me.f결과, "f결과")
        Me.f결과.AllowColumnMove = True
        Me.f결과.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.f결과.ButtonDrawMode = CType((FarPoint.Win.Spread.ButtonDrawModes.CurrentCell Or FarPoint.Win.Spread.ButtonDrawModes.CurrentColumn), FarPoint.Win.Spread.ButtonDrawModes)
        Me.f결과.ContextMenuStrip = Me.mnu결과
        Me.f결과.EditModeReplace = True
        Me.f결과.HorizontalScrollBar.Buttons = New FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton")
        Me.f결과.HorizontalScrollBar.Name = ""
        FlatScrollBarRenderer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.f결과.HorizontalScrollBar.Renderer = FlatScrollBarRenderer1
        Me.f결과.Name = "f결과"
        NamedStyle1.BackColor = System.Drawing.Color.Empty
        NamedStyle1.ForeColor = System.Drawing.Color.Empty
        NamedStyle2.BackColor = System.Drawing.Color.Silver
        FilterBarCellType1.FormatString = ""
        NamedStyle2.CellType = FilterBarCellType1
        NamedStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        NamedStyle2.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        NamedStyle2.Renderer = FilterBarCellType1
        NamedStyle2.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle3.BackColor = System.Drawing.Color.Silver
        NamedStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        NamedStyle3.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        EnhancedColumnHeaderRenderer1.ActiveBackgroundColor = System.Drawing.Color.DarkGray
        EnhancedColumnHeaderRenderer1.BackColor = System.Drawing.Color.Empty
        EnhancedColumnHeaderRenderer1.BackColor2 = System.Drawing.Color.Empty
        EnhancedColumnHeaderRenderer1.DarkColor = System.Drawing.Color.Empty
        EnhancedColumnHeaderRenderer1.Font = Nothing
        EnhancedColumnHeaderRenderer1.ForeColor = System.Drawing.Color.Empty
        EnhancedColumnHeaderRenderer1.HorizontalAlignment = FarPoint.Win.HorizontalAlignment.Left
        EnhancedColumnHeaderRenderer1.LightColor = System.Drawing.Color.Empty
        EnhancedColumnHeaderRenderer1.Name = Nothing
        EnhancedColumnHeaderRenderer1.NormalGridLineColor = System.Drawing.Color.DarkGray
        EnhancedColumnHeaderRenderer1.SelectedActiveBackgroundColor = System.Drawing.Color.DarkGray
        EnhancedColumnHeaderRenderer1.SelectedBackgroundColor = System.Drawing.Color.Gray
        EnhancedColumnHeaderRenderer1.SelectedGridLineColor = System.Drawing.Color.DimGray
        EnhancedColumnHeaderRenderer1.TextRotationAngle = 0R
        EnhancedColumnHeaderRenderer1.VerticalAlignment = FarPoint.Win.VerticalAlignment.Top
        NamedStyle3.Renderer = EnhancedColumnHeaderRenderer1
        NamedStyle3.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle4.BackColor = System.Drawing.Color.Silver
        NamedStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        NamedStyle4.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        EnhancedRowHeaderRenderer1.ActiveBackgroundColor = System.Drawing.Color.DarkGray
        EnhancedRowHeaderRenderer1.BackColor = System.Drawing.Color.Empty
        EnhancedRowHeaderRenderer1.BackColor2 = System.Drawing.Color.Empty
        EnhancedRowHeaderRenderer1.DarkColor = System.Drawing.Color.Empty
        EnhancedRowHeaderRenderer1.Font = Nothing
        EnhancedRowHeaderRenderer1.ForeColor = System.Drawing.Color.Empty
        EnhancedRowHeaderRenderer1.HorizontalAlignment = FarPoint.Win.HorizontalAlignment.Left
        EnhancedRowHeaderRenderer1.LightColor = System.Drawing.Color.Empty
        EnhancedRowHeaderRenderer1.Name = Nothing
        EnhancedRowHeaderRenderer1.NormalGridLineColor = System.Drawing.Color.DarkGray
        EnhancedRowHeaderRenderer1.SelectedActiveBackgroundColor = System.Drawing.Color.DarkGray
        EnhancedRowHeaderRenderer1.SelectedBackgroundColor = System.Drawing.Color.Gray
        EnhancedRowHeaderRenderer1.SelectedGridLineColor = System.Drawing.Color.DimGray
        EnhancedRowHeaderRenderer1.TextRotationAngle = 0R
        EnhancedRowHeaderRenderer1.VerticalAlignment = FarPoint.Win.VerticalAlignment.Top
        NamedStyle4.Renderer = EnhancedRowHeaderRenderer1
        NamedStyle4.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle5.BackColor = System.Drawing.Color.DimGray
        NamedStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        NamedStyle5.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        EnhancedCornerRenderer1.ActiveBackgroundColor = System.Drawing.Color.Gray
        EnhancedCornerRenderer1.GridLineColor = System.Drawing.Color.Empty
        EnhancedCornerRenderer1.NormalBackgroundColor = System.Drawing.Color.DarkGray
        NamedStyle5.Renderer = EnhancedCornerRenderer1
        NamedStyle5.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle6.BackColor = System.Drawing.Color.Empty
        NamedStyle6.CellType = GeneralCellType1
        NamedStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        NamedStyle6.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        NamedStyle6.Renderer = GeneralCellType1
        NamedStyle6.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.f결과.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.f결과_Sheet1})
        Me.f결과.Skin = FarPoint.Win.Spread.DefaultSpreadSkins.Office2016White
        Me.f결과.NamedStyles.AddRange(New FarPoint.Win.Spread.NamedStyle() {NamedStyle1, NamedStyle2, NamedStyle3, NamedStyle4, NamedStyle5, NamedStyle6})
        Me.f결과.TitleInfo.BackColor = System.Drawing.Color.Blue
        Me.f결과.TitleInfo.Value = ""
        Me.f결과.VerticalScrollBar.Buttons = New FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton")
        Me.f결과.VerticalScrollBar.Name = ""
        FlatScrollBarRenderer2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.f결과.VerticalScrollBar.Renderer = FlatScrollBarRenderer2
        f결과_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StopEditing)
        f결과_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumn)
        f결과_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Left, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumn)
        f결과_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousRow)
        f결과_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextRow)
        f결과_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Home, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToFirstColumn)
        f결과_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[End], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToLastColumn)
        f결과_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.PageUp, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousPageOfRows)
        f결과_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Next], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextPageOfRows)
        f결과_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F3, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StopEditing)
        f결과_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Back, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StartEditing)
        Me.f결과.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenFocused, FarPoint.Win.Spread.OperationMode.Normal, f결과_InputMapWhenFocusedNormal)
        f결과_InputMapWhenFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(Global.Microsoft.VisualBasic.ChrW(61)), FarPoint.Win.Spread.SpreadActions.StartEditingFormula)
        f결과_InputMapWhenFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ComboShowList)
        f결과_InputMapWhenFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ComboShowList)
        f결과_InputMapWhenFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F4, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.ShowSubEditor)
        f결과_InputMapWhenFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Z, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.Undo)
        f결과_InputMapWhenFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Y, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.Redo)
        Me.f결과.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenFocused, FarPoint.Win.Spread.OperationMode.RowMode, f결과_InputMapWhenFocusedRowMode)
        f결과_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StopEditing)
        f결과_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Home, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToFirstColumn)
        f결과_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[End], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToLastColumn)
        f결과_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumn)
        f결과_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.PageUp, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousPageOfRows)
        f결과_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Next], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextPageOfRows)
        f결과_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F3, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StopEditing)
        f결과_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Back, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StartEditing)
        f결과_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousRow)
        f결과_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextRow)
        f결과_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Left, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumn)
        Me.f결과.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenAncestorOfFocused, FarPoint.Win.Spread.OperationMode.Normal, f결과_InputMapWhenAncestorOfFocusedNormal)
        f결과_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousRow)
        f결과_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextRow)
        f결과_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Left, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumnVisual)
        f결과_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnVisual)
        f결과_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToPreviousRow)
        f결과_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToNextRow)
        f결과_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Left, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumnVisual)
        f결과_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Right, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnVisual)
        f결과_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.PageUp, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousPageOfRows)
        f결과_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Next], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextPageOfRows)
        f결과_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.PageUp, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToPreviousPageOfColumns)
        f결과_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Next], CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToNextPageOfColumns)
        f결과_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Home, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToFirstColumn)
        f결과_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[End], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToLastColumn)
        f결과_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Home, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToFirstCell)
        f결과_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[End], CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToLastCell)
        f결과_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Escape, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.CancelEditing)
        f결과_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StopEditing)
        f결과_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.CSEStopEditing)
        f결과_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Tab, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        f결과_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Tab, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumnWrap)
        f결과_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.ClearCell)
        f결과_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F4, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.ShowSubEditor)
        f결과_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ComboShowList)
        f결과_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ComboShowList)
        Me.f결과.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenAncestorOfFocused, FarPoint.Win.Spread.OperationMode.RowMode, f결과_InputMapWhenAncestorOfFocusedRowMode)
        Me.f결과.SetViewportLeftColumn(0, 0, 6)
        Me.f결과.SetActiveViewport(0, 0, -1)
        '
        'mnu결과
        '
        Me.mnu결과.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu결과엑셀변환, Me.ToolStripSeparator1, Me.mnuPDF출력하기})
        Me.mnu결과.Name = "mnu처방"
        resources.ApplyResources(Me.mnu결과, "mnu결과")
        '
        'mnu결과엑셀변환
        '
        Me.mnu결과엑셀변환.ForeColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.mnu결과엑셀변환, "mnu결과엑셀변환")
        Me.mnu결과엑셀변환.Name = "mnu결과엑셀변환"
        Me.mnu결과엑셀변환.Tag = "  "
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        '
        'mnuPDF출력하기
        '
        Me.mnuPDF출력하기.Name = "mnuPDF출력하기"
        resources.ApplyResources(Me.mnuPDF출력하기, "mnuPDF출력하기")
        '
        'f결과_Sheet1
        '
        Me.f결과_Sheet1.Reset()
        Me.f결과_Sheet1.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.f결과_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.f결과_Sheet1.ColumnCount = 9
        Me.f결과_Sheet1.RowCount = 50
        Me.f결과_Sheet1.ActiveSkin = FarPoint.Win.Spread.DefaultSkins.Default
        Me.f결과_Sheet1.AlternatingRows.Get(1).BackColor = System.Drawing.Color.WhiteSmoke
        Me.f결과_Sheet1.Cells.Get(0, 0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        Me.f결과_Sheet1.Cells.Get(0, 0).Value = "2021-06"
        Me.f결과_Sheet1.Cells.Get(0, 0).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.f결과_Sheet1.Cells.Get(0, 1).Value = "15:00"
        Me.f결과_Sheet1.Cells.Get(0, 2).Value = 12
        Me.f결과_Sheet1.Cells.Get(0, 4).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        Me.f결과_Sheet1.Cells.Get(0, 4).Value = "2020-04-05"
        Me.f결과_Sheet1.Cells.Get(0, 4).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.f결과_Sheet1.Cells.Get(1, 0).Value = "31204996"
        Me.f결과_Sheet1.ColumnFooter.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.f결과_Sheet1.ColumnFooter.DefaultStyle.BackColor = System.Drawing.Color.Empty
        Me.f결과_Sheet1.ColumnFooter.DefaultStyle.ForeColor = System.Drawing.Color.Empty
        Me.f결과_Sheet1.ColumnFooter.DefaultStyle.Locked = False
        Me.f결과_Sheet1.ColumnFooter.DefaultStyle.Parent = "ColumnFooterFlatOffice2016White"
        Me.f결과_Sheet1.ColumnFooter.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.f결과_Sheet1.ColumnFooter.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.f결과_Sheet1.ColumnFooterSheetCornerStyle.BackColor = System.Drawing.Color.Empty
        Me.f결과_Sheet1.ColumnFooterSheetCornerStyle.ForeColor = System.Drawing.Color.Empty
        Me.f결과_Sheet1.ColumnFooterSheetCornerStyle.Locked = False
        Me.f결과_Sheet1.ColumnFooterSheetCornerStyle.Parent = "CornerFooterFlatOffice2016White"
        Me.f결과_Sheet1.ColumnFooterSheetCornerStyle.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.f결과_Sheet1.ColumnHeader.AutoText = FarPoint.Win.Spread.HeaderAutoText.Numbers
        Me.f결과_Sheet1.ColumnHeader.Cells.Get(0, 0).Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.f결과_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "내원일"
        Me.f결과_Sheet1.ColumnHeader.Cells.Get(0, 1).Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.f결과_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "내원시각"
        Me.f결과_Sheet1.ColumnHeader.Cells.Get(0, 2).Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.f결과_Sheet1.ColumnHeader.Cells.Get(0, 2).Value = "연령"
        Me.f결과_Sheet1.ColumnHeader.Cells.Get(0, 3).Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.f결과_Sheet1.ColumnHeader.Cells.Get(0, 3).Value = "외/입"
        Me.f결과_Sheet1.ColumnHeader.Cells.Get(0, 4).Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.f결과_Sheet1.ColumnHeader.Cells.Get(0, 4).Tag = "HIDDEN"
        Me.f결과_Sheet1.ColumnHeader.Cells.Get(0, 4).Value = "진료과"
        Me.f결과_Sheet1.ColumnHeader.Cells.Get(0, 5).Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.f결과_Sheet1.ColumnHeader.Cells.Get(0, 5).Value = "진료의"
        Me.f결과_Sheet1.ColumnHeader.Cells.Get(0, 6).Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.f결과_Sheet1.ColumnHeader.Cells.Get(0, 6).Value = "초재구분"
        Me.f결과_Sheet1.ColumnHeader.Cells.Get(0, 7).Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.f결과_Sheet1.ColumnHeader.Cells.Get(0, 7).Value = "M/S"
        Me.f결과_Sheet1.ColumnHeader.Cells.Get(0, 8).Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.f결과_Sheet1.ColumnHeader.Cells.Get(0, 8).Value = "비 고"
        Me.f결과_Sheet1.ColumnHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.f결과_Sheet1.ColumnHeader.DefaultStyle.BackColor = System.Drawing.Color.Empty
        Me.f결과_Sheet1.ColumnHeader.DefaultStyle.ForeColor = System.Drawing.Color.Empty
        Me.f결과_Sheet1.ColumnHeader.DefaultStyle.Locked = False
        Me.f결과_Sheet1.ColumnHeader.DefaultStyle.Parent = "ColumnHeaderFlatOffice2016White"
        Me.f결과_Sheet1.ColumnHeader.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.f결과_Sheet1.ColumnHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.f결과_Sheet1.ColumnHeader.Rows.Get(0).Height = 26.0!
        Me.f결과_Sheet1.Columns.Get(0).CellType = TextCellType1
        Me.f결과_Sheet1.Columns.Get(0).Font = New System.Drawing.Font("맑은 고딕", 9.0!)
        Me.f결과_Sheet1.Columns.Get(0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        Me.f결과_Sheet1.Columns.Get(0).Label = "내원일"
        Me.f결과_Sheet1.Columns.Get(0).Locked = True
        Me.f결과_Sheet1.Columns.Get(0).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.f결과_Sheet1.Columns.Get(0).Width = 79.0!
        Me.f결과_Sheet1.Columns.Get(1).CellType = TextCellType2
        Me.f결과_Sheet1.Columns.Get(1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.f결과_Sheet1.Columns.Get(1).Label = "내원시각"
        Me.f결과_Sheet1.Columns.Get(1).Locked = True
        Me.f결과_Sheet1.Columns.Get(1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.f결과_Sheet1.Columns.Get(2).CellType = TextCellType3
        Me.f결과_Sheet1.Columns.Get(2).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.f결과_Sheet1.Columns.Get(2).Label = "연령"
        Me.f결과_Sheet1.Columns.Get(2).Locked = True
        Me.f결과_Sheet1.Columns.Get(2).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.f결과_Sheet1.Columns.Get(2).Visible = False
        Me.f결과_Sheet1.Columns.Get(2).Width = 56.0!
        Me.f결과_Sheet1.Columns.Get(3).CellType = TextCellType4
        Me.f결과_Sheet1.Columns.Get(3).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.f결과_Sheet1.Columns.Get(3).Label = "외/입"
        Me.f결과_Sheet1.Columns.Get(3).Locked = True
        Me.f결과_Sheet1.Columns.Get(3).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.f결과_Sheet1.Columns.Get(3).Width = 43.0!
        Me.f결과_Sheet1.Columns.Get(4).CellType = TextCellType5
        Me.f결과_Sheet1.Columns.Get(4).Font = New System.Drawing.Font("맑은 고딕", 9.0!)
        Me.f결과_Sheet1.Columns.Get(4).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.f결과_Sheet1.Columns.Get(4).Label = "진료과"
        Me.f결과_Sheet1.Columns.Get(4).Locked = True
        Me.f결과_Sheet1.Columns.Get(4).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.f결과_Sheet1.Columns.Get(4).Width = 67.0!
        Me.f결과_Sheet1.Columns.Get(5).CellType = TextCellType6
        Me.f결과_Sheet1.Columns.Get(5).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.f결과_Sheet1.Columns.Get(5).Label = "진료의"
        Me.f결과_Sheet1.Columns.Get(5).Locked = True
        Me.f결과_Sheet1.Columns.Get(5).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.f결과_Sheet1.Columns.Get(5).Width = 67.0!
        Me.f결과_Sheet1.Columns.Get(6).CellType = TextCellType7
        Me.f결과_Sheet1.Columns.Get(6).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.f결과_Sheet1.Columns.Get(6).Label = "초재구분"
        Me.f결과_Sheet1.Columns.Get(6).Locked = True
        Me.f결과_Sheet1.Columns.Get(6).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.f결과_Sheet1.Columns.Get(6).Visible = False
        Me.f결과_Sheet1.Columns.Get(6).Width = 94.0!
        Me.f결과_Sheet1.Columns.Get(7).CellType = TextCellType8
        Me.f결과_Sheet1.Columns.Get(7).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.f결과_Sheet1.Columns.Get(7).Label = "M/S"
        Me.f결과_Sheet1.Columns.Get(7).Locked = True
        Me.f결과_Sheet1.Columns.Get(7).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.f결과_Sheet1.Columns.Get(8).CellType = TextCellType9
        Me.f결과_Sheet1.Columns.Get(8).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        Me.f결과_Sheet1.Columns.Get(8).Label = "비 고"
        Me.f결과_Sheet1.Columns.Get(8).Locked = True
        Me.f결과_Sheet1.Columns.Get(8).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.f결과_Sheet1.Columns.Get(8).Width = 354.0!
        Me.f결과_Sheet1.DefaultStyle.BackColor = System.Drawing.Color.Empty
        Me.f결과_Sheet1.DefaultStyle.ForeColor = System.Drawing.Color.Empty
        Me.f결과_Sheet1.DefaultStyle.Locked = False
        Me.f결과_Sheet1.DefaultStyle.Parent = "DataAreaDefault"
        Me.f결과_Sheet1.FilterBar.DefaultStyle.BackColor = System.Drawing.Color.Empty
        Me.f결과_Sheet1.FilterBar.DefaultStyle.ForeColor = System.Drawing.Color.Empty
        Me.f결과_Sheet1.FilterBar.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.f결과_Sheet1.FilterBar.DefaultStyle.Locked = False
        Me.f결과_Sheet1.FilterBar.DefaultStyle.Parent = "FilterBarFlatOffice2016White"
        Me.f결과_Sheet1.FilterBar.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.f결과_Sheet1.FilterBar.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.f결과_Sheet1.FilterBarHeaderStyle.BackColor = System.Drawing.Color.Empty
        Me.f결과_Sheet1.FilterBarHeaderStyle.ForeColor = System.Drawing.Color.Empty
        Me.f결과_Sheet1.FilterBarHeaderStyle.Locked = False
        Me.f결과_Sheet1.FilterBarHeaderStyle.Parent = "FilterBarHeaderFlatOffice2016White"
        Me.f결과_Sheet1.FilterBarHeaderStyle.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.f결과_Sheet1.FrozenColumnCount = 6
        Me.f결과_Sheet1.GrayAreaBackColor = System.Drawing.Color.White
        Me.f결과_Sheet1.HorizontalGridLine = New FarPoint.Win.Spread.GridLine(FarPoint.Win.Spread.GridLineType.Flat, System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(208, Byte), Integer)))
        Me.f결과_Sheet1.OperationMode = FarPoint.Win.Spread.OperationMode.RowMode
        Me.f결과_Sheet1.Protect = True
        Me.f결과_Sheet1.RowHeader.Columns.Default.Resizable = False
        Me.f결과_Sheet1.RowHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.f결과_Sheet1.RowHeader.DefaultStyle.BackColor = System.Drawing.Color.Empty
        Me.f결과_Sheet1.RowHeader.DefaultStyle.ForeColor = System.Drawing.Color.Empty
        Me.f결과_Sheet1.RowHeader.DefaultStyle.Locked = False
        Me.f결과_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderFlatOffice2016White"
        Me.f결과_Sheet1.RowHeader.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.f결과_Sheet1.RowHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.f결과_Sheet1.Rows.Get(0).Height = 22.0!
        Me.f결과_Sheet1.Rows.Get(1).Height = 22.0!
        Me.f결과_Sheet1.Rows.Get(2).Height = 22.0!
        Me.f결과_Sheet1.Rows.Get(3).Height = 22.0!
        Me.f결과_Sheet1.Rows.Get(4).Height = 22.0!
        Me.f결과_Sheet1.Rows.Get(5).Height = 22.0!
        Me.f결과_Sheet1.Rows.Get(6).Height = 22.0!
        Me.f결과_Sheet1.Rows.Get(7).Height = 22.0!
        Me.f결과_Sheet1.Rows.Get(8).Height = 22.0!
        Me.f결과_Sheet1.Rows.Get(9).Height = 22.0!
        Me.f결과_Sheet1.Rows.Get(10).Height = 22.0!
        Me.f결과_Sheet1.Rows.Get(11).Height = 22.0!
        Me.f결과_Sheet1.Rows.Get(12).Height = 22.0!
        Me.f결과_Sheet1.Rows.Get(13).Height = 22.0!
        Me.f결과_Sheet1.SelectionBackColor = System.Drawing.Color.Transparent
        Me.f결과_Sheet1.SelectionStyle = FarPoint.Win.Spread.SelectionStyles.Both
        Me.f결과_Sheet1.SheetCornerStyle.BackColor = System.Drawing.Color.Empty
        Me.f결과_Sheet1.SheetCornerStyle.ForeColor = System.Drawing.Color.Empty
        Me.f결과_Sheet1.SheetCornerStyle.Locked = False
        Me.f결과_Sheet1.SheetCornerStyle.Parent = "CornerHeaderFlatOffice2016White"
        Me.f결과_Sheet1.SheetCornerStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.f결과_Sheet1.SheetCornerStyle.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.f결과_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'SplitContainer4
        '
        Me.SplitContainer4.BackColor = System.Drawing.Color.LightGray
        resources.ApplyResources(Me.SplitContainer4, "SplitContainer4")
        Me.SplitContainer4.Name = "SplitContainer4"
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer4.Panel1.Controls.Add(Me.LabelControl8)
        Me.SplitContainer4.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer4.Panel1.Controls.Add(Me.l확인방법)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.BackColor = System.Drawing.Color.White
        Me.SplitContainer4.Panel2.Controls.Add(Me.sprCodes)
        Me.SplitContainer4.Panel2.Controls.Add(Me.Panel2)
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = CType(resources.GetObject("LabelControl8.Appearance.Font"), System.Drawing.Font)
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.ImageOptions.Alignment = System.Drawing.ContentAlignment.BottomLeft
        Me.LabelControl8.ImageOptions.Image = Global.데이터쿼리뷰어.My.Resources.Resources.cancel_16x16
        resources.ApplyResources(Me.LabelControl8, "LabelControl8")
        Me.LabelControl8.Name = "LabelControl8"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'l확인방법
        '
        resources.ApplyResources(Me.l확인방법, "l확인방법")
        Me.l확인방법.Appearance.Font = CType(resources.GetObject("l확인방법.Appearance.Font"), System.Drawing.Font)
        Me.l확인방법.Appearance.Options.UseFont = True
        Me.l확인방법.Name = "l확인방법"
        '
        'sprCodes
        '
        resources.ApplyResources(Me.sprCodes, "sprCodes")
        Me.sprCodes.AllowColumnMove = True
        Me.sprCodes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sprCodes.ButtonDrawMode = CType((FarPoint.Win.Spread.ButtonDrawModes.CurrentCell Or FarPoint.Win.Spread.ButtonDrawModes.CurrentColumn), FarPoint.Win.Spread.ButtonDrawModes)
        Me.sprCodes.ContextMenuStrip = Me.mnu결과
        Me.sprCodes.EditModeReplace = True
        Me.sprCodes.Name = "sprCodes"
        NamedStyle7.BackColor = System.Drawing.Color.Empty
        NamedStyle7.ForeColor = System.Drawing.Color.Empty
        NamedStyle8.BackColor = System.Drawing.Color.Silver
        FilterBarCellType2.FormatString = ""
        NamedStyle8.CellType = FilterBarCellType2
        NamedStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        NamedStyle8.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        NamedStyle8.Renderer = FilterBarCellType2
        NamedStyle8.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle9.BackColor = System.Drawing.Color.Silver
        NamedStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        NamedStyle9.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        EnhancedColumnHeaderRenderer2.ActiveBackgroundColor = System.Drawing.Color.DarkGray
        EnhancedColumnHeaderRenderer2.BackColor = System.Drawing.Color.Empty
        EnhancedColumnHeaderRenderer2.BackColor2 = System.Drawing.Color.Empty
        EnhancedColumnHeaderRenderer2.DarkColor = System.Drawing.Color.Empty
        EnhancedColumnHeaderRenderer2.Font = Nothing
        EnhancedColumnHeaderRenderer2.ForeColor = System.Drawing.Color.Empty
        EnhancedColumnHeaderRenderer2.HorizontalAlignment = FarPoint.Win.HorizontalAlignment.Left
        EnhancedColumnHeaderRenderer2.LightColor = System.Drawing.Color.Empty
        EnhancedColumnHeaderRenderer2.Name = Nothing
        EnhancedColumnHeaderRenderer2.NormalGridLineColor = System.Drawing.Color.DarkGray
        EnhancedColumnHeaderRenderer2.SelectedActiveBackgroundColor = System.Drawing.Color.DarkGray
        EnhancedColumnHeaderRenderer2.SelectedBackgroundColor = System.Drawing.Color.Gray
        EnhancedColumnHeaderRenderer2.SelectedGridLineColor = System.Drawing.Color.DimGray
        EnhancedColumnHeaderRenderer2.TextRotationAngle = 0R
        EnhancedColumnHeaderRenderer2.VerticalAlignment = FarPoint.Win.VerticalAlignment.Top
        NamedStyle9.Renderer = EnhancedColumnHeaderRenderer2
        NamedStyle9.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle10.BackColor = System.Drawing.Color.Silver
        NamedStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        NamedStyle10.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        EnhancedRowHeaderRenderer2.ActiveBackgroundColor = System.Drawing.Color.DarkGray
        EnhancedRowHeaderRenderer2.BackColor = System.Drawing.Color.Empty
        EnhancedRowHeaderRenderer2.BackColor2 = System.Drawing.Color.Empty
        EnhancedRowHeaderRenderer2.DarkColor = System.Drawing.Color.Empty
        EnhancedRowHeaderRenderer2.Font = Nothing
        EnhancedRowHeaderRenderer2.ForeColor = System.Drawing.Color.Empty
        EnhancedRowHeaderRenderer2.HorizontalAlignment = FarPoint.Win.HorizontalAlignment.Left
        EnhancedRowHeaderRenderer2.LightColor = System.Drawing.Color.Empty
        EnhancedRowHeaderRenderer2.Name = Nothing
        EnhancedRowHeaderRenderer2.NormalGridLineColor = System.Drawing.Color.DarkGray
        EnhancedRowHeaderRenderer2.SelectedActiveBackgroundColor = System.Drawing.Color.DarkGray
        EnhancedRowHeaderRenderer2.SelectedBackgroundColor = System.Drawing.Color.Gray
        EnhancedRowHeaderRenderer2.SelectedGridLineColor = System.Drawing.Color.DimGray
        EnhancedRowHeaderRenderer2.TextRotationAngle = 0R
        EnhancedRowHeaderRenderer2.VerticalAlignment = FarPoint.Win.VerticalAlignment.Top
        NamedStyle10.Renderer = EnhancedRowHeaderRenderer2
        NamedStyle10.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle11.BackColor = System.Drawing.Color.DimGray
        NamedStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        NamedStyle11.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        EnhancedCornerRenderer2.ActiveBackgroundColor = System.Drawing.Color.Gray
        EnhancedCornerRenderer2.GridLineColor = System.Drawing.Color.Empty
        EnhancedCornerRenderer2.NormalBackgroundColor = System.Drawing.Color.DarkGray
        NamedStyle11.Renderer = EnhancedCornerRenderer2
        NamedStyle11.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle12.BackColor = System.Drawing.Color.White
        NamedStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        NamedStyle12.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        FlatColumnHeaderRenderer1.ActiveFontStyle = System.Drawing.FontStyle.Regular
        FlatColumnHeaderRenderer1.BackColor = System.Drawing.Color.Empty
        FlatColumnHeaderRenderer1.BackColor2 = System.Drawing.Color.Empty
        FlatColumnHeaderRenderer1.DarkColor = System.Drawing.Color.Empty
        FlatColumnHeaderRenderer1.Font = Nothing
        FlatColumnHeaderRenderer1.ForeColor = System.Drawing.Color.Empty
        FlatColumnHeaderRenderer1.HorizontalAlignment = FarPoint.Win.HorizontalAlignment.Left
        FlatColumnHeaderRenderer1.LightColor = System.Drawing.Color.Empty
        FlatColumnHeaderRenderer1.Name = Nothing
        FlatColumnHeaderRenderer1.TextRotationAngle = 0R
        FlatColumnHeaderRenderer1.VerticalAlignment = FarPoint.Win.VerticalAlignment.Top
        NamedStyle12.Renderer = FlatColumnHeaderRenderer1
        NamedStyle12.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle13.BackColor = System.Drawing.Color.White
        FilterBarCellType3.FormatString = ""
        NamedStyle13.CellType = FilterBarCellType3
        NamedStyle13.ForeColor = System.Drawing.SystemColors.ControlText
        NamedStyle13.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        NamedStyle13.Renderer = FilterBarCellType3
        NamedStyle13.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle14.BackColor = System.Drawing.Color.White
        NamedStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        NamedStyle14.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        FlatFilterBarHeaderRenderer1.BackColor = System.Drawing.Color.Empty
        FlatFilterBarHeaderRenderer1.BackColor2 = System.Drawing.Color.Empty
        FlatFilterBarHeaderRenderer1.DarkColor = System.Drawing.Color.Empty
        FlatFilterBarHeaderRenderer1.Font = Nothing
        FlatFilterBarHeaderRenderer1.ForeColor = System.Drawing.Color.Empty
        FlatFilterBarHeaderRenderer1.HorizontalAlignment = FarPoint.Win.HorizontalAlignment.Left
        FlatFilterBarHeaderRenderer1.LightColor = System.Drawing.Color.Empty
        FlatFilterBarHeaderRenderer1.Name = Nothing
        FlatFilterBarHeaderRenderer1.TextRotationAngle = 0R
        FlatFilterBarHeaderRenderer1.VerticalAlignment = FarPoint.Win.VerticalAlignment.Top
        NamedStyle14.Renderer = FlatFilterBarHeaderRenderer1
        NamedStyle14.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle15.BackColor = System.Drawing.Color.White
        NamedStyle15.ForeColor = System.Drawing.SystemColors.ControlText
        NamedStyle15.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        FlatColumnFooterRenderer1.ActiveFontStyle = System.Drawing.FontStyle.Regular
        FlatColumnFooterRenderer1.BackColor = System.Drawing.Color.Empty
        FlatColumnFooterRenderer1.BackColor2 = System.Drawing.Color.Empty
        FlatColumnFooterRenderer1.DarkColor = System.Drawing.Color.Empty
        FlatColumnFooterRenderer1.Font = Nothing
        FlatColumnFooterRenderer1.ForeColor = System.Drawing.Color.Empty
        FlatColumnFooterRenderer1.HorizontalAlignment = FarPoint.Win.HorizontalAlignment.Left
        FlatColumnFooterRenderer1.LightColor = System.Drawing.Color.Empty
        FlatColumnFooterRenderer1.Name = Nothing
        FlatColumnFooterRenderer1.TextRotationAngle = 0R
        FlatColumnFooterRenderer1.VerticalAlignment = FarPoint.Win.VerticalAlignment.Top
        NamedStyle15.Renderer = FlatColumnFooterRenderer1
        NamedStyle15.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle16.BackColor = System.Drawing.Color.White
        NamedStyle16.ForeColor = System.Drawing.SystemColors.ControlText
        NamedStyle16.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        FlatRowHeaderRenderer1.ActiveFontStyle = System.Drawing.FontStyle.Regular
        FlatRowHeaderRenderer1.BackColor = System.Drawing.Color.Empty
        FlatRowHeaderRenderer1.BackColor2 = System.Drawing.Color.Empty
        FlatRowHeaderRenderer1.DarkColor = System.Drawing.Color.Empty
        FlatRowHeaderRenderer1.Font = Nothing
        FlatRowHeaderRenderer1.ForeColor = System.Drawing.Color.Empty
        FlatRowHeaderRenderer1.HorizontalAlignment = FarPoint.Win.HorizontalAlignment.Left
        FlatRowHeaderRenderer1.LightColor = System.Drawing.Color.Empty
        FlatRowHeaderRenderer1.Name = Nothing
        FlatRowHeaderRenderer1.TextRotationAngle = 0R
        FlatRowHeaderRenderer1.VerticalAlignment = FarPoint.Win.VerticalAlignment.Top
        NamedStyle16.Renderer = FlatRowHeaderRenderer1
        NamedStyle16.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle17.BackColor = System.Drawing.Color.White
        NamedStyle17.ForeColor = System.Drawing.SystemColors.ControlText
        NamedStyle17.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        NamedStyle17.Renderer = FlatCornerHeaderRenderer1
        NamedStyle17.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle18.BackColor = System.Drawing.Color.White
        NamedStyle18.ForeColor = System.Drawing.SystemColors.ControlText
        NamedStyle18.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        NamedStyle18.Renderer = FlatCornerFooterRenderer1
        NamedStyle18.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle19.BackColor = System.Drawing.Color.Empty
        NamedStyle19.CellType = GeneralCellType2
        NamedStyle19.ForeColor = System.Drawing.SystemColors.WindowText
        NamedStyle19.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        NamedStyle19.Renderer = GeneralCellType2
        NamedStyle19.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.sprCodes.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.sprCodes_Sheet1})
        Me.sprCodes.Skin = FarPoint.Win.Spread.DefaultSpreadSkins.Office2016White
        Me.sprCodes.NamedStyles.AddRange(New FarPoint.Win.Spread.NamedStyle() {NamedStyle7, NamedStyle8, NamedStyle9, NamedStyle10, NamedStyle11, NamedStyle12, NamedStyle13, NamedStyle14, NamedStyle15, NamedStyle16, NamedStyle17, NamedStyle18, NamedStyle19})
        Me.sprCodes.TitleInfo.BackColor = System.Drawing.Color.Blue
        Me.sprCodes.TitleInfo.Value = ""
        sprCodes_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StopEditing)
        sprCodes_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumn)
        sprCodes_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Left, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumn)
        sprCodes_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousRow)
        sprCodes_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextRow)
        sprCodes_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Home, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToFirstColumn)
        sprCodes_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[End], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToLastColumn)
        sprCodes_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.PageUp, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousPageOfRows)
        sprCodes_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Next], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextPageOfRows)
        sprCodes_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F3, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StopEditing)
        sprCodes_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Back, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StartEditing)
        Me.sprCodes.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenFocused, FarPoint.Win.Spread.OperationMode.Normal, sprCodes_InputMapWhenFocusedNormal)
        sprCodes_InputMapWhenFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(Global.Microsoft.VisualBasic.ChrW(61)), FarPoint.Win.Spread.SpreadActions.StartEditingFormula)
        sprCodes_InputMapWhenFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ComboShowList)
        sprCodes_InputMapWhenFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ComboShowList)
        sprCodes_InputMapWhenFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F4, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.ShowSubEditor)
        sprCodes_InputMapWhenFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Z, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.Undo)
        sprCodes_InputMapWhenFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Y, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.Redo)
        Me.sprCodes.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenFocused, FarPoint.Win.Spread.OperationMode.RowMode, sprCodes_InputMapWhenFocusedRowMode)
        sprCodes_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StopEditing)
        sprCodes_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Home, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToFirstColumn)
        sprCodes_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[End], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToLastColumn)
        sprCodes_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumn)
        sprCodes_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.PageUp, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousPageOfRows)
        sprCodes_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Next], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextPageOfRows)
        sprCodes_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F3, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StopEditing)
        sprCodes_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Back, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StartEditing)
        sprCodes_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousRow)
        sprCodes_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextRow)
        sprCodes_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Left, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumn)
        Me.sprCodes.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenAncestorOfFocused, FarPoint.Win.Spread.OperationMode.Normal, sprCodes_InputMapWhenAncestorOfFocusedNormal)
        sprCodes_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousRow)
        sprCodes_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextRow)
        sprCodes_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Left, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumnVisual)
        sprCodes_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnVisual)
        sprCodes_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToPreviousRow)
        sprCodes_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToNextRow)
        sprCodes_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Left, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumnVisual)
        sprCodes_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Right, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnVisual)
        sprCodes_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.PageUp, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousPageOfRows)
        sprCodes_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Next], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextPageOfRows)
        sprCodes_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.PageUp, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToPreviousPageOfColumns)
        sprCodes_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Next], CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToNextPageOfColumns)
        sprCodes_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Home, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToFirstColumn)
        sprCodes_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[End], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToLastColumn)
        sprCodes_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Home, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToFirstCell)
        sprCodes_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[End], CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToLastCell)
        sprCodes_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Escape, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.CancelEditing)
        sprCodes_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StopEditing)
        sprCodes_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.CSEStopEditing)
        sprCodes_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Tab, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        sprCodes_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Tab, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumnWrap)
        sprCodes_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.ClearCell)
        sprCodes_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F4, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.ShowSubEditor)
        sprCodes_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ComboShowList)
        sprCodes_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ComboShowList)
        Me.sprCodes.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenAncestorOfFocused, FarPoint.Win.Spread.OperationMode.RowMode, sprCodes_InputMapWhenAncestorOfFocusedRowMode)
        Me.sprCodes.SetViewportLeftColumn(0, 0, 6)
        Me.sprCodes.SetActiveViewport(0, 0, -1)
        '
        'sprCodes_Sheet1
        '
        Me.sprCodes_Sheet1.Reset()
        Me.sprCodes_Sheet1.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.sprCodes_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.sprCodes_Sheet1.ColumnCount = 15
        Me.sprCodes_Sheet1.RowCount = 50
        Me.sprCodes_Sheet1.ActiveSkin = FarPoint.Win.Spread.DefaultSkins.Default
        Me.sprCodes_Sheet1.AlternatingRows.Get(1).BackColor = System.Drawing.Color.WhiteSmoke
        Me.sprCodes_Sheet1.Cells.Get(0, 2).Value = 12
        Me.sprCodes_Sheet1.ColumnFooter.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.sprCodes_Sheet1.ColumnFooter.DefaultStyle.BackColor = System.Drawing.Color.Empty
        Me.sprCodes_Sheet1.ColumnFooter.DefaultStyle.ForeColor = System.Drawing.Color.Empty
        Me.sprCodes_Sheet1.ColumnFooter.DefaultStyle.Locked = False
        Me.sprCodes_Sheet1.ColumnFooter.DefaultStyle.Parent = "ColumnFooterFlatOffice2016White"
        Me.sprCodes_Sheet1.ColumnFooter.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.sprCodes_Sheet1.ColumnFooter.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.sprCodes_Sheet1.ColumnFooterSheetCornerStyle.BackColor = System.Drawing.Color.Empty
        Me.sprCodes_Sheet1.ColumnFooterSheetCornerStyle.ForeColor = System.Drawing.Color.Empty
        Me.sprCodes_Sheet1.ColumnFooterSheetCornerStyle.Locked = False
        Me.sprCodes_Sheet1.ColumnFooterSheetCornerStyle.Parent = "CornerFooterFlatOffice2016White"
        Me.sprCodes_Sheet1.ColumnFooterSheetCornerStyle.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.sprCodes_Sheet1.ColumnHeader.AutoText = FarPoint.Win.Spread.HeaderAutoText.Numbers
        Me.sprCodes_Sheet1.ColumnHeader.Cells.Get(0, 0).Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.sprCodes_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "명칭"
        Me.sprCodes_Sheet1.ColumnHeader.Cells.Get(0, 1).Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.sprCodes_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "코드"
        Me.sprCodes_Sheet1.ColumnHeader.Cells.Get(0, 2).Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.sprCodes_Sheet1.ColumnHeader.Cells.Get(0, 2).Value = "연령"
        Me.sprCodes_Sheet1.ColumnHeader.Cells.Get(0, 3).Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.sprCodes_Sheet1.ColumnHeader.Cells.Get(0, 3).Value = "데이터"
        Me.sprCodes_Sheet1.ColumnHeader.Cells.Get(0, 4).Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.sprCodes_Sheet1.ColumnHeader.Cells.Get(0, 4).Tag = "HIDDEN"
        Me.sprCodes_Sheet1.ColumnHeader.Cells.Get(0, 4).Value = "데이터0"
        Me.sprCodes_Sheet1.ColumnHeader.Cells.Get(0, 5).Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.sprCodes_Sheet1.ColumnHeader.Cells.Get(0, 5).Value = "데이터1"
        Me.sprCodes_Sheet1.ColumnHeader.Cells.Get(0, 6).Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.sprCodes_Sheet1.ColumnHeader.Cells.Get(0, 6).Value = "초재구분"
        Me.sprCodes_Sheet1.ColumnHeader.Cells.Get(0, 7).Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.sprCodes_Sheet1.ColumnHeader.Cells.Get(0, 7).Value = "데이터2"
        Me.sprCodes_Sheet1.ColumnHeader.Cells.Get(0, 8).Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.sprCodes_Sheet1.ColumnHeader.Cells.Get(0, 8).Value = "데이터3"
        Me.sprCodes_Sheet1.ColumnHeader.Cells.Get(0, 9).Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Bold)
        Me.sprCodes_Sheet1.ColumnHeader.Cells.Get(0, 9).Value = "데이터4"
        Me.sprCodes_Sheet1.ColumnHeader.Cells.Get(0, 10).Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Bold)
        Me.sprCodes_Sheet1.ColumnHeader.Cells.Get(0, 10).Value = "데이터5"
        Me.sprCodes_Sheet1.ColumnHeader.Cells.Get(0, 11).Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Bold)
        Me.sprCodes_Sheet1.ColumnHeader.Cells.Get(0, 11).Value = "데이터6"
        Me.sprCodes_Sheet1.ColumnHeader.Cells.Get(0, 12).Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Bold)
        Me.sprCodes_Sheet1.ColumnHeader.Cells.Get(0, 12).Value = "데이터7"
        Me.sprCodes_Sheet1.ColumnHeader.Cells.Get(0, 13).Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Bold)
        Me.sprCodes_Sheet1.ColumnHeader.Cells.Get(0, 13).Value = "데이터8"
        Me.sprCodes_Sheet1.ColumnHeader.Cells.Get(0, 14).Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Bold)
        Me.sprCodes_Sheet1.ColumnHeader.Cells.Get(0, 14).Value = "데이터9"
        Me.sprCodes_Sheet1.ColumnHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.sprCodes_Sheet1.ColumnHeader.DefaultStyle.BackColor = System.Drawing.Color.Empty
        Me.sprCodes_Sheet1.ColumnHeader.DefaultStyle.ForeColor = System.Drawing.Color.Empty
        Me.sprCodes_Sheet1.ColumnHeader.DefaultStyle.Locked = False
        Me.sprCodes_Sheet1.ColumnHeader.DefaultStyle.Parent = "ColumnHeaderFlatOffice2016White"
        Me.sprCodes_Sheet1.ColumnHeader.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.sprCodes_Sheet1.ColumnHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.sprCodes_Sheet1.ColumnHeader.Rows.Get(0).Height = 26.0!
        Me.sprCodes_Sheet1.Columns.Get(0).CellType = TextCellType10
        Me.sprCodes_Sheet1.Columns.Get(0).Font = New System.Drawing.Font("맑은 고딕", 9.0!)
        Me.sprCodes_Sheet1.Columns.Get(0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        Me.sprCodes_Sheet1.Columns.Get(0).Label = "명칭"
        Me.sprCodes_Sheet1.Columns.Get(0).Locked = True
        Me.sprCodes_Sheet1.Columns.Get(0).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.sprCodes_Sheet1.Columns.Get(0).Width = 79.0!
        Me.sprCodes_Sheet1.Columns.Get(1).CellType = TextCellType11
        Me.sprCodes_Sheet1.Columns.Get(1).Font = New System.Drawing.Font("맑은 고딕", 9.0!)
        Me.sprCodes_Sheet1.Columns.Get(1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.sprCodes_Sheet1.Columns.Get(1).Label = "코드"
        Me.sprCodes_Sheet1.Columns.Get(1).Locked = True
        Me.sprCodes_Sheet1.Columns.Get(1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.sprCodes_Sheet1.Columns.Get(2).CellType = TextCellType12
        Me.sprCodes_Sheet1.Columns.Get(2).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.sprCodes_Sheet1.Columns.Get(2).Label = "연령"
        Me.sprCodes_Sheet1.Columns.Get(2).Locked = True
        Me.sprCodes_Sheet1.Columns.Get(2).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.sprCodes_Sheet1.Columns.Get(2).Visible = False
        Me.sprCodes_Sheet1.Columns.Get(2).Width = 56.0!
        Me.sprCodes_Sheet1.Columns.Get(3).CellType = TextCellType13
        Me.sprCodes_Sheet1.Columns.Get(3).Font = New System.Drawing.Font("맑은 고딕", 9.0!)
        Me.sprCodes_Sheet1.Columns.Get(3).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.sprCodes_Sheet1.Columns.Get(3).Label = "데이터"
        Me.sprCodes_Sheet1.Columns.Get(3).Locked = True
        Me.sprCodes_Sheet1.Columns.Get(3).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.sprCodes_Sheet1.Columns.Get(3).Width = 77.0!
        Me.sprCodes_Sheet1.Columns.Get(4).CellType = TextCellType14
        Me.sprCodes_Sheet1.Columns.Get(4).Font = New System.Drawing.Font("맑은 고딕", 9.0!)
        Me.sprCodes_Sheet1.Columns.Get(4).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.sprCodes_Sheet1.Columns.Get(4).Label = "데이터0"
        Me.sprCodes_Sheet1.Columns.Get(4).Locked = True
        Me.sprCodes_Sheet1.Columns.Get(4).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.sprCodes_Sheet1.Columns.Get(4).Width = 48.0!
        Me.sprCodes_Sheet1.Columns.Get(5).Border = ComplexBorder1
        Me.sprCodes_Sheet1.Columns.Get(5).CellType = TextCellType15
        Me.sprCodes_Sheet1.Columns.Get(5).Font = New System.Drawing.Font("맑은 고딕", 9.0!)
        Me.sprCodes_Sheet1.Columns.Get(5).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.sprCodes_Sheet1.Columns.Get(5).Label = "데이터1"
        Me.sprCodes_Sheet1.Columns.Get(5).Locked = True
        Me.sprCodes_Sheet1.Columns.Get(5).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.sprCodes_Sheet1.Columns.Get(5).Width = 48.0!
        Me.sprCodes_Sheet1.Columns.Get(6).CellType = TextCellType16
        Me.sprCodes_Sheet1.Columns.Get(6).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.sprCodes_Sheet1.Columns.Get(6).Label = "초재구분"
        Me.sprCodes_Sheet1.Columns.Get(6).Locked = True
        Me.sprCodes_Sheet1.Columns.Get(6).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.sprCodes_Sheet1.Columns.Get(6).Visible = False
        Me.sprCodes_Sheet1.Columns.Get(6).Width = 94.0!
        Me.sprCodes_Sheet1.Columns.Get(7).CellType = TextCellType17
        Me.sprCodes_Sheet1.Columns.Get(7).Font = New System.Drawing.Font("맑은 고딕", 9.0!)
        Me.sprCodes_Sheet1.Columns.Get(7).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.sprCodes_Sheet1.Columns.Get(7).Label = "데이터2"
        Me.sprCodes_Sheet1.Columns.Get(7).Locked = True
        Me.sprCodes_Sheet1.Columns.Get(7).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.sprCodes_Sheet1.Columns.Get(7).Width = 48.0!
        Me.sprCodes_Sheet1.Columns.Get(8).CellType = TextCellType18
        Me.sprCodes_Sheet1.Columns.Get(8).Font = New System.Drawing.Font("맑은 고딕", 9.0!)
        Me.sprCodes_Sheet1.Columns.Get(8).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        Me.sprCodes_Sheet1.Columns.Get(8).Label = "데이터3"
        Me.sprCodes_Sheet1.Columns.Get(8).Locked = True
        Me.sprCodes_Sheet1.Columns.Get(8).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.sprCodes_Sheet1.Columns.Get(8).Width = 48.0!
        Me.sprCodes_Sheet1.Columns.Get(9).Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.sprCodes_Sheet1.Columns.Get(9).Label = "데이터4"
        Me.sprCodes_Sheet1.Columns.Get(9).Width = 48.0!
        Me.sprCodes_Sheet1.Columns.Get(10).Font = New System.Drawing.Font("맑은 고딕", 9.0!)
        Me.sprCodes_Sheet1.Columns.Get(10).Label = "데이터5"
        Me.sprCodes_Sheet1.Columns.Get(10).Width = 48.0!
        Me.sprCodes_Sheet1.Columns.Get(11).Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.sprCodes_Sheet1.Columns.Get(11).Label = "데이터6"
        Me.sprCodes_Sheet1.Columns.Get(11).Width = 48.0!
        Me.sprCodes_Sheet1.Columns.Get(12).Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.sprCodes_Sheet1.Columns.Get(12).Label = "데이터7"
        Me.sprCodes_Sheet1.Columns.Get(12).Width = 48.0!
        Me.sprCodes_Sheet1.Columns.Get(13).Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.sprCodes_Sheet1.Columns.Get(13).Label = "데이터8"
        Me.sprCodes_Sheet1.Columns.Get(13).Width = 48.0!
        Me.sprCodes_Sheet1.Columns.Get(14).Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.sprCodes_Sheet1.Columns.Get(14).Label = "데이터9"
        Me.sprCodes_Sheet1.Columns.Get(14).Width = 48.0!
        Me.sprCodes_Sheet1.DefaultStyle.BackColor = System.Drawing.Color.Empty
        Me.sprCodes_Sheet1.DefaultStyle.ForeColor = System.Drawing.Color.Empty
        Me.sprCodes_Sheet1.DefaultStyle.Locked = False
        Me.sprCodes_Sheet1.DefaultStyle.Parent = "DataAreaDefault"
        Me.sprCodes_Sheet1.FilterBar.DefaultStyle.BackColor = System.Drawing.Color.Empty
        Me.sprCodes_Sheet1.FilterBar.DefaultStyle.ForeColor = System.Drawing.Color.Empty
        Me.sprCodes_Sheet1.FilterBar.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.sprCodes_Sheet1.FilterBar.DefaultStyle.Locked = False
        Me.sprCodes_Sheet1.FilterBar.DefaultStyle.Parent = "FilterBarFlatOffice2016White"
        Me.sprCodes_Sheet1.FilterBar.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.sprCodes_Sheet1.FilterBar.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.sprCodes_Sheet1.FilterBarHeaderStyle.BackColor = System.Drawing.Color.Empty
        Me.sprCodes_Sheet1.FilterBarHeaderStyle.ForeColor = System.Drawing.Color.Empty
        Me.sprCodes_Sheet1.FilterBarHeaderStyle.Locked = False
        Me.sprCodes_Sheet1.FilterBarHeaderStyle.Parent = "FilterBarHeaderFlatOffice2016White"
        Me.sprCodes_Sheet1.FilterBarHeaderStyle.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.sprCodes_Sheet1.FrozenColumnCount = 6
        Me.sprCodes_Sheet1.GrayAreaBackColor = System.Drawing.Color.White
        Me.sprCodes_Sheet1.HorizontalGridLine = New FarPoint.Win.Spread.GridLine(FarPoint.Win.Spread.GridLineType.Flat, System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(208, Byte), Integer)))
        Me.sprCodes_Sheet1.OperationMode = FarPoint.Win.Spread.OperationMode.RowMode
        Me.sprCodes_Sheet1.Protect = True
        Me.sprCodes_Sheet1.RowHeader.Columns.Default.Resizable = False
        Me.sprCodes_Sheet1.RowHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.sprCodes_Sheet1.RowHeader.DefaultStyle.BackColor = System.Drawing.Color.Empty
        Me.sprCodes_Sheet1.RowHeader.DefaultStyle.ForeColor = System.Drawing.Color.Empty
        Me.sprCodes_Sheet1.RowHeader.DefaultStyle.Locked = False
        Me.sprCodes_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderFlatOffice2016White"
        Me.sprCodes_Sheet1.RowHeader.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.sprCodes_Sheet1.RowHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.sprCodes_Sheet1.Rows.Get(0).Height = 22.0!
        Me.sprCodes_Sheet1.Rows.Get(1).Height = 22.0!
        Me.sprCodes_Sheet1.Rows.Get(2).Height = 22.0!
        Me.sprCodes_Sheet1.Rows.Get(3).Height = 22.0!
        Me.sprCodes_Sheet1.Rows.Get(4).Height = 22.0!
        Me.sprCodes_Sheet1.Rows.Get(5).Height = 22.0!
        Me.sprCodes_Sheet1.Rows.Get(6).Height = 22.0!
        Me.sprCodes_Sheet1.Rows.Get(7).Height = 22.0!
        Me.sprCodes_Sheet1.Rows.Get(8).Height = 22.0!
        Me.sprCodes_Sheet1.Rows.Get(9).Height = 22.0!
        Me.sprCodes_Sheet1.Rows.Get(10).Height = 22.0!
        Me.sprCodes_Sheet1.Rows.Get(11).Height = 22.0!
        Me.sprCodes_Sheet1.Rows.Get(12).Height = 22.0!
        Me.sprCodes_Sheet1.Rows.Get(13).Height = 22.0!
        Me.sprCodes_Sheet1.SelectionBackColor = System.Drawing.Color.Transparent
        Me.sprCodes_Sheet1.SelectionStyle = FarPoint.Win.Spread.SelectionStyles.Both
        Me.sprCodes_Sheet1.SheetCornerStyle.BackColor = System.Drawing.Color.Empty
        Me.sprCodes_Sheet1.SheetCornerStyle.ForeColor = System.Drawing.Color.Empty
        Me.sprCodes_Sheet1.SheetCornerStyle.Locked = False
        Me.sprCodes_Sheet1.SheetCornerStyle.Parent = "CornerHeaderFlatOffice2016White"
        Me.sprCodes_Sheet1.SheetCornerStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.sprCodes_Sheet1.SheetCornerStyle.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.sprCodes_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'SplitContainer2
        '
        resources.ApplyResources(Me.SplitContainer2, "SplitContainer2")
        Me.SplitContainer2.BackColor = System.Drawing.Color.LightGray
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SplitContainer2.Panel1.Controls.Add(Me.LabelControl2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.b검색)
        Me.SplitContainer2.Panel1.Controls.Add(Me.f검색)
        Me.SplitContainer2.Panel1.Controls.Add(Me.t검색어)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.tab쿼리)
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = CType(resources.GetObject("LabelControl2.Appearance.Font"), System.Drawing.Font)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.LabelControl2.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelControl2.ImageOptions.Image = CType(resources.GetObject("LabelControl2.ImageOptions.Image"), System.Drawing.Image)
        resources.ApplyResources(Me.LabelControl2, "LabelControl2")
        Me.LabelControl2.Name = "LabelControl2"
        '
        'b검색
        '
        resources.ApplyResources(Me.b검색, "b검색")
        Me.b검색.Appearance.Font = CType(resources.GetObject("b검색.Appearance.Font"), System.Drawing.Font)
        Me.b검색.Appearance.Options.UseFont = True
        Me.b검색.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.b검색.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b검색.ImageOptions.Image = CType(resources.GetObject("b검색.ImageOptions.Image"), System.Drawing.Image)
        Me.b검색.Name = "b검색"
        '
        'f검색
        '
        resources.ApplyResources(Me.f검색, "f검색")
        Me.f검색.AllowColumnMove = True
        Me.f검색.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.f검색.ButtonDrawMode = CType((FarPoint.Win.Spread.ButtonDrawModes.CurrentCell Or FarPoint.Win.Spread.ButtonDrawModes.CurrentColumn), FarPoint.Win.Spread.ButtonDrawModes)
        Me.f검색.EditModeReplace = True
        Me.f검색.Name = "f검색"
        NamedStyle20.BackColor = System.Drawing.Color.Empty
        NamedStyle20.ForeColor = System.Drawing.Color.Empty
        NamedStyle21.BackColor = System.Drawing.Color.Silver
        FilterBarCellType4.FormatString = ""
        NamedStyle21.CellType = FilterBarCellType4
        NamedStyle21.ForeColor = System.Drawing.SystemColors.ControlText
        NamedStyle21.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        NamedStyle21.Renderer = FilterBarCellType4
        NamedStyle21.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle22.BackColor = System.Drawing.Color.Silver
        NamedStyle22.ForeColor = System.Drawing.SystemColors.ControlText
        NamedStyle22.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        EnhancedColumnHeaderRenderer3.ActiveBackgroundColor = System.Drawing.Color.DarkGray
        EnhancedColumnHeaderRenderer3.BackColor = System.Drawing.Color.Empty
        EnhancedColumnHeaderRenderer3.BackColor2 = System.Drawing.Color.Empty
        EnhancedColumnHeaderRenderer3.DarkColor = System.Drawing.Color.Empty
        EnhancedColumnHeaderRenderer3.Font = Nothing
        EnhancedColumnHeaderRenderer3.ForeColor = System.Drawing.Color.Empty
        EnhancedColumnHeaderRenderer3.HorizontalAlignment = FarPoint.Win.HorizontalAlignment.Left
        EnhancedColumnHeaderRenderer3.LightColor = System.Drawing.Color.Empty
        EnhancedColumnHeaderRenderer3.Name = Nothing
        EnhancedColumnHeaderRenderer3.NormalGridLineColor = System.Drawing.Color.DarkGray
        EnhancedColumnHeaderRenderer3.SelectedActiveBackgroundColor = System.Drawing.Color.DarkGray
        EnhancedColumnHeaderRenderer3.SelectedBackgroundColor = System.Drawing.Color.Gray
        EnhancedColumnHeaderRenderer3.SelectedGridLineColor = System.Drawing.Color.DimGray
        EnhancedColumnHeaderRenderer3.TextRotationAngle = 0R
        EnhancedColumnHeaderRenderer3.VerticalAlignment = FarPoint.Win.VerticalAlignment.Top
        NamedStyle22.Renderer = EnhancedColumnHeaderRenderer3
        NamedStyle22.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle23.BackColor = System.Drawing.Color.Silver
        NamedStyle23.ForeColor = System.Drawing.SystemColors.ControlText
        NamedStyle23.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        EnhancedRowHeaderRenderer3.ActiveBackgroundColor = System.Drawing.Color.DarkGray
        EnhancedRowHeaderRenderer3.BackColor = System.Drawing.Color.Empty
        EnhancedRowHeaderRenderer3.BackColor2 = System.Drawing.Color.Empty
        EnhancedRowHeaderRenderer3.DarkColor = System.Drawing.Color.Empty
        EnhancedRowHeaderRenderer3.Font = Nothing
        EnhancedRowHeaderRenderer3.ForeColor = System.Drawing.Color.Empty
        EnhancedRowHeaderRenderer3.HorizontalAlignment = FarPoint.Win.HorizontalAlignment.Left
        EnhancedRowHeaderRenderer3.LightColor = System.Drawing.Color.Empty
        EnhancedRowHeaderRenderer3.Name = Nothing
        EnhancedRowHeaderRenderer3.NormalGridLineColor = System.Drawing.Color.DarkGray
        EnhancedRowHeaderRenderer3.SelectedActiveBackgroundColor = System.Drawing.Color.DarkGray
        EnhancedRowHeaderRenderer3.SelectedBackgroundColor = System.Drawing.Color.Gray
        EnhancedRowHeaderRenderer3.SelectedGridLineColor = System.Drawing.Color.DimGray
        EnhancedRowHeaderRenderer3.TextRotationAngle = 0R
        EnhancedRowHeaderRenderer3.VerticalAlignment = FarPoint.Win.VerticalAlignment.Top
        NamedStyle23.Renderer = EnhancedRowHeaderRenderer3
        NamedStyle23.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle24.BackColor = System.Drawing.Color.DimGray
        NamedStyle24.ForeColor = System.Drawing.SystemColors.ControlText
        NamedStyle24.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        EnhancedCornerRenderer3.ActiveBackgroundColor = System.Drawing.Color.Gray
        EnhancedCornerRenderer3.GridLineColor = System.Drawing.Color.Empty
        EnhancedCornerRenderer3.NormalBackgroundColor = System.Drawing.Color.DarkGray
        NamedStyle24.Renderer = EnhancedCornerRenderer3
        NamedStyle24.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle25.BackColor = System.Drawing.Color.Empty
        NamedStyle25.CellType = GeneralCellType3
        NamedStyle25.ForeColor = System.Drawing.SystemColors.WindowText
        NamedStyle25.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        NamedStyle25.Renderer = GeneralCellType3
        NamedStyle25.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.f검색.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.f검색_Sheet1})
        Me.f검색.Skin = FarPoint.Win.Spread.DefaultSpreadSkins.Office2016White
        Me.f검색.NamedStyles.AddRange(New FarPoint.Win.Spread.NamedStyle() {NamedStyle20, NamedStyle21, NamedStyle22, NamedStyle23, NamedStyle24, NamedStyle25})
        Me.f검색.TitleInfo.BackColor = System.Drawing.Color.Blue
        Me.f검색.TitleInfo.Value = ""
        f검색_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StopEditing)
        f검색_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumn)
        f검색_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Left, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumn)
        f검색_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousRow)
        f검색_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextRow)
        f검색_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Home, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToFirstColumn)
        f검색_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[End], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToLastColumn)
        f검색_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.PageUp, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousPageOfRows)
        f검색_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Next], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextPageOfRows)
        f검색_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F3, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StopEditing)
        f검색_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Back, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StartEditing)
        Me.f검색.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenFocused, FarPoint.Win.Spread.OperationMode.Normal, f검색_InputMapWhenFocusedNormal)
        f검색_InputMapWhenFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(Global.Microsoft.VisualBasic.ChrW(61)), FarPoint.Win.Spread.SpreadActions.StartEditingFormula)
        f검색_InputMapWhenFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ComboShowList)
        f검색_InputMapWhenFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ComboShowList)
        f검색_InputMapWhenFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F4, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.ShowSubEditor)
        f검색_InputMapWhenFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Z, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.Undo)
        f검색_InputMapWhenFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Y, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.Redo)
        Me.f검색.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenFocused, FarPoint.Win.Spread.OperationMode.RowMode, f검색_InputMapWhenFocusedRowMode)
        f검색_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StopEditing)
        f검색_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Home, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToFirstColumn)
        f검색_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[End], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToLastColumn)
        f검색_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumn)
        f검색_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.PageUp, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousPageOfRows)
        f검색_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Next], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextPageOfRows)
        f검색_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F3, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StopEditing)
        f검색_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Back, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StartEditing)
        f검색_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousRow)
        f검색_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextRow)
        f검색_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Left, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumn)
        Me.f검색.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenAncestorOfFocused, FarPoint.Win.Spread.OperationMode.Normal, f검색_InputMapWhenAncestorOfFocusedNormal)
        f검색_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousRow)
        f검색_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextRow)
        f검색_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Left, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumnVisual)
        f검색_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnVisual)
        f검색_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToPreviousRow)
        f검색_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToNextRow)
        f검색_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Left, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumnVisual)
        f검색_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Right, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnVisual)
        f검색_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.PageUp, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousPageOfRows)
        f검색_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Next], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextPageOfRows)
        f검색_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.PageUp, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToPreviousPageOfColumns)
        f검색_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Next], CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToNextPageOfColumns)
        f검색_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Home, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToFirstColumn)
        f검색_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[End], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToLastColumn)
        f검색_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Home, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToFirstCell)
        f검색_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[End], CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToLastCell)
        f검색_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Escape, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.CancelEditing)
        f검색_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StopEditing)
        f검색_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.CSEStopEditing)
        f검색_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Tab, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        f검색_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Tab, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumnWrap)
        f검색_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.ClearCell)
        f검색_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F4, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.ShowSubEditor)
        f검색_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ComboShowList)
        f검색_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ComboShowList)
        Me.f검색.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenAncestorOfFocused, FarPoint.Win.Spread.OperationMode.RowMode, f검색_InputMapWhenAncestorOfFocusedRowMode)
        '
        'f검색_Sheet1
        '
        Me.f검색_Sheet1.Reset()
        Me.f검색_Sheet1.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.f검색_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.f검색_Sheet1.ColumnCount = 5
        Me.f검색_Sheet1.RowCount = 50
        Me.f검색_Sheet1.ActiveSkin = FarPoint.Win.Spread.DefaultSkins.Default
        Me.f검색_Sheet1.AlternatingRows.Get(1).BackColor = System.Drawing.Color.WhiteSmoke
        Me.f검색_Sheet1.Cells.Get(0, 0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        Me.f검색_Sheet1.Cells.Get(0, 0).Value = "2021-06"
        Me.f검색_Sheet1.Cells.Get(0, 0).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.f검색_Sheet1.Cells.Get(0, 3).Value = "처방전교부번호"
        Me.f검색_Sheet1.Cells.Get(1, 0).Value = "31204996"
        Me.f검색_Sheet1.ColumnFooter.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.f검색_Sheet1.ColumnFooter.DefaultStyle.BackColor = System.Drawing.Color.Empty
        Me.f검색_Sheet1.ColumnFooter.DefaultStyle.ForeColor = System.Drawing.Color.Empty
        Me.f검색_Sheet1.ColumnFooter.DefaultStyle.Locked = False
        Me.f검색_Sheet1.ColumnFooter.DefaultStyle.Parent = "ColumnFooterFlatOffice2016White"
        Me.f검색_Sheet1.ColumnFooter.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.f검색_Sheet1.ColumnFooter.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.f검색_Sheet1.ColumnFooterSheetCornerStyle.BackColor = System.Drawing.Color.Empty
        Me.f검색_Sheet1.ColumnFooterSheetCornerStyle.ForeColor = System.Drawing.Color.Empty
        Me.f검색_Sheet1.ColumnFooterSheetCornerStyle.Locked = False
        Me.f검색_Sheet1.ColumnFooterSheetCornerStyle.Parent = "CornerFooterFlatOffice2016White"
        Me.f검색_Sheet1.ColumnFooterSheetCornerStyle.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.f검색_Sheet1.ColumnHeader.AutoText = FarPoint.Win.Spread.HeaderAutoText.Numbers
        Me.f검색_Sheet1.ColumnHeader.Cells.Get(0, 0).Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Bold)
        Me.f검색_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "대분류"
        Me.f검색_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "소분류"
        Me.f검색_Sheet1.ColumnHeader.Cells.Get(0, 2).Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Bold)
        Me.f검색_Sheet1.ColumnHeader.Cells.Get(0, 2).Value = "내 용"
        Me.f검색_Sheet1.ColumnHeader.Cells.Get(0, 3).Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Bold)
        Me.f검색_Sheet1.ColumnHeader.Cells.Get(0, 3).Value = "타이틀"
        Me.f검색_Sheet1.ColumnHeader.Cells.Get(0, 4).Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Bold)
        Me.f검색_Sheet1.ColumnHeader.Cells.Get(0, 4).Value = "인덱스"
        Me.f검색_Sheet1.ColumnHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.f검색_Sheet1.ColumnHeader.DefaultStyle.BackColor = System.Drawing.Color.Empty
        Me.f검색_Sheet1.ColumnHeader.DefaultStyle.ForeColor = System.Drawing.Color.Empty
        Me.f검색_Sheet1.ColumnHeader.DefaultStyle.Locked = False
        Me.f검색_Sheet1.ColumnHeader.DefaultStyle.Parent = "ColumnHeaderFlatOffice2016White"
        Me.f검색_Sheet1.ColumnHeader.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.f검색_Sheet1.ColumnHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.f검색_Sheet1.ColumnHeader.Rows.Get(0).Height = 26.0!
        Me.f검색_Sheet1.Columns.Get(0).CellType = TextCellType19
        Me.f검색_Sheet1.Columns.Get(0).Font = New System.Drawing.Font("맑은 고딕", 9.0!)
        Me.f검색_Sheet1.Columns.Get(0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        Me.f검색_Sheet1.Columns.Get(0).Label = "대분류"
        Me.f검색_Sheet1.Columns.Get(0).Locked = True
        Me.f검색_Sheet1.Columns.Get(0).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.f검색_Sheet1.Columns.Get(0).Width = 65.0!
        Me.f검색_Sheet1.Columns.Get(1).CellType = TextCellType20
        Me.f검색_Sheet1.Columns.Get(1).Font = New System.Drawing.Font("맑은 고딕", 9.0!)
        Me.f검색_Sheet1.Columns.Get(1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        Me.f검색_Sheet1.Columns.Get(1).Label = "소분류"
        Me.f검색_Sheet1.Columns.Get(1).Locked = True
        Me.f검색_Sheet1.Columns.Get(1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.f검색_Sheet1.Columns.Get(2).CellType = TextCellType21
        Me.f검색_Sheet1.Columns.Get(2).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        Me.f검색_Sheet1.Columns.Get(2).Label = "내 용"
        Me.f검색_Sheet1.Columns.Get(2).Locked = True
        Me.f검색_Sheet1.Columns.Get(2).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.f검색_Sheet1.Columns.Get(2).Width = 307.0!
        Me.f검색_Sheet1.Columns.Get(3).CellType = TextCellType22
        Me.f검색_Sheet1.Columns.Get(3).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        Me.f검색_Sheet1.Columns.Get(3).Label = "타이틀"
        Me.f검색_Sheet1.Columns.Get(3).Locked = True
        Me.f검색_Sheet1.Columns.Get(3).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.f검색_Sheet1.Columns.Get(3).Visible = False
        Me.f검색_Sheet1.Columns.Get(3).Width = 83.0!
        Me.f검색_Sheet1.Columns.Get(4).CanFocus = True
        Me.f검색_Sheet1.Columns.Get(4).CellType = TextCellType23
        Me.f검색_Sheet1.Columns.Get(4).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.f검색_Sheet1.Columns.Get(4).Label = "인덱스"
        Me.f검색_Sheet1.Columns.Get(4).Locked = True
        Me.f검색_Sheet1.Columns.Get(4).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.f검색_Sheet1.Columns.Get(4).Visible = False
        Me.f검색_Sheet1.Columns.Get(4).Width = 42.0!
        Me.f검색_Sheet1.DefaultStyle.BackColor = System.Drawing.Color.Empty
        Me.f검색_Sheet1.DefaultStyle.ForeColor = System.Drawing.Color.Empty
        Me.f검색_Sheet1.DefaultStyle.Locked = False
        Me.f검색_Sheet1.DefaultStyle.Parent = "DataAreaDefault"
        Me.f검색_Sheet1.FilterBar.DefaultStyle.BackColor = System.Drawing.Color.Empty
        Me.f검색_Sheet1.FilterBar.DefaultStyle.ForeColor = System.Drawing.Color.Empty
        Me.f검색_Sheet1.FilterBar.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.f검색_Sheet1.FilterBar.DefaultStyle.Locked = False
        Me.f검색_Sheet1.FilterBar.DefaultStyle.Parent = "FilterBarFlatOffice2016White"
        Me.f검색_Sheet1.FilterBar.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.f검색_Sheet1.FilterBar.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.f검색_Sheet1.FilterBarHeaderStyle.BackColor = System.Drawing.Color.Empty
        Me.f검색_Sheet1.FilterBarHeaderStyle.ForeColor = System.Drawing.Color.Empty
        Me.f검색_Sheet1.FilterBarHeaderStyle.Locked = False
        Me.f검색_Sheet1.FilterBarHeaderStyle.Parent = "FilterBarHeaderFlatOffice2016White"
        Me.f검색_Sheet1.FilterBarHeaderStyle.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.f검색_Sheet1.GrayAreaBackColor = System.Drawing.Color.White
        Me.f검색_Sheet1.HorizontalGridLine = New FarPoint.Win.Spread.GridLine(FarPoint.Win.Spread.GridLineType.Flat, System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(208, Byte), Integer)))
        Me.f검색_Sheet1.OperationMode = FarPoint.Win.Spread.OperationMode.RowMode
        Me.f검색_Sheet1.Protect = True
        Me.f검색_Sheet1.RowHeader.Columns.Default.Resizable = False
        Me.f검색_Sheet1.RowHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.f검색_Sheet1.RowHeader.DefaultStyle.BackColor = System.Drawing.Color.Empty
        Me.f검색_Sheet1.RowHeader.DefaultStyle.ForeColor = System.Drawing.Color.Empty
        Me.f검색_Sheet1.RowHeader.DefaultStyle.Locked = False
        Me.f검색_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderFlatOffice2016White"
        Me.f검색_Sheet1.RowHeader.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.f검색_Sheet1.RowHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.f검색_Sheet1.Rows.Get(0).Height = 22.0!
        Me.f검색_Sheet1.Rows.Get(1).Height = 22.0!
        Me.f검색_Sheet1.Rows.Get(2).Height = 22.0!
        Me.f검색_Sheet1.Rows.Get(3).Height = 22.0!
        Me.f검색_Sheet1.Rows.Get(4).Height = 22.0!
        Me.f검색_Sheet1.Rows.Get(5).Height = 22.0!
        Me.f검색_Sheet1.Rows.Get(6).Height = 22.0!
        Me.f검색_Sheet1.Rows.Get(7).Height = 22.0!
        Me.f검색_Sheet1.Rows.Get(8).Height = 22.0!
        Me.f검색_Sheet1.Rows.Get(9).Height = 22.0!
        Me.f검색_Sheet1.Rows.Get(10).Height = 22.0!
        Me.f검색_Sheet1.Rows.Get(11).Height = 22.0!
        Me.f검색_Sheet1.Rows.Get(12).Height = 22.0!
        Me.f검색_Sheet1.Rows.Get(13).Height = 22.0!
        Me.f검색_Sheet1.SelectionBackColor = System.Drawing.Color.Transparent
        Me.f검색_Sheet1.SelectionStyle = FarPoint.Win.Spread.SelectionStyles.Both
        Me.f검색_Sheet1.SheetCornerStyle.BackColor = System.Drawing.Color.Empty
        Me.f검색_Sheet1.SheetCornerStyle.ForeColor = System.Drawing.Color.Empty
        Me.f검색_Sheet1.SheetCornerStyle.Locked = False
        Me.f검색_Sheet1.SheetCornerStyle.Parent = "CornerHeaderFlatOffice2016White"
        Me.f검색_Sheet1.SheetCornerStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.f검색_Sheet1.SheetCornerStyle.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.f검색_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        't검색어
        '
        resources.ApplyResources(Me.t검색어, "t검색어")
        Me.t검색어.Name = "t검색어"
        Me.t검색어.Properties.Appearance.Font = CType(resources.GetObject("t검색어.Properties.Appearance.Font"), System.Drawing.Font)
        Me.t검색어.Properties.Appearance.ForeColor = System.Drawing.Color.Green
        Me.t검색어.Properties.Appearance.Options.UseFont = True
        Me.t검색어.Properties.Appearance.Options.UseForeColor = True
        Me.t검색어.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("t검색어.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.t검색어.Properties.Items.AddRange(New Object() {resources.GetString("t검색어.Properties.Items"), resources.GetString("t검색어.Properties.Items1"), resources.GetString("t검색어.Properties.Items2"), resources.GetString("t검색어.Properties.Items3"), resources.GetString("t검색어.Properties.Items4")})
        '
        'tab쿼리
        '
        resources.ApplyResources(Me.tab쿼리, "tab쿼리")
        Me.tab쿼리.Name = "tab쿼리"
        Me.tab쿼리.SelectedTabPage = Me.tabQUERY
        Me.tab쿼리.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabQUERY, Me.XtraTabPage1})
        '
        'tabQUERY
        '
        Me.tabQUERY.Appearance.Header.Font = CType(resources.GetObject("tabQUERY.Appearance.Header.Font"), System.Drawing.Font)
        Me.tabQUERY.Appearance.Header.Options.UseFont = True
        Me.tabQUERY.Appearance.HeaderActive.Font = CType(resources.GetObject("tabQUERY.Appearance.HeaderActive.Font"), System.Drawing.Font)
        Me.tabQUERY.Appearance.HeaderActive.Options.UseFont = True
        Me.tabQUERY.Appearance.PageClient.BackColor = System.Drawing.Color.Black
        Me.tabQUERY.Appearance.PageClient.Options.UseBackColor = True
        Me.tabQUERY.Controls.Add(Me.SplitContainer1)
        Me.tabQUERY.Name = "tabQUERY"
        resources.ApplyResources(Me.tabQUERY, "tabQUERY")
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Appearance.Header.Font = CType(resources.GetObject("XtraTabPage1.Appearance.Header.Font"), System.Drawing.Font)
        Me.XtraTabPage1.Appearance.Header.Options.UseFont = True
        Me.XtraTabPage1.Appearance.HeaderActive.Font = CType(resources.GetObject("XtraTabPage1.Appearance.HeaderActive.Font"), System.Drawing.Font)
        Me.XtraTabPage1.Appearance.HeaderActive.Options.UseFont = True
        Me.XtraTabPage1.Controls.Add(Me.SplitContainer5)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        resources.ApplyResources(Me.XtraTabPage1, "XtraTabPage1")
        '
        'SplitContainer5
        '
        Me.SplitContainer5.BackColor = System.Drawing.Color.LightGray
        resources.ApplyResources(Me.SplitContainer5, "SplitContainer5")
        Me.SplitContainer5.Name = "SplitContainer5"
        '
        'SplitContainer5.Panel1
        '
        Me.SplitContainer5.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer5.Panel1.Controls.Add(Me.t쿼리sub)
        '
        'SplitContainer5.Panel2
        '
        Me.SplitContainer5.Panel2.BackColor = System.Drawing.Color.White
        Me.SplitContainer5.Panel2.Controls.Add(Me.f결과sub)
        '
        't쿼리sub
        '
        resources.ApplyResources(Me.t쿼리sub, "t쿼리sub")
        Me.t쿼리sub.Name = "t쿼리sub"
        Me.t쿼리sub.TabStop = False
        '
        'f결과sub
        '
        resources.ApplyResources(Me.f결과sub, "f결과sub")
        Me.f결과sub.AllowColumnMove = True
        Me.f결과sub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.f결과sub.ButtonDrawMode = CType((FarPoint.Win.Spread.ButtonDrawModes.CurrentCell Or FarPoint.Win.Spread.ButtonDrawModes.CurrentColumn), FarPoint.Win.Spread.ButtonDrawModes)
        Me.f결과sub.ContextMenuStrip = Me.mnu결과
        Me.f결과sub.EditModeReplace = True
        Me.f결과sub.Name = "f결과sub"
        NamedStyle26.BackColor = System.Drawing.Color.Empty
        NamedStyle26.ForeColor = System.Drawing.Color.Empty
        NamedStyle27.BackColor = System.Drawing.Color.Silver
        FilterBarCellType5.FormatString = ""
        NamedStyle27.CellType = FilterBarCellType5
        NamedStyle27.ForeColor = System.Drawing.SystemColors.ControlText
        NamedStyle27.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        NamedStyle27.Renderer = FilterBarCellType5
        NamedStyle27.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle28.BackColor = System.Drawing.Color.Silver
        NamedStyle28.ForeColor = System.Drawing.SystemColors.ControlText
        NamedStyle28.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        EnhancedColumnHeaderRenderer4.ActiveBackgroundColor = System.Drawing.Color.DarkGray
        EnhancedColumnHeaderRenderer4.BackColor = System.Drawing.Color.Empty
        EnhancedColumnHeaderRenderer4.BackColor2 = System.Drawing.Color.Empty
        EnhancedColumnHeaderRenderer4.DarkColor = System.Drawing.Color.Empty
        EnhancedColumnHeaderRenderer4.Font = Nothing
        EnhancedColumnHeaderRenderer4.ForeColor = System.Drawing.Color.Empty
        EnhancedColumnHeaderRenderer4.HorizontalAlignment = FarPoint.Win.HorizontalAlignment.Left
        EnhancedColumnHeaderRenderer4.LightColor = System.Drawing.Color.Empty
        EnhancedColumnHeaderRenderer4.Name = Nothing
        EnhancedColumnHeaderRenderer4.NormalGridLineColor = System.Drawing.Color.DarkGray
        EnhancedColumnHeaderRenderer4.SelectedActiveBackgroundColor = System.Drawing.Color.DarkGray
        EnhancedColumnHeaderRenderer4.SelectedBackgroundColor = System.Drawing.Color.Gray
        EnhancedColumnHeaderRenderer4.SelectedGridLineColor = System.Drawing.Color.DimGray
        EnhancedColumnHeaderRenderer4.TextRotationAngle = 0R
        EnhancedColumnHeaderRenderer4.VerticalAlignment = FarPoint.Win.VerticalAlignment.Top
        NamedStyle28.Renderer = EnhancedColumnHeaderRenderer4
        NamedStyle28.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle29.BackColor = System.Drawing.Color.Silver
        NamedStyle29.ForeColor = System.Drawing.SystemColors.ControlText
        NamedStyle29.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        EnhancedRowHeaderRenderer4.ActiveBackgroundColor = System.Drawing.Color.DarkGray
        EnhancedRowHeaderRenderer4.BackColor = System.Drawing.Color.Empty
        EnhancedRowHeaderRenderer4.BackColor2 = System.Drawing.Color.Empty
        EnhancedRowHeaderRenderer4.DarkColor = System.Drawing.Color.Empty
        EnhancedRowHeaderRenderer4.Font = Nothing
        EnhancedRowHeaderRenderer4.ForeColor = System.Drawing.Color.Empty
        EnhancedRowHeaderRenderer4.HorizontalAlignment = FarPoint.Win.HorizontalAlignment.Left
        EnhancedRowHeaderRenderer4.LightColor = System.Drawing.Color.Empty
        EnhancedRowHeaderRenderer4.Name = Nothing
        EnhancedRowHeaderRenderer4.NormalGridLineColor = System.Drawing.Color.DarkGray
        EnhancedRowHeaderRenderer4.SelectedActiveBackgroundColor = System.Drawing.Color.DarkGray
        EnhancedRowHeaderRenderer4.SelectedBackgroundColor = System.Drawing.Color.Gray
        EnhancedRowHeaderRenderer4.SelectedGridLineColor = System.Drawing.Color.DimGray
        EnhancedRowHeaderRenderer4.TextRotationAngle = 0R
        EnhancedRowHeaderRenderer4.VerticalAlignment = FarPoint.Win.VerticalAlignment.Top
        NamedStyle29.Renderer = EnhancedRowHeaderRenderer4
        NamedStyle29.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle30.BackColor = System.Drawing.Color.DimGray
        NamedStyle30.ForeColor = System.Drawing.SystemColors.ControlText
        NamedStyle30.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        EnhancedCornerRenderer4.ActiveBackgroundColor = System.Drawing.Color.Gray
        EnhancedCornerRenderer4.GridLineColor = System.Drawing.Color.Empty
        EnhancedCornerRenderer4.NormalBackgroundColor = System.Drawing.Color.DarkGray
        NamedStyle30.Renderer = EnhancedCornerRenderer4
        NamedStyle30.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle31.BackColor = System.Drawing.Color.Empty
        NamedStyle31.CellType = GeneralCellType4
        NamedStyle31.ForeColor = System.Drawing.SystemColors.WindowText
        NamedStyle31.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        NamedStyle31.Renderer = GeneralCellType4
        NamedStyle31.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.f결과sub.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.f결과sub_Sheet1})
        Me.f결과sub.Skin = FarPoint.Win.Spread.DefaultSpreadSkins.Office2016White
        Me.f결과sub.NamedStyles.AddRange(New FarPoint.Win.Spread.NamedStyle() {NamedStyle26, NamedStyle27, NamedStyle28, NamedStyle29, NamedStyle30, NamedStyle31})
        Me.f결과sub.TitleInfo.BackColor = System.Drawing.Color.Blue
        Me.f결과sub.TitleInfo.Value = ""
        f결과sub_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StopEditing)
        f결과sub_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumn)
        f결과sub_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Left, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumn)
        f결과sub_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousRow)
        f결과sub_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextRow)
        f결과sub_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Home, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToFirstColumn)
        f결과sub_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[End], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToLastColumn)
        f결과sub_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.PageUp, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousPageOfRows)
        f결과sub_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Next], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextPageOfRows)
        f결과sub_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F3, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StopEditing)
        f결과sub_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Back, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StartEditing)
        Me.f결과sub.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenFocused, FarPoint.Win.Spread.OperationMode.Normal, f결과sub_InputMapWhenFocusedNormal)
        f결과sub_InputMapWhenFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(Global.Microsoft.VisualBasic.ChrW(61)), FarPoint.Win.Spread.SpreadActions.StartEditingFormula)
        f결과sub_InputMapWhenFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ComboShowList)
        f결과sub_InputMapWhenFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ComboShowList)
        f결과sub_InputMapWhenFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F4, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.ShowSubEditor)
        f결과sub_InputMapWhenFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Z, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.Undo)
        f결과sub_InputMapWhenFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Y, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.Redo)
        Me.f결과sub.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenFocused, FarPoint.Win.Spread.OperationMode.RowMode, f결과sub_InputMapWhenFocusedRowMode)
        f결과sub_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StopEditing)
        f결과sub_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Home, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToFirstColumn)
        f결과sub_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[End], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToLastColumn)
        f결과sub_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumn)
        f결과sub_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.PageUp, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousPageOfRows)
        f결과sub_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Next], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextPageOfRows)
        f결과sub_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F3, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StopEditing)
        f결과sub_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Back, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StartEditing)
        f결과sub_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousRow)
        f결과sub_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextRow)
        f결과sub_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Left, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumn)
        Me.f결과sub.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenAncestorOfFocused, FarPoint.Win.Spread.OperationMode.Normal, f결과sub_InputMapWhenAncestorOfFocusedNormal)
        f결과sub_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousRow)
        f결과sub_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextRow)
        f결과sub_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Left, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumnVisual)
        f결과sub_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnVisual)
        f결과sub_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToPreviousRow)
        f결과sub_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToNextRow)
        f결과sub_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Left, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumnVisual)
        f결과sub_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Right, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnVisual)
        f결과sub_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.PageUp, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousPageOfRows)
        f결과sub_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Next], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextPageOfRows)
        f결과sub_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.PageUp, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToPreviousPageOfColumns)
        f결과sub_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Next], CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToNextPageOfColumns)
        f결과sub_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Home, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToFirstColumn)
        f결과sub_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[End], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToLastColumn)
        f결과sub_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Home, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToFirstCell)
        f결과sub_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[End], CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToLastCell)
        f결과sub_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Escape, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.CancelEditing)
        f결과sub_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StopEditing)
        f결과sub_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.CSEStopEditing)
        f결과sub_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Tab, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        f결과sub_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Tab, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumnWrap)
        f결과sub_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.ClearCell)
        f결과sub_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F4, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.ShowSubEditor)
        f결과sub_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ComboShowList)
        f결과sub_InputMapWhenAncestorOfFocusedRowMode.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ComboShowList)
        Me.f결과sub.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenAncestorOfFocused, FarPoint.Win.Spread.OperationMode.RowMode, f결과sub_InputMapWhenAncestorOfFocusedRowMode)
        Me.f결과sub.SetViewportLeftColumn(0, 0, 6)
        Me.f결과sub.SetActiveViewport(0, 0, -1)
        '
        'f결과sub_Sheet1
        '
        Me.f결과sub_Sheet1.Reset()
        Me.f결과sub_Sheet1.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.f결과sub_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.f결과sub_Sheet1.ColumnCount = 9
        Me.f결과sub_Sheet1.RowCount = 50
        Me.f결과sub_Sheet1.ActiveSkin = FarPoint.Win.Spread.DefaultSkins.Default
        Me.f결과sub_Sheet1.AlternatingRows.Get(1).BackColor = System.Drawing.Color.WhiteSmoke
        Me.f결과sub_Sheet1.Cells.Get(0, 0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        Me.f결과sub_Sheet1.Cells.Get(0, 0).Value = "2021-06"
        Me.f결과sub_Sheet1.Cells.Get(0, 0).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.f결과sub_Sheet1.Cells.Get(0, 1).Value = "15:00"
        Me.f결과sub_Sheet1.Cells.Get(0, 2).Value = 12
        Me.f결과sub_Sheet1.Cells.Get(0, 4).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        Me.f결과sub_Sheet1.Cells.Get(0, 4).Value = "2020-04-05"
        Me.f결과sub_Sheet1.Cells.Get(0, 4).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.f결과sub_Sheet1.Cells.Get(1, 0).Value = "31204996"
        Me.f결과sub_Sheet1.ColumnFooter.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.f결과sub_Sheet1.ColumnFooter.DefaultStyle.BackColor = System.Drawing.Color.Empty
        Me.f결과sub_Sheet1.ColumnFooter.DefaultStyle.ForeColor = System.Drawing.Color.Empty
        Me.f결과sub_Sheet1.ColumnFooter.DefaultStyle.Locked = False
        Me.f결과sub_Sheet1.ColumnFooter.DefaultStyle.Parent = "ColumnFooterFlatOffice2016White"
        Me.f결과sub_Sheet1.ColumnFooter.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.f결과sub_Sheet1.ColumnFooter.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.f결과sub_Sheet1.ColumnFooterSheetCornerStyle.BackColor = System.Drawing.Color.Empty
        Me.f결과sub_Sheet1.ColumnFooterSheetCornerStyle.ForeColor = System.Drawing.Color.Empty
        Me.f결과sub_Sheet1.ColumnFooterSheetCornerStyle.Locked = False
        Me.f결과sub_Sheet1.ColumnFooterSheetCornerStyle.Parent = "CornerFooterFlatOffice2016White"
        Me.f결과sub_Sheet1.ColumnFooterSheetCornerStyle.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.f결과sub_Sheet1.ColumnHeader.AutoText = FarPoint.Win.Spread.HeaderAutoText.Numbers
        Me.f결과sub_Sheet1.ColumnHeader.Cells.Get(0, 0).Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.f결과sub_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "내원일"
        Me.f결과sub_Sheet1.ColumnHeader.Cells.Get(0, 1).Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.f결과sub_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "내원시각"
        Me.f결과sub_Sheet1.ColumnHeader.Cells.Get(0, 2).Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.f결과sub_Sheet1.ColumnHeader.Cells.Get(0, 2).Value = "연령"
        Me.f결과sub_Sheet1.ColumnHeader.Cells.Get(0, 3).Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.f결과sub_Sheet1.ColumnHeader.Cells.Get(0, 3).Value = "외/입"
        Me.f결과sub_Sheet1.ColumnHeader.Cells.Get(0, 4).Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.f결과sub_Sheet1.ColumnHeader.Cells.Get(0, 4).Tag = "HIDDEN"
        Me.f결과sub_Sheet1.ColumnHeader.Cells.Get(0, 4).Value = "진료과"
        Me.f결과sub_Sheet1.ColumnHeader.Cells.Get(0, 5).Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.f결과sub_Sheet1.ColumnHeader.Cells.Get(0, 5).Value = "진료의"
        Me.f결과sub_Sheet1.ColumnHeader.Cells.Get(0, 6).Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.f결과sub_Sheet1.ColumnHeader.Cells.Get(0, 6).Value = "초재구분"
        Me.f결과sub_Sheet1.ColumnHeader.Cells.Get(0, 7).Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.f결과sub_Sheet1.ColumnHeader.Cells.Get(0, 7).Value = "M/S"
        Me.f결과sub_Sheet1.ColumnHeader.Cells.Get(0, 8).Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.f결과sub_Sheet1.ColumnHeader.Cells.Get(0, 8).Value = "비 고"
        Me.f결과sub_Sheet1.ColumnHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.f결과sub_Sheet1.ColumnHeader.DefaultStyle.BackColor = System.Drawing.Color.Empty
        Me.f결과sub_Sheet1.ColumnHeader.DefaultStyle.ForeColor = System.Drawing.Color.Empty
        Me.f결과sub_Sheet1.ColumnHeader.DefaultStyle.Locked = False
        Me.f결과sub_Sheet1.ColumnHeader.DefaultStyle.Parent = "ColumnHeaderFlatOffice2016White"
        Me.f결과sub_Sheet1.ColumnHeader.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.f결과sub_Sheet1.ColumnHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.f결과sub_Sheet1.ColumnHeader.Rows.Get(0).Height = 26.0!
        Me.f결과sub_Sheet1.Columns.Get(0).CellType = TextCellType24
        Me.f결과sub_Sheet1.Columns.Get(0).Font = New System.Drawing.Font("맑은 고딕", 9.0!)
        Me.f결과sub_Sheet1.Columns.Get(0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        Me.f결과sub_Sheet1.Columns.Get(0).Label = "내원일"
        Me.f결과sub_Sheet1.Columns.Get(0).Locked = True
        Me.f결과sub_Sheet1.Columns.Get(0).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.f결과sub_Sheet1.Columns.Get(0).Width = 79.0!
        Me.f결과sub_Sheet1.Columns.Get(1).CellType = TextCellType25
        Me.f결과sub_Sheet1.Columns.Get(1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.f결과sub_Sheet1.Columns.Get(1).Label = "내원시각"
        Me.f결과sub_Sheet1.Columns.Get(1).Locked = True
        Me.f결과sub_Sheet1.Columns.Get(1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.f결과sub_Sheet1.Columns.Get(2).CellType = TextCellType26
        Me.f결과sub_Sheet1.Columns.Get(2).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.f결과sub_Sheet1.Columns.Get(2).Label = "연령"
        Me.f결과sub_Sheet1.Columns.Get(2).Locked = True
        Me.f결과sub_Sheet1.Columns.Get(2).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.f결과sub_Sheet1.Columns.Get(2).Visible = False
        Me.f결과sub_Sheet1.Columns.Get(2).Width = 56.0!
        Me.f결과sub_Sheet1.Columns.Get(3).CellType = TextCellType27
        Me.f결과sub_Sheet1.Columns.Get(3).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.f결과sub_Sheet1.Columns.Get(3).Label = "외/입"
        Me.f결과sub_Sheet1.Columns.Get(3).Locked = True
        Me.f결과sub_Sheet1.Columns.Get(3).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.f결과sub_Sheet1.Columns.Get(3).Width = 43.0!
        Me.f결과sub_Sheet1.Columns.Get(4).CellType = TextCellType28
        Me.f결과sub_Sheet1.Columns.Get(4).Font = New System.Drawing.Font("맑은 고딕", 9.0!)
        Me.f결과sub_Sheet1.Columns.Get(4).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.f결과sub_Sheet1.Columns.Get(4).Label = "진료과"
        Me.f결과sub_Sheet1.Columns.Get(4).Locked = True
        Me.f결과sub_Sheet1.Columns.Get(4).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.f결과sub_Sheet1.Columns.Get(4).Width = 67.0!
        Me.f결과sub_Sheet1.Columns.Get(5).CellType = TextCellType29
        Me.f결과sub_Sheet1.Columns.Get(5).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.f결과sub_Sheet1.Columns.Get(5).Label = "진료의"
        Me.f결과sub_Sheet1.Columns.Get(5).Locked = True
        Me.f결과sub_Sheet1.Columns.Get(5).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.f결과sub_Sheet1.Columns.Get(5).Width = 67.0!
        Me.f결과sub_Sheet1.Columns.Get(6).CellType = TextCellType30
        Me.f결과sub_Sheet1.Columns.Get(6).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.f결과sub_Sheet1.Columns.Get(6).Label = "초재구분"
        Me.f결과sub_Sheet1.Columns.Get(6).Locked = True
        Me.f결과sub_Sheet1.Columns.Get(6).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.f결과sub_Sheet1.Columns.Get(6).Visible = False
        Me.f결과sub_Sheet1.Columns.Get(6).Width = 94.0!
        Me.f결과sub_Sheet1.Columns.Get(7).CellType = TextCellType31
        Me.f결과sub_Sheet1.Columns.Get(7).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.f결과sub_Sheet1.Columns.Get(7).Label = "M/S"
        Me.f결과sub_Sheet1.Columns.Get(7).Locked = True
        Me.f결과sub_Sheet1.Columns.Get(7).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.f결과sub_Sheet1.Columns.Get(8).CellType = TextCellType32
        Me.f결과sub_Sheet1.Columns.Get(8).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        Me.f결과sub_Sheet1.Columns.Get(8).Label = "비 고"
        Me.f결과sub_Sheet1.Columns.Get(8).Locked = True
        Me.f결과sub_Sheet1.Columns.Get(8).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.f결과sub_Sheet1.Columns.Get(8).Width = 354.0!
        Me.f결과sub_Sheet1.DefaultStyle.BackColor = System.Drawing.Color.Empty
        Me.f결과sub_Sheet1.DefaultStyle.ForeColor = System.Drawing.Color.Empty
        Me.f결과sub_Sheet1.DefaultStyle.Locked = False
        Me.f결과sub_Sheet1.DefaultStyle.Parent = "DataAreaDefault"
        Me.f결과sub_Sheet1.FilterBar.DefaultStyle.BackColor = System.Drawing.Color.Empty
        Me.f결과sub_Sheet1.FilterBar.DefaultStyle.ForeColor = System.Drawing.Color.Empty
        Me.f결과sub_Sheet1.FilterBar.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.f결과sub_Sheet1.FilterBar.DefaultStyle.Locked = False
        Me.f결과sub_Sheet1.FilterBar.DefaultStyle.Parent = "FilterBarFlatOffice2016White"
        Me.f결과sub_Sheet1.FilterBar.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.f결과sub_Sheet1.FilterBar.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.f결과sub_Sheet1.FilterBarHeaderStyle.BackColor = System.Drawing.Color.Empty
        Me.f결과sub_Sheet1.FilterBarHeaderStyle.ForeColor = System.Drawing.Color.Empty
        Me.f결과sub_Sheet1.FilterBarHeaderStyle.Locked = False
        Me.f결과sub_Sheet1.FilterBarHeaderStyle.Parent = "FilterBarHeaderFlatOffice2016White"
        Me.f결과sub_Sheet1.FilterBarHeaderStyle.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.f결과sub_Sheet1.FrozenColumnCount = 6
        Me.f결과sub_Sheet1.GrayAreaBackColor = System.Drawing.Color.White
        Me.f결과sub_Sheet1.HorizontalGridLine = New FarPoint.Win.Spread.GridLine(FarPoint.Win.Spread.GridLineType.Flat, System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(208, Byte), Integer)))
        Me.f결과sub_Sheet1.OperationMode = FarPoint.Win.Spread.OperationMode.RowMode
        Me.f결과sub_Sheet1.Protect = True
        Me.f결과sub_Sheet1.RowHeader.Columns.Default.Resizable = False
        Me.f결과sub_Sheet1.RowHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.f결과sub_Sheet1.RowHeader.DefaultStyle.BackColor = System.Drawing.Color.Empty
        Me.f결과sub_Sheet1.RowHeader.DefaultStyle.ForeColor = System.Drawing.Color.Empty
        Me.f결과sub_Sheet1.RowHeader.DefaultStyle.Locked = False
        Me.f결과sub_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderFlatOffice2016White"
        Me.f결과sub_Sheet1.RowHeader.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.f결과sub_Sheet1.RowHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.f결과sub_Sheet1.Rows.Get(0).Height = 22.0!
        Me.f결과sub_Sheet1.Rows.Get(1).Height = 22.0!
        Me.f결과sub_Sheet1.Rows.Get(2).Height = 22.0!
        Me.f결과sub_Sheet1.Rows.Get(3).Height = 22.0!
        Me.f결과sub_Sheet1.Rows.Get(4).Height = 22.0!
        Me.f결과sub_Sheet1.Rows.Get(5).Height = 22.0!
        Me.f결과sub_Sheet1.Rows.Get(6).Height = 22.0!
        Me.f결과sub_Sheet1.Rows.Get(7).Height = 22.0!
        Me.f결과sub_Sheet1.Rows.Get(8).Height = 22.0!
        Me.f결과sub_Sheet1.Rows.Get(9).Height = 22.0!
        Me.f결과sub_Sheet1.Rows.Get(10).Height = 22.0!
        Me.f결과sub_Sheet1.Rows.Get(11).Height = 22.0!
        Me.f결과sub_Sheet1.Rows.Get(12).Height = 22.0!
        Me.f결과sub_Sheet1.Rows.Get(13).Height = 22.0!
        Me.f결과sub_Sheet1.SelectionBackColor = System.Drawing.Color.Transparent
        Me.f결과sub_Sheet1.SelectionStyle = FarPoint.Win.Spread.SelectionStyles.Both
        Me.f결과sub_Sheet1.SheetCornerStyle.BackColor = System.Drawing.Color.Empty
        Me.f결과sub_Sheet1.SheetCornerStyle.ForeColor = System.Drawing.Color.Empty
        Me.f결과sub_Sheet1.SheetCornerStyle.Locked = False
        Me.f결과sub_Sheet1.SheetCornerStyle.Parent = "CornerHeaderFlatOffice2016White"
        Me.f결과sub_Sheet1.SheetCornerStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.f결과sub_Sheet1.SheetCornerStyle.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.f결과sub_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'b종료
        '
        resources.ApplyResources(Me.b종료, "b종료")
        Me.b종료.Appearance.Font = CType(resources.GetObject("b종료.Appearance.Font"), System.Drawing.Font)
        Me.b종료.Appearance.Options.UseFont = True
        Me.b종료.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.b종료.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b종료.ImageOptions.Image = CType(resources.GetObject("b종료.ImageOptions.Image"), System.Drawing.Image)
        Me.b종료.Name = "b종료"
        '
        'b실행
        '
        resources.ApplyResources(Me.b실행, "b실행")
        Me.b실행.Appearance.Font = CType(resources.GetObject("b실행.Appearance.Font"), System.Drawing.Font)
        Me.b실행.Appearance.Options.UseFont = True
        Me.b실행.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.b실행.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b실행.ImageOptions.Image = CType(resources.GetObject("b실행.ImageOptions.Image"), System.Drawing.Image)
        Me.b실행.Name = "b실행"
        '
        'l서버연결
        '
        resources.ApplyResources(Me.l서버연결, "l서버연결")
        Me.l서버연결.Appearance.Font = CType(resources.GetObject("l서버연결.Appearance.Font"), System.Drawing.Font)
        Me.l서버연결.Appearance.Options.UseFont = True
        Me.l서버연결.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.l서버연결.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.l서버연결.Name = "l서버연결"
        '
        'l서버연결해제
        '
        resources.ApplyResources(Me.l서버연결해제, "l서버연결해제")
        Me.l서버연결해제.Appearance.Font = CType(resources.GetObject("l서버연결해제.Appearance.Font"), System.Drawing.Font)
        Me.l서버연결해제.Appearance.ForeColor = System.Drawing.Color.Silver
        Me.l서버연결해제.Appearance.Options.UseFont = True
        Me.l서버연결해제.Appearance.Options.UseForeColor = True
        Me.l서버연결해제.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.l서버연결해제.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.l서버연결해제.Name = "l서버연결해제"
        '
        't챠트번호
        '
        resources.ApplyResources(Me.t챠트번호, "t챠트번호")
        Me.t챠트번호.Name = "t챠트번호"
        Me.t챠트번호.Properties.Appearance.Font = CType(resources.GetObject("t챠트번호.Properties.Appearance.Font"), System.Drawing.Font)
        Me.t챠트번호.Properties.Appearance.ForeColor = System.Drawing.Color.Green
        Me.t챠트번호.Properties.Appearance.Options.UseFont = True
        Me.t챠트번호.Properties.Appearance.Options.UseForeColor = True
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = CType(resources.GetObject("LabelControl1.Appearance.Font"), System.Drawing.Font)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.LabelControl1.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelControl1.ImageOptions.Image = CType(resources.GetObject("LabelControl1.ImageOptions.Image"), System.Drawing.Image)
        resources.ApplyResources(Me.LabelControl1, "LabelControl1")
        Me.LabelControl1.Name = "LabelControl1"
        '
        't처방코드
        '
        resources.ApplyResources(Me.t처방코드, "t처방코드")
        Me.t처방코드.Name = "t처방코드"
        Me.t처방코드.Properties.Appearance.Font = CType(resources.GetObject("t처방코드.Properties.Appearance.Font"), System.Drawing.Font)
        Me.t처방코드.Properties.Appearance.ForeColor = System.Drawing.Color.Green
        Me.t처방코드.Properties.Appearance.Options.UseFont = True
        Me.t처방코드.Properties.Appearance.Options.UseForeColor = True
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = CType(resources.GetObject("LabelControl3.Appearance.Font"), System.Drawing.Font)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.LabelControl3.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelControl3.ImageOptions.Image = CType(resources.GetObject("LabelControl3.ImageOptions.Image"), System.Drawing.Image)
        resources.ApplyResources(Me.LabelControl3, "LabelControl3")
        Me.LabelControl3.Name = "LabelControl3"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = CType(resources.GetObject("LabelControl4.Appearance.Font"), System.Drawing.Font)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.LabelControl4.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelControl4.ImageOptions.Image = CType(resources.GetObject("LabelControl4.ImageOptions.Image"), System.Drawing.Image)
        resources.ApplyResources(Me.LabelControl4, "LabelControl4")
        Me.LabelControl4.Name = "LabelControl4"
        '
        'd산출기간2
        '
        resources.ApplyResources(Me.d산출기간2, "d산출기간2")
        Me.d산출기간2.Name = "d산출기간2"
        Me.d산출기간2.Properties.Appearance.Font = CType(resources.GetObject("d산출기간2.Properties.Appearance.Font"), System.Drawing.Font)
        Me.d산출기간2.Properties.Appearance.Options.UseFont = True
        Me.d산출기간2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("d산출기간2.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.d산출기간2.Properties.CalendarTimeProperties.Appearance.Options.UseTextOptions = True
        Me.d산출기간2.Properties.CalendarTimeProperties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.d산출기간2.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("d산출기간2.Properties.CalendarTimeProperties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        '
        'd산출기간1
        '
        resources.ApplyResources(Me.d산출기간1, "d산출기간1")
        Me.d산출기간1.Name = "d산출기간1"
        Me.d산출기간1.Properties.Appearance.Font = CType(resources.GetObject("d산출기간1.Properties.Appearance.Font"), System.Drawing.Font)
        Me.d산출기간1.Properties.Appearance.Options.UseFont = True
        Me.d산출기간1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("d산출기간1.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.d산출기간1.Properties.CalendarTimeProperties.Appearance.Options.UseTextOptions = True
        Me.d산출기간1.Properties.CalendarTimeProperties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.d산출기간1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("d산출기간1.Properties.CalendarTimeProperties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Name = "Label1"
        '
        'l타이틀
        '
        Me.l타이틀.Appearance.Font = CType(resources.GetObject("l타이틀.Appearance.Font"), System.Drawing.Font)
        Me.l타이틀.Appearance.Options.UseFont = True
        Me.l타이틀.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.l타이틀.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.l타이틀.ImageOptions.Image = CType(resources.GetObject("l타이틀.ImageOptions.Image"), System.Drawing.Image)
        resources.ApplyResources(Me.l타이틀, "l타이틀")
        Me.l타이틀.Name = "l타이틀"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = CType(resources.GetObject("LabelControl5.Appearance.Font"), System.Drawing.Font)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.LabelControl5.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelControl5.ImageOptions.Image = CType(resources.GetObject("LabelControl5.ImageOptions.Image"), System.Drawing.Image)
        resources.ApplyResources(Me.LabelControl5, "LabelControl5")
        Me.LabelControl5.Name = "LabelControl5"
        '
        't청구일련번호
        '
        resources.ApplyResources(Me.t청구일련번호, "t청구일련번호")
        Me.t청구일련번호.Name = "t청구일련번호"
        Me.t청구일련번호.Properties.Appearance.Font = CType(resources.GetObject("t청구일련번호.Properties.Appearance.Font"), System.Drawing.Font)
        Me.t청구일련번호.Properties.Appearance.ForeColor = System.Drawing.Color.Green
        Me.t청구일련번호.Properties.Appearance.Options.UseFont = True
        Me.t청구일련번호.Properties.Appearance.Options.UseForeColor = True
        '
        'luDB
        '
        resources.ApplyResources(Me.luDB, "luDB")
        Me.luDB.Name = "luDB"
        Me.luDB.Properties.Appearance.Font = CType(resources.GetObject("luDB.Properties.Appearance.Font"), System.Drawing.Font)
        Me.luDB.Properties.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.luDB.Properties.Appearance.Options.UseFont = True
        Me.luDB.Properties.Appearance.Options.UseForeColor = True
        Me.luDB.Properties.AppearanceDropDown.Font = CType(resources.GetObject("luDB.Properties.AppearanceDropDown.Font"), System.Drawing.Font)
        Me.luDB.Properties.AppearanceDropDown.Options.UseFont = True
        Me.luDB.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("luDB.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.luDB.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.luDB.Properties.NullText = resources.GetString("luDB.Properties.NullText")
        Me.luDB.Properties.PopupWidth = 450
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl6.Appearance.Font = CType(resources.GetObject("LabelControl6.Appearance.Font"), System.Drawing.Font)
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.LabelControl6.Appearance.Options.UseBackColor = True
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Appearance.Options.UseForeColor = True
        Me.LabelControl6.Appearance.Options.UseTextOptions = True
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        resources.ApplyResources(Me.LabelControl6, "LabelControl6")
        Me.LabelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.LabelControl6.Name = "LabelControl6"
        '
        'b쿼리추가
        '
        resources.ApplyResources(Me.b쿼리추가, "b쿼리추가")
        Me.b쿼리추가.Appearance.Font = CType(resources.GetObject("b쿼리추가.Appearance.Font"), System.Drawing.Font)
        Me.b쿼리추가.Appearance.Options.UseFont = True
        Me.b쿼리추가.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.b쿼리추가.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b쿼리추가.ImageOptions.Image = CType(resources.GetObject("b쿼리추가.ImageOptions.Image"), System.Drawing.Image)
        Me.b쿼리추가.Name = "b쿼리추가"
        '
        'LabelControl7
        '
        Me.LabelControl7.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.LabelControl7.Appearance.Font = CType(resources.GetObject("LabelControl7.Appearance.Font"), System.Drawing.Font)
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.SystemColors.Desktop
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Appearance.Options.UseForeColor = True
        Me.LabelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.LabelControl7.ImageOptions.Alignment = System.Drawing.ContentAlignment.BottomLeft
        Me.LabelControl7.ImageOptions.Image = Global.데이터쿼리뷰어.My.Resources.Resources.floatingobjectoutlinecolor_16x161
        resources.ApplyResources(Me.LabelControl7, "LabelControl7")
        Me.LabelControl7.Name = "LabelControl7"
        '
        't수진자명
        '
        resources.ApplyResources(Me.t수진자명, "t수진자명")
        Me.t수진자명.Name = "t수진자명"
        '
        'frm자료보기
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CausesValidation = False
        Me.Controls.Add(Me.t수진자명)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.b쿼리추가)
        Me.Controls.Add(Me.luDB)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.t청구일련번호)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.l타이틀)
        Me.Controls.Add(Me.d산출기간2)
        Me.Controls.Add(Me.d산출기간1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.t처방코드)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.t챠트번호)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Controls.Add(Me.l서버연결)
        Me.Controls.Add(Me.l서버연결해제)
        Me.Controls.Add(Me.b종료)
        Me.Controls.Add(Me.b실행)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.KeyPreview = True
        Me.Name = "frm자료보기"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.f결과, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnu결과.ResumeLayout(False)
        CType(Me.f결과_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel1.PerformLayout()
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        CType(Me.sprCodes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sprCodes_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.f검색, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.f검색_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t검색어.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tab쿼리, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab쿼리.ResumeLayout(False)
        Me.tabQUERY.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.SplitContainer5.Panel1.ResumeLayout(False)
        Me.SplitContainer5.Panel1.PerformLayout()
        Me.SplitContainer5.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer5.ResumeLayout(False)
        CType(Me.f결과sub, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.f결과sub_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t챠트번호.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t처방코드.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.d산출기간2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.d산출기간2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.d산출기간1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.d산출기간1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t청구일련번호.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luDB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t수진자명.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents t쿼리 As TextBox
    Friend WithEvents b종료 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents b실행 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents l서버연결 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents l서버연결해제 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents f결과 As FarPoint.Win.Spread.FpSpread
    Friend WithEvents f결과_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents f검색 As FarPoint.Win.Spread.FpSpread
    Friend WithEvents f검색_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents b검색 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents t챠트번호 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tab쿼리 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabQUERY As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents t처방코드 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents SplitContainer4 As SplitContainer
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents d산출기간2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents d산출기간1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents l타이틀 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents t청구일련번호 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents mnu결과 As ContextMenuStrip
    Friend WithEvents mnu결과엑셀변환 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuPDF출력하기 As ToolStripMenuItem
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SplitContainer5 As SplitContainer
    Friend WithEvents t쿼리sub As TextBox
    Friend WithEvents f결과sub As FarPoint.Win.Spread.FpSpread
    Friend WithEvents f결과sub_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents luDB As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents b쿼리추가 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents sprCodes As FarPoint.Win.Spread.FpSpread
    Friend WithEvents sprCodes_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents t수진자명 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents t검색어 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents l확인방법 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
End Class
