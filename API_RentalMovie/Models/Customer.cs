using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_RentalMovie.Models;

[Table("tb_rzh_m_customers")]
public class Customer
{
    [Key, Column("id")]
    public int Id { get; set; }
    [Required, Column("first_name"), MaxLength(255)]
    public string FirstName { get; set; }
    [Column("last_name"), MaxLength(255)]
    public string? LastName { get; set; }
    [Required, Column("email"), MaxLength(50)]
    public string Email { get; set; }
    [Required, Column("active", TypeName = "nchar(1)")]
    public string Active { get; set; }
    [Required, Column("create_update")]
    public DateTime CreateDate { get; set; } = DateTime.Now;
    [Required, Column("last_update")]
    public DateTime LastUpdate { get; set; }
    [Required, Column("addres_id")]
    public int AddressId { get; set; }

    // Relation & Cardinality
    [JsonIgnore]
    [ForeignKey(nameof(AddressId))]
    public Address? Address { get; set; }
    [JsonIgnore]
    public ICollection<Rental>? Rentals { get; set; }
    [JsonIgnore]
    public ICollection<Payment>? Payments { get; set; }
}
