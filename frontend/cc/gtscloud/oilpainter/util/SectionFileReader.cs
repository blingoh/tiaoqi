using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace frontend.cc.gtscloud.oilpainter.util
{
    /// <summary>
    /// ini文件读取工具
    /// </summary>
    class SectionFileReader : AbstractSectionHandler
    {
        /// <summary>
        /// 通过指定文件路径，构造配置文件读工具
        /// </summary>
        /// <param name="path">文件所在路径</param>
        public SectionFileReader(string path) : base(path)
        {
        }

        #region 所有读的方法
        /// <summary>
        /// 读取INI配置文件中的指定节点字符串值
        /// </summary>
        /// <param name="section">指定节名</param>
        /// <param name="key">节下的节点名</param>
        /// <returns>指定节指定键下的字符值</returns>
        public String ReadString(string section, string key)
        {
            StringBuilder buffer = new StringBuilder(65535);
            GetPrivateProfileStringA(section, key, "", buffer, buffer.Capacity, initPath);
            return buffer.ToString();
        }

        /// <summary>
        /// 读取整型值
        /// </summary>
        /// <param name="section">指定的节</param>
        /// <param name="key">指定节下的节点名</param>
        /// <returns>指定节指定键下的整型值</returns>
        public virtual int ReadInt(string section, string key)
        {
            int result = 0;
            try
            {
                result = int.Parse(this.ReadString(section, key));
            }
            catch
            {
                result = -1;
            }
            return result;
        }

        /// <summary>
        /// 从配置文件中读取Long值的配置
        /// </summary>
        /// <param name="section">指定的节</param>
        /// <param name="key">指定节下的节点名</param>
        /// <returns>指定节指定键下的长整型值</returns>
        public virtual long ReadLong(string section, string key)
        {
            long result;
            try
            {
                result = long.Parse(this.ReadString(section, key));
            }
            catch
            {
                result = -1;
            }
            return result;
        }

        /// <summary>
        /// 从配置文件中读取Byte值的配置
        /// </summary>
        /// <param name="section">指定的节</param>
        /// <param name="key">指定节下的节点名</param>
        /// <returns>指定节指定键下的字节值</returns>
        public virtual byte ReadByte(string section, string key)
        {
            byte result;
            try
            {
                result = byte.Parse(this.ReadString(section, key));
            }
            catch
            {
                result = 0;
            }
            return result;
        }

        /// <summary>
        /// 从配置文件中读取单精度浮点值的配置
        /// </summary>
        /// <param name="section">指定的节</param>
        /// <param name="key">指定节下的节点名</param>
        /// <returns>指定节指定键下的浮点数值</returns>
        public virtual float ReadFloat(string section, string key)
        {
            float result;
            try
            {
                result = float.Parse(this.ReadString(section, key));
            }
            catch
            {
                result = -1;
            }
            return result;
        }

        /// <summary>
        /// 从配置文件中读取双精度浮点值的配置
        /// </summary>
        /// <param name="section">指定的节</param>
        /// <param name="key">指定节下的节点名</param>
        /// <returns>指定节指定键下的浮点数值</returns>
        public virtual double ReadDouble(string section, string key)
        {
            double result;
            try
            {
                result = double.Parse(this.ReadString(section, key));
            }
            catch
            {
                result = -1;
            }
            return result;
        }

        /// <summary>
        /// 从配置文件中读取日期值的配置
        /// </summary>
        /// <param name="section">指定的节</param>
        /// <param name="key">指定节下的节点名</param>
        /// <returns>指定节指定键下的日期值</returns>
        public virtual DateTime ReadDateTime(string section, string key)
        {
            DateTime result;
            try
            {
                result = DateTime.Parse(this.ReadString(section, key));
            }
            catch
            {
                result = DateTime.Parse("0-0-0"); ;
            }
            return result;
        }

        /// <summary>
        /// 从配置文件中读取布尔值的配置
        /// </summary>
        /// <param name="section">指定的节</param>
        /// <param name="key">指定节下的节点名</param>
        /// <returns>指定节指定键下的布尔值</returns>
        public virtual bool ReadBool(string section, string key)
        {
            bool result;
            try
            {
                result = bool.Parse(this.ReadString(section, key));
            }
            catch
            {
                result = bool.Parse("0-0-0"); ;
            }
            return result;
        }
        
        /// <summary>
        /// 读取所有的节
        /// </summary>
        /// <returns>配置文件下的所有节</returns>
        public ArrayList ReadSections()
        {
            byte[] buffer = new byte[65535];
            int rel = GetPrivateProfileSectionNamesA(buffer, buffer.GetUpperBound(0), initPath);
            int iCnt, iPos;
            ArrayList arrayList = new ArrayList();
            string tmp;
            if (rel > 0)
            {
                iCnt = 0; iPos = 0;
                for (iCnt = 0; iCnt < rel; iCnt++)
                {
                    if (buffer[iCnt] == 0x00)
                    {
                        tmp = System.Text.ASCIIEncoding.Default.GetString(buffer, iPos, iCnt).Trim();
                        iPos = iCnt + 1;
                        if (tmp != "")
                            arrayList.Add(tmp);
                    }
                }
            }
            return arrayList;
        }
        
        #endregion
    }
}
