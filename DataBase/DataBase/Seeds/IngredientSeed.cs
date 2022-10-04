using Database.Migrations;
using FluentMigrator;

namespace Database.Seeds
{
    [Migration(1002)]
    public class IngredientSeed : Migration
    {
        public override void Up()
        {
            var seeds = new List<(Guid, string)> {
                (Guid.Parse("544a06c3-34f6-4748-893e-4eb848e602a6"),"water"),
                (Guid.Parse("72b13cb4-f0f5-4cb7-95d4-5c51123ea1f8"),"sugar"),
                (Guid.Parse("77ef1807-c1ab-4246-8438-fda584ab89d6"),"CO2"),
                (Guid.Parse("a40cd5e7-18e7-4da2-961b-a1def62dea0f"),"wheat"),
                (Guid.Parse("b6cc1a5a-c5a2-472c-ac3e-def5aa1da42c"),"water"),
                (Guid.Parse("f8262fa4-5c33-45aa-895a-33b904488b8b"),"sugar"),
            };
            //var seeds = new List< string> {
            //    ("water"),
            //    ("sugar"),
            //    ("CO2"),
            //    ("wheat"),
            //    ("water"),
            //    ("sugar"),
            //};

            foreach ((Guid, string) ingredient in seeds)
            {
                Insert.IntoTable(tableName: Tables.Ingredients).Row(new
                {
                    id = ingredient.Item1,
                    content = ingredient.Item2
                });
            }

            //foreach (string ingredient in seeds)
            //{
            //    Insert.IntoTable(tableName: Tables.Ingredients).Row(new
            //    {
            //        id = Guid.NewGuid(),
            //        content = ingredient
            //    });
            //}
        }

        public override void Down()
        {
        }
    }
}