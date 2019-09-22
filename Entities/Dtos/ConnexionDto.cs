using System;
using System.Linq;

namespace Entities.Models.Dtos
{
    public class ConnexionDto
    {
        public int ConnexionId { get; set; }

        public int UserId { get; set; }

        public string AdresseIpSource { get; set; }

        public DateTime DateConnexion { get; set; }

        public DateTime? DateLastConnexion { get; set; }

        public string Token { get; set; }

        public bool Bsucces { get; set; }

        public static ConnexionDto FromModel(Connexion model)
        {
            return new ConnexionDto()
            {
                ConnexionId = model.ConnexionId, 
                UserId = model.UserId, 
                AdresseIpSource = model.AdresseIpSource, 
                DateConnexion = model.DateConnexion, 
                DateLastConnexion = model.DateLastConnexion, 
                Token = model.Token, 
                Bsucces = model.Bsucces, 
            }; 
        }

        public Connexion ToModel()
        {
            return new Connexion()
            {
                ConnexionId = ConnexionId, 
                UserId = UserId, 
                AdresseIpSource = AdresseIpSource, 
                DateConnexion = DateConnexion, 
                DateLastConnexion = DateLastConnexion, 
                Token = Token, 
                Bsucces = Bsucces, 
            }; 
        }
    }
}