﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JukkaServer
{
    class LoginExtensionManager : IExtensionLoginManager
    {
        public bool IsLoginValid(NameValueCollection loginCollection)
        {
            return true;
        }
    }
}
