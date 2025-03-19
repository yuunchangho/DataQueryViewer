Module mdl변수

    Public Const strP_ProgramName = "ProgramName"
    Public Const strP_ProgramHanName = "프로그램이름"
    Public strG_ProgramName As String
    Public strG_Path로그 As String
    Public intG_ErrorCount As Integer
    Public Const conG_취소 = "|취소|"
    Public Const conG_구분자 = "|"
    Public Const conG_분류 = "="
    Public Const conG_열거 = ","
    Public Const conG_구분끝 = ""
    Public Const conG_구분시작 = ""
    Public Const conG_속성구분 = "「"    '바이탈 컬럼 속성용
    Public Const conG_관리자비밀번호 = "TMZPDLFDJQ" '스케일업
    Public Const conG_SenseINI = "C:\Sense\Bin\Sense.ini" 'Sense ini 파일
    Public Const conG_MedichartINI = "C:\Medichart\Bin\Medichart.ini" '23/10/11 준혁 추가
    Public Const conG_HanimacINI = "C:\HanimacPro\Bin\Medichart.ini" '23/10/19 준혁 추가
    Public Const conG_EchartINI = "C:\E_Chart\E_Chart.ini" '23/11/22 준혁 추가
    Public Const 년월일 = "yyyy-MM-dd"
    Public Const 년월 = "yyyy-MM"
    Public Const 년월일시분 = "yyyy-MM-dd HH:mm"
    Public Const 년월일시분초 = "yyyy-MM-dd HH:mm:ss"
    Public Const 년월일시분초yyyyMMddHHmmss = "yyyyMMddHHmmss"
    Public Const 시분초 = "HH:mm:ss"
    Public Const 시분 = "HH:mm"
    Public Const 금액Format = "#,##0"
    Public Const conG_HTMLText = "<Color=AliceBlue>{타이틀}</Color>"

    Public strG_Path실행경로 As String

    Public strG_Path리소스 As String
    Public strG_Path설정 As String
    Public strG_Path그리드설정 As String '20/12/29 재민
    Public strG_INI폼설정 As String

    Public strG_Path프로그램설정 As String
    Public strG_ProgramHanName As String
    Public strG_ProgramVersion As String


