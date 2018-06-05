using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comm_model
{
	//보관 요청	
	class StcReqModel
	{
		public int SEQ_NO { get; set; }             //	data_type	int		KEY
		public int ESE_NO { get; set; }             //	data_type	int		ESE_INFO - SEQ_NO
		public int EST_NO { get; set; }             //	data_type	int		EST_INFO - SEQ_NO 등록한 EST
		public int INPUT_TYPE { get; set; }             //	data_type	tinyint		입고방법
		public string INPUT_DELVNO { get; set; }                //	data_type	char		입고 배송번호
		public string SENDER_NAME { get; set; }             //	data_type	varchar		발송인 이름
		public string SENDER_TEL { get; set; }              //	data_type	char		발송인 전화번호
		public string SENDER_ADDR { get; set; }             //	data_type	varchar		발송인 주소
		public string MEMO_ESE { get; set; }                //	data_type	varchar		메모
		public string MEMO_EST { get; set; }                //	data_type	varchar		관리자메모
		public int INPUT_STAT { get; set; }             //	data_type	tinyint		
		public string REG_DT { get; set; }              //	data_type	datetime		등록일자
		public string UPDT_DT { get; set; }             //	data_type	datetime		수정일자

	}
}
