using System;
using System.Collections.Generic;
using System.Linq;

    public class Unit
    {
        public double Health { get; set; }
        public double DistanceToExplosion { get; set; }
    }

    public static class UnitExtensions
    {
        public static IEnumerable<Unit> FilterAndSortByHealth(this IEnumerable<Unit> units)
        {
            return units
                .Where(u => u.DistanceToExplosion < 10)
                .OrderBy(u => u.Health);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Unit> units = new List<Unit>
            {
                new Unit { Health = 100, DistanceToExplosion = 5 },
                new Unit { Health = 80, DistanceToExplosion = 3 },
                new Unit { Health = 120, DistanceToExplosion = 12 },
                new Unit { Health = 60, DistanceToExplosion = 7 }
            };

            var filteredSortedUnits = units.FilterAndSortByHealth();

            Console.WriteLine("Отсортированные юниты по уровню здоровья, находящиеся ближе 10м до взрыва:");
            foreach (var unit in filteredSortedUnits)
            {
                Console.WriteLine($"Здоровье: {unit.Health}, Дистанция до взрыва: {unit.DistanceToExplosion}");
            }
        }
    }
