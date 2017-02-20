using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcDemo.Models
{
    public enum Sex
    {
        Male, Female
    }
    public class Worker
    {
        public int ID { get; set; }//名为ID的属性将被数据库视为主键。自增长的INT或GUID都可以作为主键类型。
        [Display(Name = "Last Name")]
        [DataType(DataType.Text)]
        [Required]
        public string LastName { get; set; }
        [Display(Name = "First Name")]
        [DataType(DataType.Text)]
        [Required]
        public string FirstName { get; set; }
        [Required]
        public Sex Sex { get; set; }
        public double? Rating { get; set; }
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }
        public bool bit { get; set; }
    }
}