using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCore.Domain
{
    public class County
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? CountyId { get; set; }
        [MaxLength(255)]
        public string NameFormated { get; set; }
        public string FullName { get; set; }
        public string AliasName { get; set; }
        public virtual City City { get; set; }
        public DateTime? UpdateAt { get; set; }
        [Timestamp]
        public byte[] Timestamp { get; set; }
        public virtual ICollection<Address> Address { get; set; }
        public bool IsDelete { get; set; }
    }
}
