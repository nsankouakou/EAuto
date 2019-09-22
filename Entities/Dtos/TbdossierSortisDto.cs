using System;
using System.Linq;

namespace Entities.Models.Dtos
{
    public class TbdossierSortisDto
    {
        public decimal IdSorti { get; set; }

        public DateTime DatSorti { get; set; }

        public string Rubrique { get; set; }

        public string Mt { get; set; }

        public string Total { get; set; }

        public decimal IdDoss { get; set; }

        public string IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }

        public TbdossierDto IdDossNavigation { get; set; }

        public static TbdossierSortisDto FromModel(TbdossierSortis model)
        {
            return new TbdossierSortisDto()
            {
                IdSorti = model.IdSorti, 
                DatSorti = model.DatSorti, 
                Rubrique = model.Rubrique, 
                Mt = model.Mt, 
                Total = model.Total, 
                IdDoss = model.IdDoss, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                IdDossNavigation = TbdossierDto.FromModel(model.IdDossNavigation), 
            }; 
        }

        public TbdossierSortis ToModel()
        {
            return new TbdossierSortis()
            {
                IdSorti = IdSorti, 
                DatSorti = DatSorti, 
                Rubrique = Rubrique, 
                Mt = Mt, 
                Total = Total, 
                IdDoss = IdDoss, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                IdDossNavigation = IdDossNavigation.ToModel(), 
            }; 
        }
    }
}