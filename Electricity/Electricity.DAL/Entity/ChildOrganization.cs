using System;
using System.Collections.Generic;
using System.Text;

namespace Electricity.DAL.Entity
{
    /// <summary>
    /// Дочерняя организация
    /// </summary>
    public class ChildOrganization
    {
        
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public int ParentId { get; set; }
        
        public Organization Parent { get; set; }

        public List<ConsumptionObject> Objects { get; set; }

    }
}
