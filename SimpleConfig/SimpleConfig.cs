using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleConfig
{
    /// <summary>
    /// Main initjalize class
    /// </summary>
    public class SimpleConfig
    {
        /// <summary>
        /// Singelton object to return only internal acces
        /// </summary>
        internal static IConfig conf = new MainInit();
        /// <summary>
        /// Main config initjalization no settings present
        /// </summary>
        /// <returns>Interface for configuration</returns>
        public static IConfig Init()
        {
            return conf;
        }
        /// <summary>
        /// Constructor not welcome
        /// </summary>
        private SimpleConfig()
        {
            
        }
        
    }
}
