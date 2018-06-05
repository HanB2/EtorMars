using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comm_model
{
	//개별환경설정
	public class EsmSettingModel
	{
		public int SEQ_NO { get; set; }             //	data_type	int		KEY
		public int EST_NO { get; set; }             //	data_type	int		EST_INFO - SEQ_NO
		public string OPT_KEY { get; set; }             //	data_type	char		옵션 고유값
		public string OPT_VALUE { get; set; }               //	data_type	varchar		옵션 정보값

	}
}
