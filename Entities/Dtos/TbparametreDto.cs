using System;
using System.Linq;

namespace Entities.Models.Dtos
{
    public class TbparametreDto
    {
        public decimal IdParam { get; set; }

        public string Param { get; set; }

        public string Token { get; set; }


        public static TbparametreDto FromModel(Tbparametre model)
        {
            return new TbparametreDto()
            {
                IdParam = model.IdParam, 
                Param = model.Param, 
            }; 
        }

        public Tbparametre ToModel()
        {
            return new Tbparametre()
            {
                IdParam = IdParam, 
                Param = Param, 
            }; 
        }
    }
}