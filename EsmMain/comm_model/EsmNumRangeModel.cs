using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comm_model
{
	//송장번호 권역대
	class EsmNumRangeModel
	{
		public int SEQ_NO { get; set; }             //	data_type	int		KEY
		public string HBLNO_START { get; set; }             //	data_type	char		시작번호
		public string HBLNO_END { get; set; }               //	data_type	char		끝번호
		public string HBLNO_CURRENT { get; set; }               //	data_type	char		마지막 사용번호
		public int DIGIT { get; set; }              //	data_type	int		송장번호 전체 자릿수
		public string PREFIX { get; set; }              //	data_type	char		접두어
		public string POSTFIX { get; set; }             //	data_type	char		접미어
		public int STAT { get; set; }               //	data_type	tinyint		1 : 사용 / 0 : 미사용
		public string REG_DT { get; set; }              //	data_type	datetime		등록일자

	}
}
