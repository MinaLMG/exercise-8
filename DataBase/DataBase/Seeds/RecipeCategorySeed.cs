using Database.Migrations;
using FluentMigrator;

namespace Database.Seeds
{
    [Migration(1006)]
    public class RecipeCategorySeed : Migration
    {
        public override void Up()
        {
            var seeds = new List<(Guid, Guid, Guid id)> {

                (Guid.Parse("51b8671b-b4e4-4a89-996e-bdd141e52492"),Guid.Parse("2af787ee-f2d1-4605-8fd9-ac925c8060c3"),Guid.Parse("32a140ba-303c-4e76-8aa7-8ca25c189316")),
                (Guid.Parse("b12c7e14-81d5-46f2-a6a1-b322627d5d7c"),Guid.Parse("3d7f3130-8e4e-4926-95aa-6afd70655a5a"),Guid.Parse("4b2b08f0-2611-4f0e-8920-4b48b56452bc")),
            };

            //var seeds = new List<(Guid, Guid)> {
            //    (Guid.Parse("51b8671b-b4e4-4a89-996e-bdd141e52492"),Guid.Parse("2af787ee-f2d1-4605-8fd9-ac925c8060c3")),
            //    (Guid.Parse("b12c7e14-81d5-46f2-a6a1-b322627d5d7c"),Guid.Parse("3d7f3130-8e4e-4926-95aa-6afd70655a5a")),
            //};

            foreach ((Guid, Guid, Guid id) recipeCategory in seeds)
            {
                Insert.IntoTable(tableName: Tables.RecipesCategories).Row(new
                {
                    id = recipeCategory.Item3,
                    recipe = recipeCategory.Item1,
                    category = recipeCategory.Item2,
                });
            }

            //foreach ((Guid, Guid) recipeCategory in seeds)
            //{
            //    Insert.IntoTable(tableName: Tables.RecipesCategories).Row(new
            //    {
            //        id = Guid.NewGuid(),
            //        recipe = recipeCategory.Item1,
            //        category = recipeCategory.Item2,
            //    });
            //}
        }

        public override void Down()
        {
        }
    }
}