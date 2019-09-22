using System;
using System.Linq;
using System.Collections.Generic;

namespace Entities.Models.Dtos
{
    public class TbassuranceDto
    {
        public decimal IdAssur { get; set; }

        public string NomAssur { get; set; }

        public string TelAssur { get; set; }

        public string AdrAssur { get; set; }

        public string BpAssur { get; set; }

        public string MailAssur { get; set; }

        public string FaxAssur { get; set; }

        public string Contact { get; set; }

        public string SiglAssur { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }

        public ICollection<TbvehiculeAssurance> TbvehiculeAssurance { get; set; }

        public static TbassuranceDto FromModel(Tbassurance model)
        {
            return new TbassuranceDto()
            {
                IdAssur = model.IdAssur, 
                NomAssur = model.NomAssur, 
                TelAssur = model.TelAssur, 
                AdrAssur = model.AdrAssur, 
                BpAssur = model.BpAssur, 
                MailAssur = model.MailAssur, 
                FaxAssur = model.FaxAssur, 
                Contact = model.Contact, 
                SiglAssur = model.SiglAssur, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                TbvehiculeAssurance = model.TbvehiculeAssurance, 
            }; 
        }

        public Tbassurance ToModel()
        {
            return new Tbassurance()
            {
                IdAssur = IdAssur, 
                NomAssur = NomAssur, 
                TelAssur = TelAssur, 
                AdrAssur = AdrAssur, 
                BpAssur = BpAssur, 
                MailAssur = MailAssur, 
                FaxAssur = FaxAssur, 
                Contact = Contact, 
                SiglAssur = SiglAssur, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                TbvehiculeAssurance = TbvehiculeAssurance, 
            }; 
        }
    }
}