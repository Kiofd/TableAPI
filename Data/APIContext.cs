using Microsoft.EntityFrameworkCore;
using TableAPI.Models;

namespace TableAPI.Data
{
    public class APIContext:DbContext
    {
        public DbSet<HotelBooking> Bookings { get; set; }

        public APIContext(DbContextOptions<APIContext> option)
            :base(option)
        {

        }
    }
}
