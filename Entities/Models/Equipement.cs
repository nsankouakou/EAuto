using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Equipement
    {
        public Equipement()
        {
        }
        public decimal Equipementid { get; set; }
        public string Libequipement { get; set; }
        public string CodeEq { get; set; }
        public string Numero { get; set; }
        public Guid? Marqueid { get; set; }
        public string NumeroSerie { get; set; }
        public DateTime? DateMiseEnService { get; set; }
        public DateTime? Createon { get; set; }
        public int? Statutcode { get; set; }
        public int? Statecode { get; set; }
        public Guid? Modifiedby { get; set; }
        public DateTime? Modifiedon { get; set; }
        public Guid? TypeEqid { get; set; }
        public Guid? Agenceid { get; set; }
        
    }
}
