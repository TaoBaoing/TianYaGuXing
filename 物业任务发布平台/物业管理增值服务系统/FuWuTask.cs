using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HH.Dapper;

namespace 物业任务发布平台
{
   public   class FuWuTask:DbBase
    {
       public string TName { get; set; }

       public string TContent { get; set; }

       public string Price { get; set; }

    }
}
