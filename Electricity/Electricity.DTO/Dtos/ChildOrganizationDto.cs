using System;
using System.Collections.Generic;
using System.Text;

namespace Electricity.DTO.Dtos
{
    public class ChildOrganizationDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public int OrganizationId { get; set; }

        public  OrganizationDto Organization { get; set; }
    }
}
