using System;
using System.Linq;
using System.Collections.Generic;

namespace Entities.Models.Dtos
{
    public class TbtravauxExterieurDto
    {
        public decimal Idautrecharg { get; set; }

        public string Libautrecharg { get; set; }

        public decimal? NbAutres { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public ICollection<TbexpertiseTravauxExterieurPointChoc> TbexpertiseTravauxExterieurPointChoc { get; set; }

        public static TbtravauxExterieurDto FromModel(TbtravauxExterieur model)
        {
            return new TbtravauxExterieurDto()
            {
                Idautrecharg = model.Idautrecharg, 
                Libautrecharg = model.Libautrecharg, 
                NbAutres = model.NbAutres, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                TbexpertiseTravauxExterieurPointChoc = model.TbexpertiseTravauxExterieurPointChoc, 
            }; 
        }

        public TbtravauxExterieur ToModel()
        {
            return new TbtravauxExterieur()
            {
                Idautrecharg = Idautrecharg, 
                Libautrecharg = Libautrecharg, 
                NbAutres = NbAutres, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                TbexpertiseTravauxExterieurPointChoc = TbexpertiseTravauxExterieurPointChoc, 
            }; 
        }
    }
}