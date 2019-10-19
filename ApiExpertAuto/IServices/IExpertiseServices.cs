using ApiExpertAuto.Models;
using Entities.Models.Dtos;
using System.Threading.Tasks;

namespace ApiExpertAuto.IServices
{
    public interface IExpertiseServices
    {
        #region Expertise standard

        Task<ObjetRetour> GetExpertiseParDossier(int IdDossier, string token = "");

        ObjetRetour GetAllTbassurance(string token = "");

        Task<ObjetRetour> GetTbassurance(decimal id, string token = "");

        Task<ObjetRetour> InsertExpertiseStandard(ExpertiseStandardModel value);

        ObjetRetour MajExpertiseStandard(ExpertiseStandardModel value);


        ObjetRetour DeleteTbexpertise(TbexpertiseDto value);

        ObjetRetour ValiderDeleteTbexpertise(TbexpertiseDto value);

        #endregion

        #region Expertise EI

        Task<ObjetRetour> GetExpertiseEIParDossier(int IdDossier, string token = "");


        Task<ObjetRetour> InsertExpertiseStandard(ExpertiseEIModel value);

        ObjetRetour MajExpertiseEI(ExpertiseEIModel value);


        #endregion
    }
}