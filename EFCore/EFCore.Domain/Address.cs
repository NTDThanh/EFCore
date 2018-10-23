using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCore.Domain
{
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AddressNo { get; set; }
        public string AddressName { get; set; }
        //public virtual ICollection<County> County { get; set; }
        // For create many-to-many relatedship via intermediate table CountyAddress
        public virtual ICollection<CountyAddress> CountyAddress { get; set; }
        public virtual City City { get; set; }
        public DateTime? UpdateAt { get; set; }
        [Timestamp]
        public byte[] Timestamp { get; set; }
        public bool IsDelete { get; set; }
    }

    public class CountyAddress
    {
        public int CountyId { get; set; }
        public virtual County County { get; set; }
        public int AddressNo { get; set; }
        public virtual Address Address { get; set; }
    }
}
