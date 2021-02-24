using System;
using ServiceStack;
using AureliaSpaTemplate.ServiceModel;

namespace AureliaSpaTemplate.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = $"Hello, {request.Name}!" };
        }
    }
}
