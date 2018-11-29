using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace TaskManager.DataAccessLayer
{
    public class TaskDataLayer
    {
        public List<Task_table> GetTasksList()
        {
            using (TaskManagerEntities dbContext = new TaskManagerEntities())
            {
                return dbContext.Task_table.ToList();
            }
        }

        public Task_table GetTaskById(int _id)
        {
            using (TaskManagerEntities dbContext = new TaskManagerEntities())
            {
                return dbContext.Task_table.Find(_id);
            }
        }
        [HttpPost]
        public void CreateTask(Task_table task)
        {
            using (TaskManagerEntities dbContext = new TaskManagerEntities())
            {
                dbContext.Task_table.Add(task);
                dbContext.SaveChanges();
            }
        }
        public void UpdateTaskById(int taskId, Task_table task)
        {
            using (TaskManagerEntities dbContext = new TaskManagerEntities())
            {
                dbContext.Entry(task).State = System.Data.Entity.EntityState.Modified;
                dbContext.SaveChanges();
            }
        }


        public void DeleteTaskById(int taskId)
        {
            using (TaskManagerEntities dbContext = new TaskManagerEntities())
            {
                var  task = dbContext.Task_table.Find(taskId);
                if (task != null) dbContext.Task_table.Remove(task);
                dbContext.SaveChanges();
            }
        }
    }
}
