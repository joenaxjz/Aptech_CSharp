using DemoSession_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoSession_1.Controllers;

[Route("q")]
public class QController : Controller
{
	[Route("")]
	[Route("~/")]
	[Route("index")]
	public IActionResult Index()
	{
		var questionModel = new QuestionModel();
		ViewBag.questions = questionModel.findAll();
		return View();
	}

	[HttpPost]
	[Route("submit")]
	public IActionResult submit()
	{
		var questionModel = new QuestionModel();
		var questions = questionModel.findAll();
		int score = 0;
		foreach (var question in questions)
		{
			var answerId = int.Parse(HttpContext.Request.Form["question_"+ question.Id].ToString());
			if(questionModel.isCorret(question.Id, answerId))
			{
				score++;
			}
		}
		ViewBag.score = score;
		return View("result");
	}
}
