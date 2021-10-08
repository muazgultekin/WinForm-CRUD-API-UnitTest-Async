using Employees.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.REPOSITORY
{
    public interface IGenericRepository<T> where T : class
    {
        Task<string> GetUsers(string param);
        Task<string> PostPutUsers(MethodType methodType, T root);
        Task<string> DeleteUsers(string id);

    }
}
