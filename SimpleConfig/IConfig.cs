using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleConfig.Common;

namespace SimpleConfig
{
    public interface IConfig
    {
        SourceType TypeOfConfig { get; set ; }
        FileTypeSource FileSourceType { get; set; }

    }
}
