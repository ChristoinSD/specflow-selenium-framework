using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specflow_Selenium_PO_Example2.Utils
{
    class CustomRemoteDriver : RemoteWebDriver 
    {
        CustomRemoteDriver(ICapabilities desiredCapabilities) : base(desiredCapabilities)
        {
        }

        public CustomRemoteDriver(ICommandExecutor commandExecutor, ICapabilities desiredCapabilities):base(commandExecutor, desiredCapabilities)
    {
        }

        public CustomRemoteDriver(Uri remoteAddress, ICapabilities desiredCapabilities):base(remoteAddress, desiredCapabilities)
    {
        }

        public CustomRemoteDriver(Uri remoteAddress, ICapabilities desiredCapabilities, TimeSpan commandTimeout):base(remoteAddress, desiredCapabilities, commandTimeout)
    {
        }

        public string GetSessionId()
        {
            return base.SessionId.ToString();
        }

    }


}
