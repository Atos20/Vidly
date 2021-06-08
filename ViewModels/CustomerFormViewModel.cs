using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }//In the view we don't need all the functionality given by the list class so we use the IEnumerable  since the only thing we need is to iterate over the list

        public Customer Customer { get; set; }

    }
}