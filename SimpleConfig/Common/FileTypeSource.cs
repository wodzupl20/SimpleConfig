using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleConfig.Common
{
    /// <summary>
    /// Source where to store the config
    /// </summary>
    public enum FileTypeSource
    {
        /// <summary>
        /// Application data of the user
        /// </summary>
        AppData=0,
        /// <summary>
        /// Common aplication Data
        /// </summary>
        CommonApplicationData=1,
        /// <summary>
        /// Custom path if exist if not appdata
        /// </summary>
        CustomPath=2,
        NONE =3,
    }
}
