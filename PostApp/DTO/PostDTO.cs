using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostApp.DTO
{
    public class PostDTO
    {
        public int Id { get; set; }
        public string PostedBy { get; set; }
        public string Content { get; set; }
        public string CountryOfCreation { get; set; }
        public int CreationTime { get; set; }
    }
}
