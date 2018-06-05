using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comm_model
{
	//배송가능 국가
	class EsmNationUseModel
	{
		public int SEQ_NO { get; set; }             //	data_type	int		KEY
		public string NATION_CODE { get; set; }             //	data_type	char		KR / CN 등 두글자 코드
		public string NATIONNAME { get; set; }              //	data_type	varchar		영문 표기
		public string NATIONNAME_ko_KR { get; set; }                //	data_type	varchar		한글 표기
		public string NATIONNAME_zh_CN { get; set; }                //	data_type	varchar		중국어 표기
		public string CURRENCY_UNIT { get; set; }               //	data_type	char		기준통화 종류(USD, CNY, KRW, EUR ...)
		public string CURRENCY_SYMBOL { get; set; }             //	data_type	varchar		기준통화 기호($, ¥, ₩, € ...)
		public double BASIC_UNIT { get; set; }              //	data_type	decimal		기준 단위
		public double AMNT { get; set; }                //	data_type	decimal		환율
		public string UPDT_DT { get; set; }             //	data_type	datetime		환율 수정 일자
		public string MEMO { get; set; }                //	data_type	varchar		메모
		public string REG_DT { get; set; }              //	data_type	datetime		등록일자

	}
}
