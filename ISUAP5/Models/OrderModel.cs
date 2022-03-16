using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISUAP5.Models
{
    [Table("test")]
    public class OrderModel
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}