using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_RentalMovie.Models;

[Table("tb_rzh_m_staffs")]
public class Staff
{
    [Key, Column("id")]
    public int Id { get; set; }
    [Column("payment_id")]
    public int? PaymentId { get; set; }
    [Required, Column("first_name"), MaxLength(255)]
    public string FirstName { get; set; }
    [Column("last_name"), MaxLength(255)]
    public string? LastName { get; set; }
    [Required, Column("email"), MaxLength(50)]
    public string Email { get; set; }
    [Required, Column("active", TypeName = "nchar(1)")]
    public string Active { get; set; }
    [Required, Column("password"), MaxLength(255)]
    public string Password { get; set; }
    [Required, Column("last_update")]
    public DateTime LastUpdate { get; set; }
    [Column("picture_url"), MaxLength(80)]
    public string? PictureUrl { get; set; }
    [Required, Column("address_id")]
    public int AddressId { get; set; }
    [Required, Column("store_id")]
    public int StoreId { get; set; }


    // Relation & Cardinality
    [JsonIgnore]
    [ForeignKey(nameof(AddressId))]
    public Address? Address { get; set; }
    [JsonIgnore]
    public Store? Store { get; set; }
    [JsonIgnore]
    public Account? Account { get; set; }
    [JsonIgnore]
    public ICollection<Payment>? Payments { get; set; }
    [JsonIgnore]
    public ICollection<Rental>? Rentals { get; set; }
}
