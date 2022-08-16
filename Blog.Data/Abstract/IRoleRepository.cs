using Blog.Entities.Concrete;
using Blog.Shared.Entities.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Abstract
{
    public interface IRoleRepository : IEntityRepository<Role>
    {
    }
