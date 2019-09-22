using System;
using System.Linq;

namespace Entities.Models.Dtos
{
    public class TbavanceDto
    {
        public decimal IdAvance { get; set; }

        public string NumAvance { get; set; }

        public DateTime DatAvance { get; set; }

        public decimal Mtavance { get; set; }

        public string NumCheqAvan { get; set; }

        public decimal IdDoss { get; set; }

        public decimal IdModeReglmnt { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }

        public TbdossierDto IdDossNavigation { get; set; }

        public TbmodeReglementDto IdModeReglmntNavigation { get; set; }

        public static TbavanceDto FromModel(Tbavance model)
        {
            return new TbavanceDto()
            {
                IdAvance = model.IdAvance, 
                NumAvance = model.NumAvance, 
                DatAvance = model.DatAvance, 
                Mtavance = model.Mtavance, 
                NumCheqAvan = model.NumCheqAvan, 
                IdDoss = model.IdDoss, 
                IdModeReglmnt = model.IdModeReglmnt, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                IdDossNavigation = TbdossierDto.FromModel(model.IdDossNavigation), 
                IdModeReglmntNavigation = TbmodeReglementDto.FromModel(model.IdModeReglmntNavigation), 
            }; 
        }

        public Tbavance ToModel()
        {
            return new Tbavance()
            {
                IdAvance = IdAvance, 
                NumAvance = NumAvance, 
                DatAvance = DatAvance, 
                Mtavance = Mtavance, 
                NumCheqAvan = NumCheqAvan, 
                IdDoss = IdDoss, 
                IdModeReglmnt = IdModeReglmnt, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                IdDossNavigation = IdDossNavigation.ToModel(), 
                IdModeReglmntNavigation = IdModeReglmntNavigation.ToModel(), 
            }; 
        }
    }
}