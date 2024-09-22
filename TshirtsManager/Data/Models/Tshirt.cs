using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TshirtsManager.Data.Models
{
    public class Tshirt
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(150), Column(TypeName = "nvachar(150)")]
        public string Name { get; set; } = "Name";

        [MaxLength(150), Column(TypeName = "nvachar(150)")]
        public string Names { get; set; } = "Names";

        [MaxLength(300), Column(TypeName = "nvachar(300)")]
        public string Description { get; set; } = "Description";

        public DateTime CreateDate { get; set; } = DateTime.Now;

        public DateTime ModifiedDate { get; set; } = DateTime.Now;

        public DateTime Date { get; set; } = DateTime.Now;

        [MaxLength(100), Column(TypeName = "nvarchar(100)")]
        public string Adresse { get; set; } = "Adress";

        [MaxLength(10), Column(TypeName = "nvarchar(10)")]
        public string Time { get; set; } = "12:30";

        public bool Done { get; set; } = false;

        public bool Deleted { get; set; } = false;

        public byte Rating { get; set; } = 2;
    }
}
