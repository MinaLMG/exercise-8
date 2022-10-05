using Database.Migrations;
using FluentMigrator;

namespace Database.Seeds
{
    [Migration(1007)]
    public class RecipeInstructionSeed : Migration
    {
        public override void Up()
        {
            //var seeds = new List<(Guid, Guid, int, Guid id)> {
            //    (Guid.Parse("51b8671b-b4e4-4a89-996e-bdd141e52492"),Guid.Parse("544a06c3-34f6-4748-893e-4eb848e602a6"),1,Guid.Parse("4c80f47a-1822-4c66-a83a-b1042b9af89d")),
            //    (Guid.Parse("51b8671b-b4e4-4a89-996e-bdd141e52492"),Guid.Parse("72b13cb4-f0f5-4cb7-95d4-5c51123ea1f8"),2,Guid.Parse("1f1f294c-c73a-46fd-a6a9-5509d8269825")),
            //    (Guid.Parse("51b8671b-b4e4-4a89-996e-bdd141e52492"),Guid.Parse("77ef1807-c1ab-4246-8438-fda584ab89d6"),3,Guid.Parse("ced60ec1-5512-4d04-8327-d0123ca98e08")),
            //    (Guid.Parse("b12c7e14-81d5-46f2-a6a1-b322627d5d7c"),Guid.Parse("a40cd5e7-18e7-4da2-961b-a1def62dea0f"),1,Guid.Parse("6bd613a7-08d6-4e9e-8f2c-95fe63f14375")),
            //    (Guid.Parse("b12c7e14-81d5-46f2-a6a1-b322627d5d7c"),Guid.Parse("b6cc1a5a-c5a2-472c-ac3e-def5aa1da42c"),2,Guid.Parse("b99dde6b-9a69-4904-ab2d-ef4b37fe025f")),
            //    (Guid.Parse("b12c7e14-81d5-46f2-a6a1-b322627d5d7c"),Guid.Parse("f8262fa4-5c33-45aa-895a-33b904488b8b"),3,Guid.Parse("913f7975-09bf-4c3b-88f8-a3472df47974")),
            //    };

            var seeds = new List<(Guid, Guid, int)> {
                (Guid.Parse("51b8671b-b4e4-4a89-996e-bdd141e52492"),Guid.Parse("544a06c3-34f6-4748-893e-4eb848e602a6"),1),
                (Guid.Parse("51b8671b-b4e4-4a89-996e-bdd141e52492"),Guid.Parse("72b13cb4-f0f5-4cb7-95d4-5c51123ea1f8"),2),
                (Guid.Parse("51b8671b-b4e4-4a89-996e-bdd141e52492"),Guid.Parse("77ef1807-c1ab-4246-8438-fda584ab89d6"),3),
                (Guid.Parse("b12c7e14-81d5-46f2-a6a1-b322627d5d7c"),Guid.Parse("a40cd5e7-18e7-4da2-961b-a1def62dea0f"),1),
                (Guid.Parse("b12c7e14-81d5-46f2-a6a1-b322627d5d7c"),Guid.Parse("b6cc1a5a-c5a2-472c-ac3e-def5aa1da42c"),2),
                (Guid.Parse("b12c7e14-81d5-46f2-a6a1-b322627d5d7c"),Guid.Parse("f8262fa4-5c33-45aa-895a-33b904488b8b"),3),
            };

            //foreach ((Guid,Guid,int,Guid) recipeIngredient in seeds)
            //{
            //    Insert.IntoTable(tableName: Tables.RecipesIngredients).Row(new
            //    {
            //        id = recipeIngredient.Item4,
            //        recipe = recipeIngredient.Item1,
            //        category = recipeIngredient.Item2,
            //        rank = recipeIngredient.Item3,
            //    });
            //}

            foreach ((Guid, Guid, int) recipeCategory in seeds)
            {
                Insert.IntoTable(tableName: Tables.RecipesIngredients).Row(new
                {
                    id = Guid.NewGuid(),
                    recipe = recipeCategory.Item1,
                    category = recipeCategory.Item2,
                    rank = recipeCategory.Item3,
                });
            }
        }

        public override void Down()
        {
        }
    }
}