using System;
using System.Linq;

namespace Entities.Models.Dtos
{
    public class TbexpertiseRubriqueMoDto
    {
        public decimal Idexpert { get; set; }

        public decimal IdrubriqMo { get; set; }

        public string Constat { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public TbexpertiseDto IdexpertNavigation { get; set; }

        public TbrubriqueMainOeuvreDto IdrubriqMoNavigation { get; set; }

        public static TbexpertiseRubriqueMoDto FromModel(TbexpertiseRubriqueMo model)
        {
            return new TbexpertiseRubriqueMoDto()
            {
                Idexpert = model.Idexpert, 
                IdrubriqMo = model.IdrubriqMo, 
                Constat = model.Constat, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                IdexpertNavigation = TbexpertiseDto.FromModel(model.IdexpertNavigation), 
                IdrubriqMoNavigation = TbrubriqueMainOeuvreDto.FromModel(model.IdrubriqMoNavigation), 
            }; 
        }

        public TbexpertiseRubriqueMo ToModel()
        {
            return new TbexpertiseRubriqueMo()
            {
                Idexpert = Idexpert, 
                IdrubriqMo = IdrubriqMo, 
                Constat = Constat, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                IdexpertNavigation = IdexpertNavigation.ToModel(), 
                IdrubriqMoNavigation = IdrubriqMoNavigation.ToModel(), 
            }; 
        }
    }
}