using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comm_model
{
	//EST 사용자 권한
	class EstAuthModel
	{
		public int SEQ_NO { get; set; }             //	data_type	int		KEY
		public int AUTH_GROUP_NO { get; set; }              //	data_type	int		EST_AUTH_GROUP - SEQ_NO
		public int AUTHFUNCTION_NO { get; set; }                //	data_type	int		EST_AUTHFUNCTION - SEQ_NO
		public string REG_DT { get; set; }              //	data_type	datetime		등록일자


	}
}
