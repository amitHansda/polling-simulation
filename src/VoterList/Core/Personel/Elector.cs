using System;
using VoterList.Core.Common;

namespace VoterList.Core.Personel
{
    public class Elector : DomainEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}