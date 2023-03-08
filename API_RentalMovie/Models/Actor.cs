using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_RentalMovie.Models;

[Table("tb_rzh_m_actors")]
public class Actor
{
    [Key, Column("id")]
    public int Id { get; set; }
    [Required, Column("first_name"), MaxLength(255)]
    public string FirstName { get; set; }
    [Column("last_name"), MaxLength(255)]
    public string? LastName { get; set; }
    [Required, Column("last_update")]
    public DateTime LastUpdate { get; set; }

    // Cardinality
    [JsonIgnore]
    public ICollection<FilmActor>? FilmActors { get; set; }
}
