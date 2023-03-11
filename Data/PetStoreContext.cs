using System;
using Microsoft.EntityFrameworkCore;

namespace DBContextExample.Data
{
	public class PetStoreContext: DbContext
	{
		public PetStoreContext(DbContextOptions<PetStoreContext>options):base(options)
		{

		}
		//here the table would be named as "Pets"
		public DbSet<Pets> Pets { get; set; }
   //     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
   //     {
			//optionsBuilder.UseSqlServer("Server=.;Database=PetStore;User=sa;Password=Hdytycmp2501");
   //         base.OnConfiguring(optionsBuilder);
   //     }
    }
}

