using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {

    [HttpGet("/wordcounter")]
    public ActionResult Index()
    {
        // List<RepeatCounter> allWordCounts = RepeatCounter.GetAll();
        // return View(allWordCounts);
        return View();
    }

    [HttpGet("/wordcounter/new")]
    public ActionResult CreateForm()
    {
        return View();
    }

    [HttpPost("/wordcounter")]
    public ActionResult Create(string userInputsentence, string userInputWord)
    {
        RepeatCounter myRepeatCounter = new RepeatCounter("test", "test");
        return RedirectToAction("Index");
    }

  }

}

//
