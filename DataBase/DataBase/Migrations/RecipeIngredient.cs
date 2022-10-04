﻿using FluentMigrator;
namespace DataBase.Migrations
{
    [Migration(8)]
    public class RecipeIngredient : Migration
    {
        public override void Up()
        {
            Create.Table("RecipeIngredient")
                .WithColumn("recipe").AsString()
                .WithColumn("category").AsString()
                .WithColumn("rank").AsInt32()
                .WithColumn("id").AsGuid().PrimaryKey();
        }

        public override void Down()
        {
            Delete.Table("RecipeIngredient");
        }
    }

}
