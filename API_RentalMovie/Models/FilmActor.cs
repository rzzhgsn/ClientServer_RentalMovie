using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_RentalMovie.Models;

[Table("tb_rzh_tr_filmactors")]
public class FilmActor
{
    [Key, Column("id")]
    public int Id { get; set; }
    [Required, Column("last_update")]
    public DateTime LastUpdate { get; set; }
    [Required, Column("film_id")]
    public int FilmId { get; set; }
    [Required, Column("actor_id")]
    public int ActorId { get; set; }

    // Relation & Cardinality
    [ForeignKey(nameof(FilmId))]
    public Film? Film { get; set; }
    [ForeignKey(nameof(ActorId))]
    public Actor? Actor { get; set; }
}
