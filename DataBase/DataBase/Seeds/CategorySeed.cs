using Database.Migrations;
using FluentMigrator;

namespace Database.Seeds
{
    [Migration(1001)]
    public class CategorySeed : Migration
    {
        public record CategoryRecord
        {
            public Guid Id { get; set; } = Guid.NewGuid();
            public string Name { get; set; } = string.Empty;
        }

        public override void Up()
        {
            var seeds = new List<(Guid, string)> {
                (Guid.Parse("23523d41-dbf2-475d-a3c1-2dd488634236"),"french"),
                (Guid.Parse("3d7f3130-8e4e-4926-95aa-6afd70655a5a"),"Italian"),
                (Guid.Parse("3c522855-941f-46b3-867e-95b978763ef5"),"pasta"),
                (Guid.Parse("2af787ee-f2d1-4605-8fd9-ac925c8060c3"),"soda")
            };

            foreach ((Guid, string) category in seeds)
            {
                Insert.IntoTable(tableName: Tables.Categories).Row(new
                {
                    id = category.Item1,
                    name = category.Item2
                });
            }
        }

        public override void Down()
        {
        }
    }
}