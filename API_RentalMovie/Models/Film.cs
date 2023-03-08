using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_RentalMovie.Models;

[Table("tb_rzh_m_films")]
public class Film
{
    [Key, Column("id")]
    public int Id { get; set; }
    [Required, Column("tittle"), MaxLength(255)]
    public string Tittle { get; set; }
    [Required, Column("description"), MaxLength(255)]
    public string Description { get; set; }
    [Required, Column("release_year")]
    public int ReleaseYear { get; set; }
    [Required, Column("rental_duration")]
    public int RentalDuration { get; set; }
    [Required, Column("rental_rate", TypeName = "numeric(19,0)")]
    public int RentalRate { get; set; }
    [Required, Column("length")]
    public int Length { get; set; }
    [Required, Column("replacement_cost", TypeName = "numeric(19,0)")]
    public int ReplacementCost { get; set; }
    [Required, Column("rating")]
    public int Rating { get; set; }
    [Required, Column("last_update")]
    public DateTime LastUpdate { get; set; }
    [Column("special_features"), MaxLength(255)]
    public string? SpecialFeatures { get; set; }
    [Required, Column("full_text"), MaxLength(255)]
    public string FullText { get; set; }
    [Required, Column("language_id")]
    public int LanguageId { get; set; }

    // Relation & Cardinality
    [JsonIgnore]
    [ForeignKey(nameof(LanguageId))]
    public Language? Language { get; set; }
    [JsonIgnore]
    public ICollection<FilmCategory>? FilmCategories { get; set; }
    [JsonIgnore]
    public ICollection<FilmActor>? FilmActors { get; set; }
    [JsonIgnore]
    public ICollection<Inventory>? Inventories { get; set; }
}
