using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.Interface
{
    public interface IServicePointRepository
    {
        Task<IEnumerable<ServicePoint>> GetServicePoints();

        Task<ServicePoint> GetServicePoint(string id);
    }
}
