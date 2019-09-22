using System;
using System.Linq;
using System.Collections.Generic;

namespace Entities.Models.Dtos
{
    public class TbgarageDto
    {
        public decimal IdGara { get; set; }

        public string RaisonSociale { get; set; }

        public string TelGar { get; set; }

        public string AdrGar { get; set; }

        public string MailGar { get; set; }

        public string Sigle { get; set; }

        public string FaxGar { get; set; }

        public string Contact { get; set; }

        public bool Pme { get; set; }

        public string BpGar { get; set; }

        public decimal? IdUser { get; set; }

        public decimal? IdTyGara { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public ICollection<Tbexpertise> Tbexpertise { get; set; }

        public ICollection<TbtarifHoraireGarageMarque> TbtarifHoraireGarageMarque { get; set; }

        public static TbgarageDto FromModel(Tbgarage model)
        {
            return new TbgarageDto()
            {
                IdGara = model.IdGara, 
                RaisonSociale = model.RaisonSociale, 
                TelGar = model.TelGar, 
                AdrGar = model.AdrGar, 
                MailGar = model.MailGar, 
                Sigle = model.Sigle, 
                FaxGar = model.FaxGar, 
                Contact = model.Contact, 
                Pme = model.Pme, 
                BpGar = model.BpGar, 
                IdUser = model.IdUser, 
                IdTyGara = model.IdTyGara, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                Tbexpertise = model.Tbexpertise, 
                TbtarifHoraireGarageMarque = model.TbtarifHoraireGarageMarque, 
            }; 
        }

        public Tbgarage ToModel()
        {
            return new Tbgarage()
            {
                IdGara = IdGara, 
                RaisonSociale = RaisonSociale, 
                TelGar = TelGar, 
                AdrGar = AdrGar, 
                MailGar = MailGar, 
                Sigle = Sigle, 
                FaxGar = FaxGar, 
                Contact = Contact, 
                Pme = Pme, 
                BpGar = BpGar, 
                IdUser = IdUser, 
                IdTyGara = IdTyGara, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                Tbexpertise = Tbexpertise, 
                TbtarifHoraireGarageMarque = TbtarifHoraireGarageMarque, 
            }; 
        }
    }
}