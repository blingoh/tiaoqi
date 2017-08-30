using frontend.cc.gtscloud.oilpainter.dao.model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace frontend.cc.gtscloud.oilpainter.models
{
    /// <summary>
    /// 完整的BOM信息实体
    /// </summary>
    [Serializable]
    public class BomInfoCompleteModel : ObservablePropertyChangedModel, ICloneable
    {
        private ObservableCollection<BomPartInformationModel> _mainPart = new ObservableCollection<BomPartInformationModel>();
        private ObservableCollection<BomPartInformationModel> _guhua = new ObservableCollection<BomPartInformationModel>();
        private ObservableCollection<BomPartInformationModel> _xishi = new ObservableCollection<BomPartInformationModel>();
        private BomInfoModel bomBasic = new BomInfoModel();
        /// <summary>
        /// 获取和设置Bom基本信息
        /// </summary>
        public BomInfoModel BomBasic
        {
            get
            {
                return bomBasic;
            }
            set
            {
                bomBasic = value;
                SendPropertyChangedEvent("BomBasic");
            }
        }

        /// <summary>
        /// 获取主剂料部分
        /// </summary>
        public ObservableCollection<BomPartInformationModel> MainPart
        {
            get
            {
                return _mainPart;
            }
            set
            {
                _mainPart = value;
                SendPropertyChangedEvent("MainPart");
            }
        }

        /// <summary>
        /// 获取固化剂部分
        /// </summary>
        public ObservableCollection<BomPartInformationModel> GuHua
        {
            get { return _guhua; }
            private set { }
        }

        /// <summary>
        /// 获取稀释剂部分
        /// </summary>
        public ObservableCollection<BomPartInformationModel> XiShi
        {
            get { return _xishi; }
            private set { }
        }
        /// <summary>
        /// 深克隆对象
        /// </summary>
        /// <returns>克隆副本</returns>
        public object Clone()
        {
            var newobj = new BomInfoCompleteModel();
            newobj.BomBasic = JsonConvert.DeserializeObject<BomInfoModel>(JsonConvert.SerializeObject(BomBasic));
            newobj._mainPart = new ObservableCollection<BomPartInformationModel>(JsonConvert.DeserializeObject<IList<BomPartInformationModel>>(JsonConvert.SerializeObject(MainPart)));
            newobj._guhua = new ObservableCollection<BomPartInformationModel>(JsonConvert.DeserializeObject<IList<BomPartInformationModel>>(JsonConvert.SerializeObject(GuHua)));
            newobj._xishi = new ObservableCollection<BomPartInformationModel>(JsonConvert.DeserializeObject<IList<BomPartInformationModel>>(JsonConvert.SerializeObject(MainPart)));
            return newobj;
        }
        
    }
}
