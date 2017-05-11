using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GT5SaveGameLibrary.GT5SqlModel.EarlyVersion
{
    public partial class t_garage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long garage_id { get; set; }

        public long? car_code { get; set; }

        public long? color { get; set; }

        public long? type { get; set; }

        [StringLength(2147483647)]
        public string tuner_label { get; set; }

        [StringLength(2147483647)]
        public string drive_train { get; set; }

        public long? favorite { get; set; }

        public long? year { get; set; }

        public long? power { get; set; }

        [StringLength(2147483647)]
        public string power_rpm { get; set; }

        public long? pp { get; set; }

        public long? mass { get; set; }

        public long? online { get; set; }

        public long? grim_car_id { get; set; }

        [StringLength(2147483647)]
        public string name_JP { get; set; }

        [StringLength(2147483647)]
        public string name_EN { get; set; }

        [MaxLength(2147483647)]
        public byte[] carparameter { get; set; }

        public long? odometer { get; set; }

        public long? ride_count { get; set; }

        public long? obtained_date { get; set; }

        public long? aspiration { get; set; }

        public long? paint_color { get; set; }

        public long? riding_order { get; set; }

        public long? slot_id { get; set; }

        [MaxLength(2147483647)]
        public byte[] carparameterB { get; set; }

        [MaxLength(2147483647)]
        public byte[] carparameterC { get; set; }

        [StringLength(2147483647)]
        public string cp_commentA { get; set; }

        [StringLength(2147483647)]
        public string cp_commentB { get; set; }

        [StringLength(2147483647)]
        public string cp_commentC { get; set; }

        public long? invalid { get; set; }

        public long? length { get; set; }

        public long? car_category { get; set; }
    }
}
