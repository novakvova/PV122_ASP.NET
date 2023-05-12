using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShop.Data.Entities
{
    [Table("tblRealeStateComercials")]
    public class RealeStateComercialEntity
    {
        [Key, ForeignKey("RealeState")]
        public int RealeStateId { get; set; }
        public virtual RealeStateEntity RealeState { get; set; }
        public string Region { get; set; }
        public string Location { get; set; }
        public string Address { get; set; }

    }
}
