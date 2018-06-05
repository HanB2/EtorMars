using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comm_model
{
	//EST 사용자 계정
	class EstUserModel
	{
		public int SEQ_NO { get; set; }             //	data_type	int		KEY
		public int EST_NO { get; set; }             //	data_type	int		EST_INFO - SEQ_NO
		public int AUTH_NO { get; set; }                //	data_type	int		EST_AUTH_GROUP - SEQ_NO
		public string EMAIL { get; set; }               //	data_type	char		사용자 이메일 / ID
		public string PASSWD { get; set; }              //	data_type	varchar		로그인 비밀번호
		public string NAME { get; set; }                //	data_type	char		사용자 이름
		public string TEL { get; set; }             //	data_type	char		사용자 전화번호
		public int STAT { get; set; }               //	data_type	tinyint		1 : 사용 / 0 : 미사용 / 상태값 추가 시 
		public string REG_DT { get; set; }              //	data_type	datetime		등록일자
		public string UPDT_DT { get; set; }             //	data_type	datetime		수정일자

	}
}
