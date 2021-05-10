using PostApp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostApp.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CountryCreatedIn { get; set; }

        public int GetCreationTime()
        {
            return CreatedAt.CalculateCreation();
        }
    }
}
