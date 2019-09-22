using System;

namespace Entities.Models.Dtos
{
    public class TbuserDossierDto
    {
        public decimal Iddoss { get; set; }

        public decimal Iduser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public TbdossierDto IddossNavigation { get; set; }

        public TbuserDto IduserNavigation { get; set; }

        public static TbuserDossierDto FromModel(TbuserDossier model)
        {
            return new TbuserDossierDto()
            {
                Iddoss = model.Iddoss, 
                Iduser = model.Iduser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                IddossNavigation = TbdossierDto.FromModel(model.IddossNavigation), 
                IduserNavigation = TbuserDto.FromModel(model.IduserNavigation), 
            }; 
        }

        public TbuserDossier ToModel()
        {
            return new TbuserDossier()
            {
                Iddoss = Iddoss, 
                Iduser = Iduser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                IddossNavigation = IddossNavigation.ToModel(), 
                IduserNavigation = IduserNavigation.ToModel(), 
            }; 
        }
    }
}