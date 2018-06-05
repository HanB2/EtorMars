using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comm_model
{
	//배송정보
	class EtsInfoModel
	{
		public int SEQ_NO { get; set; }             //	data_type	int		KEY
		public string ETS_NO { get; set; }              //	data_type	varchar		ESM_NUM_RANGE 의 설정에 따른 자동생성 코드
		public int EST_NO { get; set; }             //	data_type	int		EST_INFO - SEQ_NO
		public int MASTER_NO { get; set; }              //	data_type	int		ETS_MASTER - SEQ_NO 
		public int ETS_TYPE { get; set; }               //	data_type	tinyint		0 : 보관상품배송 / 1 : 일반상품배송 / 2 : 혜관상품배송
		public int CLEAR_PDT_CODE { get; set; }             //	data_type	tinyint		신청타입(0:목록,1:일반) => 배송국가 한국
		public string MASTERNO { get; set; }                //	data_type	varchar		마스터번호
		public string NATION_CODE { get; set; }             //	data_type	char		도착국가코드
		public string DEP_NATION_CODE { get; set; }             //	data_type	char		출발국가 코드
		public int STATUS { get; set; }             //	data_type	tinyint		ETS_STAT - STATUS
		public string SENDER_NAME { get; set; }             //	data_type	varchar		보내는사람 이름
		public string SENDER_TELNO { get; set; }                //	data_type	varchar		보내는사람 전화번호
		public string SENDER_ADDR { get; set; }             //	data_type	varchar		보내는사람 주소
		public string CUSTOMNO { get; set; }                //	data_type	varchar		통관번호
		public string DELV_COM_REQ { get; set; }                //	data_type	varchar		사용자가 요청한 택배회사
		public string DELVNO { get; set; }              //	data_type	varchar		현지배송번호
		public string DELV_COM { get; set; }                //	data_type	varchar		배송회사 코드
		public string RECEIVERTYPE { get; set; }                //	data_type	varchar		받는이 구분(1=개인, 2=사업자)
		public string RECEIVER_NAME { get; set; }               //	data_type	varchar		받는사람 이름
		public string RECEIVER_NAME_ENG { get; set; }               //	data_type	varchar		받는사람 영문 이름
		public string RECEIVER_TELNO { get; set; }              //	data_type	varchar		받는사람 전화번호
		public string RECEIVER_CPHONENO { get; set; }               //	data_type	varchar		받는사람 휴대폰번호
		public string RECEIVER_STATE { get; set; }              //	data_type	varchar		받는사람 성
		public string RECEIVER_CITY { get; set; }               //	data_type	varchar		받는사람 시
		public string RECEIVER_DISTRICT { get; set; }               //	data_type	varchar		받는사람 구
		public string RECEIVER_ZIPCODE { get; set; }                //	data_type	varchar		받는사람 우편번호
		public string RECEIVER_ADDR { get; set; }               //	data_type	varchar		받는사람 기본 주소
		public string RECEIVER_ADDR_SUB { get; set; }               //	data_type	varchar		받는사람 상세 주소
		public string RECEIVER_EMAIL { get; set; }              //	data_type	varchar		받는사람 이메일
		public string SOCIALNO_BIZNO { get; set; }              //	data_type	varchar		받는사람 신분증번호
		public string MESSAGE_DELV { get; set; }                //	data_type	varchar		배송메세지
		public int PACKING_COUNT { get; set; }             //	data_type	smallint		팩킹리스트 출력횟수
		public int LABEL_COUNT { get; set; }               //	data_type	smallint		송장출력 횟수
		public int PACKING_CHECK { get; set; }             //	data_type	smallint		검수 횟수
		public string ORDERNO1 { get; set; }                //	data_type	varchar		주문번호1
		public string ORDERNO2 { get; set; }                //	data_type	varchar		주문번호2
		public string ORDERNO3 { get; set; }                //	data_type	varchar		주문번호3
		public int QTY_BOX { get; set; }               //	data_type	smallint		박스갯수
		public double stringGEABLE_WEIGHT { get; set; }             //	data_type	double		적용무게
		public string OUTPUT_TYPE { get; set; }             //	data_type	varchar		출고타입
		public double DELVFEE { get; set; }             //	data_type	double		배송비
		public double REALWEIGHT { get; set; }              //	data_type	double		실제무게
		public string WEIGHT_UNIT { get; set; }             //	data_type	char		무게단위(KG, LB)
		public double REALVOLUME { get; set; }              //	data_type	double		부피무게
		public double DIM_WIDTH { get; set; }               //	data_type	double		박스가로길이
		public double DIM_LENGTH { get; set; }              //	data_type	double		박스세로길이
		public double DIM_HEIGHT { get; set; }              //	data_type	double		박스높이
		public string DIM_UNIT { get; set; }                //	data_type	varchar		박스치수단위(cm,inch)
		public double TAX { get; set; }             //	data_type	double		세금
		public double INSURANCE { get; set; }               //	data_type	double		보험료
		public double OTHER_COST { get; set; }              //	data_type	double		기타비용
		public string CURRENCY_GOODS { get; set; }              //	data_type	char		상품금액 화폐단위
		public string CURRENCY_DELVFEE { get; set; }                //	data_type	char		배송비 화폐단위
		public string CURRENCY_TAX { get; set; }                //	data_type	char		세금 화폐단위
		public string CURRENCY_INSURANCE { get; set; }              //	data_type	char		보험료 화폐단위
		public string CURRENCY_OTHER_COST { get; set; }             //	data_type	char		기타비용 화폐단위
		public string USER1 { get; set; }               //	data_type	varchar		사용자입력1
		public string USER2 { get; set; }               //	data_type	varchar		사용자입력2
		public string USER3 { get; set; }               //	data_type	varchar		사용자입력3
		public string ACCIDENT_YN { get; set; }             //	data_type	varchar		사고 유무(yes / no)
		public string ACCIDENT_TYPE { get; set; }               //	data_type	varchar		사고 종류(간단 설명)
		public string IMPORTANT { get; set; }               //	data_type	varchar		중요메세지 여부(yes / no)
		public string ORDER_TYPE { get; set; }              //	data_type	varchar		데이터를 등록한 방법
		public string SDATA1 { get; set; }              //	data_type	varchar		기타데이터1
		public string SDATA2 { get; set; }              //	data_type	varchar		기타데이터2
		public string SDATA3 { get; set; }              //	data_type	varchar		기타데이터3
		public string SDATA4 { get; set; }              //	data_type	varchar		기타데이터4
		public string SDATA5 { get; set; }              //	data_type	varchar		기타데이터5
		public string SDATA6 { get; set; }              //	data_type	varchar		기타데이터6

	}
}
