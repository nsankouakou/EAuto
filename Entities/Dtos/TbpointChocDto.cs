using System;
using System.Linq;
using System.Collections.Generic;

namespace Entities.Models.Dtos
{
    public class TbpointChocDto
    {
        public decimal IdPointChoc { get; set; }

        public string LibPointChoc { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public ICollection<TbexpertiseFourniturePointChoc> TbexpertiseFourniturePointChoc { get; set; }

        public ICollection<TbexpertisePointChoc> TbexpertisePointChoc { get; set; }

        public ICollection<TbexpertisePourRecousPointChoc> TbexpertisePourRecousPointChoc { get; set; }

        public ICollection<TbexpertiseRubriqueConstatationPointChoc> TbexpertiseRubriqueConstatationPointChoc { get; set; }

        public ICollection<TbexpertiseTravauxExterieurPointChoc> TbexpertiseTravauxExterieurPointChoc { get; set; }

        public ICollection<TbmainOeuvrePointChoc> TbmainOeuvrePointChoc { get; set; }

        public ICollection<TbrecapPrejudice> TbrecapPrejudice { get; set; }

        public static TbpointChocDto FromModel(TbpointChoc model)
        {
            return new TbpointChocDto()
            {
                IdPointChoc = model.IdPointChoc, 
                LibPointChoc = model.LibPointChoc, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                TbexpertiseFourniturePointChoc = model.TbexpertiseFourniturePointChoc, 
                TbexpertisePointChoc = model.TbexpertisePointChoc, 
                TbexpertisePourRecousPointChoc = model.TbexpertisePourRecousPointChoc, 
                TbexpertiseRubriqueConstatationPointChoc = model.TbexpertiseRubriqueConstatationPointChoc, 
                TbexpertiseTravauxExterieurPointChoc = model.TbexpertiseTravauxExterieurPointChoc, 
                TbmainOeuvrePointChoc = model.TbmainOeuvrePointChoc, 
                TbrecapPrejudice = model.TbrecapPrejudice, 
            }; 
        }

        public TbpointChoc ToModel()
        {
            return new TbpointChoc()
            {
                IdPointChoc = IdPointChoc, 
                LibPointChoc = LibPointChoc, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                TbexpertiseFourniturePointChoc = TbexpertiseFourniturePointChoc, 
                TbexpertisePointChoc = TbexpertisePointChoc, 
                TbexpertisePourRecousPointChoc = TbexpertisePourRecousPointChoc, 
                TbexpertiseRubriqueConstatationPointChoc = TbexpertiseRubriqueConstatationPointChoc, 
                TbexpertiseTravauxExterieurPointChoc = TbexpertiseTravauxExterieurPointChoc, 
                TbmainOeuvrePointChoc = TbmainOeuvrePointChoc, 
                TbrecapPrejudice = TbrecapPrejudice, 
            }; 
        }
    }
}