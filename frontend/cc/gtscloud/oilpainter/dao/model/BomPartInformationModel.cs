using frontend.cc.gtscloud.oilpainter.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontend.cc.gtscloud.oilpainter.dao.model
{
    /// <summary>
    /// BOM分支信息
    /// </summary>
    [Serializable]
    public class BomPartInformationModel : ObservablePropertyChangedModel
    {
        private string bomid;
        private string partType;
        private string partNumber;
        /// <summary>
        /// BOM ID
        /// </summary>
        public string BomId
        {
            get
            {
                return bomid;
            }
            set
            {
                bomid = value;
                SendPropertyChangedEvent("BomId");
            }
        }
        /// <summary>
        /// 分支类别
        /// </summary>
        public string PartType
        {
            get
            {
                return partType;
            }
            set
            {
                partType = value;
                SendPropertyChangedEvent("PartType");
            }
        }

        /// <summary>
        /// 分支编号
        /// </summary>
        public string PartNumber
        {
            get
            {
                return partNumber;
            }
            set
            {
                partNumber = value;
                SendPropertyChangedEvent("PartNumber");
            }
        }
    }
}
