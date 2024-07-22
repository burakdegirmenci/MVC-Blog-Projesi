using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS14MVC.Applicationn.DTOs.ArticleDTOs
{
    public class ArticleCreateDTO
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public byte[] Image { get; set; }
        public Guid AuthorId { get; set; }
        public Guid SubjectId { get; set; }
        public TimeSpan ReadTime { get; set; }
    }
}
