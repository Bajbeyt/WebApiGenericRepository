using System;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.EFCore.Config
{
    public class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)//entitynin tipinin inşaası
        {
            builder.HasData(new Student
            {
                Id=1,
                Name="Name",
                Surname="Surname",
            });
        }
    }
}

