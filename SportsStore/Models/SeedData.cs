using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
namespace SportsStore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Лыжи пластиковые",
                        Description = "Беговые, отечественные",
                        Category = "Зима",
                        Price = 2000
                    },
                    new Product
                    {
                        Name = "Шапочка для плавания",
                        Description = "Резиновая универсального размера",
                        Category = "Плавание",
                        Price = 48.95m
                    },
                    new Product
                    {
                        Name = "Футбольный мяч",
                        Description = "FIFA-одобренный размер и вес",
                        Category = "Футбол",
                        Price = 19.50m
                    },
                    new Product
                    {
                        Name = "Угловой флажок",
                        Description = "Для размещения на углу футбольного поля",
                        Category = "Футбол",
                        Price = 34.95m
                    },
                    new Product
                    {
                        Name = "Перчатки вратарские",
                        Description = "Для футбольных вратарей",
                        Category = "Футбол",
                        Price = 79500
                    },
                    new Product
                    {
                        Name = "Шахматная доска",
                        Description = "Деревянная",
                        Category = "Шахматы",
                        Price = 16
                    },
                    new Product
                    {
                        Name = "Фигуры шахматные",
                        Description = "Белые и черные пластиковые",
                        Category = "Шахматы",
                        Price = 29.95m
                    },
                    new Product
                    {
                        Name = "Шахматная доска",
                        Description = "Картонная",
                        Category = "Шахматы",
                        Price = 75
                    },
                    new Product
                    {
                        Name = "Часы шахматные",
                        Description = "С механической стрелкой и флажком",
                        Category = "Шахматы",
                        Price = 1200
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
