// Kopierrechte bei Sascha Lember 2023
// Erstellt 18.06.2023

#region Verweise

using System.Net.NetworkInformation;
using System.Windows.Forms;

#endregion

namespace Lember.WerkMa.Allgemein.Database.DatabaseClass
{
    public class ServerPinger
    {
        #region Methods

        public bool PingServer(string serverAddress)
        {
            var pingSender = new Ping();

            try
            {
                var reply = pingSender.Send(serverAddress);

                if (reply != null && reply.Status == IPStatus.Success)
                {
                    MessageBox.Show(@"Server erreichbar!");
                    return true;
                }

                MessageBox.Show(@"Server nicht erreichbar");
                return false;
            }
            catch (PingException)
            {
                MessageBox.Show(@"Server nicht erreichbar");
                return false;
            }
        }

        #endregion
    }
}