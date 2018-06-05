using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comm_model
{
	//마르 환전 요청
	class MarOutModel
	{
		public int SEQ_NO { get; set; }             //	data_type	int		KEY
		public int IN_TYPE { get; set; }                //	data_type	int		0 : EST / 1 : ESE
		public int EST_NO { get; set; }             //	data_type	int		EST_INFO SEQ_NO
		public int ESE_NO { get; set; }             //	data_type	int		ESE_INFO SEQ_NO
		public int ESM_NO { get; set; }             //	data_type	int		승인한 ESM USER 키
		public double MAR_REQ { get; set; }             //	data_type	decimal		환전요청 MAR
		public double REFUND { get; set; }              //	data_type	decimal		실제 환전된 금액(수수료 제외)
		public string UNIT { get; set; }                //	data_type	varchar		화폐단위
		public double FEES { get; set; }                //	data_type	decimal		수수료 금액
		public double EXCHANGE_RATE { get; set; }               //	data_type	decimal		승인일자 기준 환율
		public string REG_DT { get; set; }              //	data_type	datetime		등록일자
		public string UPDT_DT { get; set; }             //	data_type	datetime		승인 일자
		public string REQ_MEMO { get; set; }                //	data_type	varchar		요청자 메모
		public string ESM_MEMO { get; set; }                //	data_type	varchar		관리자 메모


	}
}
