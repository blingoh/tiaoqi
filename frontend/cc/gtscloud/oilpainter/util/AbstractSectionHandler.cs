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
    /// 抽象ini文件读写接口
    /// </summary>
    abstract class AbstractSectionHandler
    {
        protected string initPath;
        #region 引入平台中INI读写的库
        [DllImport("kernel32.dll")]
        protected extern static int GetPrivateProfileStringA(string segName, string keyName, string sDefault, StringBuilder buffer, int nSize, string fileName);
        [DllImport("kernel32.dll")]
        protected extern static int GetPrivateProfileSectionA(string segName, StringBuilder buffer, int nSize, string fileName);
        [DllImport("kernel32.dll")]
        protected extern static int WritePrivateProfileSectionA(string segName, string sValue, string fileName);
        [DllImport("kernel32.dll")]
        protected extern static int WritePrivateProfileStringA(string segName, string keyName, string sValue, string fileName);
        [DllImport("kernel32.dll")]
        protected extern static int GetPrivateProfileSectionNamesA(byte[] buffer, int iLen, string fileName);
        #endregion

        /// <summary>
        /// 指定配置文件路径构造一个读写器
        /// </summary>
        /// <param name="path">文件所在路径</param>
        public AbstractSectionHandler(string path)
        {
            initPath = path;
        }

        /// <summary>
        /// 检查文件是否存在
        /// </summary>
        /// <returns>存在则为true，否则为false</returns>
        public bool FileExists()
        {
            return File.Exists(initPath);
        }
        /// <summary>
        /// 自动创建文件
        /// </summary>
        public void CreateFile()
        {
            File.Create(initPath).Close();
        }

        /// <summary>
        /// 是否存在指定的节
        /// </summary>
        /// <param name="section">节的名</param>
        /// <returns>若节存在则为true，否则为false</returns>
        public bool SectionExists(string section)
        {
            //done SectionExists
            StringBuilder buffer = new StringBuilder(65535);
            GetPrivateProfileSectionA(section, buffer, buffer.Capacity, initPath);
            if (buffer.ToString().Trim() == "")
                return false;
            else
                return true;
        }

        /// <summary>
        /// 检查是否存在节的值
        /// </summary>
        /// <param name="section">要检查的节</param>
        /// <param name="key">要检查的节下的key</param>
        /// <returns></returns>
        public bool ValueExits(string section, string key)
        {
            StringBuilder buffer = new StringBuilder(65535);
            GetPrivateProfileStringA(section, key, "", buffer, buffer.Capacity, initPath);
            buffer.ToString();
            if (0 < buffer.Length)
                return false;
            else
                return true;
        }

    }
}
