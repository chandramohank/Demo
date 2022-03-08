using Elsa.Models;
using Elsa.Serialization;
using Elsa.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Elsa.Samples.JsonWorkflowHttp
{
    public class HomeController : Controller
    {
        private readonly IServiceProvider serviceProvider;

        public HomeController(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        // GET: HomeController
        public ActionResult Index()
        {
            var serializer = this.serviceProvider.GetRequiredService<IContentSerializer>();
            var json = System.IO.File.ReadAllText("C:\\Users\\zh7v\\Chandra\\Projects\\ElsaCore\\elsa-core\\src\\samples\\aspnet\\Elsa.Samples.JsonWorkflowHttp\\Workflows\\SendHttpRequest.json");
            var deserializedWorkflowDefinition = serializer.Deserialize<WorkflowDefinition>(json);
            var materializer = this.serviceProvider.GetRequiredService<IWorkflowBlueprintMaterializer>();
            var workflowBlueprint = materializer.CreateWorkflowBlueprintAsync(deserializedWorkflowDefinition).Result;

            // Execute workflow.
            var workflowRunner = this.serviceProvider.GetRequiredService<IStartsWorkflow>();
            var res = workflowRunner.StartWorkflowAsync(workflowBlueprint).Result;
            return View();
        }

        // GET: HomeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HomeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
