using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comm_model
{
	//마르 충전 요청
	class MarInModel
	{
		public int SEQ_NO { get; set; }             //	data_type	int		KEY
		public int ESE_NO { get; set; }             //	data_type	int		ESE_INFO SEQ_NO
		public int ESM_NO { get; set; }             //	data_type	int		승인한 ESM USER 키
		public double COST { get; set; }                //	data_type	decimal		충전 요청금액
		public string UNIT { get; set; }                //	data_type	varchar		화폐단위
		public double EXCHANGE_RATE { get; set; }               //	data_type	decimal		승인일자 기준 환율
		public double MAR { get; set; }             //	data_type	decimal		충전 승인한 MAR(실제충전된 MAR)
		public string REG_DT { get; set; }              //	data_type	datetime		등록일자
		public string UPDT_DT { get; set; }             //	data_type	datetime		승인 일자
		public string REQ_MEMO { get; set; }                //	data_type	varchar		요청자 메모
		public string ESM_MEMO { get; set; }                //	data_type	varchar		관리자 메모

	}
}
