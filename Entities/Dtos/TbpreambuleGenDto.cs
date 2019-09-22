using System;
using System.Linq;

namespace Entities.Models.Dtos
{
    public class TbpreambuleGenDto
    {
        public decimal Idpream { get; set; }

        public string Libpream { get; set; }

        public decimal Iddoss { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public TbdossierDto IddossNavigation { get; set; }

        public static TbpreambuleGenDto FromModel(TbpreambuleGen model)
        {
            return new TbpreambuleGenDto()
            {
                Idpream = model.Idpream, 
                Libpream = model.Libpream, 
                Iddoss = model.Iddoss, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                IddossNavigation = TbdossierDto.FromModel(model.IddossNavigation), 
            }; 
        }

        public TbpreambuleGen ToModel()
        {
            return new TbpreambuleGen()
            {
                Idpream = Idpream, 
                Libpream = Libpream, 
                Iddoss = Iddoss, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                IddossNavigation = IddossNavigation.ToModel(), 
            }; 
        }
    }
}