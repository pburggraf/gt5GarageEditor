using System.ComponentModel.DataAnnotations;

namespace GT5SaveGameLibrary.GT5SqlModel.EarlyVersion
{
    public partial class t_tuner
    {
        [Key]
        [StringLength(2147483647)]
        public string tuner { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string tuner_long { get; set; }
    }
}
