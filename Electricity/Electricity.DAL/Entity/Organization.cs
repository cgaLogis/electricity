using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Electricity.DAL.Entity
{
    public class Organization
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public ICollection<ChildOrganization> ChildOrganizations { get; set; }

    }
}
