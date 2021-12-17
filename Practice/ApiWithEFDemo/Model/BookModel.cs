using System.ComponentModel.DataAnnotations;
namespace ApiWithEFDemo.Model
{
    public class BookModel
    {
       
        public int ID { get; set; }

        [Required(ErrorMessage = "Please Enter Title")]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
