using System;
using System.Linq;
using System.Collections.Generic;

namespace Entities.Models.Dtos
{
    public class TbproprietaireDto
    {
        public decimal IdProprio { get; set; }

        public string NomProprio { get; set; }

        public string PrenProPrio { get; set; }

        public string TelProprio { get; set; }

        public string AdrProprio { get; set; }

        public string BpProprio { get; set; }

        public string MailProrio { get; set; }

        public string FaxProprio { get; set; }

        public DateTime DatEnreg { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public ICollection<Tbvehicule> Tbvehicule { get; set; }

        public static TbproprietaireDto FromModel(Tbproprietaire model)
        {
            return new TbproprietaireDto()
            {
                IdProprio = model.IdProprio, 
                NomProprio = model.NomProprio, 
                PrenProPrio = model.PrenProPrio, 
                TelProprio = model.TelProprio, 
                AdrProprio = model.AdrProprio, 
                BpProprio = model.BpProprio, 
                MailProrio = model.MailProrio, 
                FaxProprio = model.FaxProprio, 
                DatEnreg = model.DatEnreg, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                Tbvehicule = model.Tbvehicule, 
            }; 
        }

        public Tbproprietaire ToModel()
        {
            return new Tbproprietaire()
            {
                IdProprio = IdProprio, 
                NomProprio = NomProprio, 
                PrenProPrio = PrenProPrio, 
                TelProprio = TelProprio, 
                AdrProprio = AdrProprio, 
                BpProprio = BpProprio, 
                MailProrio = MailProrio, 
                FaxProprio = FaxProprio, 
                DatEnreg = DatEnreg, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                Tbvehicule = Tbvehicule, 
            }; 
        }
    }
}