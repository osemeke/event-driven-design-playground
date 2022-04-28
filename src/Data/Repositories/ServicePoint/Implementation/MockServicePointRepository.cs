using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.Interface
{
    public class MockServicePointRepository : IServicePointRepository
    {
        public async Task<ServicePoint> GetServicePoint(string id)
        {
            var servicePoints = await GetServicePoints();
            return servicePoints.Where(x => x.Id == id).FirstOrDefault();
        }

        public async Task<IEnumerable<ServicePoint>> GetServicePoints()
        {
            var servicePoints = new List<ServicePoint>();
            servicePoints.Add(new ServicePoint { Id = "1", Name = "Doctor Room 1" });
            servicePoints.Add(new ServicePoint { Id = "2", Name = "Doctor Room 2" });
            servicePoints.Add(new ServicePoint { Id = "3", Name = "Vital Signs" });
            return await Task.FromResult(servicePoints);
        }
    }
}
