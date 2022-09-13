using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entities.Dtos
{
   public class CategoryAddDto
    {
        [DisplayName("Kategori Adı")]
        [Required(ErrorMessage ="{0} boş geçilmemelidir.")]
        [MaxLength(70,ErrorMessage ="{0} {1} karekterden fazla olmamalıdır.")]
        [MinLength(3,ErrorMessage = "{0} {1} karakteden az olmamalıdır")]
        public string Name { get; set; }

        [DisplayName("Kategori Açıklaması")]
        //[Required(ErrorMessage = "{0} boş geçilemez.")]
        [MaxLength(500, ErrorMessage = "{0} {1} karekterden fazla olmamalıdır")]
        [MinLength(3, ErrorMessage = "{0} {1} karakteden az olmamalıdır")]
        public string Description { get; set; }

        [DisplayName("Kategori Not Alanı")]
        //[Required(ErrorMessage = "{0} boş geçilemez.")]
        [MaxLength(500, ErrorMessage = "{0} {1} karekterden fazla olmamalıdır")]
        [MinLength(3, ErrorMessage = "{0} {1} karakteden az olmamalıdır")]
        public string Note { get; set; }

        [DisplayName("Aktif Mi?")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]

        public bool IsActive { get; set; }
    }
}
