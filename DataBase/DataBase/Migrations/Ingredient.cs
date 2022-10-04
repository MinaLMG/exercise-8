using FluentMigrator;
namespace DataBase.Migrations
{
    [Migration(5)]
    public class Ingredient : Migration
    {
        public override void Up()
        {
            Create.Table("Ingredient")
                .WithColumn("content").AsString()
                .WithColumn("id").AsGuid().PrimaryKey();
        }

        public override void Down()
        {
            Delete.Table("Ingredient");
        }
    }

}
