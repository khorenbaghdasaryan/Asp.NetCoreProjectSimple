using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Project.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ProjectContext(
                serviceProvider.GetRequiredService
                    <DbContextOptions<ProjectContext>>()))
            {
                // Look for any movies.
                if (context.Category.Any())
                {
                    return;   // DB has been seeded
                }
                context.Category.AddRange
                    (
                        new Category
                        {
                            CategoryName = "Hiking"
                        },

                        new Category
                        {
                            CategoryName = "City"
                        },

                        new Category
                        {
                            CategoryName = "Museum"
                        },

                        new Category
                        {
                            CategoryName = "Diving"
                        },

                        new Category
                        {
                            CategoryName = "Off Road"
                        }
                    ) ;

                // Look for any movies.
                if (context.Tour.Any())
                {
                    return;   // DB has been seeded
                }

                context.Tour.AddRange
                    (
                        new Tour
                        {
                            TourTitle = "Hiking in Himalayas",
                            ToursStartAt = DateTime.Parse("2020-09-15"),
                            ToursEndAt = DateTime.Parse("2020-09-25"),
                            CategoryId = 1
                        },

                        new Tour
                        {
                            TourTitle = "10 Days At Prague",
                            ToursStartAt = DateTime.Parse("2020-10-20"),
                            ToursEndAt = DateTime.Parse("2020-10-30"),
                            CategoryId = 2
                        }
                    );
                context.SaveChanges();
            }
        }
    }
}
