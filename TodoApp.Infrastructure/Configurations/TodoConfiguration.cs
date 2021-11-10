//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using TodoApp.Domain;

//namespace TodoApp.Infrastructure.Configurations
//{
//    public class TodoConfiguration : IEntityTypeConfiguration<Todo>
//    {
//        public void Configure(EntityTypeBuilder<Todo> builder)
//        {
//            builder.Property<int>("TodoId").ValueGeneratedOnAdd();
//            builder.HasKey("TodoId");
//            builder.Property(x => x.Title).HasColumnName("Title");
//            builder.Property(x => x.Description).HasColumnName("Description");
//            builder.Property(x => x.Completed).HasColumnName("Completed");
//            builder.Property(x => x.Created).HasColumnName("Created");
//        }
//    }
//}
