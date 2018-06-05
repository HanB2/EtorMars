using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comm_model
{
	//EST 출고타입 요율
	class EstOutputcostModel
	{
		public int SEQ_NO { get; set; }             //	data_type	int		KEY
		public int EST_NO { get; set; }             //	data_type	int		EST_INFO - SEQ_NO
		public string NATION_CODE { get; set; }             //	data_type	char		ESM_NATION_USE - NATION_CODE 
		public double WEIGHT { get; set; }              //	data_type	decimal		기준무게
		public double COST { get; set; }                //	data_type	decimal		요금

	}
}
