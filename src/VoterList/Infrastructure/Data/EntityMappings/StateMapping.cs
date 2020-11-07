using VoterList.Core.Jurisdiction;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VoterList.Infrastructure.Data
{
    public class StateMapping : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> builder)
        {
           builder.ToTable("State","jurisdiction");
        }
    }
}