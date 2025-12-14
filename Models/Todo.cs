using System.ComponentModel.DataAnnotations;
using TODO_Correction.Enums;

namespace TODO_Correction.Models
{
    public class Todo
    {
        public string Libelle { get; set; }
        public string Description { get; set; }
        public DateTime DateLimite { get; set; }
        public State Statut { get; set; }
    }
}
