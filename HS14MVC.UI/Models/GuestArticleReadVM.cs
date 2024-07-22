using Microsoft.AspNetCore.Mvc.Rendering;

namespace HS14MVC.UI.Models
{
    public class GuestArticleReadVM
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public byte[]? Image { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public string SubjectName { get; set; }
		public IEnumerable<GuestArticleListVM>? Articles { get; set; }
	}
}
