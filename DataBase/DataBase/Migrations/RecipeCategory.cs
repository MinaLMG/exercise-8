using FluentMigrator;
namespace DataBase.Migrations
{
    [Migration(6)]
    public class RecipeCategory : Migration
    {
        public override void Up()
        {
            Create.Table("RecipeCategory")
                .WithColumn("recipe").AsString()
                .WithColumn("category").AsString()
                .WithColumn("id").AsGuid().PrimaryKey();
        }

        public override void Down()
        {
            Delete.Table("RecipeCategory");
        }
    }

}
