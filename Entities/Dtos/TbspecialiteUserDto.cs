using System;

namespace Entities.Models.Dtos
{
    public class TbspecialiteUserDto
    {
        public decimal IdUser { get; set; }

        public decimal IdSpec { get; set; }

        public string Token { get; set; }


        public TbspecialiteDto IdSpecNavigation { get; set; }

        public TbuserDto IdUserNavigation { get; set; }

        public static TbspecialiteUserDto FromModel(TbspecialiteUser model)
        {
            return new TbspecialiteUserDto()
            {
                IdUser = model.IdUser, 
                IdSpec = model.IdSpec, 
                IdSpecNavigation = TbspecialiteDto.FromModel(model.IdSpecNavigation), 
                IdUserNavigation = TbuserDto.FromModel(model.IdUserNavigation), 
            }; 
        }

        public TbspecialiteUser ToModel()
        {
            return new TbspecialiteUser()
            {
                IdUser = IdUser, 
                IdSpec = IdSpec, 
                IdSpecNavigation = IdSpecNavigation.ToModel(), 
                IdUserNavigation = IdUserNavigation.ToModel(), 
            }; 
        }
    }
}