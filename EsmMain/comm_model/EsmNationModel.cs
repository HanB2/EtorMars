using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comm_model
{
	//국가 목록
	class EsmNationModel
	{
		public int SEQ_NO { get; set; }             //	data_type	int		KEY
		public string NATION_CODE { get; set; }             //	data_type	char		KR / CN 등 두글자 코드
		public string NATIONNAME { get; set; }              //	data_type	varchar		영문 표기
		public string NATIONNAME_ko_KR { get; set; }                //	data_type	varchar		한글 표기
		public string NATIONNAME_zh_CN { get; set; }                //	data_type	varchar		중국어 표기

	}
}
