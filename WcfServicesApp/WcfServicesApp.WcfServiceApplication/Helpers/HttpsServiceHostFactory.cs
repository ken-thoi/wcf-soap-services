using System;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Description;

namespace WcfServicesApp.WcfServiceApplication.Helpers
{
    public class HttpsServiceHostFactory : ServiceHostFactory
    {
        protected override ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses)
        {
            ServiceHost host = new ServiceHost(serviceType, baseAddresses);

            foreach (Uri baseAddress in baseAddresses)
            {
                BasicHttpBinding binding = CreateSoapBinding(baseAddress);
                ServiceEndpoint endpoint = host.AddServiceEndpoint(serviceType.GetInterfaces()[0], binding, baseAddress);
            }

            if (HasHttpEndpoint(baseAddresses))
            {
                if (host.Description.Behaviors.Contains(typeof(ServiceMetadataBehavior)))
                {
                    var smb = (ServiceMetadataBehavior)host.Description.Behaviors[typeof(ServiceMetadataBehavior)];
                    smb.HttpGetEnabled = true;
                }
                else
                {
                    var smb = new ServiceMetadataBehavior();
                    smb.HttpGetEnabled = true;

                    host.Description.Behaviors.Add(smb);
                }
            }

            if (HasHttpsEndpoint(baseAddresses))
            {
                if (host.Description.Behaviors.Contains(typeof(ServiceMetadataBehavior)))
                {
                    var smb = (ServiceMetadataBehavior)host.Description.Behaviors[typeof(ServiceMetadataBehavior)];
                    smb.HttpsGetEnabled = true;
                }
                else
                {
                    var smb = new ServiceMetadataBehavior();
                    smb.HttpsGetEnabled = true;

                    host.Description.Behaviors.Add(smb);
                }
            }

            return host;
        }

        private bool HasHttpsEndpoint(Uri[] baseAddresses)
        {
            return baseAddresses.Any(b => b.Scheme == Uri.UriSchemeHttps);
        }

        private bool HasHttpEndpoint(Uri[] baseAddresses)
        {
            return baseAddresses.Any(b => b.Scheme == Uri.UriSchemeHttp);
        }

        private BasicHttpBinding CreateSoapBinding(Uri baseAddress)
        {
            BasicHttpBinding binding;
            if (baseAddress.Scheme == Uri.UriSchemeHttps)
            {
                binding = new BasicHttpBinding(BasicHttpSecurityMode.Transport);
            }
            else
            {
                binding = new BasicHttpBinding();
            }

            return binding;
        }

    }
}