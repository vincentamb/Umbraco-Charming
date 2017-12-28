using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace Umbraco_Charming.Controllers
{
    public class SiteLayoutController : SurfaceController
    {
        private const string PARTIAL_VIEW_FOLDER = "~/Views/Partials/SiteLayout/";

        public ActionResult RenderSentence()
        {
            return PartialView(PARTIAL_VIEW_FOLDER + "_Sentence.cshtml");
        }
        public ActionResult RenderCharmingSentence()
        {
            return PartialView(PARTIAL_VIEW_FOLDER + "_CharmingSentence.cshtml");
        }
    }
}