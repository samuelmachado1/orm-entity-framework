﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Codenation.Challenge.Models
{
    [Table("candidate")]
    public class Candidate
    {
        [Required]
        [Column("status")]
        public int Status { get; set; }
        [Required]
        [Timestamp]
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }


        //Foreign key for User
        [ForeignKey("User")]
        [Column("user_id")]
        [Required]
        public int UserId { get; set; }
        public User User { get; set; }

        //Foreign key for Challenge
        [ForeignKey("Acceleration")]
        [Column("acceleration_id")]
        [Required]
        public int AccelerationId { get; set; }
        public Acceleration Acceleration { get; set; }

        //Foreign key for Company
        [ForeignKey("Company")]
        [Column("company_id")]
        [Required]
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}