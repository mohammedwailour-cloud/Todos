using TODO_Correction.Models;
using TODO_Correction.ViewModels;

namespace TODO_Correction.Mappers
{
    public class TodoMapper
    {
        public static Todo GetTodoFromTodoAddVM(TodoAddVM vm)
        {
            //Todo todo = new Todo (); 
            //  todo.Libelle = vm.Libelle;
            //  todo.Description = vm.Description;
            //  todo.Statut = vm.Statut;
            //  todo.DateLimite = vm.DateLimite;

            //  return todo; 
            return new Todo
            {
                Libelle = vm.Libelle,
                Description = vm.Description,
                Statut = vm.Statut,
                DateLimite = vm.DateLimite,
            };
        }




        //Mappage 
       /* todo.Libelle = vm.Libelle;
            todo.DateLimite = vm.DateLimite;
            todo.Statut = vm.Statut;
            todo.Description = vm.Description; */

    }
}
