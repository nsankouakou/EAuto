using System;

namespace Entities.Models.Dtos
{
    public class TbdossierRubriqueHonoraireDto
    {
        public decimal Idrubhonr { get; set; }

        public decimal IdDoss { get; set; }

        public decimal MtRubHono { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }

        public TbdossierDto IdDossNavigation { get; set; }

        public TbrubriqueHonoraireDto IdrubhonrNavigation { get; set; }

        public static TbdossierRubriqueHonoraireDto FromModel(TbdossierRubriqueHonoraire model)
        {
            return new TbdossierRubriqueHonoraireDto()
            {
                Idrubhonr = model.Idrubhonr, 
                IdDoss = model.IdDoss, 
                MtRubHono = model.MtRubHono, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                IdDossNavigation = TbdossierDto.FromModel(model.IdDossNavigation), 
                IdrubhonrNavigation = TbrubriqueHonoraireDto.FromModel(model.IdrubhonrNavigation), 
            }; 
        }

        public TbdossierRubriqueHonoraire ToModel()
        {
            return new TbdossierRubriqueHonoraire()
            {
                Idrubhonr = Idrubhonr, 
                IdDoss = IdDoss, 
                MtRubHono = MtRubHono, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                IdDossNavigation = IdDossNavigation.ToModel(), 
                IdrubhonrNavigation = IdrubhonrNavigation.ToModel(), 
            }; 
        }
    }
}