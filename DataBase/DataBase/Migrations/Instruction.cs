using FluentMigrator;
namespace DataBase.Migrations
{
    [Migration(4)]
    public class Instruction : Migration
    {
        public override void Up()
        {
            Create.Table("Instruction")
                .WithColumn("content").AsString()
                .WithColumn("id").AsGuid().PrimaryKey();
        }

        public override void Down()
        {
            Delete.Table("Instruction");
        }
    }

}
