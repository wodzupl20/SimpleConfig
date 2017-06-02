using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleConfig.Common;

namespace SimpleConfig
{
    internal class MainInit : IConfig
    {
        internal static SourceType _TypeOfConfig = SourceType.File;
        internal static FileTypeSource _FileTypeSourceIfFileType = FileTypeSource.AppData;
        internal static object _TypeOfConfigLock = new object();
        public SourceType TypeOfConfig
        {
            get { return _TypeOfConfig; }

            set
            {
                lock (_TypeOfConfigLock)
                {
                    if (value == SourceType.File)
                    {
                        if (_FileTypeSourceIfFileType != FileTypeSource.AppData || _FileTypeSourceIfFileType != FileTypeSource.CustomPath)
                        {
                            _FileTypeSourceIfFileType = FileTypeSource.AppData;
                        }
                    }
                    else
                    {
                        if (_FileTypeSourceIfFileType == FileTypeSource.AppData || _FileTypeSourceIfFileType == FileTypeSource.CustomPath)
                        {
                            _FileTypeSourceIfFileType = FileTypeSource.NONE;
                        }
                    }
                    _TypeOfConfig = value;
                }
            }
        }

        public FileTypeSource FileSourceType
        {
            get { return _FileTypeSourceIfFileType; }
            set
            {
                lock (_TypeOfConfigLock)
                {
                    _FileTypeSourceIfFileType = TypeOfConfig == SourceType.File ? value : FileTypeSource.NONE;

                }
            }
        }
    }
}
