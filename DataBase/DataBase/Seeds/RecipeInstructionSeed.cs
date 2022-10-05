using Database.Migrations;
using FluentMigrator;

namespace Database.Seeds
{
    [Migration(1007)]
    public class RecipeInstructionSeed : Migration
    {
        public override void Up()
        {
            var seeds = new List<(Guid, Guid, int, Guid id)> {
                (Guid.Parse("51b8671b-b4e4-4a89-996e-bdd141e52492"),Guid.Parse("544a06c3-34f6-4748-893e-4eb848e602a6"),1,Guid.Parse("166f9cb2-4e96-4a05-b18c-a08a971d5881")),
                (Guid.Parse("51b8671b-b4e4-4a89-996e-bdd141e52492"),Guid.Parse("72b13cb4-f0f5-4cb7-95d4-5c51123ea1f8"),2,Guid.Parse("342e3972-c3b0-47a7-8263-95d18cd6b5a3")),
                (Guid.Parse("b12c7e14-81d5-46f2-a6a1-b322627d5d7c"),Guid.Parse("77ef1807-c1ab-4246-8438-fda584ab89d6"),1,Guid.Parse("cd5d4ed3-7f34-41f2-b39e-6fe9d1588072")),
                (Guid.Parse("b12c7e14-81d5-46f2-a6a1-b322627d5d7c"),Guid.Parse("a40cd5e7-18e7-4da2-961b-a1def62dea0f"),2,Guid.Parse("daa1fe6b-0232-4175-a220-c299f8b44d5c")),
                };

            //var seeds = new List<(Guid, Guid, int)> {
            //    (Guid.Parse("51b8671b-b4e4-4a89-996e-bdd141e52492"),Guid.Parse("544a06c3-34f6-4748-893e-4eb848e602a6"),1),
            //    (Guid.Parse("51b8671b-b4e4-4a89-996e-bdd141e52492"),Guid.Parse("72b13cb4-f0f5-4cb7-95d4-5c51123ea1f8"),2),
            //    (Guid.Parse("b12c7e14-81d5-46f2-a6a1-b322627d5d7c"),Guid.Parse("77ef1807-c1ab-4246-8438-fda584ab89d6"),1),
            //    (Guid.Parse("b12c7e14-81d5-46f2-a6a1-b322627d5d7c"),Guid.Parse("a40cd5e7-18e7-4da2-961b-a1def62dea0f"),2),
            //};

            foreach ((Guid, Guid, int, Guid) recipeInstruction in seeds)
            {
                Insert.IntoTable(tableName: Tables.RecipesInstructions).Row(new
                {
                    id = recipeInstruction.Item4,
                    recipe = recipeInstruction.Item1,
                    instruction = recipeInstruction.Item2,
                    rank = recipeInstruction.Item3,
                });
            }

            //foreach ((Guid, Guid, int) recipeInstruction in seeds)
            //{
            //    Insert.IntoTable(tableName: Tables.RecipesInstructions).Row(new
            //    {
            //        id = Guid.NewGuid(),
            //        recipe = recipeInstruction.Item1,
            //        instruction = recipeInstruction.Item2,
            //        rank = recipeInstruction.Item3,
            //    });
            //}
        }

        public override void Down()
        {
        }
    }
}