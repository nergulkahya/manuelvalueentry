using Manuelvalueentry.Api.Database.Contract.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manuelvalueentry.Api.Database.Contract.Services
{
    internal interface IFactoryOperationService
    {
        Task<List<FactoryModel>> GetAllFactories();
        Task<FactoryModel> AddFactory(FactoryModel factory);
    }
}
