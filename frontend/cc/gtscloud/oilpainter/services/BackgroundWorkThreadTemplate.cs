using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace frontend.cc.gtscloud.oilpainter.services
{
    /// <summary>
    /// 后台工作线程模板
    /// </summary>
    class BackgroundWorkThreadTemplate
    {
        /// <summary>
        /// 线程入口
        /// </summary>
        public ParameterizedThreadStart StartEntry
        {
            get;set;
        }

        /// <summary>
        /// 线程回调函数
        /// </summary>
        public SendOrPostCallback Callback
        {
            get;set;
        }

        /// <summary>
        /// 同步上下文
        /// </summary>
        public SynchronizationContext SyncContext
        {
            get;set;
        }

        public void Start(object param)
        {
            Thread startThread = new Thread(StartEntry);

            startThread.Start(param);
        }

        private void ThreadEntry(object param)
        {
            if (null == StartEntry)
            {
                StartEntry(param); // 执行操作
            }
        }
    }
}
