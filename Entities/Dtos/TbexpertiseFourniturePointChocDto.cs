using System;
using System.Linq;

namespace Entities.Models.Dtos
{
    public class TbexpertiseFourniturePointChocDto
    {
        public decimal Idexpert { get; set; }

        public decimal Idpointchoc { get; set; }

        public decimal Idfourn { get; set; }

        public string DepRep { get; set; }

        public string Reparer { get; set; }

        public string Remp { get; set; }

        public string Peint { get; set; }

        public decimal? Pu { get; set; }

        public decimal? Vetuste { get; set; }

        public decimal Mtht { get; set; }

        public decimal MtTtc { get; set; }

        public decimal? Rem { get; set; }

        public decimal? MtTotHt { get; set; }

        public decimal? MtTotTtc { get; set; }

        public decimal? Ligne { get; set; }

        public string Vneuve { get; set; }

        public decimal IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }

        public TbexpertiseDto IdexpertNavigation { get; set; }

        public TbfournitureDto IdfournNavigation { get; set; }

        public TbpointChocDto IdpointchocNavigation { get; set; }

        public static TbexpertiseFourniturePointChocDto FromModel(TbexpertiseFourniturePointChoc model)
        {
            return new TbexpertiseFourniturePointChocDto()
            {
                Idexpert = model.Idexpert, 
                Idpointchoc = model.Idpointchoc, 
                Idfourn = model.Idfourn, 
                DepRep = model.DepRep, 
                Reparer = model.Reparer, 
                Remp = model.Remp, 
                Peint = model.Peint, 
                Pu = model.Pu, 
                Vetuste = model.Vetuste, 
                Mtht = model.Mtht, 
                MtTtc = model.MtTtc, 
                Rem = model.Rem, 
                MtTotHt = model.MtTotHt, 
                MtTotTtc = model.MtTotTtc, 
                Ligne = model.Ligne, 
                Vneuve = model.Vneuve, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                IdexpertNavigation = TbexpertiseDto.FromModel(model.IdexpertNavigation), 
                IdfournNavigation = TbfournitureDto.FromModel(model.IdfournNavigation), 
                IdpointchocNavigation = TbpointChocDto.FromModel(model.IdpointchocNavigation), 
            }; 
        }

        public TbexpertiseFourniturePointChoc ToModel()
        {
            return new TbexpertiseFourniturePointChoc()
            {
                Idexpert = Idexpert, 
                Idpointchoc = Idpointchoc, 
                Idfourn = Idfourn, 
                DepRep = DepRep, 
                Reparer = Reparer, 
                Remp = Remp, 
                Peint = Peint, 
                Pu = Pu, 
                Vetuste = Vetuste, 
                Mtht = Mtht, 
                MtTtc = MtTtc, 
                Rem = Rem, 
                MtTotHt = MtTotHt, 
                MtTotTtc = MtTotTtc, 
                Ligne = Ligne, 
                Vneuve = Vneuve, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                IdexpertNavigation = IdexpertNavigation.ToModel(), 
                IdfournNavigation = IdfournNavigation.ToModel(), 
                IdpointchocNavigation = IdpointchocNavigation.ToModel(), 
            }; 
        }
    }
}