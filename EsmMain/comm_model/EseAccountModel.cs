using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comm_model
{
	//ESE 계좌 정보 (수정대기)	
	class EseAccountModel
	{
		public int SEQ_NO { get; set; }             //	data_type	int		KEY
		public int ESE_NO { get; set; }             //	data_type	int		EST_INFO - SEQ_NO
		public string BANK_NATION { get; set; }             //	data_type	char		환전시 수금 은행 국가
		public string BANK_CODE { get; set; }               //	data_type	char		환전시 수금 은행 코드
		public string BANK_NAME { get; set; }               //	data_type	char		환전시 수금 은행 명
		public string BANK_ACCOUNT { get; set; }                //	data_type	char		환전시 수금 은행 계좌
		public string BENEFICIARY_NAME { get; set; }                //	data_type	char		환전시 수금자 명
		public string REG_DT { get; set; }              //	data_type	datetime		등록일자
		public string UPDT_DT { get; set; }             //	data_type	datetime		수정일자

	}
}
