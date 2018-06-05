using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comm_model
{
	//DB 조작 이력
	class EtcDbLogModel
	{
		public int SEQ_NO { get; set; }             //	data_type	int		KEY
		public int USER_TYPE { get; set; }              //	data_type	int		1: ESE / 2 : EST / 3 : ESM
		public int USER_NO { get; set; }                //	data_type	int		실행 유저 SEQ_NO
		public string EXE_QUERY { get; set; }               //	data_type	text		실행된 쿼리
		public string REG_DT { get; set; }              //	data_type	datetime		등록일자

	}
}
