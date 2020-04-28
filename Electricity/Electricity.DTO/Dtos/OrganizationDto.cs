using System;
using System.Collections.Generic;
using System.Text;

namespace Electricity.DTO.Dtos
{
    public class OrganizationDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public List<ChildOrganizationDto> ChildOrganizations { get; set; }
    }
}
