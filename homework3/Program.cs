using System;

namespace homework3
{
	class Program
	{
		static void Main(string[] args)
		{
			AtistContext context = new AtistContext();
			context.Database.EnsureDeleted();
			context.Database.EnsureCreated();


			context.SaveChanges();


			context.Dispose();
		}
	}
}
