﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FrmHome.Entities
{
    public partial class v_Instructor
    {
        public int usr_id { get; set; }
        [Required]
        [StringLength(50)]
        public string f_name { get; set; }
        [Required]
        [StringLength(50)]
        public string l_name { get; set; }
        [StringLength(150)]
        public string address { get; set; }
        [Required]
        [StringLength(90)]
        public string email { get; set; }
        [Column(TypeName = "money")]
        public decimal? salary { get; set; }
        [StringLength(50)]
        public string degree { get; set; }
        public int dept_id { get; set; }
        [Required]
        [StringLength(100)]
        public string dept_name { get; set; }
    }
}