using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 调漆工艺管理系统
{
    class DbConfigReader
    {

        private string dbName; // 数据库名
        private string dbHost; // 主机名/IP地址
        private string dbUser; // 数据库用户
        private string dbPassword; // 数据库密码
        private int port; // 数据库服务端口

        public DbConfigReader() : this(clsApp.filepath)
        {
        }

        public DbConfigReader(String path)
        {

            clsIniFile clsif = new clsIniFile(path);

            //Database
            dbName = clsif.ReadString("Database", "DatabaseName");
            dbHost = clsif.ReadString("Database", "ServerName");
            dbUser = clsif.ReadString("Database", "UserName");
            dbPassword = clsif.ReadString("Database", "Password");
            if (clsif.ValueExits("Database", "Port"))
            {
                port = clsif.ReadInt("Database", "port");
            }
            else
            {
                port = 1433;
            }
        }

        public string DBName
        {
            get { return dbName; }
            private set { }
        }

        /// <summary>
        /// 获取数据库主机
        /// </summary>
        public string DBHost
        {
            get { return dbHost; }
            private set { }
        }

        /// <summary>
        /// 获取数据库用户名
        /// </summary>
        public string DBUser
        {
            get { return dbUser; }
            private set { }
        }

        /// <summary>
        /// 获取数据库登录密码
        /// </summary>
        public string DBPassword
        {
            get { return dbPassword; }
            private set { }
        }

        /// <summary>
        /// 获取数据库服务端口
        /// </summary>
        public int DBPort
        {
            get { return port; }
            private set { }
        }

        /// <summary>
        /// 根据已有配置，产生连接字符串
        /// </summary>
        /// <returns></returns>
        public string GenerateConnectionString()
        {
            string sConnectionString = "";// "database=EKanban;server=ch3uw1030;user id=DZDZ;password=HON123well;Connect Timeout=100";
            sConnectionString = "database=" + DBName +";server=" + DBHost + ";user id=" + DBUser + ";password=" + DBPassword + ";Connect Timeout=10";
            return sConnectionString;
        }
    }
}
