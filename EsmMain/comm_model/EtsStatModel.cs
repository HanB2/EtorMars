using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comm_model
{
	//배송 상태
	class EtsStatModel
	{
		public int SEQ_NO { get; set; }             //	data_type	int		KEY
		public string ETS_NO { get; set; }              //	data_type	varchar		EST_INFO - SEQ_NO
		public int STATUS { get; set; }                //	data_type	smallint		상태
		public string LOCATION { get; set; }                //	data_type	varchar		위치
		public string REG_DT { get; set; }              //	data_type	datetime		등록일자

	}
}
