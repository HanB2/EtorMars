using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comm_model
{
	//배송 상품
	class EtsGoodsModel
	{
		public int SEQ_NO { get; set; }             //	data_type	int		KEY
		public int INFO_NO { get; set; }                //	data_type	int		ETS_INFO - SEQ_NO
		public string CATE_CODE { get; set; }               //	data_type	char		ETC_CAREGORY - CATE_CODE
		public string HSCODE { get; set; }              //	data_type	varchar		HSCODE (상품종류)
		public double TAX_RATE { get; set; }                //	data_type	double		세율
		public string GOODS_NAME { get; set; }              //	data_type	varchar		상품명
		public int QTY { get; set; }               //	data_type	smallint		수량
		public double PRICE { get; set; }               //	data_type	double		단가
		public string BRAND { get; set; }               //	data_type	varchar		브랜드명
		public string PURCHASE_URL { get; set; }                //	data_type	varchar		구매URL
		public double VOLUME { get; set; }              //	data_type	double		용량
		public string UNIT { get; set; }                //	data_type	varchar		단위
		public string BARCODE { get; set; }             //	data_type	varchar		바코드
		public int OUTPUTNO { get; set; }               //	data_type	int		출고번호
		public string SKU { get; set; }             //	data_type	varchar		SKU 재고관리번호
		public string REG_DT { get; set; }              //	data_type	datetime		등록일자
		public string UPDT_DT { get; set; }             //	data_type	datetime		수정일자

	}
}
