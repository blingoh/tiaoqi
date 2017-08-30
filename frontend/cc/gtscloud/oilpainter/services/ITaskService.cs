using frontend.cc.gtscloud.oilpainter.dao.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontend.cc.gtscloud.oilpainter.services
{
    interface ITaskService
    {
        /// <summary>
        /// 查找所有任务
        /// </summary>
        /// <returns>任务列表，失败为null</returns>
        IList<TaskModel> FindAllTasks();

        /// <summary>
        /// 根据参数模糊查询任务列表
        /// </summary>
        /// <param name="param">查询参数</param>
        /// <returns>任务列表</returns>
        IList<TaskModel> FindTasksWithParam(TaskModel param);

        /// <summary>
        /// 新增作业纪录
        /// </summary>
        /// <param name="task">待增作业记录</param>
        /// <returns>新增结果：null表示成功，否则表示失败原因</returns>
        string AddTask(TaskModel task);

        /// <summary>
        /// 修改作业信息
        /// </summary>
        /// <param name="task">作业记录信息</param>
        /// <returns>修改结果：null表示成功，否则表示失败原因</returns>
        string ModifyTask(TaskModel task);
    }
}
