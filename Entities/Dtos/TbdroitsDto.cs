using System;
using System.Linq;

namespace Entities.Models.Dtos
{
    public class TbdroitsDto
    {
        public decimal IdDroit { get; set; }

        public string LigMenu { get; set; }

        public decimal? NumMenu { get; set; }

        public string Token { get; set; }

        public static TbdroitsDto FromModel(Tbdroits model)
        {
            return new TbdroitsDto()
            {
                IdDroit = model.IdDroit, 
                LigMenu = model.LigMenu, 
                NumMenu = model.NumMenu, 
            }; 
        }

        public Tbdroits ToModel()
        {
            return new Tbdroits()
            {
                IdDroit = IdDroit, 
                LigMenu = LigMenu, 
                NumMenu = NumMenu, 
            }; 
        }
    }
}