using PostApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostApp
{
    public class Main
    {
        private IPostService _service;
        public Main(IPostService service)
        {
            _service = service;
        }
        public void Run()
        {
            _service.MapPost();
        }
    }
}
