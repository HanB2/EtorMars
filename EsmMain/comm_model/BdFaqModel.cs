using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comm_model
{
	//자주묻는 질문
	class BdFaqModel
	{
		public int SEQ_NO { get; set; }                 //	data_type	int			KEY
		public int FAQ_TYPE { get; set; }               //	data_type	tinyint		자주묻는 질문 유형 타입 1 : 시스템 사용 관련 등
		public string TITLE { get; set; }               //	data_type	varchar		제목
		public string QUESTION { get; set; }            //	data_type	text		질문
		public string ANSWER { get; set; }              //	data_type	text		답변
		public string REGDATE { get; set; }             //	data_type	datetime	등록일시
		public string UP_DATE { get; set; }             //	data_type	datetime	수정일시
	}
}
