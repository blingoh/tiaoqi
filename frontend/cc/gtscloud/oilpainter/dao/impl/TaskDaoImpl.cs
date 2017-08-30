using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using frontend.cc.gtscloud.oilpainter.dao.model;
using IBatisNet.DataMapper;

namespace frontend.cc.gtscloud.oilpainter.dao.impl
{
    class TaskDaoImpl : ITaskDao
    {
        private ISqlMapper mapper = SingletonSqlMapper.Get();
        private readonly static string SQL_SELECT_TASKS_WITH_PARAM = "SelectTasksWithParam";
        private readonly static string SQL_INSERT_NEW_TASK = "InsertNewTask";
        private readonly static string SQL_UPDATE_TASK = "UpdateTask";
        public IList<TaskModel> FindModelsWithParam(TaskModel param)
        {
            try
            {
                return mapper.QueryForList<TaskModel>(SQL_SELECT_TASKS_WITH_PARAM, param);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public string InsertNewTask(TaskModel task)
        {
            try
            {
                mapper.Insert(SQL_INSERT_NEW_TASK, task);
                return null;
            }
            catch (Exception ex)
            {
                return ex.Message + "位于：" + ex.StackTrace;
            }
        }

        public string UpdateTask(TaskModel task)
        {
            try
            {
                mapper.Update(SQL_UPDATE_TASK, task);
                return null;
            }
            catch (Exception ex)
            {
                return ex.Message + "位于：" + ex.StackTrace;
            }
        }
    }
}
