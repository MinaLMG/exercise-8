﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.9.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
////////////////////////////////////////////////////////////// 
using System;
using System.Linq;
using ex_8.EntityClasses;
using ex_8.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.QuerySpec.AdapterSpecific;
using SD.LLBLGen.Pro.QuerySpec;

namespace ex_8.FactoryClasses
{
	/// <summary>Factory class to produce DynamicQuery instances and EntityQuery instances</summary>
	public partial class QueryFactory : QueryFactoryBase2
	{
		/// <summary>Creates and returns a new EntityQuery for the Category entity</summary>
		public EntityQuery<CategoryEntity> Category { get { return Create<CategoryEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the Ingredient entity</summary>
		public EntityQuery<IngredientEntity> Ingredient { get { return Create<IngredientEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the Instruction entity</summary>
		public EntityQuery<InstructionEntity> Instruction { get { return Create<InstructionEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the Recipe entity</summary>
		public EntityQuery<RecipeEntity> Recipe { get { return Create<RecipeEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the RecipeCategory entity</summary>
		public EntityQuery<RecipeCategoryEntity> RecipeCategory { get { return Create<RecipeCategoryEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the RecipeIngredient entity</summary>
		public EntityQuery<RecipeIngredientEntity> RecipeIngredient { get { return Create<RecipeIngredientEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the RecipeInstruction entity</summary>
		public EntityQuery<RecipeInstructionEntity> RecipeInstruction { get { return Create<RecipeInstructionEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the User entity</summary>
		public EntityQuery<UserEntity> User { get { return Create<UserEntity>(); } }

		/// <inheritdoc/>
		protected override IElementCreatorCore CreateElementCreator() { return new ElementCreator(); }
 
	}
}