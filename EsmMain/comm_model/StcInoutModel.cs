using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comm_model
{
	//보관 이력
	class StcInoutModel
	{
		public int SEQ_NO { get; set; }             //	data_type	int		KEY
		public int ESE_NO { get; set; }             //	data_type	int		ESE_INFO - SEQ_NO
		public int EST_NO { get; set; }             //	data_type	int		EST_INFO - SEQ_NO 등록한 EST
		public int GOODS_NO { get; set; }               //	data_type	int		STC_GOODS - SEQ_NO
		public int GOODS_CNT { get; set; }             //	data_type	smallint		입출고 수량
		public string INOUT_YMD { get; set; }             //	data_type	date		입출고 일자
		public int INOUT_TYPE { get; set; }             //	data_type	tinyint		0=입고, 1=출고, 2=불량, 3=재고조정
		public string RACKNO { get; set; }              //	data_type	varchar		랙번호
		public string NOTE { get; set; }                //	data_type	varchar		메모
		public string EST_EMAIL { get; set; }               //	data_type	char		EST_USER - EMAIL / 사용자 이메일 / ID (승인자)
		public string UPDTIME { get; set; }             //	data_type	datetime		입출고 날짜시간

	}
}
