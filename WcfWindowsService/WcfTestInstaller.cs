using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;
using System.ServiceProcess;

namespace WcfWindowsService
{
    [RunInstaller(true)]
    public partial class WcfTestInstaller : System.Configuration.Install.Installer
    {
        public WcfTestInstaller()
        {
            //InitializeComponent();
            ServiceProcessInstaller process = new ServiceProcessInstaller();
            process.Account = ServiceAccount.NetworkService;
            ServiceInstaller service = new ServiceInstaller();
            service.ServiceName = "WcfTestWindowsService";
            service.DisplayName = "WcfTestWindowsService";
            service.Description = "WcfTestWindowsService.";
            service.StartType = ServiceStartMode.Automatic;

            Installers.Add(process);
            Installers.Add(service);
        }
    }
}
