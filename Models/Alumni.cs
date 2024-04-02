using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace finalPOCService.models
{
    public class Alumni
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int rollno { get; set; }
        public string? name { get; set; }
        public int age { get; set; }
        public string? branch { get; set; }
        public int batchYear { get; set; }
    }
}

//rollno,name,age,branch,year