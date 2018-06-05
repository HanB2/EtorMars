using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comm_model
{
	//ESE 마르 이력
	class MarEseInoutModel
	{
		public int SEQ_NO { get; set; }             //	data_type	int		KEY
		public int CALC_TYPE { get; set; }              //	data_type	int		0 : + / 1 : - (계산 타입)
		public int ACT_TYPE { get; set; }               //	data_type	int		0 : 배송 신청 / 1 : 보관비용 / 2 : …
		public int ESE_NO { get; set; }             //	data_type	int		ESE_INFO SEQ_NO
		public int ESM_NO { get; set; }             //	data_type	int		승인한 ESM USER 키
		public double MAR { get; set; }             //	data_type	decimal		환전 요청 MAR
		public string REG_DT { get; set; }              //	data_type	datetime		등록일자
		public int IN_NO { get; set; }              //	data_type	int		MAR_IN - SEQ
		public int OUT_NO { get; set; }             //	data_type	int		MAR_OUT - SEQ

	}
}
