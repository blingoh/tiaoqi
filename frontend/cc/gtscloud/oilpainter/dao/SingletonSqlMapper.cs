using IBatisNet.Common.Utilities;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontend.cc.gtscloud.oilpainter.dao
{
    class SingletonSqlMapper
    {
        private static volatile ISqlMapper _mapper = null;
        protected static void Configure(object obj)
        {
            _mapper = null;
        }
        // 初始化Mapper实例
        protected static void InitMapper()
        {
            ConfigureHandler handler = new ConfigureHandler(Configure);
            DomSqlMapBuilder builder = new DomSqlMapBuilder();
            _mapper = builder.ConfigureAndWatch(handler);
        }
        /// <summary>
        /// 获取单例的SQL Mapper
        /// </summary>
        /// <returns>SQL Mapper单例实例</returns>
        public static ISqlMapper Instance()
        {
            if (_mapper == null)
            {
                lock (typeof(SqlMapper))
                {
                    if (_mapper == null) // double-check
                    {
                        InitMapper();
                    }
                }
            }
            return _mapper;
        }
        /// <summary>
        /// 获取唯一实例
        /// </summary>
        /// <returns>实例</returns>
        public static ISqlMapper Get()
        {
            return Instance();
        }
    }
}
