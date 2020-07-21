using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Codenation.Challenge.Models
{
    [Table("challenge")]
    public class Challenge
    {
        [Key]
        [Required]
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


        public ICollection<Submission> Submissions { get; set; }
        public ICollection<Acceleration> Accelerations { get; set; }
    }
}