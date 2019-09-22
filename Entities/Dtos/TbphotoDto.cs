using System;
using System.Linq;

namespace Entities.Models.Dtos
{
    public class TbphotoDto
    {
        public Guid Idphoto { get; set; }

        public string DocNumber { get; set; }

        public string DocName { get; set; }

        public string DocDescription { get; set; }

        public string DocExtension { get; set; }

        public byte[] Doc { get; set; }

        public decimal Idexpert { get; set; }

        public decimal IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public string Token { get; set; }


        public TbexpertiseDto IdexpertNavigation { get; set; }

        public static TbphotoDto FromModel(Tbphoto model)
        {
            return new TbphotoDto()
            {
                Idphoto = model.Idphoto, 
                DocNumber = model.DocNumber, 
                DocName = model.DocName, 
                DocDescription = model.DocDescription, 
                DocExtension = model.DocExtension, 
                Doc = model.Doc.ToArray(), 
                Idexpert = model.Idexpert, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                IdexpertNavigation = TbexpertiseDto.FromModel(model.IdexpertNavigation), 
            }; 
        }

        public Tbphoto ToModel()
        {
            return new Tbphoto()
            {
                Idphoto = Idphoto, 
                DocNumber = DocNumber, 
                DocName = DocName, 
                DocDescription = DocDescription, 
                DocExtension = DocExtension, 
                Doc = Doc.ToArray(), 
                Idexpert = Idexpert, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                IdexpertNavigation = IdexpertNavigation.ToModel(), 
            }; 
        }
    }
}