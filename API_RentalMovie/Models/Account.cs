using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_RentalMovie.Models;

[Table("tb_rzh_m_accounts")]
public class Account
{
    [Key, Column("staff_id")]
    public int StaffId { get; set; }
    [Required, Column("password"), MaxLength(255)]
    public string Password { get; set; }

    // Cardinality
    [JsonIgnore]
    public ICollection<AccountRole>? AccountRoles { get; set; }
    [JsonIgnore]
    public Staff? Staff { get; set; }
}
