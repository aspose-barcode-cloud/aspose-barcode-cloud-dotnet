using System.Collections.Generic;
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Internal;
using Aspose.BarCode.Cloud.Sdk.Internal.RequestHandlers;

namespace Aspose.BarCode.Cloud.Sdk.Tests
{
    internal static class ApiInvokerFactory
    {
        internal static ApiInvoker CreateInvoker(Configuration configuration)
        {
            List<IRequestHandler> requestHandlers = new List<IRequestHandler>();
            switch (configuration.AuthType)
            {
                case AuthType.JWT:
                    requestHandlers.Add(new JwtRequestHandler(configuration));
                    break;
                case AuthType.ExternalAuth:
                    requestHandlers.Add(new ExternalAuthorizationRequestHandler(configuration));
                    break;
                default:
                    throw new System.ArgumentOutOfRangeException(
                        $"Unknown AuthType={configuration.AuthType}.");
            }

            requestHandlers.Add(new DebugLogRequestHandler(configuration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            return new ApiInvoker(configuration, requestHandlers);
        }
    }
}