#Region "Enum 모음"

    Public Enum ocsEnumCodeLibType
        ocsCodeLibType00코드정의 = 0
        ocsCodeLibType01처방코드구분 = 1
        ocsCodeLibType02처방예외구분 = 2
        ocsCodeLibType03수탁구분 = 3
        ocsCodeLibType04초재진구분 = 4
        ocsCodeLibType05보험구분 = 5
        ocsCodeLibType06진료과목 = 6
        ocsCodeLibType07계산서영수증 = 7
        ocsCodeLibType08검사구분 = 8
        ocsCodeLibType09할인코드 = 9
        ocsCodeLibType10카드정보 = 10
        ocsCodeLibType11사용자직분 = 11
        ocsCodeLibType12사용자상태 = 12
        ocsCodeLibType13확인코드 = 13
        ocsCodeLibType14특정기호 = 14
        ocsCodeLibType15심사불능코드 = 15
        ocsCodeLibType16심사자격유형 = 16
        ocsCodeLibType17진료결과 = 17
        ocsCodeLibType18도착경로 = 18
        ocsCodeLibType19입원경로 = 19
        ocsCodeLibType20의료급여종별구분 = 20
        ocsCodeLibType21공상구분 = 21
        ocsCodeLibType22오류사유코드 = 22
        ocsCodeLibType23병원종별 = 23
        ocsCodeLibType24급여구분 = 24
        ocsCodeLibType25처방목구분 = 25
        ocsCodeLibType26병실등급 = 26
        ocsCodeLibType27병실구분 = 27
        ocsCodeLibType28제한연령구분 = 28
        ocsCodeLibType29행위구분 = 29
        ocsCodeLibType30투여량조건 = 30
        ocsCodeLibType31수탁기관 = 31
        ocsCodeLibType32수가산정코드 = 32
        ocsCodeLibType33진료지원구분 = 33
        ocsCodeLibType34처방항구분 = 34
        ocsCodeLibType35상해외인 = 35
        ocsCodeLibType36가족관계 = 36
        ocsCodeLibType37청구구분 = 37
        ocsCodeLibType38공휴야간구분 = 38
        ocsCodeLibType39나이구분 = 39
        ocsCodeLibType40산정특례 = 40
        ocsCodeLibType41요약주소 = 41
        ocsCodeLibType42이메일 = 42
        ocsCodeLibType43소개자관계 = 43
        ocsCodeLibType44정액정율 = 44
        ocsCodeLibType45처방단가적용 = 45
        ocsCodeLibType46입원청구방법 = 46
        ocsCodeLibType47진료상태 = 47
        ocsCodeLibType48상병클래스 = 48
        ocsCodeLibType49즐겨메모 = 49
        ocsCodeLibType50처방전 = 50
        ocsCodeLibType51진찰카드 = 51
        ocsCodeLibType52식이구분 = 52
        ocsCodeLibType53챠트라벨지 = 53
        ocsCodeLibType54검사결과 = 54
        ocsCodeLibType55PACS코드 = 55
        ocsCodeLibType56접수증 = 56
        ocsCodeLibType57의료급여본인부담코드 = 57
        ocsCodeLibType58저함량배수 = 58
        ocsCodeLibType59영상구분 = 59
        ocsCodeLibType75보호종별 = 75 '20/08/05 준혁 추가
        ocsCodeLibType92산재진료결과 = 92
        ocsCodeLibType93EDI수신처 = 93
        ocsCodeLibType94분만기록지 = 94
        ocsCodeLibType95진료실상태 = 95         'ocsCodeLibType95진료실상태 실수 ㅠ.ㅠ
        ocsCodeLibType96의약품분류번호 = 96
        ocsCodeLibType97거래처분류 = 97
        ocsCodeLibType98수술코드통계 = 98
        ocsCodeLibType99중복처방사유 = 99
        ocsCodeLibTypeA101외국인나라 = 101
        ocsCodeLibType103스티커라벨 = 103
        ocsCodeLibType104계약종별 = 104
        ocsCodeLibType105예약구분 = 105         'SONGSH 사용안함
        ocsCodeLibType105스마트카드 = 105
        ocsCodeLibType106예약구분 = 106
        ocsCodeLibType107전체일괄투약 = 107
        ocsCodeLibType108DRG상병유무 = 108
        ocsCodeLibType109지역시도 = 109
        ocsCodeLibType110지역시군구 = 110
        ocsCodeLIbtype111계좌입금 = 111
        ocsCodeLibType112영수증병원양식 = 112       '12/11/09 선용 영수증 병원양식 추가
        ocsCodeLibType113수술실예약 = 113
        ocsCodeLibType114한방영수증 = 114   '13/03/04 선용 한방 영수증추가
        ocsCodeLibType115한방처방목 = 115   '13/03/04 선용 한방 처방목추가
        ocsCodeLibType116한방처방항 = 116   '13/03/15 선용 한방 처방항추가
        ocsCodeLibType117퇴원약처방전 = 117 '13/05/27 대원 퇴원약
        ocsCodeLibType118자동차보험회사 = 118 '13/07/05 선용 자보 개정 작업
        ocsCodeLibType119병원종별가산 = 119 '13/07/17 BY SONG. 병원종별가산 추가
        ocsCodeLibType200자동차보험회사 = 200 '13/10/15 선용 자보 변경
        ocsCodeLibType201선수촌종목 = 201 '13/11/12 선용 선수촌종목 추가
        ocsCodeLibType202선수촌분류 = 202 '13/11/12 선용 선수촌분류 추가
        ocsCodeLibType203제왕절개사유 = 203 '14/04/10 영환 제왕절개사유 추가
        ocsCodeLibType204분만방법 = 204 '14/05/27 영환 분만방법 추가
        ocsCodeLibType206면허종류 = 206 '14/10/20 이준 면허종류 추가
        ocsCodeLibType209인공신장실 = 209   '15/02/23 정근영 추가
        ocsCodeLibType210Bst시간설정 = 210  '15/02/23 정동희 추가
        ocsCodeLibType211간호기록지시간설정 = 211   '15/02/23 정동희 추가
        ocsCodeLibType212항목별시행시간설정 = 212   '15/06/30 희빈 추가
        ocsCodeLibType213바이탈형식설정 = 213   '15/07/14 한샘 추가

        '16/05/30 한샘 CodeLibType 214, 215, 216  추가
        ocsCodeLibType214특진의사배율설정 = 214

        ocsCodeLibType215불임지원금관리 = 215
        ocsCodeLibType216라벨프린터전달부서 = 216
        ocsCodeLibType217수술실상태 = 217 '16/08/03 희빈 수술실 상태 추가.
        ocsCodeLibType218수술실마취방법 = 218 '17/05/16 희빈
        ocsCodeLibType219TAT시간설정 = 219 '17/05/31 희빈
        ocsCodeLibType220자격조회항목 = 220 '20/11/27 재민
        ocsCodeLibType221환자등급 = 221 '21/05/13 명주
        ocsCodeLibType222보훈구분 = 222 '24/08/08 준혁 추가
        ocsCodeLibTypeMAX = 222 '추가될 때마다 늘려줘라
    End Enum

    Public Enum ocsEnumChartAgeLevel
        ocsChartAgeLevel자동 = 0
        ocsChartAgeLevel성인 = 1
        ocsChartAgeLevel1세미만 = 2
        ocsChartAgeLevel3세미만 = 3
        ocsChartAgeLevel6세미만 = 4
        ocsChartAgeLevel8세미만 = 5
        ocsChartAgeLevel70세이상 = 6
        ocsChartAgeLevel65세이상 = 7
        ocsChartAgeLevel뇌성마비 = 9
        ocsChartAgeLevel35세이상 = 10
        ocsChartAgeLevel신생아 = 11
        ocsChartAgeLevel15세이하 = 12
    End Enum

    Public Enum ocsEnumUserPosition
        ocsUserPosition0의사 = 0
        ocsUserPosition1간호사 = 1
        ocsUserPosition2간호보조 = 2
        ocsUserPosition3원무직 = 3
        ocsUserPosition4마취과전문의 = 4
        ocsUserPosition5방사선전문의 = 5
        ocsUserPosition6약사 = 6
        ocsUserPosition7관리자 = 7
        ocsUserPosition8기사 = 8
        ocsUserPosition9기타 = 9
        ocsUserPosition10사회복지사 = 10 '17/08/28 준혁 추가
    End Enum

    '입원청구방법
    Public Enum ocsEnumWardChungKind
        ocsWardChungKindIN = 0
        ocsWardChungKindOUT = 1
        ocsWardChungKindDRG = 2
        ocsWardChungKindBaby = 3
        ocsWardChungKindDRG_S = 4
    End Enum

    Public Enum ocsEnumUserState
        ocsUserState0근무 = 0
        ocsUserState1퇴사 = 1
        ocsUserState2휴가 = 2
        ocsUserState3파트타임 = 3
    End Enum

    Public Enum ocsEnumHospitalKind
        ocsHospitalKind0의원 = 0
        ocsHospitalKind1병원 = 1
        ocsHospitalKind2병원_읍면 = 2
        ocsHospitalKind2사회복지법인 = 2        '사용안함
        ocsHospitalKind3요양병원 = 3            '20120112. BY SONG. 요양병원 구분 추가
        ocsHospitalKind4정신병원 = 4 '24/12/06 준혁 추가
    End Enum

    Public Enum ocsEnumUserPermit
        ocsUserPermit0권한없음 = 0
        ocsUserPermit1조회 = 1
        ocsUserPermit2모든권한 = 2
    End Enum

    Public Enum ocsEnumSugaCostLevel
        ocsSugaCostLevel0급여 = 0
        ocsSugaCostLevel1본인부담 = 1
        ocsSugaCostLevel2비급여공상 = 2         '공상은 급여
        ocsSugaCostLevel3비급여 = 3
        ocsSugaCostLevel4산정불가 = 4
    End Enum

    Public Enum ocsEnumSlipEdit
        ocsSlip0최신 = 0
        ocsSlip1삭제 = 1
    End Enum

    Public Enum ocsEnumSlipCostLevel
        ocsSlipCostLevel0급여 = 0               '보험단가
        ocsSlipCostLevel1본인부담 = 1           '보험단가
        ocsSlipCostLevel2비급여공상 = 2         '보험단가 / 공상은 급여
        ocsSlipCostLevel3비급여 = 3             '일반단가
        ocsSlipCostLevel4산정불가 = 4           '보험단가
        ocsSlipCostLevel5일반 = 5               '일반단가
        ocsSlipCostLevel6급여본인 = 6           '100/100
        ocsSlipCostLevel7일반1 = 7              '일반단가1
        ocsSlipCostLevel8제로 = 8               '제로단가
        ocsSlipCostLevel9사용자 = 9             '사용자
        ocsSlipCostLevelM급여산정 = 20          '마스터설정

        '14/02/26 청구 078 고시내용 a,B항 추가
        ocsSlipCostLevelA급여본인 = 10        '100/80  (A항)

        ocsSlipCostLevelB급여본인 = 11        '100/50  (B항)

        '18/03/07 급여본인 D항 E항 추가
        ocsSlipCostLevelD급여본인 = 12 '100/30

        ocsSlipCostLevelE급여본인 = 13 '100/90

    End Enum

    Public Enum ocsEnumSlipInsert
        ocsSlipInsert0처방 = 0
        ocsSlipInsert1자동 = 1
        ocsSlipInsert2자동입원 = 2
        ocsSlipInsert3자동연결 = 3
        ocsSlipInsert4자동조제 = 4
        ocsSlipInsert5자동주사 = 5
        ocsSlipInsert7자동변경 = 7
        ocsSlipInsert8검사 = 8          '사용안함   ->진료지원 병동 필요처방에서 등록시 사용함 ㅠ.ㅠ
        ocsSlipInsert9묶음 = 9
        ocsSlipInsertA필요처방 = 10
    End Enum

    Public Enum OcsEnumJinIOGbn
        ocsjinIOGbnOut = 0
        ocsjinIOGbnIn = 1
        ocsjinIOGbnInDay = 2
    End Enum

    Public Enum ocsEnumJinStationKind
        ocsjinStationKind없음 = 100   '21/08/19 재민 추가
        ocsJinStationKind진료실 = 0
        ocsJinStationKind데스크 = 1
        ocsJinStationKind예진실 = 2
        ocsJinStationKind원무과 = 3
        ocsJinStationKind검사실 = 4
        ocsJinStationKind물리치료실 = 5
        ocsJinStationKind방사선실 = 6
        ocsJinStationKindMRI실 = 7
        ocsJinStationKindCT실 = 8
        ocsJinStationKind초음파실 = 9
        ocsJinStationKind주사실 = 10
        ocsJinStationKind처치실 = 11
        ocsJinStationKind입원실 = 12
        ocsJinStationKind조제실 = 13
        ocsJinStationKind수술실 = 14
        ocsJinStationKind영양실 = 15
        ocsJinStationKind약국 = 16
        ocsJinStationKind내시경실 = 17
        ocsJinStationKind분만실 = 18
        ocsJinStationKind신생아실 = 19
        ocsJinStationKind간호과 = 20
        ocsJinStationKind검진실 = 21
        ocsJinStationKind총무과 = 22
        ocsJinStationKind기획실 = 23
        ocsJinStationKind경영지원 = 24
        ocsJinStationKind침구실 = 25
        ocsJinStationKind응급실 = 26
        ocsjinStationKind탕제실 = 27
        ocsjinStationKind사회복지실 = 28 '16/01/08 희빈 사회복지실 추가
        ocsjinStationKind불임연구소 = 29 '16/12/17 희빈 불임연구소 추가.
        ocsjinStationKind한방처치실 = 30 '17/07/25 희빈 한방처치실 추가.
    End Enum

    Public Enum ocsEnumBohumKind
        ocsBohumKind0일반 = 0
        ocsBohumKind1국민공단 = 1
        ocsBohumKind2의료급여 = 2
        ocsBohumKind3자동차보험 = 3
        ocsBohumKind4산업재해 = 4
        ocsBohumKind5국민공단본인 = 5
        ocsBohumKind6자보본인 = 6
        ocsBohumKind7산재본인 = 7
        ocsBohumKind8계약 = 8
        ocsBohumKind9보훈상이처 = 9
        ocsBohumKindA정신과정액 = 10
        ocsBohumKindB외국인 = 11
        ocsBohumKindC혈액투석정액 = 12 '14/08/06 가람 추가
        ocsBohumKind13보호본인 = 13 '24/01/16 준혁 추가
    End Enum

    Public Enum ocsEnumChoJaeKind
        ocsChoJaeKind0초진 = 0
        ocsChoJaeKind1재진 = 1
        ocsChoJaeKind2처방전 = 2
        ocsChoJaeKind3물리치료 = 3
        ocsChoJaeKind4입원 = 4
        ocsChoJaeKind5외박 = 5              '낮병동->외박(정신과)
        ocsChoJaeKind6정액수가 = 6
        ocsChoJaeKind7촉탁의 = 7
        ocsChoJaeKind9진찰료없음 = 9
        ocsChoJaeKind10건강검진초진 = 10
        ocsChoJaeKind11건강검진재진 = 11
        ocsChoJaeKind12가정간호 = 12
    End Enum

    Public Enum ocsEnumNightKong
        ocsNightKongWeekday = 0
        ocsNightKongNight = 1
        ocsNightKongHoliday = 2
    End Enum

    Public Enum ocsEnumJungRate
        ocsJungRateFixAmt = 0           '정액
        ocsJungRateFixRate = 1          '정율
        ocsJungRateFixAmtOld = 2        '정액 노인
        ocsJungRateFixRateSan = 3       '정율 산정특례
        ocsJungRateFixIn = 4            '입원   사용x
        ocsJungRateFixRateCD = 5        '정율 어린이
        ocsJungRateFixRateSanCD = 7     '정율 산정특례 어린이
    End Enum

    Public Enum ocsEnumSanSpc
        ocsSanSpcNo = 0
        ocsSanSpcUser20 = 1
        ocsSanSpcUser10 = 2
        ocsSanSpcUser3o = 3
        ocsSanSpcUserNo = 4
        ocsSanSpcUser05 = 5
        ocsSanSpcUser40 = 6
        ocsSanSpcUserBo20 = 7
        ocsSanSpcUser30 = 8
        ocsSanSpcUser03 = 9
    End Enum

    Public Enum OcsEnumDataState
        ocsDataStateNo = 0
        ocsDataStateYes = 1
    End Enum

    Public Enum ocsEnumJinState
        ocsJinStateReserve = 0          '예약
        ocsJinStateApp = 1              '접수1
        ocsJinStateApp2 = 2              '접수2
        ocsJinStateApp3 = 3              '접수3
        ocsJinStateCancel = 4           '취소
        ocsJinStateIN = 5               '입원
        ocsJinStateJinRoom = 6          '진료중
        ocsJinStateSupport = 7          '진료지원완료)
        ocsJinStateWithhold = 8         '보류
        ocsJinStateFinish = 9           '완료
        ocsJinStateAll = 20             '진료상태

    End Enum

    Public Enum ocsEnumJinSupportState
        ocsJinSupportState접수 = 0
        ocsJinSupportState처치 = 1
        ocsJinSupportState보류 = 2
        ocsJinSupportState완료 = 5
        ocsJinSupportStateDC = 6
    End Enum

    '20/12/18 준혁 추가
    Public Enum ocsEnumAccountKind

        ocsAccountNo = 0 '해당 없음
        ocsAccountUnConfirmed = 1 '계좌입금 후 미확인
        ocsAccountConfirmed = 2 '계좌입금 후 확인완료

    End Enum

    Public Enum ocsEnumReceiptKind
        ocsReceiptKindOut = 0           '수납
        ocsReceiptKindRefund = 1        '환불
        ocsReceiptKindChange = 2        '변경
        ocsReceiptKindOutRe = 3         '재발행
        ocsReceiptKindCancel = 4        '수납취소
        ocsReceiptKindKioskWait = 5     '키오스크 수납대기 추가
    End Enum

    '입원상태
    Public Enum ocsEnumWardState
        ocsWardStateIN = 0
        ocsWardStateOUT = 1
        ocsWardStateCancel = 2
        ocsWardStateCollabor = 5
    End Enum

    Public Enum ocsEnumCodeGubn
        ocsCodeGubn수가 = 1
        ocsCodeGubn준용 = 2
        ocsCodeGubn보험등재약 = 3
        ocsCodeGubn원료조제약 = 4
        ocsCodeGubn일반명 = 5
        ocsCodeGubn협약재료대 = 7
        ocsCodeGubn치료재료대 = 8
    End Enum

    Public Enum ocsEnum공상구분
        ocskong공상구분0무 = 0
        ocskong공상구분1공상1 = 1
        ocskong공상구분2희귀난치성H = 2
        ocskong공상구분3차상위대상C = 3
        ocskong공상구분4차상위대상E = 4
        ocskong공상구분5차상위대상F = 5
        ocskong공상구분6보훈공단4 = 6
        ocskong공상구분7보훈상이처7 = 7
        ocskong공상구분8보훈상이7급 = 8     '60%
        ocskong공상구분9보훈상이7급40 = 9   '사용안함
        ocskong공상구분10보훈상이7급20 = 10 '사용안함
        ocskong공상구분11보훈90감면자 = 11
        ocskong공상구분12보훈본인부담10 = 12
        ocskong공상구분13보훈무자격본인부담10 = 13 '24/08/08 준혁 센스동일하게 추가
        ocskong공상구분14긴급복지의료지원G = 14
        ocskong공상구분15보훈60감면자 = 15
    End Enum

    '24/07/25 준혁 추가
    Public Enum ocsEnumSupportState
        없음 = 0
        대기 = 1
        처치 = 2
        완료 = 3
    End Enum

    '21/01/27 준혁 추가
    Public Enum ocsEnum진료결과
        ocsEnum진료상태1계속 = 1
        ocsEnum진료상태2이송 = 2
        ocsEnum진료상태3회송 = 3
        ocsEnum진료상태4사망 = 4
        ocsEnum진료상태9퇴원 = 9
    End Enum

    '보호종별
    Public Enum ocsEnumProtectKind
        ocsProtect해당없음 = 0
        ocsProtect급여1종 = 1
        ocsProtect급여2종 = 2
        ocsProtect행려 = 4
        ocsProtect장애인2차 = 6
        ocsProtect장애인1차 = 8
        ocsProtect노숙자외국인 = 9
    End Enum

    '예약상태
    Public Enum ocsEnumReserveState
        ocsReserveState0취소 = 0
        ocsReserveState1예약 = 1
        ocsReserveState2내원 = 2
        ocsReserveState3인터넷 = 3
        ocsReserveState4삭제 = 4 '21/05/26 준혁 추가
    End Enum

    '심사상태
    Public Enum ocsEnum심사상태
        심사대기 = 0
        심사중 = 1
        심사보류 = 2
        심사완료 = 3
        수납완료 = 4
        가퇴원 = 5
    End Enum

    Public Enum enBXL_BarcodeType
        BXL_CODE39 = 0
        BXL_CODE128 = 1
        BXL_I2OF5 = 2
        BXL_CODEBAR = 3
        BXL_CODE93 = 4
        BXL_UPC_A = 5
        BXL_UPC_E = 6
        BXL_EAN13 = 7
        BXL_EAN8 = 8
        BXL_UCC_EAN128 = 9
    End Enum

    Public Enum ocsEnumResultLogin
        ocsResultLogin0True = 0
        ocsResultLogin1FalseID = 1
        ocsResultLogin2FalsePWD = 2
        ocsResultLogin3FalseOUT = 3

    End Enum

    Public Enum ocsEnumProgram
        ocsProgram0센스 = 0
        ocsProgram1메디챠트 = 1
        ocsProgram2이플러스 = 2
        ocsProgram3이챠트 = 3
        ocsProgram4한의맥프로 = 4
        ocsProgram5기타 = 5
        ocsProgram6센스플러스 = 6 '23/08/18 준혁 추가
    End Enum

    '공휴일구분
    Public Enum ocsEnumHolydayKind
        ocsHolydayKind양력 = 0
        ocsHolydayKind음력 = 1
        ocsHolydayKind특정 = 2
    End Enum

    Public Enum ocsEnumLogKind
        LogProcess = 0
        LogError = 1
        LogQuery = 2
    End Enum

    Public Enum ocsEnum질가산검사종류
        ocsEnum질가산검사종류0해당없음 = 0
        ocsEnum질가산검사종류1진단검사 = 1
        ocsEnum질가산검사종류2병리검사 = 2
        ocsEnum질가산검사종류3핵의학검사 = 3
    End Enum

    Public Enum ocsEnum야간전담간호사
        ocs야간전담해당없음 = 0
        ocs야간전담5미만 = 1
        ocs야간전담5이상8미만 = 2
        ocs야간전담8이상 = 3
    End Enum

    Public Enum ocsEnum야간전담간호사2
        ocs야간전담2_해당없음 = 0
        ocs야간전담2_10미만 = 1
        ocs야간전담2_10이상15미만 = 2
        ocs야간전담2_15이상20미만 = 3
        ocs야간전담2_20이상25미만 = 4
        ocs야간전담2_25이상 = 5
    End Enum

    Public Enum ocsEnum안전관리료산정
        ocsEnum안전관리료산정안함 = 0
        ocsEnum안전관리료산정함 = 1
    End Enum

    '검사 하이로우
    Public Enum ocsEnumHighLow
        ocsEnum정상 = 0
        ocsEnumHigh = 1
        ocsEnumLow = 2
    End Enum

    '외주검사 연동구분
    Public Enum ocsEnumOutLab
        ocsEnumOutLabSCL = 1
        ocsEnumOutLab랩지노믹스 = 2
        ocsEnumOutLab을지 = 3
        ocsEnumOutLab삼광 = 4
        ocsEnumOutLab써비코CNS = 5
        ocsEnumOutLab써비코CSL = 6
        ocsEnumOutLab써비코 = 7
        ocsEnumOutLab녹십자 = 8
        ocsEnumOutLab이원 = 9
        ocsEnumOutLab김동석 = 10
        ocsEnumOutLab성윤 = 11
        ocsEnumOutLab랩케어 = 12
        ocsEnumOutLabNTL = 13
        ocsEnumOutLab씨젠 = 14
        ocsEnumOutLab티엔씨 = 15
        ocsEnumOutLab신원 = 16
        ocsEnumOutLab필 = 17 '16/06/08 희빈 필의료재단 추가.
        ocsEnumOutLabSQLab = 18 '17/04/27 희빈 SQLab 추가
        ocsEnumOutLab다이오진 = 19
        ocsEnumOutLab이기은 = 20 '17/11/01 희빈
        ocsEnumOutLab녹십자광주 = 21 '17/12/06 희빈
        ocsEnumOutLab녹십자제주 = 22 '17/12/06 희빈
        ocsEnumOutLab필2 = 23 '17/12/21 희빈 필의료재단 KCL자체 검사 추가.(이전의 필의료재단은 KCL에서 다른업체로 외주를 줬었고 이번에는 KCL자체 연구소 연동.)
        ocsEnumOutLab바이오지노 = 24 '18/01/02 희빈
        ocsEnumOutLab씨젠부산 = 25
        ocsEnumOutLab삼광부산 = 26 '19/08/12 희빈 삼광부산 추가
        ocsEnumOutLab씨젠대구 = 27 '20/03/02 희빈 씨젠 대구 추가
        ocsEnumOutLab생명과학연구소 = 28 '20/04/20 희빈 생명과학연구소 추가
        ocsEnumOutLab씨젠광주 = 29

        ocsEnumOutLab기타 = 99
    End Enum

    Public Enum ocsEnumCoWorkState '협진관련
        ocsEnumCoWorkState0의뢰보류 = 0
        ocsEnumCoWorkState1의뢰완료 = 1
        ocsEnumCoWorkState2회신보류 = 2
        ocsEnumCoWorkState3회신완료 = 3
        ocsEnumCoWorkState4협진취소 = 4
    End Enum

    Public Enum ocsEnumSugaInOut '원내/원외
        ocsSugaInOut0원내 = 0
        ocsSugaInOut1원외 = 1
    End Enum

    Public Enum ocsEnumLimitAgeLevel '제한연령구분
        ocsLimitAgeLevel0없음 = 0
        ocsLimitAgeLevel1주미만 = 1
        ocsLimitAgeLevel2개월미만 = 2
        ocsLimitAgeLevel3세미만 = 3
        ocsLimitAgeLevel4세이상 = 4
    End Enum

    '바이탈코드정보
    Public Enum ocsEnumVitalKind
        ocsVital0내과 = 0
        ocsVital1산부인과 = 1
        ocsVital2안과 = 2
        ocsVital3Pelvic = 3
        ocsVital4Sono = 4
        ocsVital5분만 = 5     '22/07/04 명주 분만/신생아 탭 옵션 적용하기 위해 추가
        ocsVital6신생아 = 6
        ocsVital7병원 = 7
        ocsVital8병원 = 8
        ocsVital9병원 = 9
        ocsVital10병동1 = 10
        ocsVital11병동2 = 11
        ocsVital12병동3 = 12
        ocsVital13병동4 = 13
        ocsVital14병동5 = 14
        ocsVital15학생검진 = 15
        ocsVital16소아과 = 16 '24/08/13 준혁 추가. 내과랑 루틴동일함. 산부인과에서 이미 내과바이탈 사용하는경우 소아과를 따로관리 불가하다해서 추가
    End Enum

    Public Enum ocs시설공동기관
        ocs시설_0의원 = 0
        ocs시설_1병원
        ocs시설_2종합병원
        ocs시설_3상급종합병원
    End Enum

    'Sense 공용폼 실행을 위한 Enum
    Public Enum ocsEnum공용폼Kind
        수술실문서 = 0
        병동현황 = 1
        분만기록지 = 2
        입원접수검색 = 3
        외래접수현황 = 4

        TAT관리 = 5
        의무기록출력 = 6
        여성생식기초음파 = 7
        치매검사결과 = 8
        마약향정처방전 = 9

        위험군환자현황 = 10
        전달부서설정 = 11

        물리치료대장 = 12 '22/04/14 정일 추가
        방사선치료대장 = 13 '23/10/25 정일 추가
        달빛어린이스케쥴 = 14 '24/01/25 이훈 추가
        문진표뷰어 = 15 '24/03/15 정일 추가
    End Enum

    'Spread , Grid Row 추가, 수정, 삭제 상태
    Public Enum ocsEnumRowStatus
        ocsRowStatus0None = 0
        ocsRowStatus1New = 1
        ocsRowStatus2Update = 2
        ocsRowStatus3Delete = 3
    End Enum

    Public Enum ocsPACSKind
        ocsPacs_0없음 = 0
        ocsPacs1_Infinity = 1 '인피니티
        ocsPacs2_PacsPlus = 2 '메디칼스탠다드
        ocsPacs3_PPCLinic = 3
        ocsPacs4_IView = 4
        ocsPacs5_의료영상기술 = 5
        ocsPacs6_제노레이 = 6
        ocsPacs7_후지GEPacs = 7
        ocsPacs8_태영 = 8
        ocsPacs9_Infinity2 = 9
        ocsPacs10_PPCLinicNew = 10
        ocsPacs11_IView2 = 11
        ocsPacs12_메디엔 = 12
        ocsPacs13_InfinityNew = 13
        ocsPacs14_테크하임 = 14
        ocsPacs15_메디엔New = 15
        ocsPacs16_UBCare = 16
        ocsPacs18_Infinity탄방엠블 = 18 '탄방엠블용 
        ocsPacs19_마로테크 = 19
        ocsPacs20_CandS = 20
        ocsPacs21_테크하임New = 21
        ocsPacs23_CLIT = 23
        ocsPacs24_DenteeView = 24
        ocsPacs25_ZeroPacs = 25
        ocsPacs26_후지Pacs = 26
        ocsPacs27_GEPacs = 27
        ocsPacs28_MedicalStandardKMI = 28
        ocsPacs29_HIPacs = 29
        ocsPacs30_ZetaPacs = 30
        ocsPacs31_PacsPlusNEW_HISIF = 31
        ocsPacs32_엠디팍스 = 32
    End Enum

    ''' <summary>
    ''' 환경설정 관련 Enum값
    ''' </summary>
    Public Enum ocsEnumPreference_주사수기료비급여적용방법

        일반환자및비급여발생안함 = 1
        보험유형발생안함 = 2
        전종별발생안함 = 3

    End Enum

    Public Enum Log실행파일구분
        'S가 붙은건 센스
        메인화면 = 0
        S데스크 = 1
        S진료실 = 2
        S진료지원 = 3
        청구심사 = 4
        병원관리 = 5
        문서관리 = 6
        S입원수납 = 7
        S병동 = 8
        의무기록실 = 9
        환자평가표 = 10
        이미지뷰어 = 11
        S챠트뷰어 = 12 '23/09/11 정일 수정
        검사결과뷰어 = 13
        수술실예약 = 14
        S외래간호 = 15 '22/04/25 정일 수정
        불임챠트 = 16
        경영관리 = 17
        예방접종 = 18
        화면캡쳐 = 19

        S난임챠트 = 21 '22/05/19 준혁 추가
        S난임챠트뷰어 = 22

        '.NET은 기존꺼와 분리되게끔 100부터 시작하고.. 센스랑 일단 +100으로 맞췄다.
        Agent = 100
        데스크 = 101
        진료실 = 102
        진료지원 = 103
        심사 = 104
        병동 = 108
        챠트뷰어 = 112 '23/09/11 정일 추가
        수술예약 = 114 '24/03/26 준혁 추가
        외래간호 = 115 '22/04/21 정일 추가
        CRM = 120
        Kiosk = 200
    End Enum

    '21/12/09 준혁 Log 실행구분 추가
    Public Enum Log실행구분
        조회 = 0
        삭제 = 1
        저장 = 2
        기타 = 3
    End Enum

    ''' <summary>
    ''' 수납상태, 수납여부 관련 enum 추가
    ''' </summary>
    Public Enum ocsEnum수납대기상태
        해당없음 = 0
        수납대기 = 1
    End Enum

    Public Enum ocsEnum수납여부
        수납안함 = 0
        수납완료 = 1
        수납취소 = 2
    End Enum

    Public Enum ocsEnum응급여부
        일반 = 0
        응급 = 1
        내원 = 2
    End Enum

    Public Enum ocsEnum퇴원중간
        중간 = 0
        퇴원 = 1
        선수금 = 2
        가퇴원 = 3
        수납대기 = 4 '심사쪽에서 발생시킨 가수납
        수납대기_중도금 = 5 '23/03/22 준혁 추가
        수납대기_가퇴원 = 6
    End Enum

    '21/07/06 준혁 추가
    Public Enum ocsEnum임산부초음파분기
        제1삼분기일반 = 1
        제1삼분기정밀 = 2
        제2삼분기일반 = 3
        제2삼분기정밀 = 4
    End Enum

    '21/08/06 준혁 추가
    Public Enum ocsEnumPreDocuments
        여성생식기초음파 = 1
        유방초음파 = 2
        흉부초음파 = 3
    End Enum

    '22/02/23 준혁 추가
    Public Enum ocsEnumReceiptPrintKind
        일반출력 = 0
        KOCES단말기 = 1
    End Enum

    Public Enum ocsEnumDemandKind
        원청구 = 1
        누락청구 = 2
        보완청구 = 3
        추가청구 = 4
        분리청구 = 5
        약제비상한차액_추가청구 = 8
    End Enum

    '23/07/24 준혁 추가
    Public Enum enDataFields진료기본_기타
        심사참고사항 = 0
        처방전조제참고 = 1
        똑닥접수ID = 2
        똑닥결제ID = 3
    End Enum

    Public Enum enDataFields진료내역_기타
        DC사유 = 0
        초음파특정내역 = 1
        기타내역 = 2
        판독소견코드 = 3
        검사분류 = 4
        산정식 = 5
    End Enum

    Public Enum enDataFields진료내역원무_기타
        초음파특정내역 = 0
        기타내역 = 1
        판독소견코드 = 2
        검사분류 = 3
        산정식 = 4
        여성생식기초음파 = 5
        여성생식기문서정보 = 6
    End Enum

    '23/08/08 준혁 키오스크관련 추가
    Public Enum enKiosk수납상태
        NONE = 0
        정산중 = 1
        수납대기 = 2
        수납완료 = 3
    End Enum

    '24/12/18 준혁 진료결과 추가
    Public Enum ocsEnumJinResult
        ocsJinResult1계속 = 1
        ocsJinResult2이송 = 2
        ocsJinResult3회송 = 3
        ocsJinResult4사망 = 4
        ocsJinResult5퇴원 = 9
    End Enum

    '24/12/18 준혁 청구구분 추가 
    Public Enum ocsEnum청구구분
        ocsDemandFirst = 1 '원청구
        ocsDemandForget = 2 '누락
        ocsDemandRepair = 3 '보완
        ocsDemandAppend = 4 '추가
        ocsDemandDivide = 5 '분리
        ocsDemandFertility = 6 '난임
    End Enum

    Public Structure ocsType진료과목
        Dim 해당없음 As String
        Dim 내과 As String
        Dim 신경과 As String
        Dim 정신과 As String
        Dim 일반외과 As String
        Dim 정형외과 As String
        Dim 신경외과 As String
        Dim 흉곽외과 As String
        Dim 성형외과 As String
        Dim 마취과 As String
        Dim 산부인과 As String
        Dim 소아과 As String
        Dim 안과 As String
        Dim 이비인후과 As String
        Dim 피부과 As String
        Dim 비뇨기과 As String
        Dim 진단방사선과 As String
        Dim 치료방사선과 As String
        Dim 해부병리과 As String
        Dim 임상병리과 As String
        Dim 결핵과 As String
        Dim 재활의학과 As String
        Dim 핵의학과 As String
        Dim 가정의학과 As String
        Dim 응급의학과 As String
        Dim 산업의학과 As String
        Dim 예방의학과 As String

        Dim 한방내과 As String
        Dim 한방부인과 As String
        Dim 한방소아과 As String
        Dim 한방안이비인후피부과 As String
        Dim 한방신경정신과 As String
        Dim 침구과 As String
        Dim 한방재활의학과 As String
        Dim 사상체질과 As String
        Dim 한방응급 As String
    End Structure

    Public ocsEnum진료과목 As ocsType진료과목

    Public Structure ocsType메인메뉴
        Implements IEquatable(Of ocsType메인메뉴)
        Dim Name As String
        Dim Position As Integer
        Dim Visible As Boolean

        '중복여부를 비교하기 위한 Equals 정의.(이름으로 비교)
        Public Function EqualsName(other As ocsType메인메뉴) As Boolean Implements IEquatable(Of ocsType메인메뉴).Equals
            If other.Name = Nothing Then '22/07/08 준혁 이름 nothing일 때 처리 추가
                Return False
            End If
            Return Name.Equals(other.Name)
        End Function
    End Structure

    Public Enum en달력라벨
        달력라벨1검사 = 1
        달력라벨2물치 = 2
        달력라벨3방사 = 3
        달력라벨4약 = 4
        달력라벨5재진 = 5
        달력라벨6정신 = 6
        달력라벨7주사 = 7
        달력라벨8처치 = 8
        달력라벨9초진 = 9
        달력라벨10만성 = 10
        달력라벨11진X = 11
        달력라벨12예약 = 12
        달력라벨13물치 = 13
        달력라벨14처방 = 14
        달력라벨15외박 = 15
        달력라벨16HPV = 16
        달력라벨17촉탁 = 17
        달력라벨18협진 = 18
        달력라벨19가정 = 19
    End Enum

    Public Enum enFunctionResult
        enSuccess = 0 '성공
        enError = 1 '에러
        enCancel = 2 '취소
        enInvalied = 3 '유효하지 않음
    End Enum

    Public Enum enOverWriteCheck
        enOverWrite = 0 '덮어쓰기
        enNonOverWrite = 1 '덮어쓰지 않기
        enJoin = 2 '이어붙이기        
    End Enum

    Public Enum enSearchType
        코드 = 0
        명칭 = 1
        영문명칭 = 2
    End Enum

    Public Structure ocsType주소검색
        Dim 우편번호 As String
        Dim 시도 As String
        Dim 시군구 As String
        Dim 읍면동 As String
        Dim 도로명 As String
        Dim 건물명 As String

        Dim 선택주소타입 As String            'J : 지번, R : 도로명
        Dim 선택언어 As String                'E: 영문 
        Dim 도로명주소 As String
        Dim 도로명영문주소 As String
        Dim 지번주소 As String
        Dim 지번영문주소 As String

        Dim 부가주소 As String

        Dim 시군구코드 As String
        Dim 도로명코드 As String
        Dim 건물코드 As String
        Dim 관리번호 As String
        Dim 건물번호 As String

        '--------------------- 원본 데이터
        'Dim zonecode As String                  '우편번호
        'Dim address As String                   '기본 주소
        'Dim addressEnglish As String            '기본 영문 주소
        'Dim addressType As String               '검색된 기본 주소타입 : R(도로명), J(지번)
        'Dim userSelectedType As String          '검색 결과에서 사용자가 선택한 타입
        'Dim noSelected As String                '연관 주소에서 "선택안함"부분을 선택했을때 구분용 상태변수
        'Dim userLanguageType As String          '검색된 결과에서 사용자가 선택한 주소의 언어 타입 : K 한글 , E 영문
        'Dim roadAddress As String               '도로명 주소
        'Dim roadAddressEnglish As String        '영문 도로명 주소 
        'Dim jibunAddress As String              '지번 주소
        'Dim jibunAddressEnglish As String       '영문 지번 주소
        'Dim autoRoadAddress As String           ''지번주소'에 매핑된 '도로명주소'가 여러개인 경우, 사용자가 '선택안함' 또는 '지번주소'를 클릭했을 때 연관된 도로명 주소 중 임의로 첫번째 매핑 주소를 넣어서 반환합니다.
        'Dim autoRoadAddressEnglish As String    'autoRoadAddress의 영문 도로명 주소
        'Dim autoJbunAddress As String           ''도로명주소'에 매핑된 '지번주소'가 여러개인 경우, 사용자가 '선택안함' 또는 '도로명주소'를 클릭했을 때 연관된 지번 주소 중 임의로 첫번째 매핑 주소를 넣어서 반환합니다.
        'Dim autoJibunAddressEnglish As String   'autoJibunAddress의 영문 지번 주소
        'Dim buildingCode As String              '건물관리번호
        'Dim buildingName As String              '건물명
        'Dim apartment As String                 '공동주택 여부
        'Dim sido As String                      '도/시 이름
        'Dim sigungu As String                   '시/군/구 이름
        'Dim sigunguCode As String               '시/군/구 코드
        'Dim roadnameCode As String              '도로명 코드 7자리 , 추후 늘어날 수 있음
        'Dim bcode As String                     '법정동/법정리 코드
        'Dim roadname As String                  '도로명 값, 검색 결과 중 선택한 도로명주소의 "도로명" 값이 들어갑니다.(건물번호 제외)
        'Dim bname As String                     '법정동/법정리 이름
        'Dim bname1 As String                    '법정리의 읍/면 이름 ("동"지역일 경우에는 공백, "리"지역일 경우에는 "읍" 또는 "면" 정보가 들어갑니다.)
        'Dim bname2 As String                    '법정동/법정리 이름
        'Dim hname As String                     '행정동 이름, 검색어를 행정동으로 검색하고, 검색결과의 법정동과 검색어에 입력한 행정동과 다른 경우에 표시하고, 데이터를 내립니다.
        'Dim query As String                     '사용자가 입력한 검색어
        'Dim postcode As String                  '구 우편번호 (2020년 3월 9일 이후로는 데이터가 내려가지 않습니다.)
        'Dim postcode1 As String                 '구 우편번호 앞 3 (2020년 3월 9일 이후로는 데이터가 내려가지 않습니다.)
        'Dim postcode2 As String                 '구 우편번호 뒤 3 (2020년 3월 9일 이후로는 데이터가 내려가지 않습니다.)
        'Dim postcodeSeq As String               '구 우편번호 일련번호 (2020년 3월 9일 이후로는 데이터가 내려가지 않습니다.)
    End Structure

    Public Enum ocsEnum전자인증구분
        en전자인증구분_1진료 = 1
        en전자인증구분_2간호 = 2
        en전자인증구분_3수술 = 3
        en전자인증구분_4분만 = 4
        en전자인증구분_5수납 = 5
        en전자인증구분_6물리 = 6
        en전자인증구분_7진단 = 7
        en전자인증구분_8원무 = 8
        en전자인증구분_9문서 = 9
        en전자인증구분_10바이탈 = 10
    End Enum

    '21/07/23 재민 
    Public Enum en한영구분
        enKorean = 1
        enEnglish = 2
    End Enum

    '21/07/26 재민
    Public Enum ocsEnumMemoKind
        의사메모 = 1
        부서메모 = 2
        전체메모 = 3
        명칭메모1 = 4
        명칭메모2 = 5
        검사메모 = 6
        서술결과 = 7
        판독소견 = 8
        개별서술 = 9
        특이사항 = 10
        '22/02/14 재민 추가
        과거력 = 11
        가족력 = 12
        기타메모 = 13
        바이탈 = 14 '22/04/18 정일 추가
    End Enum

    '21/11/22 준혁 진료지원 대기자탭
    Public Enum ocsEnumSupportWaitPatientTab
        외래 = 0
        입원 = 1
        처치 = 2
        보류 = 3
        완료 = 4
    End Enum
    '실제값 컬럼값이 아닌 임의 분류 값 '23/04/28 @이훈 추가
    'mc = Main Category / 'sc = Sub Category
    Public Enum Enum연동종류
        mc오프라인 = 0
        mc똑닥 = 1
        sc똑닥예약M = 2
        sc똑닥접수M = 3
        sc똑닥키오스크 = 4
        mc굿닥 = 5
        sc굿닥예약M = 6
        sc굿닥접수M = 7
        sc굿닥태블릿 = 8
        mc네이버 = 9
        sc네이버예약M = 10
    End Enum

    'TB_예약정보 똑닥컬럼의 실제 컬럼 값 '23/04/28 @이훈 추가
    Public Enum ocsEnum예약Flag
        ocs오프라인 = 0
        ocs똑닥예약 = 1
        ocs굿닥예약 = 11
        ocs네이버예약 = 20
    End Enum

    'TB_진료기본 똑닥컬럼의 실제 컬럼 값 '23/04/28 @이훈 추가
    Public Enum ocsEnum접수Flag
        ocs오프라인 = 0
        ocs똑닥 = 1
        ocs똑닥키오스크 = 2
        ocs굿닥모바일접수 = 11
        ocs굿닥태블릿 = 12
        ocs네이버예약접수 = 20
    End Enum

    '23/08/31 준혁 추가
    Public Enum ocsEnumOBGY
        해당없음 = 0
        OB = 1
        GY = 2
    End Enum


    Public Enum ocsEnum정책수가
        해당없음 = 0
        소아진료 = 1
    End Enum

    Public Structure ocsType문서정보
        Dim 여성생식기초음파 As String
        Dim 여성생식기초음파_표준판독지 As String
    End Structure

    Public ocsDocuments문서정보 As ocsType문서정보

    Public Enum ocsEnumValidPasswd
        ocsValidPwd1인증 = 1
        ocsValidPwd2숫자없음 = 2
        ocsValidPwd3영문없음 = 3
        ocsValidPwd4길이부족 = 4
        ocsValidPwd5기간만료 = 5
        ocsValidPwd6특수문자 = 5 '특수문자는 일단 보류...센스는 영문,숫자,길이만 체크해서 일단 통일시킴..
    End Enum
