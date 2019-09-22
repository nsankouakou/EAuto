using System;
using System.Collections.Generic;

namespace Entities.Models.Dtos
{
    public class TbmainOeuvreDto
    {
        public decimal IdMo { get; set; }

        public decimal? ToRem { get; set; }

        public decimal Idexpert { get; set; }

        public decimal IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public ICollection<TbmainOeuvrePointChoc> TbmainOeuvrePointChoc { get; set; }

        public ICollection<TbnbreElementMainOeuvreTypePeinture> TbnbreElementMainOeuvreTypePeinture { get; set; }

        public ICollection<TbtypTravauxMainOuvre> TbtypTravauxMainOuvre { get; set; }

        public static TbmainOeuvreDto FromModel(TbmainOeuvre model)
        {
            return new TbmainOeuvreDto()
            {
                IdMo = model.IdMo, 
                ToRem = model.ToRem, 
                Idexpert = model.Idexpert, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                TbmainOeuvrePointChoc = model.TbmainOeuvrePointChoc, 
                TbnbreElementMainOeuvreTypePeinture = model.TbnbreElementMainOeuvreTypePeinture, 
                TbtypTravauxMainOuvre = model.TbtypTravauxMainOuvre, 
            }; 
        }

        public TbmainOeuvre ToModel()
        {
            return new TbmainOeuvre()
            {
                IdMo = IdMo, 
                ToRem = ToRem, 
                Idexpert = Idexpert, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                TbmainOeuvrePointChoc = TbmainOeuvrePointChoc, 
                TbnbreElementMainOeuvreTypePeinture = TbnbreElementMainOeuvreTypePeinture, 
                TbtypTravauxMainOuvre = TbtypTravauxMainOuvre, 
            }; 
        }
    }
}