using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comm_model
{
	//ESE 기본정보
	class EseInfoModel
	{
		public int SEQ_NO { get; set; }             //	data_type	int		KEY
		public string EST_NO { get; set; }              //	data_type	char		EST_INFO - SEQ_NO
		public string ESE_CODE { get; set; }                //	data_type	char		자동생성 방안 확인
		public string ESE_NAME { get; set; }                //	data_type	char		업체 명
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
		public string ACTIVATION_KEY { get; set; }              //	data_type	varchar		비밀번호 변경 활성화 key
		public string SITE_URL { get; set; }                //	data_type	varchar		홉페이지 URL
		public string MEMO { get; set; }                //	data_type	varchar		메모
		public int USE_TYPE { get; set; }               //	data_type	tinyint		1 : 사용 / 0 : 미사용
		public string REG_DT { get; set; }              //	data_type	datetime		등록일자
		public string UPDT_DT { get; set; }             //	data_type	datetime		수정일자

	}
}
