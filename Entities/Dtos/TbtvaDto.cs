using System;
using System.Linq;
using System.Collections.Generic;

namespace Entities.Models.Dtos
{
    public class TbtvaDto
    {
        public decimal IdTva { get; set; }

        public DateTime DateTva { get; set; }

        public string TxTva { get; set; }

        public int EtatTva { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public ICollection<Tbdossier> Tbdossier { get; set; }

        public static TbtvaDto FromModel(Tbtva model)
        {
            return new TbtvaDto()
            {
                IdTva = model.IdTva, 
                DateTva = model.DateTva, 
                TxTva = model.TxTva, 
                EtatTva = model.EtatTva, 
                IdUser = model.IdUser, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StatusCode = model.StatusCode, 
                Tbdossier = model.Tbdossier, 
            }; 
        }

        public Tbtva ToModel()
        {
            return new Tbtva()
            {
                IdTva = IdTva, 
                DateTva = DateTva, 
                TxTva = TxTva, 
                EtatTva = EtatTva, 
                IdUser = IdUser, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StatusCode = StatusCode, 
                Tbdossier = Tbdossier, 
            }; 
        }
    }
}