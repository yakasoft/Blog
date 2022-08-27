using Blog.Data.Abstract;
using Blog.Data.Concrete.EntityFramework.Contexts;
using Blog.Data.Concrete.EntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BlogContext _context;
        private EfArticleRepository articleRepository;
        private EfCategoryRepository categoryRepository;
        private EfCommentRepository commentRepository;
        private EfRoleRepository roleRepository;
        private EfUserRepository userRepository;

        public UnitOfWork(BlogContext context)
        {
            _context = context;
        }
 
        public IArticleRepository Articles => articleRepository ?? new EfArticleRepository(_context);

        public ICategoryRepository GetCategories => categoryRepository ?? new EfCategoryRepository(_context);

        public ICommentRepository Comments => commentRepository ?? new EfCommentRepository(_context);

        public IRoleRepository Roles => roleRepository ?? new EfRoleRepository(_context);

        public IUserRepository Users => userRepository ?? new EfUserRepository(_context);


        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }
    }
}
