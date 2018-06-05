using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comm_model
{
	//EST 사용자 그룹
	class EstAuthGroupModel
	{
		public int SEQ_NO { get; set; }             //	data_type	int		KEY
		public int EST_NO { get; set; }             //	data_type	int		EST_INFO - SEQ_NO
		public string AUTH_NAME { get; set; }               //	data_type	char		권한 명
		public int STAT { get; set; }               //	data_type	tinyint		1 : 사용 / 0 : 미사용 / 상태값 추가 시 
		public string REG_DT { get; set; }              //	data_type	datetime		등록일자
		public string UPDT_DT { get; set; }             //	data_type	datetime		수정일자

	}
}
