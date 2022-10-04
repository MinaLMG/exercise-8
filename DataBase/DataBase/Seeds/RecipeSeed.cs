using Database.Migrations;
using FluentMigrator;

namespace Database.Seeds
{
    [Migration(1004)]
    public class RecipeSeed : Migration
    {
        public override void Up()
        {
            var seeds = new List<(Guid, string)> {
                (Guid.Parse("51b8671b-b4e4-4a89-996e-bdd141e52492"),"cola"),
                (Guid.Parse("b12c7e14-81d5-46f2-a6a1-b322627d5d7c"),"chocolate cake"),
            };

            //var seeds = new List<string> {
            //    ("cola"),
            //    ("chocolate cake"),
            //};

            foreach ((Guid, string) recipe in seeds)
            {
                Insert.IntoTable(tableName: Tables.Recipes).Row(new
                {
                    id = recipe.Item1,
                    title = recipe.Item2
                });
            }

            //foreach (string recipe in seeds)
            //{
            //    Insert.IntoTable(tableName: Tables.Recipes).Row(new
            //    {
            //        id = Guid.NewGuid(),
            //        title = recipe
            //    });
            //}
        }

        public override void Down()
        {
        }
    }
}