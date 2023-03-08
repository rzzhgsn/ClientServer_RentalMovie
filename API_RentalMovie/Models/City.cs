using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_RentalMovie.Models;

[Table("tb_rzh_m_cities")]
public class City
{
    [Key, Column("id")]
    public int Id { get; set; }
    [Required, Column("name"), MaxLength(50)]
    public string Name { get; set; }
    [Required, Column("last_update")]
    public DateTime LastUpdate { get; set; }
    [Required, Column("country_id")]
    public int CountryId { get; set; }

    //Relation & Cardinality
    [JsonIgnore]
    [ForeignKey(nameof(CountryId))]
    public Country? Country { get; set; }
    [JsonIgnore]
    public ICollection<Address>? Addresses { get; set; }

}
