using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comm_model
{
	//문의사항
	class BdQnaModel
	{
		public int SEQ_NO { get; set; }             //	data_type	int		KEY
		public int ESE_NO { get; set; }             //	data_type	int		ESE_USER - SEQ_NO 
		public int EST_NO { get; set; }             //	data_type	int		EST_USER - SEQ_NO
		public int ESM_NO { get; set; }             //	data_type	int		ESM_USER - SEQ_NO 
		public int QNA_TYPE { get; set; }               //	data_type	tinyint		문의 유형 1 : 일반 문의 / 2 : 충전 문의 등등
		public string TITLE { get; set; }               //	data_type	varchar		제목
		public string QUESTION { get; set; }                //	data_type	text		문의 내용
		public string ANSWER { get; set; }              //	data_type	text		답변 내용
		public string REGDATE { get; set; }             //	data_type	datetime		등록일시
		public string UP_DATE { get; set; }             //	data_type	datetime		수정일시

	}
}
