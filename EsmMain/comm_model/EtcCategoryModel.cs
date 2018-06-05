using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comm_model
{
	//상품 카테고리
	class EtcCategoryModel
	{
		public int SEQ_NO { get; set; }             //	data_type	int		KEY
		public string CATE_CODE { get; set; }               //	data_type	char		카테고리 코드
		public string CATE_NAME_KR { get; set; }                //	data_type	varchar		카태고리명 한글
		public string CATE_NAME_CN { get; set; }                //	data_type	varchar		카테고리명 중문
		public string CATE_NAME_EN { get; set; }                //	data_type	varchar		카태고리명 영문
		public int USE_TYPE { get; set; }               //	data_type	tinyint		1 : 사용 / 0 : 미사용
		public string REG_DT { get; set; }              //	data_type	datetime		등록일자
		public string UPDT_DT { get; set; }             //	data_type	datetime		수정일자

	}
}
