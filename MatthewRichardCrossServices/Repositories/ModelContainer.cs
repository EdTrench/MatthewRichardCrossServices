using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.Unity;
using MatthewRichardCrossServices.Repositories.Interfaces;


namespace MatthewRichardCrossServices.Repositories
{
    public static class ModelContainer
    {
        private static readonly object key = new object();
        private static IUnityContainer instance;

        static ModelContainer()
        {
            instance = new UnityContainer();
        }

        public static IUnityContainer Instance
        {
            get
            {
                instance = new UnityContainer();
                instance.RegisterType<IPortfolioFullItemRepository, PortfolioFullItemRepository>();
                instance.RegisterType<IPortfolioSummaryItemRepository, PortfolioSummaryItemRepository>();
                return instance;
            }
        }
    }
}