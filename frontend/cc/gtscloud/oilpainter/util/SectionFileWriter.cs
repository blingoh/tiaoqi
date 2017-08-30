using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace frontend.cc.gtscloud.oilpainter.util
{
    /// <summary>
    /// ini文件写工具
    /// </summary>
    class SectionFileWriter : AbstractSectionHandler
    {
        /// <summary>
        /// 通过指定文件路径，构造配置文件写工具
        /// </summary>
        /// <param name="path">文件所在路径</param>
        public SectionFileWriter(string path) : base(path)
        {
        }

        /// <summary>
        /// Delete Key
        /// </summary>
        /// <param name="section">该键所在的节的名称</param>
        /// <param name="key">该键的名称</param>
        public void DeleteKey(string section, string key)
        {
            Write(section, key, null);
        }

        /// <summary>
        /// Add Key
        /// </summary>
        /// <param name="section">该键所在的节的名称</param>
        /// <param name="key">该键的名称</param>
        public void AddKey(string section, string key)
        {
            Write(section, key, "");
        }

        /// <summary>
        /// 删除指定的节的所有内容
        /// </summary>
        /// <param name="section">要删除的节的名字</param>
        public void DeleteSection(string section)
        {
            WritePrivateProfileSectionA(section, null, initPath);
        }

        /// <summary>
        /// 添加一个节
        /// </summary>
        /// <param name="section">要添加的节名称</param>
        public void AddSection(string section)
        {
            WritePrivateProfileSectionA(section, "", initPath);
        }

        /// <summary>
        /// 用于写任何类型的键值到ini文件中
        /// </summary>
        /// <param name="section">该键所在的节名称</param>
        /// <param name="key">该键的名称</param>
        /// <param name="value">该键的值</param>
        public void Write(string section, string key, object value)
        {
            if (value != null)
                WritePrivateProfileStringA(section, key, value.ToString(), initPath);
            else
                WritePrivateProfileStringA(section, key, null, initPath);
        }


        /// <summary>
        /// 将配置文件值写入文件
        /// </summary>
        /// <param name="section">要写入的节</param>
        /// <param name="key">要写入的键</param>
        /// <param name="svalue">要写入的值</param>
        public void WriteInifile(string section, string key, string svalue)
        {
            if (FileExists() == false)
            {
                CreateFile();
            }

            if (SectionExists(section) == false)
            {
                AddSection(section);
                AddKey(section, key);
                Write(section, key, svalue);
            }
            else
            {
                if (ValueExits(section, key) == false)
                {
                    AddKey(section, key);
                    Write(section, key, svalue);
                }
                else
                {
                    Write(section, key, svalue);
                }
            }
        }
        
    }
}
