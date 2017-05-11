using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GT5SaveGameLibrary.GT5SqlModel.EarlyVersion
{
    public partial class t_colour
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Colour_Number { get; set; }

        public long? Colour_Category { get; set; }

        [StringLength(2147483647)]
        public string Item_Name { get; set; }

        [StringLength(2147483647)]
        public string Maker { get; set; }
    }
}
