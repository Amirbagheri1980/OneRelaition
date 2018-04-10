using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RelationShips.Models
{
    public class Cars
    {
       [Key]
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display(Name ="Make")]
        public string Make { get; set; }
        [Display(Name ="Model")]
        public string Model { get; set; }
    }
}