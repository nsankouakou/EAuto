using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Connexion
    {
        public int ConnexionId { get; set; }
        public int UserId { get; set; }
        public string AdresseIpSource { get; set; }
        public DateTime DateConnexion { get; set; }
        public DateTime? DateLastConnexion { get; set; }
        public string Token { get; set; }
        public bool Bsucces { get; set; }
    }
}
