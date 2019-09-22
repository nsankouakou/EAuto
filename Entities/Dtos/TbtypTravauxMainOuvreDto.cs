using System;
using System.Linq;

namespace Entities.Models.Dtos
{
    public class TbtypTravauxMainOuvreDto
    {
        public decimal Idtyptrav { get; set; }

        public decimal IdMo { get; set; }

        public string ElemntTravo { get; set; }

        public decimal? Nbheure { get; set; }

        public decimal? MtTravo { get; set; }

        public decimal IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public TbmainOeuvreDto IdMoNavigation { get; set; }

        public TbtypeTravauxDto IdtyptravNavigation { get; set; }

        public static TbtypTravauxMainOuvreDto FromModel(TbtypTravauxMainOuvre model)
        {
            return new TbtypTravauxMainOuvreDto()
            {
                Idtyptrav = model.Idtyptrav, 
                IdMo = model.IdMo, 
                ElemntTravo = model.ElemntTravo, 
                Nbheure = model.Nbheure, 
                MtTravo = model.MtTravo, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                IdMoNavigation = TbmainOeuvreDto.FromModel(model.IdMoNavigation), 
                IdtyptravNavigation = TbtypeTravauxDto.FromModel(model.IdtyptravNavigation), 
            }; 
        }

        public TbtypTravauxMainOuvre ToModel()
        {
            return new TbtypTravauxMainOuvre()
            {
                Idtyptrav = Idtyptrav, 
                IdMo = IdMo, 
                ElemntTravo = ElemntTravo, 
                Nbheure = Nbheure, 
                MtTravo = MtTravo, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                IdMoNavigation = IdMoNavigation.ToModel(), 
                IdtyptravNavigation = IdtyptravNavigation.ToModel(), 
            }; 
        }
    }
}