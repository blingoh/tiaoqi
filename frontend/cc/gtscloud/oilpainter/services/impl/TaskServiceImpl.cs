using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using frontend.cc.gtscloud.oilpainter.dao.model;
using frontend.cc.gtscloud.oilpainter.dao;
using frontend.cc.gtscloud.oilpainter.dao.impl;

namespace frontend.cc.gtscloud.oilpainter.services.impl
{
    class TaskServiceImpl : ITaskService
    {
        private ITaskDao dao = new TaskDaoImpl();
        public IList<TaskModel> FindAllTasks()
        {
            return null;
        }

        public IList<TaskModel> FindTasksWithParam(TaskModel param)
        {
            if (null == param)
            {
                return FindAllTasks();
            }

            return dao.FindModelsWithParam(param);
        }

        public string AddTask(TaskModel task)
        {
            if (null == task || null == task.TaskID ||
                null == task.BomId ||
                null == task.ShiftName || 
                null == task.LineName ||
                null == task.MainPartVendor ||
                null == task.MainPartNumber || 
                null == task.MainLotNumber ||
                null == task.Operator ||
                null == task.SysDateTime || 
                null == task.PartNumber)
            {
                return "缺少必要参数";
            }

            return dao.InsertNewTask(task);
        }

        public string ModifyTask(TaskModel task)
        {
            if (null == task || null == task.TaskID ||
                null == task.BomId)
            {
                return "缺少必要参数";
            }

            return dao.UpdateTask(task);
        }
    }
}
