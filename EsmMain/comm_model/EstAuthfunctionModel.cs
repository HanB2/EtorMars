using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comm_model
{
	//EST 사용자 권한 목록
	class EstAuthfunctionModel
	{
		public int SEQ_NO { get; set; }             //	data_type	int		KEY
		public int CRUD { get; set; }               //	data_type	tinyint		권한구분(1=조회|2=등록|4=편집|8=삭제)
		public string UPDTIME { get; set; }             //	data_type	datetime		편집일시
		public string MENU_ID { get; set; }             //	data_type	varchar		메뉴 ID

	}
}
