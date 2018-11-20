using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.DataAccessLayer;

namespace TaskManager.BusinessLogicLayer
{
    public class Tasks
    {
        public static List<Task_table> GetAllTasks()
        {
            TaskDataLayer datalayer = new TaskDataLayer();
            return datalayer.GetTasksList();
        }

        public  static Task_table GetTaskById(int task_id)
        {
            TaskDataLayer datalayer = new TaskDataLayer();
            return datalayer.GetTaskById(task_id);
        }
        public static void AddTask(Task_table task)
        {
            TaskDataLayer datalayer = new TaskDataLayer();
             datalayer.CreateTask(task);
        }
        public static void UpdateTask(int taskId,Task_table task)
        {
            TaskDataLayer datalayer = new TaskDataLayer();
             datalayer.UpdateTaskById(taskId,task);
        }
        public static void DeleteTask(int taskId)
        {
            TaskDataLayer datalayer = new TaskDataLayer();
            datalayer.DeleteTaskById(taskId);
        }

    }
}
