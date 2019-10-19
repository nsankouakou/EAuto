using System;
using System.Linq;
using System.Collections.Generic;

namespace Entities.Models.Dtos
{
    public class TbvehiculeDto
    {
        public decimal IdVeh { get; set; }

        public string Immatriculation { get; set; }

        public string Serievehic { get; set; }

        public DateTime? Datmisecircul { get; set; }

        public string Puissancefiscal { get; set; }

        public string Nbplace { get; set; }

        public string VisiteTech { get; set; }

        public decimal? Idtypveh { get; set; }

        public decimal? IdGenre { get; set; }

        public decimal? IdCouleur { get; set; }

        public decimal? IdEnergie { get; set; }

        public decimal IdProprio { get; set; }

        public decimal? Idcarross { get; set; }

        public decimal IdDoss { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public TbcouleurDto IdCouleurNavigation { get; set; }

        public TbdossierDto IdDossNavigation { get; set; }

        public TbenergieDto IdEnergieNavigation { get; set; }

        public TbgenreDto IdGenreNavigation { get; set; }

        public TbproprietaireDto IdProprioNavigation { get; set; }

        public TbcarosserieDto IdcarrossNavigation { get; set; }

        public TbtypeVehiculeDto IdtypvehNavigation { get; set; }

        public ICollection<Tbexpertise> Tbexpertise { get; set; }

        public ICollection<TbvehiculeAssurance> TbvehiculeAssurance { get; set; }

        public static TbvehiculeDto FromModel(Tbvehicule model)
        {
            return new TbvehiculeDto()
            {
                IdVeh = model.IdVeh, 
                Immatriculation = model.Immatriculation, 
                Serievehic = model.Serievehic, 
                Datmisecircul = model.Datmisecircul, 
                Puissancefiscal = model.Puissancefiscal, 
                Nbplace = model.Nbplace, 
                VisiteTech = model.VisiteTech, 
                Idtypveh = model.Idtypveh, 
                IdGenre = model.IdGenre, 
                IdCouleur = model.IdCouleur, 
                IdEnergie = model.IdEnergie, 
                IdProprio = model.IdProprio, 
                Idcarross = model.Idcarross, 
                IdDoss = model.IdDoss, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                //StatusCode = model.StatusCode, 
                //IdCouleurNavigation = TbcouleurDto.FromModel(model.IdCouleurNavigation), 
                //IdDossNavigation = TbdossierDto.FromModel(model.IdDossNavigation), 
                //IdEnergieNavigation = TbenergieDto.FromModel(model.IdEnergieNavigation), 
                //IdGenreNavigation = TbgenreDto.FromModel(model.IdGenreNavigation), 
                //IdProprioNavigation = TbproprietaireDto.FromModel(model.IdProprioNavigation), 
                //IdcarrossNavigation = TbcarosserieDto.FromModel(model.IdcarrossNavigation), 
                //IdtypvehNavigation = TbtypeVehiculeDto.FromModel(model.IdtypvehNavigation), 
                Tbexpertise = model.Tbexpertise, 
                TbvehiculeAssurance = model.TbvehiculeAssurance, 
            }; 
        }

        public Tbvehicule ToModel()
        {
            return new Tbvehicule()
            {
                IdVeh = IdVeh, 
                Immatriculation = Immatriculation, 
                Serievehic = Serievehic, 
                Datmisecircul = Datmisecircul, 
                Puissancefiscal = Puissancefiscal, 
                Nbplace = Nbplace, 
                VisiteTech = VisiteTech, 
                Idtypveh = Idtypveh, 
                IdGenre = IdGenre, 
                IdCouleur = IdCouleur, 
                IdEnergie = IdEnergie, 
                IdProprio = IdProprio, 
                Idcarross = Idcarross, 
                IdDoss = IdDoss, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                //StatusCode = StatusCode, 
                //IdCouleurNavigation = IdCouleurNavigation.ToModel(), 
                //IdDossNavigation = IdDossNavigation.ToModel(), 
                //IdEnergieNavigation = IdEnergieNavigation.ToModel(), 
                //IdGenreNavigation = IdGenreNavigation.ToModel(), 
                //IdProprioNavigation = IdProprioNavigation.ToModel(), 
                //IdcarrossNavigation = IdcarrossNavigation.ToModel(), 
                //IdtypvehNavigation = IdtypvehNavigation.ToModel(), 
                //Tbexpertise = Tbexpertise, 
                //TbvehiculeAssurance = TbvehiculeAssurance, 
            }; 
        }
    }
}