#End Region
    Public Function fG_ConvertSunToLun(ByVal strDate As String, Optional ByRef blnR_윤달여부 As Boolean = False) As String
        Dim kLunar As New System.Globalization.KoreanLunisolarCalendar
        Dim intL_LeapMonth As Integer       '윤달이 몇 월인지
        Dim intL_Year As Integer            '변환하고자 하는 음력 년도
        Dim intL_Month As Integer           '변환하고자 하는 음력 월
        Dim intL_Day As Integer             '변환하고자 하는 음력 일

        '음력은 윤달이 있을경우 월을 1 에서 13 사이의 숫자로 반환하는데
        '예를들어 윤달이 8월이라면 첫번째 8월은 8로 윤달 8월은 9 로 9월은 10으로
        '나타낸다. 따라서 윤달여부를 확인하여 표시하여야 한다.

        blnR_윤달여부 = False

        intL_Year = kLunar.GetYear(CDate(strDate))       '음력 년
        intL_Month = kLunar.GetMonth(CDate(strDate))     '음력 월
        intL_Day = kLunar.GetDayOfMonth(CDate(strDate))  '음력 일

        '달의 개수가 12개가 넘으면 윤달이 있다는 거다
        If kLunar.GetMonthsInYear(intL_Year) > 12 Then

            intL_LeapMonth = kLunar.GetLeapMonth(intL_Year)     '윤달이 몇월인지 구하기
            blnR_윤달여부 = kLunar.IsLeapMonth(intL_Year, intL_Month) '변환할 날짜가 윤달인지 여부

            If blnR_윤달여부 = True Or intL_Month > intL_LeapMonth Then
                '변환하고자 하는 월이 윤달이면 월에 1을 뺀다 or
                '변환하고자 하는 월이 윤달 이후이면 월에 1을 뺀다.
                intL_Month -= 1

            End If
        End If

        '날짜 형식 맞추기
        Dim strL_Date As String = CStr(intL_Year)
        If intL_Month < 10 Then
            strL_Date &= "-0" & CStr(intL_Month)
        Else
            strL_Date &= "-" & CStr(intL_Month)
        End If
        If intL_Day < 10 Then
            strL_Date &= "-0" & CStr(intL_Day)
        Else
            strL_Date &= "-" & CStr(intL_Day)
        End If

        Return strL_Date
    End Function

    ''' <summary>
    ''' 음력 -> 양력 변환 함수
    ''' </summary>
    ''' <param name="intMonth">음력 달</param>
    ''' <param name="intDay">음력 일</param>
    ''' <returns></returns>
    Public Function fG_ConvertLunToSun(ByVal intYear As Integer, ByVal intMonth As Integer, ByVal intDay As Integer) As String
        '22/03/02 명주 함수 추가
        Dim kSolar As New System.Globalization.KoreanLunisolarCalendar
        Dim intL_LeapMonth As Integer
        Dim strL_SolorDate As String

        ' 윤달이 있는 년도 체크
        If kSolar.GetMonthsInYear(intYear) > 12 Then
            intL_LeapMonth = kSolar.GetLeapMonth(intYear)

            ' 윤달인 경우 Month + 1
            If intMonth >= intL_LeapMonth - 1 Then
                strL_SolorDate = kSolar.ToDateTime(intYear, intMonth + 1, intDay, 0, 0, 0, 0).ToString(년월일)
            Else
                strL_SolorDate = kSolar.ToDateTime(intYear, intMonth, intDay, 0, 0, 0, 0).ToString(년월일)
            End If
        Else
            strL_SolorDate = kSolar.ToDateTime(intYear, intMonth, intDay, 0, 0, 0, 0).ToString(년월일)
        End If

        Return strL_SolorDate
    End Function
End Module
