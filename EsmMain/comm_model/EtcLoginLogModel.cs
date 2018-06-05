using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comm_model
{
	//로그인 이력
	class EtcLoginLogModel
	{
		public int SEQ_NO { get; set; }             //	data_type	int		KEY
		public int USER_TYPE { get; set; }              //	data_type	int		1: ESE / 2 : EST / 3 : ESM
		public int USER_NO { get; set; }                //	data_type	int		ESE/EST/ESM SEQ_NO
		public string USERID { get; set; }              //	data_type	varchar		로그인 ID
		public string LOGstring { get; set; }               //	data_type	datetime		로그인 시간
		public string IPADDR { get; set; }              //	data_type	varchar		로그인 IP

	}
}
