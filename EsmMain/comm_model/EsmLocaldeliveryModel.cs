using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comm_model
{
	//배송가능 국가의 배송업체
	class EsmLocaldeliveryModel
	{
		public int SEQ_NO { get; set; }             //	data_type	int		KEY
		public int NATION_NO { get; set; }              //	data_type	int		ESM_NATION - NATION_NO
		public string NAME { get; set; }                //	data_type	varchar		배송회사 이름
		public string HOMEPAGE { get; set; }                //	data_type	varchar		배송회사 홈페이지
		public string COM_ID { get; set; }              //	data_type	varchar		배송회사 ID
		public string COMMENT { get; set; }             //	data_type	varchar		설명
		public string REG_DT { get; set; }              //	data_type	datetime		등록일자

	}
}
