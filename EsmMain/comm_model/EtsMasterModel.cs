using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comm_model
{
	//마스터 정보
	class EtsMasterModel
	{
		public int SEQ_NO { get; set; }             //	data_type	int		KEY
		public string MASTERNO { get; set; }                //	data_type	char		마스터 번호
		public string START_AIRPORT { get; set; }               //	data_type	char		출발공항기호 ESM_AIRPORT - AIRPORT_CODE
		public string ARRIVAL_AIRPORT { get; set; }             //	data_type	char		도착공항기호 ESM_AIRPORT - AIRPORT_CODE
		public int STATUS { get; set; }                //	data_type	smallint		마스터에 포함된 송장상태
		public int OUTREG_STATUS { get; set; }             //	data_type	smallint		0=미출고, 1=출고
		public string string_OUT { get; set; }              //	data_type	datetime		출고된 날짜
		public string string_ETD { get; set; }              //	data_type	datetime		예상출발 날짜시간
		public string string_ETA { get; set; }              //	data_type	datetime		예상도착 날짜시간
		public string OUTPUT_TYPE { get; set; }             //	data_type	varchar		출고타입
		public double WEIGHT { get; set; }              //	data_type	double		무게(사용자 입력)
		public string MEMO { get; set; }                //	data_type	varchar		메모
		public string NOTICE { get; set; }              //	data_type	varchar		공지사항(배송조회 site에 표시됨)
		public string REG_DT { get; set; }              //	data_type	datetime		등록일자
		public string UPDT_DT { get; set; }             //	data_type	datetime		수정일자

	}
}
