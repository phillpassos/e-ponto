using System;
using System.Collections.Specialized;
using System.Text;
using System.Web.Helpers;
using e_ponto.Exceptions;

namespace e_ponto.Classes
{
    class Conn
    {
        #region CONSTANTS
        private const string BASE_URL = @"http://consultarponto.alterdata.matriz/";
        private const string LOGIN_URI = @"login/";
        private const string SCHEDULES_URI = @"gestao/marcacoes";
        private const string USER_DATA_URI = @"usuario/";
        #endregion

        public Credentials cred { get; set; }
        public Schedules scheds { get; private set; }
        public bool connected { get; private set; }
        private CookieAwareWebClient clt;

        public Conn(Credentials c)
        {
            if (!c.IsValid()) return;

            this.cred = c;
            clt = new CookieAwareWebClient();
        }

        private bool Login()
        {
            try
            {
                var data = new NameValueCollection { { "usuario", cred.User }, { "senha", cred.Pass } };
                var response = clt.UploadValues(BASE_URL + LOGIN_URI, "POST", data);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void UpdateInfo()
        {
            if (!connected && !Login())
            {
                throw new LoginErrorException();
            }
            try
            {
                string schedDataString = Encoding.UTF8.GetString(clt.DownloadData(BASE_URL + SCHEDULES_URI));
                scheds = Json.Decode<Schedules>(schedDataString);
            }
            catch (Exception)
            {
                throw new LoginErrorException();
            }
        }
    }
}
