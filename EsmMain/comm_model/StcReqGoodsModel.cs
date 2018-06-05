using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comm_model
{
	//보관 상품
	class StcReqGoodsModel
	{
		
		public int SEQ_NO { get; set; }             //	data_type	int		KEY
		public int REQ_NO { get; set; }             //	data_type	int		STC_REQ - SEQ_NO
		public int GOODS_NO { get; set; }               //	data_type	int		STC_GOODS - SEQ_NO
		public int GOODS_CNT { get; set; }             //	data_type	smallint		입출고 수량
		public string REG_DT { get; set; }              //	data_type	datetime		등록일자
		public string UPDT_DT { get; set; }             //	data_type	datetime		수정일자

	}
}
