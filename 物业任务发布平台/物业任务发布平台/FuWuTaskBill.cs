using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HH.Dapper;

namespace 物业任务发布平台
{

    public class FuWuTaskBill : DbBase
    {
        public long FuWuTaskId { get; set; }

        //业主
        public long YeZhuId { get; set; }

        //选择任务时间
        public DateTime YeZhuDateTime { get; set; }

        //业务员
        public long? YeWuYuanId { get; set; }

        //业务员接受 任务时间
        public DateTime? YeWuYuanJieShouDateTime { get; set; }
        
        //业务员完成 任务时间
        public DateTime? YeWuYuanWanChengDateTime { get; set; }

        //当前单据状态
        public string BillState { get; set; }


    }

    public class BillState
    {
        public static string 未开始 = "未开始";
        public static string 进行中 = "进行中";
        public static string 完成 = "完成";
    }

}
