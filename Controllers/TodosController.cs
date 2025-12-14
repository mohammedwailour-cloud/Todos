using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using TODO_Correction.Filters;
using TODO_Correction.Mappers;
using TODO_Correction.Models;
using TODO_Correction.Services;
using TODO_Correction.ViewModels;

namespace TODO_Correction.Controllers
{
    [AuthFilter]
    public class TodosController : Controller
    {
        ISessionManagerService session; 
        public TodosController(ISessionManagerService session)
        {
            this.session = session;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(TodoAddVM vm)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
           
            List<Todo> list;
            if (HttpContext.Session.GetString("todos") == null) // si j'ai pas une session li fiha "todos" 
            {
              list  = new List<Todo>();                         // pour generer le formulaire , pour faire le transport  des données du Front vers le back 

            }
            else // si j'ai de session déjà fiha "todos" c'est pas la peine de creer une nouvelle list à chaque fois 
            {
                list = JsonSerializer.Deserialize<List<Todo>>(HttpContext.Session.GetString("todos"));
            }
            


                Todo todo = TodoMapper.GetTodoFromTodoAddVM(vm);
            


            list.Add(todo);

            // Enregistrer dans la session
            // fach kanbghi  n ajouter had list li déjà 3mrtha f dik .add() makan9drch
            // hit  HttpContext.Session.SetString() kataccepti ghi String 
            //donc ghadi nkhdm b serialisation 


           // SessionManagerService session = new SessionManagerService(); 7aydnaha lah9ach injectena dependance par l interafce
            session.Add("todos", list, HttpContext);








            return RedirectToAction(nameof(Index));
        }
    }
}
