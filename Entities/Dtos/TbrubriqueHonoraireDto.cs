using System;
using System.Linq;
using System.Collections.Generic;

namespace Entities.Models.Dtos
{
    public class TbrubriqueHonoraireDto
    {
        public decimal Idrubhonr { get; set; }

        public string Librubhonor { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public ICollection<TbdossierRubriqueHonoraire> TbdossierRubriqueHonoraire { get; set; }

        public static TbrubriqueHonoraireDto FromModel(TbrubriqueHonoraire model)
        {
            return new TbrubriqueHonoraireDto()
            {
                Idrubhonr = model.Idrubhonr, 
                Librubhonor = model.Librubhonor, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                TbdossierRubriqueHonoraire = model.TbdossierRubriqueHonoraire, 
            }; 
        }

        public TbrubriqueHonoraire ToModel()
        {
            return new TbrubriqueHonoraire()
            {
                Idrubhonr = Idrubhonr, 
                Librubhonor = Librubhonor, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                TbdossierRubriqueHonoraire = TbdossierRubriqueHonoraire, 
            }; 
        }
    }
}