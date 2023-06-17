// Kopierrechte bei Sascha Lember 2023
// Erstellt 18.06.2023

#region Verweise

using System.Net;

#endregion

namespace Lember.WerkMa.Allgemein.Database.DatabaseClass
{
    public class IpAddressValidator
    {
        #region Methods

        public bool IsValidIpAddress(string ipAddress)
        {
            IPAddress address;
            return IPAddress.TryParse(ipAddress, out address);
        }

        #endregion
    }
}