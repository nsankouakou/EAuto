using System;
using System.Linq;

namespace Entities.Models.Dtos
{
    public class TbreglementDto
    {
        public decimal Idreglmt { get; set; }

        public string Numreglmt { get; set; }

        public DateTime Datreglmt { get; set; }

        public string NomMandant { get; set; }

        public decimal Mtrglmt { get; set; }

        public decimal Idfact { get; set; }

        public decimal Idmodrglmt { get; set; }

        public string NumeroRecu { get; set; }

        public string NumeroCheque { get; set; }

        public string NumeroCompte { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public TbfactureDto IdfactNavigation { get; set; }

        public TbmodeReglementDto IdmodrglmtNavigation { get; set; }

        public static TbreglementDto FromModel(Tbreglement model)
        {
            return new TbreglementDto()
            {
                Idreglmt = model.Idreglmt, 
                Numreglmt = model.Numreglmt, 
                Datreglmt = model.Datreglmt, 
                NomMandant = model.NomMandant, 
                Mtrglmt = model.Mtrglmt, 
                Idfact = model.Idfact, 
                Idmodrglmt = model.Idmodrglmt, 
                NumeroRecu = model.NumeroRecu, 
                NumeroCheque = model.NumeroCheque, 
                NumeroCompte = model.NumeroCompte, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                IdfactNavigation = TbfactureDto.FromModel(model.IdfactNavigation), 
                IdmodrglmtNavigation = TbmodeReglementDto.FromModel(model.IdmodrglmtNavigation), 
            }; 
        }

        public Tbreglement ToModel()
        {
            return new Tbreglement()
            {
                Idreglmt = Idreglmt, 
                Numreglmt = Numreglmt, 
                Datreglmt = Datreglmt, 
                NomMandant = NomMandant, 
                Mtrglmt = Mtrglmt, 
                Idfact = Idfact, 
                Idmodrglmt = Idmodrglmt, 
                NumeroRecu = NumeroRecu, 
                NumeroCheque = NumeroCheque, 
                NumeroCompte = NumeroCompte, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                IdfactNavigation = IdfactNavigation.ToModel(), 
                IdmodrglmtNavigation = IdmodrglmtNavigation.ToModel(), 
            }; 
        }
    }
}