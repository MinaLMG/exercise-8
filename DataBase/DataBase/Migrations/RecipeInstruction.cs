﻿using FluentMigrator;
namespace DataBase.Migrations
{
    [Migration(7)]
    public class RecipeInstruction : Migration
    {
        public override void Up()
        {
            Create.Table("RecipeInstruction")
                .WithColumn("recipe").AsString()
                .WithColumn("category").AsString()
                .WithColumn("rank").AsInt32()
                .WithColumn("id").AsGuid().PrimaryKey();
        }

        public override void Down()
        {
            Delete.Table("RecipeInstruction");
        }
    }

}