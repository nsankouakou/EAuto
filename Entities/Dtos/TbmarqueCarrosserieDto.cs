using System;

namespace Entities.Models.Dtos
{
    public class TbmarqueCarrosserieDto
    {
        public decimal IdMarque { get; set; }

        public decimal Idcarross { get; set; }

        public string Token { get; set; }


        public TbmarqueDto IdMarqueNavigation { get; set; }

        public TbcarosserieDto IdcarrossNavigation { get; set; }

        public static TbmarqueCarrosserieDto FromModel(TbmarqueCarrosserie model)
        {
            return new TbmarqueCarrosserieDto()
            {
                IdMarque = model.IdMarque, 
                Idcarross = model.Idcarross, 
                IdMarqueNavigation = TbmarqueDto.FromModel(model.IdMarqueNavigation), 
                IdcarrossNavigation = TbcarosserieDto.FromModel(model.IdcarrossNavigation), 
            }; 
        }

        public TbmarqueCarrosserie ToModel()
        {
            return new TbmarqueCarrosserie()
            {
                IdMarque = IdMarque, 
                Idcarross = Idcarross, 
                IdMarqueNavigation = IdMarqueNavigation.ToModel(), 
                IdcarrossNavigation = IdcarrossNavigation.ToModel(), 
            }; 
        }
    }
}