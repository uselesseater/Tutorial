using System.Web.Mvc;
using PairingTest.Web.Models;
//using QuestionServiceWebApi;
using System.Collections.Generic;

namespace PairingTest.Web.Controllers
{
    public class QuestionnaireController : Controller
    {
          /* ASYNC ACTION METHOD... IF REQUIRED... */
//        public async Task<ViewResult> Index()
//        {
//        }

        public ActionResult Index()
        {

            //QuestionRepository repos = new QuestionRepository();
            //Questionnaire quest = repos.GetQuestionnaire();

            //QuestionnaireViewModel mod = new QuestionnaireViewModel { 
            //    QuestionnaireTitle = quest.QuestionnaireTitle,
            //    QandA = new List<QuestionAndAnswer>()
            //};

            //foreach (string q in quest.QuestionsText)
            //{
            //    mod.QandA.Add(new QuestionAndAnswer
            //    {
            //        QuestionsText = q,
            //        QuestionsAnswer = ""
            //    });
            //};

            //return View(mod);
            return PartialView();
        }

        public ActionResult Questionnaire()
        {
          

            return PartialView();
        }
    }
}
