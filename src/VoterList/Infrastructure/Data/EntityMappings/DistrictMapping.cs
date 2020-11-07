using VoterList.Core.Jurisdiction;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VoterList.Infrastructure.Data
{
    public class DistrictMapping : IEntityTypeConfiguration<District>
    {
        public void Configure(EntityTypeBuilder<District> builder)
        {
            builder.ToTable("District","jurisdiction");
        }
    }
}