using System;
using System.Linq;
using System.Collections.Generic;

namespace Entities.Models.Dtos
{
    public class TbtypeNoteDto
    {
        public decimal Idtypnote { get; set; }

        public string Libtypnote { get; set; }

        public decimal IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public ICollection<Tbexpertise> Tbexpertise { get; set; }

        public ICollection<TbexpertiseTypeNote> TbexpertiseTypeNote { get; set; }

        public ICollection<Tbnote> Tbnote { get; set; }

        public static TbtypeNoteDto FromModel(TbtypeNote model)
        {
            return new TbtypeNoteDto()
            {
                Idtypnote = model.Idtypnote, 
                Libtypnote = model.Libtypnote, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                Tbexpertise = model.Tbexpertise, 
                TbexpertiseTypeNote = model.TbexpertiseTypeNote, 
                Tbnote = model.Tbnote, 
            }; 
        }

        public TbtypeNote ToModel()
        {
            return new TbtypeNote()
            {
                Idtypnote = Idtypnote, 
                Libtypnote = Libtypnote, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                Tbexpertise = Tbexpertise, 
                TbexpertiseTypeNote = TbexpertiseTypeNote, 
                Tbnote = Tbnote, 
            }; 
        }
    }
}