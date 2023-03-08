using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_RentalMovie.Models;

[Table("tb_rzh_tr_rentals")]
public class Rental
{
    [Key, Column("id")]
    public int Id { get; set; }
    [Required, Column("rental_date")]
    public DateTime RentalDate { get; set; } = DateTime.Now;
    [Column("return_date")]
    public DateTime? ReturnDate { get; set; }
    [Required, Column("last_update")]
    public DateTime LastUpdate { get; set; }
    [Required, Column("staff_id")]
    public int StaffId { get; set; }
    [Required, Column("customer_id")]
    public int CustomerId { get; set; }
    [Required, Column("inventory_id")]
    public int InventoryId { get; set; }

    // Relation & Cardinality
    [JsonIgnore]
    [ForeignKey(nameof(CustomerId))]
    public Customer? Customer { get; set; }
    [JsonIgnore]
    [ForeignKey(nameof(InventoryId))]
    public Inventory? Inventory { get; set; }
    [JsonIgnore]
    public Staff? Staff { get; set; }
    [JsonIgnore]
    public ICollection<Payment>? Payments { get; set; }
}
