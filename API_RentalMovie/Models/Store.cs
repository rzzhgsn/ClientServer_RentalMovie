using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_RentalMovie.Models;

[Table("tb_rzh_m_stores")]
public class Store
{
    [Key, Column("id")]
    public int Id { get; set; }
    [Required, Column("last_update")]
    public DateTime LastUpdate { get; set; }
    [Required, Column("address_id")]
    public int AddressId { get; set; }

    // Relation & Cardinality
    [JsonIgnore]
    [ForeignKey(nameof(AddressId))]
    public Address? Address { get; set; }
    [JsonIgnore]
    public ICollection<Staff>? Staffs { get; set;}
}
