using System;
using System.Linq;

namespace Entities.Models.Dtos
{
    public class TbautreRubriqueDto
    {
        public decimal IdAutreRub { get; set; }

        public string LibAutreRub { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }

        public static TbautreRubriqueDto FromModel(TbautreRubrique model)
        {
            return new TbautreRubriqueDto()
            {
                IdAutreRub = model.IdAutreRub, 
                LibAutreRub = model.LibAutreRub, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
            }; 
        }

        public TbautreRubrique ToModel()
        {
            return new TbautreRubrique()
            {
                IdAutreRub = IdAutreRub, 
                LibAutreRub = LibAutreRub, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
            }; 
        }
    }
}