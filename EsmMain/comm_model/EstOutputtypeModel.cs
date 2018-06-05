using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comm_model
{
	//EST 출고타입
	class EstOutputtypeModel
	{
		public int SEQ_NO { get; set; }             //	data_type	int		KEY
		public int EST_NO { get; set; }             //	data_type	int		EST_INFO - SEQ_NO
		public string NATION_CODE { get; set; }             //	data_type	char		ESM_NATION_USE - NATION_CODE 
		public string OUTPUT_TYPE { get; set; }             //	data_type	varchar		출고타입
		public string OUTPUT_CODE { get; set; }             //	data_type	varchar		출고타입 코드
		public string OUTPUT_DESC { get; set; }             //	data_type	varchar		출고타입 설명
		public string DELV_CODE { get; set; }               //	data_type	char		출고타입 기호
		public int USE_TYPE { get; set; }               //	data_type	tinyint		1 : 사용 / 0 : 삭제
		public string REG_DT { get; set; }              //	data_type	datetime		등록일자
		public string UPDT_DT { get; set; }             //	data_type	datetime		수정일자

	}
}
