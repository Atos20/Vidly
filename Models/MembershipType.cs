using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }   //We will have just a handful of memberships //in entity frm wver editing should have an Identity
        public short SignUpFee { get; set; } // Because we don't need values > 32000

        public byte DurationInMonths { get; set; }// the largets number will no greater that 12
        public byte DiscountRate  { get; set; }//ranges between 0 and 100
        [Required]
        public string Name { get; set; }// string 

    }
}