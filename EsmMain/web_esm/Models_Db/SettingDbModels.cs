using comm_dbconn;
using System.Data;

namespace web_esm.Models_Db
{
	public class SettingDbModels
	{

		string[] strOPT_KEY = {
			"emaile_sender_server",
			"emaile_sender_port",
			"emaile_sender_id",
			"emaile_sender_pw",
			"emaile_sender_email",
			"emaile_sender_name", 
		};

		public EmailSettingModel GetEmailSettingModel()
		{
			string errorStr = "";


			EmailSettingModel emailSetM = new EmailSettingModel();
			DatabaseConnection dbConn = new DatabaseConnection();

			string sqlQueryStr = "SELECT OPT_KEY, OPT_VALUE FROM esm_setting WHERE OPT_KEY in ('" + string.Join("','", strOPT_KEY) + "')";

			DataTable dt = dbConn.getQueryResult(sqlQueryStr, out errorStr);

			for (int i = 0; i < dt.Rows.Count; i++)
			{
				if (dt.Rows[i]["OPT_KEY"].ToString() == "emaile_sender_server") { emailSetM.emaile_sender_server = dt.Rows[i]["OPT_VALUE"].ToString(); }
				if (dt.Rows[i]["OPT_KEY"].ToString() == "emaile_sender_port") { emailSetM.emaile_sender_port = dt.Rows[i]["OPT_VALUE"].ToString(); }
				if (dt.Rows[i]["OPT_KEY"].ToString() == "emaile_sender_id") { emailSetM.emaile_sender_id = dt.Rows[i]["OPT_VALUE"].ToString(); }
				if (dt.Rows[i]["OPT_KEY"].ToString() == "emaile_sender_pw") { emailSetM.emaile_sender_pw = dt.Rows[i]["OPT_VALUE"].ToString(); }
				if (dt.Rows[i]["OPT_KEY"].ToString() == "emaile_sender_email") { emailSetM.emaile_sender_email = dt.Rows[i]["OPT_VALUE"].ToString(); }
				if (dt.Rows[i]["OPT_KEY"].ToString() == "emaile_sender_name") { emailSetM.emaile_sender_name = dt.Rows[i]["OPT_VALUE"].ToString(); }


			}

			return emailSetM;
		}


	}

	public class EmailSettingModel
	{
		public string emaile_sender_server { get; set; }             //	SMTP 서버명
		public string emaile_sender_port { get; set; }             //	SMTP 포트번호
		public string emaile_sender_id { get; set; }             //	ID
		public string emaile_sender_pw { get; set; }             //	PASSWORD
		public string emaile_sender_email { get; set; }             //	보내는 사람 E-MAIL
		public string emaile_sender_name { get; set; }           //	보내는 사람 이름

	}
}