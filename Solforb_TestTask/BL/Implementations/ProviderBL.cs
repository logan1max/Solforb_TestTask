using AutoMapper;
using Solforb_TestTask.BL.Interfaces;
using Solforb_TestTask.BL.Models;
using Solforb_TestTask.DAL.Interfaces;
using Solforb_TestTask.DAL.Models;
using System.Collections.Generic;

namespace Solforb_TestTask.BL.Implementations
{
    public class ProviderBL : IProviderBL
    {
        private readonly IProviderDAL providerDAL;

        public ProviderBL(IProviderDAL providerDAL)
        {
            this.providerDAL = providerDAL;
        }

        public IEnumerable<ProviderModelBL> GetProviders()
        {
            var config = new MapperConfiguration(cfg =>
                cfg.CreateMap<IEnumerable<ProviderModelDAL>, IEnumerable<ProviderModelBL>>()
            );

            var mapper = new Mapper(config);

            IEnumerable<ProviderModelDAL> providersDAL = providerDAL.FindAll();

            IEnumerable<ProviderModelBL> providersBL = mapper.Map<IEnumerable<ProviderModelBL>>(providersDAL);

            return providersBL;
        }
    }
}
