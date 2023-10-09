using System;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.EFCore.Config;

namespace Repositories.EFCore
{
	public class RepositoryContext:DbContext
	{
		public RepositoryContext(DbContextOptions options):base(options)//base options en temeldeki kalıtım alması için base
		{

		}
        public DbSet<Student> student { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)//Configrasyonlarımızı tutuyor
        {
            modelBuilder.ApplyConfiguration(new StudentConfig());
        }
    }
}

