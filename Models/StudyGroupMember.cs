using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace u24987230_INF_272_PRACTICAL_1.Models
{
	public class StudyGroupMember
	{
        [Key]
        public int StudentNumber { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required, EmailAddress]
        public string EmailAddress { get; set; }
    }
}