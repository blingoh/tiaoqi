using cc.gtscloud.oilpainter.serialport;
using frontend.cc.gtscloud.oilpainter.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace frontend.cc.gtscloud.oilpainter.services
{
    /// <summary>
    /// 任务状态接口
    /// </summary>
    public abstract class ITaskState : ObservablePropertyChangedModel
    {
        protected Window context;

        protected SerializePortHandler mainPort;
        /// <summary>
        /// 状态枚举
        /// </summary>
        public enum TaskStateEnum
        {
            /// <summary>
            /// 主剂料称重状态
            /// </summary>
            MainMaterialState = 1,
            /// <summary>
            /// 固化剂称重状态
            /// </summary>
            GuhuaMaterialState = 2, 
            /// <summary>
            /// 稀释剂称重状态
            /// </summary>
            XishiMaterialState = 3,
            /// <summary>
            /// 搅拌状态
            /// </summary>
            MixState = 4
        }


        /// <summary>
        /// 开始
        /// </summary>
        public static readonly string StartName = "开始";
        /// <summary>
        /// 结束
        /// </summary>
        public static readonly string StopName = "结束";

        public ITaskState(Window context)
        {
            this.context = context;
        }

        private TaskStateEnum state;
        /// <summary>
        /// 获取或设置当前状态的枚举
        /// </summary>
        public TaskStateEnum State
        {
            get { return state; }
            set
            {
                state = value;
                SendPropertyChangedEvent("State");
            }
        } 

        private string taskname = "开始";
        /// <summary>
        /// 获取或设置当前任务应该显示的操作名称(开始/结束)
        /// </summary>
        public string TaskName
        {
            get
            {
                return taskname;
            }
            set
            {
                taskname = value;
                SendPropertyChangedEvent("TaskName");
            }
        }

        /// <summary>
        /// 开始当前任务
        /// </summary>
        public abstract void Start();

        /// <summary>
        /// 停止当前任务
        /// </summary>
        public abstract void Stop();
    }
}
