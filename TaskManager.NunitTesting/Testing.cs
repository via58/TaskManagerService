using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.ServiceLayer;
using TaskManager.ServiceLayer.Controllers;
using TaskManager.DataAccessLayer;
using System.Web.Http;
using System.Net.Http;
using System.Net;
using System.Web.Http.Results;

namespace TaskManager.NunitTesting
{
    [TestFixture]
    public class Testing
    {
        [Test]
        public void shouldReturnAllTasks()
        {
            //Arrange

            TasksController TestController = new TasksController();
            
            //Act
            IHttpActionResult ActionResult = TestController.GetAllTasks();

           
            var expectedResult = typeof( OkNegotiatedContentResult<List<Task_table>>);

            //Assert
            Assert.IsInstanceOf(expectedResult, ActionResult);
            
        }


        [Test]
        public void shouldReturnTask()
        {
            //Arrange

            TasksController TestController = new TasksController();
           
            //Act
            IHttpActionResult ActualResult = TestController.GetTask(2019);

            var contentResult = ActualResult as OkNegotiatedContentResult<Task_table>;

            //Assert
            Assert.That(2019, Is.EqualTo(contentResult.Content.task_id));
        }
        [Test]
        public void shouldAddTaskAndReturnString()
        {
            //Arrange

            TasksController TestController = new TasksController();

            Task_table temp = new Task_table();
            temp.task = "task";
            temp.parent_task = "parenttask";
            temp.C_priority = 10;
            temp.C_start_date = System.DateTime.Now;
            temp.C_end_date = System.DateTime.Now;


            //Act
            IHttpActionResult ActionResult = TestController.PostTask(temp);


            var expectedResult = typeof(OkNegotiatedContentResult<string>);

            //Assert
            Assert.IsInstanceOf(expectedResult, ActionResult);

        }
        [Test]
        public void shouldDeleteTaskAndReturnString()
        {
            //Arrange

            TasksController TestController = new TasksController();

           

            //Act
            IHttpActionResult ActionResult = TestController.DeleteTask(2019);


            var expectedResult = typeof(OkNegotiatedContentResult<string>);

            //Assert
            Assert.IsInstanceOf(expectedResult, ActionResult);

        }

        [Test]
        public void shouldUpdateTaskAndReturnString()
        {
            //Arrange

            TasksController TestController = new TasksController();

            Task_table temp = new Task_table();
            temp.task = "task";
            temp.parent_task = "parenttask";
            temp.C_priority = 10;
            temp.C_start_date = System.DateTime.Now;
            temp.C_end_date = System.DateTime.Now;


            //Act
            IHttpActionResult ActionResult = TestController.PutTask(2019,temp);


            var expectedResult = typeof(OkNegotiatedContentResult<string>);

            //Assert
            Assert.IsInstanceOf(expectedResult, ActionResult);

        }









    }
}
