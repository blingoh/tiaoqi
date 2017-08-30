using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontend.cc.gtscloud.oilpainter.models
{
    /// <summary>
    /// BOM上传页面的实体
    /// </summary>
    public class BomUploadViewModel : INotifyPropertyChanged
    {
        private string bomFilePath;

        private ObservableCollection<BomUploadItemModel> boms = new ObservableCollection<BomUploadItemModel>();
        /// <summary>
        /// 获取和设置BOM文件所在路径
        /// </summary>
        public string BomFilePath
        {
            get { return bomFilePath; }
            set
            {
                if (null != value)
                {
                    bomFilePath = value;
                }
                if (null != PropertyChanged)
                    PropertyChanged(this, new PropertyChangedEventArgs("BomFilePath"));

            }
        }

        /// <summary>
        /// 获取和设置BOM模板集合
        /// </summary>
        public ObservableCollection<BomUploadItemModel> Boms
        {
            get { return boms; }
            set
            {
                if (null != value)
                {
                    boms = value;
                }
                if (null != PropertyChanged)
                    PropertyChanged(this, new PropertyChangedEventArgs("Boms"));
               
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
