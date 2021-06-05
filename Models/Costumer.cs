
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]//data notaiton or attribute,, withi this attribute the property will no longer be nullable
        [StringLength(255)]// Just defining the length of the string and every time there are changes  in the domain model
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; } // THIS IS WHA WE CALL a  navigation property and this is how we associated the membership type with the costumer type// it allows us to navigate from one tyep e to another, in this case from customer to it;s membership type, this is helpful when we need to load an object and its related objects
        public byte MembershipTypeId { get; set; } // For optimization sometimes we don;t want to load the entire object but instead a piece of the object. Indentity framewrok will recognize this Id and load it 
        //Entity framework will recognize the convetion and get the data for us and treat this as a foreign key
        public DateTime? Birthdate { get; set; }//This will be optional because not all customer will have this piece of data
    }
}