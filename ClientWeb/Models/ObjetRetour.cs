using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientWeb.Models
{
    public class ObjetRetour
    {
        public ObjetRetour()
        {
            Etat = false;
            Contenu = null;
            Message = "";
        }
        public bool Etat { get; set; }
        public string Message { get; set; }
        public object Contenu { get; set; }
    }
}
