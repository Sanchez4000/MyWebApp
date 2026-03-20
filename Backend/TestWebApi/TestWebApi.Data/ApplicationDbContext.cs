using Microsoft.EntityFrameworkCore;

namespace TestWebApi.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
}
