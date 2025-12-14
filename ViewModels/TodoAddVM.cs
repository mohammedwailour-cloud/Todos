using System.ComponentModel.DataAnnotations;
using TODO_Correction.Enums;

namespace TODO_Correction.ViewModels
{
    public class TodoAddVM
    {
        [Required]
        public string Libelle {  get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateLimite { get; set; }
        [Required]
        public State Statut { get; set; }

    }
}
