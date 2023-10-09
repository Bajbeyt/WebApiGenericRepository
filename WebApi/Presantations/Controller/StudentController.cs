using System;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
namespace Presantations.Controller
{
	[Route("api/[controller]")]
	[ApiController]
	public class StudentController:ControllerBase
	{
		private readonly IServiceMananger _serviceMananger;
		public StudentController(IServiceMananger serviceMananger)
		{
			_serviceMananger = serviceMananger;
		}
		[HttpGet("get-studetn-list")]
		public IActionResult GetStudentList()
		{
			var studentList = _serviceMananger.StudentService.GetAllStudents(false);
			return Ok(studentList);
		}
	}
}

