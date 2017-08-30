using frontend.cc.gtscloud.oilpainter.dao.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontend.cc.gtscloud.oilpainter.dao
{
    interface ITaskDao
    {
        /// <summary>
        /// 根据模糊查询任务
        /// </summary>
        /// <param name="param">模糊参数</param>
        /// <returns>任务列表</returns>
        IList<TaskModel> FindModelsWithParam(TaskModel param);

        /// <summary>
        /// 增加一条新的作业记录
        /// </summary>
        /// <param name="task">待添加的作业记录</param>
        /// <returns>结果：null表示成功，否则表示失败原因</returns>
        string InsertNewTask(TaskModel task);

        /// <summary>
        /// 更新作业信息
        /// </summary>
        /// <param name="task">作业信息</param>
        /// <returns>结果：null表示成功，否则表示失败原因</returns>
        string UpdateTask(TaskModel task);
    }
}
