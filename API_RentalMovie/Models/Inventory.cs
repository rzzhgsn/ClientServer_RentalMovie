using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_RentalMovie.Models;

[Table("tb_rzh_m_inventories")]
public class Inventory
{
    [Key, Column("id")]
    public int Id { get; set; }
    [Required, Column("last_update")]
    public DateTime LastUpdate { get; set; }
    [Required, Column("film_id")]
    public int FilmId { get; set; }


    // Relation & Cardinality
    [JsonIgnore]
    [ForeignKey(nameof(FilmId))]
    public Film? Film { get; set; }
    [JsonIgnore]
    public ICollection<Rental>? Rentals { get; set; }
}
