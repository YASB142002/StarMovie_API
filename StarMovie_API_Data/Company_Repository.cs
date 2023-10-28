using StarMovie_API_Data.Repository;
using StarMovie_API_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarMovie_API_Data
{
    public class Company_Repository : ICompany
    {
        public Task<bool> DeleteCompany(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCompanyByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Company>> GetAllCompanies()
        {
            throw new NotImplementedException();
        }

        public Task<Company> GetCompanyById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Company> GetCompanyByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertCompany(Company company)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCompany(Company company)
        {
            throw new NotImplementedException();
        }
    }
}
