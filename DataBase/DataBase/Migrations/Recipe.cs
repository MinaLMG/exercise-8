using FluentMigrator;
namespace DataBase.Migrations
{
    [Migration(3)]
    public class Recipe : Migration
    {
        public override void Up()
        {
            Create.Table("Recipe")
                .WithColumn("title").AsString()
                .WithColumn("id").AsGuid().PrimaryKey();
        }

        public override void Down()
        {
            Delete.Table("Recipe");
        }
    }

}
