//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using TodoApp.Domain;

//namespace TodoApp.Infrastructure.Configurations
//{
//    public class UserConfiguration : IEntityTypeConfiguration<User>
//    {
//        public void Configure(EntityTypeBuilder<User> builder)
//        {
//            builder.Property<int>("UserId").ValueGeneratedOnAdd();
//            builder.HasKey("UserId");
//            builder.Property(x => x.FirstName).HasColumnName("FirstName");
//            builder.Property(x => x.LastName).HasColumnName("LastName");
//            builder.Property(x => x.Email).HasColumnName("Email");
//            builder.Property(x => x.Created).HasColumnName("Created");
//        }
//    }
//}
