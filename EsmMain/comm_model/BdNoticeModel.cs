using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comm_model
{
	//공지사항	
	class BdNoticeModel
	{
		public int SEQ_NO { get; set; }             //	data_type	int		KEY
		public int ESM_NO { get; set; }             //	data_type	int		ESM_USER - SEQ_NO 
		public string TITLE_CN { get; set; }                //	data_type	varchar		제목(중국어)
		public string TITLE_EN { get; set; }                //	data_type	varchar		제목(영어)
		public string TITLE_KR { get; set; }                //	data_type	varchar		제목(한국어)
		public string CONTENTS_CN { get; set; }             //	data_type	text		내용(중국어)
		public string CONTENTS_EN { get; set; }             //	data_type	text		내용(영어)
		public string CONTENTS_KR { get; set; }             //	data_type	text		내용(한국어)
		public string REGDATE { get; set; }             //	data_type	datetime		등록일시
		public string UP_DATE { get; set; }             //	data_type	datetime		수정일시
		public int READ_NUM { get; set; }               //	data_type	int		조회수
		public int POPUP_DISPLAY { get; set; }              //	data_type	tinyint		팝업여부(0 : 안보여줌, 1 : 보여줌)
		public string POPUP_START { get; set; }             //	data_type	char		팝업시작날짜
		public string POPUP_END { get; set; }               //	data_type	char		팝업종료날짜
		public int WEB_DISPLAY { get; set; }                //	data_type	tinyint		"'0:모든사이트 보여줌, 1:업체사이트만, 2:CS사이트만 수정 0 : ESM / 1 : EST / 2 : ESE 노출'"

	}
}
