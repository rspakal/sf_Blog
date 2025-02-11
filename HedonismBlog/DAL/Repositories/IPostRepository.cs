﻿using HedonismBlog.Models;
using System.Collections;
using System.ComponentModel;
using System.Threading.Tasks;

namespace HedonismBlog.DataAccess.Repositories
{
    public interface IPostRepository
    {
        public Task<Post> Create(Post post);
        public Task<Post> Get(int id);
        public Task<IEnumerable> GetAll();
        public Task<IEnumerable> GetByUserId(int userId);
        public Task<Post> Update(Post post);
        public Task Delete(int id);
    }
}
