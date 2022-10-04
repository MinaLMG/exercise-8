using Database.Migrations;
using FluentMigrator;

namespace Database.Seeds
{
    [Migration(1003)]
    public class InstructionSeed : Migration
    {
        public override void Up()
        {
            var seeds = new List<(Guid, string)> {
                (Guid.Parse("544a06c3-34f6-4748-893e-4eb848e602a6"),"open"),
                (Guid.Parse("72b13cb4-f0f5-4cb7-95d4-5c51123ea1f8"),"drink"),
                (Guid.Parse("77ef1807-c1ab-4246-8438-fda584ab89d6"),"mix the ingredients"),
                (Guid.Parse("a40cd5e7-18e7-4da2-961b-a1def62dea0f"),"bake them"),
            };

            //var seeds = new List<string> {
            //    ("open"),
            //    ("drink"),
            //    ("mix the ingredients"),
            //    ("bake them"),
            //};

            foreach ((Guid, string) instruction in seeds)
            {
                Insert.IntoTable(tableName: Tables.Instructions).Row(new
                {
                    id = instruction.Item1,
                    content = instruction.Item2
                });
            }

            //foreach (string instruction in seeds)
            //{
            //    Insert.IntoTable(tableName: Tables.Instructions).Row(new
            //    {
            //        id = Guid.NewGuid(),
            //        content = instruction
            //    });
            //}
        }

        public override void Down()
        {
        }
    }
}