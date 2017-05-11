using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GT5SaveGameLibrary.GT5SqlModel.EarlyVersion
{
    public partial class t_cars
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long car_code { get; set; }

        [StringLength(2147483647)]
        public string tuner { get; set; }

        [StringLength(2147483647)]
        public string name_EN { get; set; }

        [StringLength(2147483647)]
        public string ticket_name { get; set; }

        public long? max_dealer_colour { get; set; }
    }
}
