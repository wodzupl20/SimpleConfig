using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleConfig.Common
{
    /// <summary>
    /// Write sources
    /// </summary>
    public enum SourceType
    {
        /// <summary>
        /// Write to file
        /// </summary>
        File=0,
        /// <summary>
        /// Write to sql lite
        /// </summary>
        SqlLite=1,
        /// <summary>
        /// Write to Microsoft Sql
        /// </summary>
        MsSql = 2,
        /// <summary>
        /// Write to maria db or Mysql
        /// </summary>
        MySql_Maria=3,

    }

   
}
