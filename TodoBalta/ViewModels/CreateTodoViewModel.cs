using System.ComponentModel.DataAnnotations;

namespace TodoBalta.ViewModels
{
    public class CreateTodoViewModel
    {
        [Required]
        public string Title { get; set; }
    }
}
