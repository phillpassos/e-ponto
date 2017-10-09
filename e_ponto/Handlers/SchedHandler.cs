using System;
using System.Windows.Forms;
using e_ponto.Classes;

namespace e_ponto.Handlers
{
    class SchedHandler
    {
        public Conn conn { get; set; }
        private const string INVALID_CONN = @"Instancia de conexao invalida";
        private Timer _timer;

        public SchedHandler(Conn c)
        {
            if (c == null)
            {
                throw new Exception(INVALID_CONN);
            }
            conn = c;
        }

        public void StartWatcher()
        {
            conn.UpdateInfo();
        }

        public void StopWatcher()
        {
            throw new NotImplementedException();
        }

        private void eventRaiser()
        {
            
        }
    }
}
