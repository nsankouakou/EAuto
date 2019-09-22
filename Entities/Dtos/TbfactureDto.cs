using System;
using System.Linq;
using System.Collections.Generic;

namespace Entities.Models.Dtos
{
    public class TbfactureDto
    {
        public decimal IdFact { get; set; }

        public string NumFact { get; set; }

        public DateTime DatFact { get; set; }

        public decimal MtFact { get; set; }

        public decimal MtFactTtc { get; set; }

        public decimal MtTva { get; set; }

        public decimal IdDoss { get; set; }

        public decimal IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public TbdossierDto IdDossNavigation { get; set; }

        public ICollection<Tbreglement> Tbreglement { get; set; }

        public ICollection<Tbrembourssement> Tbrembourssement { get; set; }

        public static TbfactureDto FromModel(Tbfacture model)
        {
            return new TbfactureDto()
            {
                IdFact = model.IdFact, 
                NumFact = model.NumFact, 
                DatFact = model.DatFact, 
                MtFact = model.MtFact, 
                MtFactTtc = model.MtFactTtc, 
                MtTva = model.MtTva, 
                IdDoss = model.IdDoss, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                IdDossNavigation = TbdossierDto.FromModel(model.IdDossNavigation), 
                Tbreglement = model.Tbreglement, 
                Tbrembourssement = model.Tbrembourssement, 
            }; 
        }

        public Tbfacture ToModel()
        {
            return new Tbfacture()
            {
                IdFact = IdFact, 
                NumFact = NumFact, 
                DatFact = DatFact, 
                MtFact = MtFact, 
                MtFactTtc = MtFactTtc, 
                MtTva = MtTva, 
                IdDoss = IdDoss, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                IdDossNavigation = IdDossNavigation.ToModel(), 
                Tbreglement = Tbreglement, 
                Tbrembourssement = Tbrembourssement, 
            }; 
        }
    }
}