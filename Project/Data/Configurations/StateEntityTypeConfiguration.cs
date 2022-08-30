using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SoftServe_IT_Academy.Project.Models;

namespace SoftServe_IT_Academy.Project.Data.Configurations
{
    internal class StateEntityTypeConfiguration : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> state)
        {
            state.Property(x => x.Name)
                .IsRequired(true)
                .HasMaxLength(30)
                .IsUnicode(false);
        }
    }
}
