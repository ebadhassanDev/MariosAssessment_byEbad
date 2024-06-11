using MariosAssessment_byEbad.Documents;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosAssessment_byEbad.Sql
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {

        } 

        public DbSet<CustomerDocument> CustomerDto { get; set; }
        public DbSet<OrderDetailsDocument> OrderDetailsDto { get; set; }
        public DbSet<OrderHeadDocument> OrderHeadDto { get; set; }
    }
}
