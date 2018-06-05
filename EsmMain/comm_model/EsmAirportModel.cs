using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comm_model
{
	//배송가능 국가의 공항
	class EsmAirportModel
	{
		public int SEQ_NO { get; set; }             //	data_type	int		KEY
		public int NATION_NO { get; set; }              //	data_type	int		ESM_NATION - NATION_NO
		public string AIRPORT_CODE { get; set; }                //	data_type	char		공항코드
		public string AIRPORT_NAME { get; set; }                //	data_type	varchar		공항이름
		public string AIRPORT_LOCATION { get; set; }                //	data_type	varchar		공항위치
		public string REG_DT { get; set; }              //	data_type	datetime		등록일자

	}
}
