using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comm_model
{
	//보관 상품 정보 이력
	class StcGoodsHisModel
	{
		public int SEQ_NO { get; set; }             //	data_type	int		KEY
		public int ORI_GOODS_NO { get; set; }               //	data_type	int		STC_GOODS_NO
		public int ESE_NO { get; set; }             //	data_type	int		ESE_INFO - SEQ_NO
		public string CATE { get; set; }                //	data_type	char		ETC_CATEGORY - SEQ_NO
		public string BARCODE { get; set; }             //	data_type	varchar		바코드
		public string SKU { get; set; }             //	data_type	varchar		상품관리번호
		public string PRODUCT_NAME { get; set; }                //	data_type	varchar		대표상품명
		public string PRODUCT_NAME_KR { get; set; }             //	data_type	varchar		상품명(한글)
		public string PRODUCT_NAME_CN { get; set; }             //	data_type	varchar		상품명(중문)
		public string PRODUCT_NAME_EN { get; set; }             //	data_type	varchar		상품명(영문)
		public string BRAND { get; set; }               //	data_type	varchar		브랜드명
		public double PRICE { get; set; }               //	data_type	double		가격
		public double UNIT_WEIGHT { get; set; }             //	data_type	double		중량 / 용량
		public string WEIGHT_UNIT { get; set; }             //	data_type	char		단위
		public string STANDARD { get; set; }                //	data_type	char		규격
		public int EXPIRATION { get; set; }             //	data_type	int		유통기한
		public string EXPIRATION_DT { get; set; }               //	data_type	datetime		유통만료일자
		public string ORIGIN { get; set; }              //	data_type	char		원산지
		public string INGREDIENT { get; set; }              //	data_type	varchar		성분
		public string SPEC { get; set; }                //	data_type	text		상세스팩
		public string SALE_SITE_URL { get; set; }               //	data_type	varchar		판매 사이트 URL
		public string PRODUCT_IMAGE { get; set; }               //	data_type	text		상품 이미지 URL
		public string RACKNO { get; set; }              //	data_type	varchar		랙번호
		public string COMMENT { get; set; }             //	data_type	varchar		메모
		public string REG_DT { get; set; }              //	data_type	datetime		등록일자
		public string ESE_EMAIL { get; set; }               //	data_type	char		ESE_USER - EMAIL / 사용자 이메일 / ID (변경자)

	}
}
