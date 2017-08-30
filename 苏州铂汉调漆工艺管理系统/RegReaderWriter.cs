using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace 调漆工艺管理系统
{
    class RegReaderWriter
    {

        private RegistryKey rootKey;
        /// <summary>
        /// 创建本应用程序的注册表读写类
        /// </summary>
        public RegReaderWriter()
        {
            RegistryKey key = Registry.LocalMachine;
            rootKey = key.CreateSubKey("software\\OilPainterSpan");
        }

        /// <summary>
        /// 创建键值
        /// </summary>
        /// <param name="key">注册表键</param>
        /// <returns></returns>
        public RegistryKey Create(string key)
        {
            return rootKey.CreateSubKey(key);
        }

        /// <summary>
        /// 写入指定键值的值
        /// </summary>
        /// <param name="key">要写入的键</param>
        /// <param name="name">要写入的项</param>
        /// <param name="value">要写入的值</param>
        public void WriteValueForKey(string key, string name, object value)
        {
            RegistryKey secKey = Create(key);
            secKey.SetValue(name, value);
        }
        
        /// <summary>
        /// 删除指定键
        /// </summary>
        /// <param name="key">待删除键</param>
        public void DeleteKey(string key)
        {
            rootKey.DeleteSubKey(key, true);
        }
        
        /// <summary>
        /// 删除注册表指定值
        /// </summary>
        /// <param name="key">要删除的key</param>
        /// <param name="name">要删除的key项</param>
        public void DeleteValue(string key, string name)
        {
            var destKey = rootKey.OpenSubKey(key, true);
            if (null == destKey)
            {
                return;
            }
            destKey.DeleteValue(name, false);
        }

        /// <summary>
        /// 获取注册表值
        /// </summary>
        /// <param name="key">要获取的键</param>
        /// <param name="name">键所对应的项</param>
        /// <returns>指定注册表项值</returns>
        public object GetValue(string key, string name)
        {
            RegistryKey subKey = rootKey.OpenSubKey(key);
            if (null == subKey)
            {
                return null;
            }
            return subKey.GetValue(name);
        }
        
        /// <summary>
        /// 判断是否含有键值
        /// </summary>
        /// <param name="key">指定的键</param>
        /// <returns>是否该键含有子键</returns>
        public bool HasKey(string key)
        {
            RegistryKey destKey = rootKey.OpenSubKey(key);
            if (null == destKey)
            {
                return false;
            }
            return true;
        }
    }
}
