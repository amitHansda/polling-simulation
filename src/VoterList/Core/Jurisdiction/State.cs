using System;
using System.Collections.Generic;
using VoterList.Core.Common;

namespace VoterList.Core.Jurisdiction
{
    public class State : DomainEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }

        public virtual ICollection<District> Districts { get; set; }
        
    }
}