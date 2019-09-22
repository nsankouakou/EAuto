using System;
using System.Linq;

namespace Entities.Models.Dtos
{
    public class TbnoteDto
    {
        public decimal IdNot { get; set; }

        public string LibelleNot { get; set; }

        public decimal Idtypnote { get; set; }

        public decimal IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public TbtypeNoteDto IdtypnoteNavigation { get; set; }

        public static TbnoteDto FromModel(Tbnote model)
        {
            return new TbnoteDto()
            {
                IdNot = model.IdNot, 
                LibelleNot = model.LibelleNot, 
                Idtypnote = model.Idtypnote, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                IdtypnoteNavigation = TbtypeNoteDto.FromModel(model.IdtypnoteNavigation), 
            }; 
        }

        public Tbnote ToModel()
        {
            return new Tbnote()
            {
                IdNot = IdNot, 
                LibelleNot = LibelleNot, 
                Idtypnote = Idtypnote, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                IdtypnoteNavigation = IdtypnoteNavigation.ToModel(), 
            }; 
        }
    }
}