using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Codenation.Challenge.Models
{
    [Table("acceleration")]
    public class Acceleration
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        [Column("name")]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        [Column("slug")]
        public string Slug { get; set; }
        [Required]
        [Timestamp]
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        //Foreign key for Challenge
        [ForeignKey("Challenge")]
        [Column("challenge_id")]
        [Required]
        public int ChallengeId { get; set; }
        public Challenge Challenge { get; set; }


        public ICollection<Candidate> Candidates { get; set; }
    }
}