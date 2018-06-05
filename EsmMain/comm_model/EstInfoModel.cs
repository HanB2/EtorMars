using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comm_model
{
	//EST 기본 정보
	class EstInfoModel
	{
		public int SEQ_NO { get; set; }             //	data_type	int		KEY
		public int NATION_NO { get; set; }              //	data_type	int		ESM_NATION - NATION_NO
		public string EST_CODE { get; set; }                //	data_type	char		국가코드 + 4자리
		public string EST_NAME { get; set; }                //	data_type	char		업체 명
		public string BIZ_NO { get; set; }              //	data_type	char		업체 사업자번호
		public string ZIPCODE { get; set; }             //	data_type	char		업체 우편번호
		public string ADDR { get; set; }                //	data_type	varchar		업체 기본 주소
		public string ADDR_SUB { get; set; }                //	data_type	varchar		업체 상세 주소
		public string REP_NAME { get; set; }                //	data_type	char		대표자 이름
		public string REP_TEL { get; set; }             //	data_type	char		대표자 전화번호
		public string REP_MAIL { get; set; }                //	data_type	char		대표자 e-mail
		public string TASK_NAME { get; set; }               //	data_type	char		담당자 이름
		public string TASK_TEL { get; set; }                //	data_type	char		담당자 전화번호
		public string TASK_EMAIL { get; set; }              //	data_type	char		담당자 e-mail
		public double HAVE_MAR { get; set; }                //	data_type	decimal		보유 MAR 
		public double INCENTIVE_MAR { get; set; }               //	data_type	decimal		협력사 인센티브 설정 (0.00)
		public string API_KEY { get; set; }             //	data_type	varchar		API 연동 key
		public string ACTIVATION_KEY { get; set; }              //	data_type	varchar		비밀번호 변경 활성화 key
		public string SITE_URL { get; set; }                //	data_type	varchar		사이트 URL
		public string MEMO { get; set; }                //	data_type	varchar		메모
		public int USE_TYPE { get; set; }               //	data_type	tinyint		1 : 사용 / 0 : 미사용
		public string REG_DT { get; set; }              //	data_type	datetime		등록일자
		public string UPDT_DT { get; set; }             //	data_type	datetime		수정일자

	}
}
