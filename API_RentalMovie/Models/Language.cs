using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_RentalMovie.Models;

[Table("tb_rzh_m_languages")]
public class Language
{
    [Key, Column("id")]
    public int Id { get; set; }
    [Required, Column("name"), MaxLength(20)]
    public string Name { get; set; }
    [Required, Column("last_update")]
    public DateTime LastUpdate { get; set; }

    // Cardinality
    [JsonIgnore]
    public ICollection<Film>? Films { get; set; }
}
