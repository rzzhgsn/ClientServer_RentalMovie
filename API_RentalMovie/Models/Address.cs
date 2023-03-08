using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_RentalMovie.Models;

[Table("tb_rzh_m_addresses")]
public class Address
{
    [Key, Column("id")]
    public int Id { get; set; }
    [Required, Column("address1"), MaxLength(50)]
    public string Address1 { get; set; }
    [Column("address2"), MaxLength(50)]
    public string? Address2 { get; set; }
    [Required, Column("district")]
    public int District { get; set; }
    [Required, Column("postal_code"), MaxLength(10)]
    public string PostalCode { get; set; }
    [Required, Column("phone"), MaxLength(20)]
    public string Phone { get; set; }
    [Required, Column("last_update")]
    public DateTime LastUpdate { get; set; }
    [Required, Column("city_id")]
    public int CityId { get; set; }

    // Cardinality
    [JsonIgnore]
    [ForeignKey(nameof(CityId))]
    public City? City { get; set; }

    // Relation
    [JsonIgnore]
    public ICollection<Customer>? Customers { get; set; }
    [JsonIgnore]
    public ICollection<Store>? Stores { get; set; }
    [JsonIgnore]
    public ICollection<Staff>? Staffs { get; set; }
}
