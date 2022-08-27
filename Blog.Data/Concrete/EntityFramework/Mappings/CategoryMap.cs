using Blog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Concrete.EntityFramework.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(a => a.Name).IsRequired();
            builder.Property(a => a.Name).HasMaxLength(70);
            builder.Property(a => a.Description).HasMaxLength(500);
            builder.Property(a => a.CreatedByName).HasMaxLength(50);
            builder.Property(a => a.CreatedByName).IsRequired();
            builder.Property(a => a.ModifiedByName).HasMaxLength(50);
            builder.Property(a => a.ModifiedByName).IsRequired();
            builder.Property(a => a.CreatedDate).IsRequired();
            builder.Property(a => a.ModifieddDate).IsRequired();
            builder.Property(a => a.IsActive).IsRequired();
            builder.Property(a => a.IsDeleted).IsRequired();
            builder.Property(a => a.Note).HasMaxLength(500);
            builder.ToTable("Categories");



            builder.HasData(

            new Category
            {
                Id = 1,
                Name = "C#",
                Description = "C# programlama dili",
                IsActive = true,
                IsDeleted = true,
                CreatedByName = "InitialCreate",
                CreatedDate = DateTime.Now,
                ModifiedByName = "InitialCreate",
                ModifieddDate = DateTime.Now,
                Note = "C# blog kategorisi"


            },
                  new Category
                  {
                      Id = 2,
                      Name = "C++",
                      Description = "C++ programlama dili",
                      IsActive = true,
                      IsDeleted = true,
                      CreatedByName = "InitialCreate",
                      CreatedDate = DateTime.Now,
                      ModifiedByName = "InitialCreate",
                      ModifieddDate = DateTime.Now,
                      Note = "C++ blog kategorisi"


                  },

                new Category
                {
                    Id = 3,
                    Name = "JavaScript",
                    Description = "JavaScript programlama dili",
                    IsActive = true,
                    IsDeleted = true,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifieddDate = DateTime.Now,
                    Note = "JavaScript blog kategorisi"



                }



            );


        }
    }
}
