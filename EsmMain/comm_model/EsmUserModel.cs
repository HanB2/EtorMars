﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comm_model
{
	//ESM 관리자 계정
	class EsmUserModel
	{
		public int SEQ_NO { get; set; }             //	data_type	int		KEY
		public string EMAIL { get; set; }               //	data_type	char		사용자 이메일 / ID
		public string PASSWD { get; set; }              //	data_type	varchar		로그인 비밀번호
		public string MANAGER_NAME { get; set; }                //	data_type	char		사용자 이름
		public string MANAGER_TEL { get; set; }             //	data_type	char		사용자 전화번호
		public string AUTH { get; set; }                //	data_type	text		사용자 권한 JSON 데이터 형식 기록
		public int STAT { get; set; }               //	data_type	tinyint		1 : 사용 / 0 : 미사용 / 상태값 추가 시
		public string REG_DT { get; set; }              //	data_type	datetime		등록일자
		public string UPDT_DT { get; set; }             //	data_type	datetime		수정일자

	}
}
