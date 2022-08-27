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
    class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(a => a.Email).IsRequired();
            builder.Property(a => a.Email).HasMaxLength(50);
            builder.HasIndex(a => a.Email).IsUnique();
            builder.Property(a => a.UserName).IsRequired();
            builder.Property(a => a.UserName).HasMaxLength(20);
            builder.HasIndex(a => a.UserName).IsUnique();
            builder.Property(a => a.PasswordHash).IsRequired();
            builder.Property(a => a.PasswordHash).IsRequired();
            builder.Property(a => a.PasswordHash).HasColumnType("VARBINARY(500)");
            builder.Property(a => a.Description).IsRequired();
            builder.Property(a => a.Description).HasMaxLength(250);
            builder.Property(a => a.FirstName).IsRequired();
            builder.Property(a => a.FirstName).HasMaxLength(25);
            builder.Property(a => a.LastName).IsRequired();
            builder.Property(a => a.LastName).HasMaxLength(25);
            builder.Property(a => a.Picture).IsRequired();
            builder.Property(a => a.Picture).HasMaxLength(250);


            builder.Property(a => a.CreatedByName).HasMaxLength(50);
            builder.Property(a => a.CreatedByName).IsRequired();
            builder.Property(a => a.ModifiedByName).HasMaxLength(50);
            builder.Property(a => a.ModifiedByName).IsRequired();
            builder.Property(a => a.CreatedDate).IsRequired();
            builder.Property(a => a.ModifieddDate).IsRequired();
            builder.Property(a => a.IsActive).IsRequired();
            builder.Property(a => a.IsDeleted).IsRequired();
            builder.Property(a => a.Note).HasMaxLength(500);
            builder.ToTable("Users");

            builder.HasData(new User
            {
                Id = 1,
                RoleId = 1,
                FirstName = "Yunus",
                LastName = "Yaka",
                UserName = "yakasoft",
                Email = "yakayunus@gmail.com",
                IsActive = true,
                IsDeleted = true,
                CreatedByName = "InitialCreate",
                CreatedDate = DateTime.Now,
                ModifiedByName = "InitialCreate",
                ModifieddDate = DateTime.Now,


                Description = "İlk Admin Kullanıcı",


                Note = "Admin Kullanıcısı",
                PasswordHash = Encoding.ASCII.GetBytes("0192023a7bbd73250516f069df18b500"),

                Picture= "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSX4wVGjMQ37PaO4PdUVEAliSLi8-c2gJ1zvQ&usqp=CAU"


            });


        }
    }
}
