using FluentMigrator;
namespace DataBase.Migrations
{
    [Migration(2)]
    public class Category : Migration
    {
        public override void Up()
        {
            Create.Table("Category")
                .WithColumn("name").AsString()
                .WithColumn("id").AsGuid().PrimaryKey();
        }

        public override void Down()
        {
            Delete.Table("Category");
        }
    }

}
