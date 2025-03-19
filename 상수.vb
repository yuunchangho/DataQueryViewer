Module 상수
    Public Enum e단가적용
        급여 = 0
        비급여 = 3
        메디비급여 = 5
        전액본인 = 6
        무료단가 = 8
        비급여일반 = 13
        마스터적용 = 20
    End Enum

    ' 진료상태
    Public Enum e진료상태
        접수 = 0
        취소 = 4
        입원 = 5
        지원 = 7
        완료 = 9
    End Enum

    Public Enum e등록구분
        처방 = 0
        자동 = 1
        자동입원 = 2
        자동연결 = 3
        자동조제 = 4
        자동주사 = 5
        자동변경 = 7
        검사 = 8
        묶음 = 9
        필요처방 = 10
    End Enum

    Public Structure e형식
        Const 건수 = "###,##0"

        Const 단가 = "###,###,##0"
        Const 투여량 = "###,###,##0.0000"
        Const 투여량00 = "###,##0.00"
        Const 횟수 = "#,##0"
        Const 금액 = "###,###,##0"

        Const 년월 = "0000-00"
        Const 년월일 = "0000-00-00"
        Const 일 = "00"

        Const yyyyMMdd = "yyyy/MM/dd"
        Const HHmmss = "HH:mm:ss"
    End Structure

    Public Structure type기초자료
        Public 항목1 As String
        Public 항목2 As String
        Public 항목3 As String
        Public 항목4 As String
        Public 항목5 As String
        Public 항목6 As String
        Public 항목7 As String
        Public 항목8 As String
        Public 항목9 As String
        Public 항목10 As String
    End Structure

    Public 기초자료_자료() As type기초자료
    Public LOOKUP() As type기초자료

    Public Structure type사용자
        Public 코드 As String
        Public 성명 As String

        Public 챠트번호 As String
        Public 등록번호 As String
        Public 생년월일 As String

        Public 주민등록번호 As String
        Public 주민번호2 As String
        Public 주민번호1 As String

        Public 연령 As Integer
        Public 성별 As String

        Public 기관기호 As String
        Public 기관명 As String

        Public 우편번호 As String
        Public 주소1 As String
        Public 주소2 As String

        Public 자택전화 As String
        Public 전화번호 As String
        Public 전송번호 As String

        Public 휴대전화 As String
        Public 보호자연락처 As String

        Public 사업자번호 As String

        Public 직종 As String
        Public 근무부서 As String
        Public 복수병동근무 As String

        Public 부서코드 As String
        Public 부서명칭 As String
        Public 면허번호 As String

        Public 원무메모 As String
        Public 진료실메모 As String

        Public IP As String
        Public PCNAME As String
        Public MAC_ADDRESS As String

        Public 구분 As String
        Public 상호 As String

        Public 보험유형 As String
        Public 보험유형명 As String

        Public 조합기호 As String
        Public 증번호 As String
        Public 차상위 As String
        Public 대상구분 As String
        Public 산정특례번호 As String

        Public 진료지원코드 As String
        Public 직분 As String
        Public 전문의번호 As String

        Public 비밀번호 As String
        Public 비밀번호수정일 As String

        Public 병동 As String

        Public 입원일 As String
        Public 입원시간 As String
        Public 퇴원일 As String
        Public 퇴원시간 As String

        Public 주치의성명 As String

        Public 컴퓨터이름 As String
        Public 컴퓨터사용자이름 As String

        Public OS버젼 As String
        Public 회투사용 As Boolean
    End Structure

    Public 사용자 As type사용자

    Public Enum e수납구분
        수납 = 0
        환불 = 1
        변경 = 2
        재발행 = 3
        취소 = 4
    End Enum

    Public Enum e중간퇴원
        중간 = 0
        퇴원 = 1
        선수금 = 2
        가퇴원 = 3

        수납대기_퇴원납입 = 4
        수납대기_중도금 = 5
        수납대기_가퇴원 = 6
    End Enum

    Public 결재() As String
End Module
