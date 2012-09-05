using System;
using System.Collections.Generic;

namespace $safeprojectname$
{
    class AppServiceProvider : IServiceProvider
    {
        private readonly Dictionary<Type, object> services = new Dictionary<Type, object>();

        public void AddService(Type serviceType, object service)
        {
            this.services[serviceType] = service;
        }

        public object GetService(Type serviceType)
        {
            return this.services[serviceType];
        }
    }
}
