using Microsoft.AspNetCore.Mvc.Rendering;

namespace HS14MVC.UI.Areas.Author.Models.ArticleVMs
{
    public class ArticleCreateVM
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public IFormFile? NewImage { get; set; }       
        public Guid AuthorId { get; set; }
        public SelectList? Subjects { get; set; }
        public Guid SubjectId { get; set; }
    }
}
