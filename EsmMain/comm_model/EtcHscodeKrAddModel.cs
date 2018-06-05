using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comm_model
{
	//HSCODE 한국 추가분
	class EtcHscodeKrAddModel
	{
		public int SEQ_NO { get; set; }             //	data_type	int		KEY
		public string HSCODE { get; set; }              //	data_type	varchar		
		public string DESC_EN { get; set; }             //	data_type	varchar		품목(영문)
		public string DESC_KR { get; set; }             //	data_type	varchar		품목(한글)
		public string HSCODE_SUB1 { get; set; }             //	data_type	varchar		대분류
		public string HSCODE_SUB2 { get; set; }             //	data_type	varchar		중분류
		public string HSCODE_SUB3 { get; set; }             //	data_type	varchar		소분류
		public string CUSTOMS_TYPE { get; set; }                //	data_type	char		B=일반, Y=목록

	}
}
