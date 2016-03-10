using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HH.Dapper;

namespace 物业任务发布平台
{
    public class MUser : DbBase
    {
        public string UserName { get; set; }

        public string   UserPwd  { get; set; }

        public string UserType { get; set; }

        public string Phone { get; set; }

    }


    //    USE[TaskPlatform]
    //GO
    //
    ///****** Object:  Table [dbo].[MUser]    Script Date: 2016/3/8 20:53:53 ******/
    //SET ANSI_NULLS ON
    //GO
    //
    //SET QUOTED_IDENTIFIER ON
    //GO
    //
    //CREATE TABLE[dbo].[MUser](
    //	[Id]
    //    [bigint] IDENTITY(1,1) NOT NULL,
    //    [UserName] [nvarchar](50) NOT NULL,
    //    [UserPwd] [nvarchar](50) NOT NULL,
    //    [Phone] [nvarchar](50) NOT NULL,
    //    [UserType] [nvarchar](50) NOT NULL,
    //CONSTRAINT[PK_User] PRIMARY KEY CLUSTERED
    //(
    //[Id] ASC
    //)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
    //) ON[PRIMARY]
    //
    //GO


    public class UserType
    {
        public static string 管理员 = "管理员";
        public static string 物业管理 = "物业管理";
        public static string 物业员工 = "物业员工";
        public static string 业主 = "业主";
    }

}
