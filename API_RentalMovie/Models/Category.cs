using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_RentalMovie.Models;

[Table("tb_rzh_m_categories")]
public class Category
{
    [Key, Column("id")]
    public int Id { get; set; }
    [Required, Column("name"), MaxLength(25)]
    public string Name { get; set; }
    [Required, Column("last_update")]
    public DateTime LastUpdate { get; set; }

    // Cardinality
    [JsonIgnore]
    public ICollection<FilmCategory>? FilmCategories { get; set; }
}
