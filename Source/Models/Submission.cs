using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Codenation.Challenge.Models
{
    [Table("submission")]
    public class Submission
    {
        [Required]
        [Column("score")]
        public decimal Score { get; set; }
        [Required]
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }


        //Foreign key for User
        [ForeignKey("User")]
        [Column("user_id")]
        [Required]
        public int UserId { get; set; }
        public User User { get; set; }

        //Foreign key for Challenge
        [ForeignKey("Challenge")]
        [Column("challenge_id")]
        [Required]
        public int ChallengeId { get; set; }
        public Challenge Challenge { get; set; }
    }
}