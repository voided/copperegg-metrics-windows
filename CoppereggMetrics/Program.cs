﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CoppereggMetrics
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main( string[] args )
        {
            var service = new Service();

#if SERVICE_BUILD
            ServiceBase.Run( service );
#else
            service.Start( args );
#endif
        }
    }
}
