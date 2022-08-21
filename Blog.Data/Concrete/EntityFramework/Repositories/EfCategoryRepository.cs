﻿using Blog.Data.Abstract;
using Blog.Entities.Concrete;
using Blog.Shared.Data.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data.Concrete.EntityFramework.Repositories
{
    public class EfCategoryRepository:EfEntityRepositoryBase<Category>,ICategoryRepository
    {
        public EfCategoryRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
