using Data.Models;
using Data.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class MockDisplayScreenRepository : IDisplayScreenRepository
    {
        public async Task<DisplayScreen> GetDisplayScreen(string id)
        {
            var displays = await GetDisplayScreens();
            return displays.Where(x => x.Id == id).FirstOrDefault();
        }

        public async Task<IEnumerable<DisplayScreen>> GetDisplayScreens()
        {
            List<DisplayScreen> displays = new List<DisplayScreen>();
            displays.Add(new DisplayScreen { Id = "1", Name = "Reception Area TV" });
            displays.Add(new DisplayScreen { Id = "2", Name = "Nurse Office TV" });
            displays.Add(new DisplayScreen { Id = "3", Name = "First Floor Lobby TV" });
            return await Task.FromResult(displays);
        }
    }
}
