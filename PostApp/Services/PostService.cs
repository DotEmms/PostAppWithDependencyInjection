using AutoMapper;
using PostApp.DTO;
using PostApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostApp.Services
{
    public class PostService : IPostService
    {
        IMapper _mapper;
        public PostService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public PostDTO MapPost()
        {
            Post post = new Post
            {
                Id = 1,
                Name = "A User",
                Content = "This is a post",
                CreatedAt = new DateTime(2019, 01, 23),
                CountryCreatedIn = "Belgium"
            };

            PostDTO dto = _mapper.Map<PostDTO>(post);
            Console.WriteLine($"{dto.Content} \nCreated: {dto.CreationTime} year(s) ago \nCreated by: {dto.PostedBy}");
            return dto;
        }
    }
}
