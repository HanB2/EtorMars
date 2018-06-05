using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comm_global
{
    // etomars 시스템에서 공통으로 적용되는 변수(상수) 들을 여기에 정의해 놓는다
    public class GlobalSettings
    {
        // 한국 도착물건인 경우 일반건으로 전환되는 물품금액의 한도
        public static double CUSTOMS_KR_PRICE_LIMIT_FROM_US = 200.0;  // 미국인 경우 : $200
        public static double CUSTOMS_KR_PRICE_LIMIT_FROM_NOT_US = 150.0;  // 미국이 아닌 경우 : $150
    }
}
