using System;
using System.Linq;

namespace Entities.Models.Dtos
{
    public class TbexpertiseTypeNoteDto
    {
        public decimal Idexpert { get; set; }

        public decimal Idtypnote { get; set; }

        public string Texte { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public TbexpertiseDto IdexpertNavigation { get; set; }

        public TbtypeNoteDto IdtypnoteNavigation { get; set; }

        public static TbexpertiseTypeNoteDto FromModel(TbexpertiseTypeNote model)
        {
            return new TbexpertiseTypeNoteDto()
            {
                Idexpert = model.Idexpert, 
                Idtypnote = model.Idtypnote, 
                Texte = model.Texte, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                IdexpertNavigation = TbexpertiseDto.FromModel(model.IdexpertNavigation), 
                IdtypnoteNavigation = TbtypeNoteDto.FromModel(model.IdtypnoteNavigation), 
            }; 
        }

        public TbexpertiseTypeNote ToModel()
        {
            return new TbexpertiseTypeNote()
            {
                Idexpert = Idexpert, 
                Idtypnote = Idtypnote, 
                Texte = Texte, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                IdexpertNavigation = IdexpertNavigation.ToModel(), 
                IdtypnoteNavigation = IdtypnoteNavigation.ToModel(), 
            }; 
        }
    }
}