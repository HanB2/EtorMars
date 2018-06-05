using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comm_model
{
	//HSCODE 중국
	class EtcHscodeCnModel
	{
		public int SEQ_NO { get; set; }             //	data_type	int		KEY
		public string HSCODE { get; set; }              //	data_type	varchar		
		public string NAME_KOR { get; set; }                //	data_type	varchar		상품명(한글)
		public string NAME_CN { get; set; }             //	data_type	varchar		상품명(중국어)
		public double TAX { get; set; }             //	data_type	double		세율
		public string TYPE { get; set; }                //	data_type	char		Y/N

	}
}
