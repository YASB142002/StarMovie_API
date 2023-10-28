using StarMovie_API_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarMovie_API_Data.Repository
{
    public interface ICompany
    {
        Task<IEnumerable<Company>> GetAllCompanies();
        Task<Company> GetCompanyById(int id);
        Task<Company> GetCompanyByName(string name);
        Task<bool> InsertCompany(Company company);
        Task<bool> UpdateCompany(Company company); 
        Task<bool> DeleteCompany(int id);
        Task<bool> DeleteCompanyByName(string name);
    }
}
