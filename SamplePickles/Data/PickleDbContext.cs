using Microsoft.EntityFrameworkCore;
using SamplePickles.Models;

namespace SamplePickles.Data;

public class PickleDbContext : DbContext
{
	public PickleDbContext(DbContextOptions<PickleDbContext> options) : base(options) { }

	public DbSet<Product> Products => Set<Product>();
	public DbSet<ProductType> ProductTypes => Set<ProductType>();
	public DbSet<Review> Reviews => Set<Review>();
	public DbSet<ReviewPhoto> ReviewsPhoto => Set<ReviewPhoto>();
}


