using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TbpointChoc
    {
        public TbpointChoc()
        {
            TbexpertiseFourniturePointChoc = new HashSet<TbexpertiseFourniturePointChoc>();
            TbexpertisePointChoc = new HashSet<TbexpertisePointChoc>();
            TbexpertisePourRecousPointChoc = new HashSet<TbexpertisePourRecousPointChoc>();
            TbexpertiseRubriqueConstatationPointChoc = new HashSet<TbexpertiseRubriqueConstatationPointChoc>();
            TbexpertiseTravauxExterieurPointChoc = new HashSet<TbexpertiseTravauxExterieurPointChoc>();
            TbmainOeuvrePointChoc = new HashSet<TbmainOeuvrePointChoc>();
            TbrecapPrejudice = new HashSet<TbrecapPrejudice>();
        }

        public decimal IdPointChoc { get; set; }
        public string LibPointChoc { get; set; }
        public decimal? IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual ICollection<TbexpertiseFourniturePointChoc> TbexpertiseFourniturePointChoc { get; set; }
        public virtual ICollection<TbexpertisePointChoc> TbexpertisePointChoc { get; set; }
        public virtual ICollection<TbexpertisePourRecousPointChoc> TbexpertisePourRecousPointChoc { get; set; }
        public virtual ICollection<TbexpertiseRubriqueConstatationPointChoc> TbexpertiseRubriqueConstatationPointChoc { get; set; }
        public virtual ICollection<TbexpertiseTravauxExterieurPointChoc> TbexpertiseTravauxExterieurPointChoc { get; set; }
        public virtual ICollection<TbmainOeuvrePointChoc> TbmainOeuvrePointChoc { get; set; }
        public virtual ICollection<TbrecapPrejudice> TbrecapPrejudice { get; set; }
    }
}
