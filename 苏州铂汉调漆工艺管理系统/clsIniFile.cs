using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using System.Collections.Specialized;
using System.Collections;

namespace 调漆工艺管理系统
{
    public class clsIniFile
    {
        #region Variables
        public string _FileName;
        #endregion

        #region Import DLL
        [DllImport("kernel32.dll")]
        private extern static int GetPrivateProfileStringA(string segName, string keyName, string sDefault, StringBuilder buffer, int nSize, string fileName);
        [DllImport("kernel32.dll")]
        private extern static int GetPrivateProfileSectionA(string segName, StringBuilder buffer, int nSize, string fileName);
        [DllImport("kernel32.dll")]
        private extern static int WritePrivateProfileSectionA(string segName, string sValue, string fileName);
        [DllImport("kernel32.dll")]
        private extern static int WritePrivateProfileStringA(string segName, string keyName, string sValue, string fileName);
        [DllImport("kernel32.dll")]
        private extern static int GetPrivateProfileSectionNamesA(byte[] buffer, int iLen, string fileName);
        #endregion

        #region Construct Init
        /// <summary>
        /// Init
        /// </summary>
        public clsIniFile()
        {

        }

        public clsIniFile(string FileName)
        {
            _FileName = FileName;
            if (!FileExists())
                CreateFile();
        }
        #endregion

        #region Function

        #region ReadString
        /// <summary>
        /// 返回字符串
        /// </summary>
        public string ReadString(string Section, string Key)
        {
            StringBuilder buffer = new StringBuilder(65535);
            GetPrivateProfileStringA(Section, Key, "", buffer, buffer.Capacity, _FileName);
            return buffer.ToString();
        }
        #endregion

        #region ReadInt
        /// <summary>
        /// 返回int型的数
        /// </summary>
        public virtual int ReadInt(string Section, string Key)
        {
            int result;
            try
            {
                result = int.Parse(this.ReadString(Section, Key));
            }
            catch
            {
                result = -1;
            }
            return result;
        }
        #endregion

        #region ReadLong
        /// <summary>
        /// 返回long型的数
        /// </summary>
        public virtual long ReadLong(string Section, string Key)
        {
            long result;
            try
            {
                result = long.Parse(this.ReadString(Section, Key));
            }
            catch
            {
                result = -1;
            }
            return result;
        }
        #endregion

        #region ReadByte
        /// <summary>
        /// 返回byte型的数
        /// </summary>
        public virtual byte ReadByte(string Section, string Key)
        {
            byte result;
            try
            {
                result = byte.Parse(this.ReadString(Section, Key));
            }
            catch
            {
                result = 0;
            }
            return result;
        }
        #endregion

        #region ReadFload
        /// <summary>
        /// 返回float型的数
        /// </summary>
        public virtual float ReadFloat(string Section, string Key)
        {
            float result;
            try
            {
                result = float.Parse(this.ReadString(Section, Key));
            }
            catch
            {
                result = -1;
            }
            return result;
        }
        #endregion

        #region ReadDouble
        /// <summary>
        /// 返回double型的数
        /// </summary>
        public virtual double ReadDouble(string Section, string Key)
        {
            double result;
            try
            {
                result = double.Parse(this.ReadString(Section, Key));
            }
            catch
            {
                result = -1;
            }
            return result;
        }
        #endregion

        #region ReadDateTime
        /// <summary>
        /// 返回日期型的数
        /// </summary>
        public virtual DateTime ReadDateTime(string Section, string Key)
        {
            DateTime result;
            try
            {
                result = DateTime.Parse(this.ReadString(Section, Key));
            }
            catch
            {
                result = DateTime.Parse("0-0-0"); ;
            }
            return result;
        }
        #endregion

        #region ReadBool
        /// <summary>
        /// Get Bool
        /// </summary>
        public virtual bool ReadBool(string Section, string Key)
        {
            bool result;
            try
            {
                result = bool.Parse(this.ReadString(Section, Key));
            }
            catch
            {
                result = bool.Parse("0-0-0"); ;
            }
            return result;
        }
        #endregion

        #region Write
        /// <summary>
        /// 用于写任何类型的键值到ini文件中
        /// </summary>
        /// <param name="Section">该键所在的节名称</param>
        /// <param name="Key">该键的名称</param>
        /// <param name="Value">该键的值</param>
        public void Write(string Section, string Key, object Value)
        {
            if (Value != null)
                WritePrivateProfileStringA(Section, Key, Value.ToString(), _FileName);
            else
                WritePrivateProfileStringA(Section, Key, null, _FileName);
        }


        public void WriteInifile(string Section, string Key, string svalue)
        {
            if (FileExists() == false)
            {
                CreateFile();
            }

            if (SectionExists(Section) == false)
            {
                AddSection(Section);
                AddKey(Section, Key);
                Write(Section, Key, svalue);
            }
            else
            {
                if (ValueExits(Section, Key) == false)
                {
                    AddKey(Section, Key);
                    Write(Section, Key, svalue);
                }
                else
                {
                    Write(Section, Key, svalue);
                }
            }
        }

        #endregion

        #region others

        /// <summary>
        /// Read Sections
        /// </summary>
        public ArrayList ReadSections()
        {
            byte[] buffer = new byte[65535];
            int rel = GetPrivateProfileSectionNamesA(buffer, buffer.GetUpperBound(0), _FileName);
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

        /// <summary>
        /// Check Section Whether Exists
        /// </summary>
        public bool SectionExists(string Section)
        {
            //done SectionExists
            StringBuilder buffer = new StringBuilder(65535);
            GetPrivateProfileSectionA(Section, buffer, buffer.Capacity, _FileName);
            if (buffer.ToString().Trim() == "")
                return false;
            else
                return true;
        }

        /// <summary>
        /// Check Value
        /// </summary>
        public bool ValueExits(string Section, string Key)
        {
            if (ReadString(Section, Key).Trim() == "")
                return false;
            else
                return true;
        }

        /// <summary>
        /// Delete Key
        /// </summary>
        /// <param name="Section">该键所在的节的名称</param>
        /// <param name="Key">该键的名称</param>
        public void DeleteKey(string Section, string Key)
        {
            Write(Section, Key, null);
        }

        /// <summary>
        /// Add Key
        /// </summary>
        /// <param name="Section">该键所在的节的名称</param>
        /// <param name="Key">该键的名称</param>
        public void AddKey(string Section, string Key)
        {
            Write(Section, Key, "");
        }

        /// <summary>
        /// 删除指定的节的所有内容
        /// </summary>
        /// <param name="Section">要删除的节的名字</param>
        public void DeleteSection(string Section)
        {
            WritePrivateProfileSectionA(Section, null, _FileName);
        }

        /// <summary>
        /// 添加一个节
        /// </summary>
        /// <param name="Section">要添加的节名称</param>
        public void AddSection(string Section)
        {
            WritePrivateProfileSectionA(Section, "", _FileName);
        }
        #endregion

        #region AboutFile

        /// <summary>
        /// 删除ini文件
        /// </summary>
        public void DeleteFile()
        {
            if (FileExists())
                File.Delete(_FileName);
        }

        /// <summary>
        /// 创建文件
        /// </summary>
        public void CreateFile()
        {
            File.Create(_FileName).Close();
        }

        /// <summary>
        /// 判断文件是否存在
        /// </summary>
        /// <returns></returns>
        public bool FileExists()
        {
            return File.Exists(_FileName);
        }
        #endregion

        #endregion

    }
}
