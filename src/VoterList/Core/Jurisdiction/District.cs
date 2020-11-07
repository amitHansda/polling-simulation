using VoterList.Core.Common;

namespace VoterList.Core.Jurisdiction
{
    public class District : DomainEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public bool IsDisabled { get; set; }
        public int StateId { get; set; }
        public State State { get; set; }
    }
}