using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace finalPOCService.models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
       public string? userName { get; set; }
       public string? password { get; set; }
       public string? gender { get; set; }
       public int phoneNumber { get; set; }
       public string? country { get; set; } 
    }
}