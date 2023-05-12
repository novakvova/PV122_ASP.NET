using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShop.Data.Entities
{
    [Table("tblRealeStates")]
    public class RealeStateEntity
    {
        public int Id { get; set; }
        [Required,StringLength(255)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Price { get; set; }
        [StringLength(4000)]
        public string Description { get; set; }
        [StringLength(255)]
        public string Image { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual CategoryEntity Category { get; set; }
        public virtual RealeStateComercialEntity RealeStateComercial { get; set; }
    }
}
