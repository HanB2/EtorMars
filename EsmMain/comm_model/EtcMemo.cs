using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comm_model
{
	//메모 이력
	class EtcMemo
	{
		public int SEQ_NO { get; set; }             //	data_type	int		KEY
		public int EST_NO { get; set; }             //	data_type	int		운송장번호
		public string MEMO { get; set; }                //	data_type	varchar		메모
		public string AUTHOR { get; set; }              //	data_type	varchar		입력한 사람 이름
		public string IP_ADDR { get; set; }             //	data_type	varchar		입력한 사람 IP주소
		public string USERID { get; set; }              //	data_type	varchar		입력한 사람 ID
		public int READ_YN { get; set; }               //	data_type	smallint		0=읽지않음, 1=읽음
		public string REG_DT { get; set; }              //	data_type	datetime		등록일자
		public int DISPLAY_MODE { get; set; }              //	data_type	smallint		볼수있는 사람(1=수취인, 2=업체, 4=관리자)
		public int USER_POWER { get; set; }                //	data_type	smallint		입력한 사람 권한(100=관리자, 20=본사CS직원, 10=업체, 5=업체CS직원)

	}
}
