using IOCAutofac.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IOCAutofac.Services
{
    public class TestService
    {
        private List<Watch> watches;

        public TestService()
        {
            GenerateSomeData();
        }

        public async Task<List<Watch>> GetWatches() => watches;
        //public async Task<List<Watch>> GetWatches()
        //{
        //    return watches;
        //}

        private void GenerateSomeData()
        {
            watches = new List<Watch>();
            for (int i = 0; i < 20; i++)
            {
                var watch = new Watch
                {
                    Id = System.Guid.NewGuid(),
                    Brand = FakeData.NameData.GetCompanyName()
                };

                watches.Add(watch);
            }
        }
    }
}
