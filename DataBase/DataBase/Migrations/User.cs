using FluentMigrator;
namespace DataBase.Migrations
{
    [Migration(1)]
    public class User : Migration
    {
        public override void Up()
        {
            Create.Table("User")
                .WithColumn("userName").AsString()
                .WithColumn("passwordSalt").AsString()
                .WithColumn("passwordHash").AsString()
                .WithColumn("tokenCreatedAt").AsDateTime()
                .WithColumn("tokenExpiresAt").AsDateTime()
                .WithColumn("id").AsGuid().PrimaryKey();
        }

        public override void Down()
        {
            Delete.Table("User");
        }
    }

}
