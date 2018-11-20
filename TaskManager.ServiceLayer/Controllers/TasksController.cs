using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using TaskManager.BusinessLogicLayer;
using TaskManager.DataAccessLayer;
namespace TaskManager.ServiceLayer.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class TasksController : ApiController
    {


        //api/tasks/taskid
       
        public IHttpActionResult GetTask(int taskId)
        {
            try
            {
                var response = Tasks.GetTaskById(taskId);
                if (response != null) return Ok(response);
                else return NotFound();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //api/tasks
        public IHttpActionResult GetAllTasks()
        {
            try
            {
                var response = Tasks.GetAllTasks();
                if (response != null) return Ok(response);
                else return NotFound();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
     

       
        public IHttpActionResult PostTask(Task_table task)
        {
            try
            {
                Tasks.AddTask(task);
                return Ok("Added");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       
        public IHttpActionResult PutTask(int taskId, Task_table task)
        {
            try
            {
               Tasks.UpdateTask(taskId, task);

                return Ok("Updated");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IHttpActionResult DeleteTask(int taskId)
        {
            try
            {
                Tasks.DeleteTask(taskId);
                return Ok("Deleted");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
