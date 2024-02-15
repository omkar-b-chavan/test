using Microsoft.EntityFrameworkCore;
using ImageDownloadPDF.Models;

namespace ImageDownloadPDF.Data

{
	public class DataBaseContext : DbContext
	{
		public DataBaseContext() { }
		public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
		{

		}

		public virtual DbSet<Speaker> Speakers { get; set; }


	}
}
