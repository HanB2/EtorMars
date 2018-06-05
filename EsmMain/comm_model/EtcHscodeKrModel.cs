using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comm_model
{
	//HSCODE 한국
	class EtcHscodeKrModel
	{
		public int SEQ_NO { get; set; }             //	data_type	int		KEY
		public string CUSTOM_TYPE { get; set; }             //	data_type	char		B=일반, Y=목록
		public string HSCODE { get; set; }              //	data_type	varchar		
		public string LIST { get; set; }                //	data_type	varchar		품목
		public string LIST_DETAILS { get; set; }                //	data_type	varchar		상세품목
		public string DISCRIPTION { get; set; }             //	data_type	varchar		설명

	}
}
