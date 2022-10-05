﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.9.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using ex_8.HelperClasses;
using ex_8.FactoryClasses;
using ex_8.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace ex_8.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Entity class which represents the entity 'RecipeCategory'.<br/><br/></summary>
	[Serializable]
	public partial class RecipeCategoryEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
	
	{
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END

		private static RecipeCategoryEntityStaticMetaData _staticMetaData = new RecipeCategoryEntityStaticMetaData();
		private static RecipeCategoryRelations _relationsFactory = new RecipeCategoryRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class RecipeCategoryEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public RecipeCategoryEntityStaticMetaData()
			{
				SetEntityCoreInfo("RecipeCategoryEntity", InheritanceHierarchyType.None, false, (int)ex_8.EntityType.RecipeCategoryEntity, typeof(RecipeCategoryEntity), typeof(RecipeCategoryEntityFactory), false);
			}
		}

		/// <summary>Static ctor</summary>
		static RecipeCategoryEntity()
		{
		}

		/// <summary> CTor</summary>
		public RecipeCategoryEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public RecipeCategoryEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this RecipeCategoryEntity</param>
		public RecipeCategoryEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for RecipeCategory which data should be fetched into this RecipeCategory object</param>
		public RecipeCategoryEntity(System.Guid id) : this(id, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for RecipeCategory which data should be fetched into this RecipeCategory object</param>
		/// <param name="validator">The custom validator object for this RecipeCategoryEntity</param>
		public RecipeCategoryEntity(System.Guid id, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected RecipeCategoryEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		/// <inheritdoc/>
		protected override EntityStaticMetaDataBase GetEntityStaticMetaData() {	return _staticMetaData; }

		/// <summary>Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitClassMembersComplete();
		}

		/// <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this RecipeCategoryEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END


			OnInitialized();
		}

		/// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
		public static RecipeCategoryRelations Relations { get { return _relationsFactory; } }

		/// <summary>The Category property of the Entity RecipeCategory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RecipeCategory"."category".<br/>Table field type characteristics (type, precision, scale, length): Uuid, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Category
		{
			get { return (System.Guid)GetValue((int)RecipeCategoryFieldIndex.Category, true); }
			set	{ SetValue((int)RecipeCategoryFieldIndex.Category, value); }
		}

		/// <summary>The Id property of the Entity RecipeCategory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RecipeCategory"."id".<br/>Table field type characteristics (type, precision, scale, length): Uuid, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Guid Id
		{
			get { return (System.Guid)GetValue((int)RecipeCategoryFieldIndex.Id, true); }
			set	{ SetValue((int)RecipeCategoryFieldIndex.Id, value); }
		}

		/// <summary>The Recipe property of the Entity RecipeCategory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RecipeCategory"."recipe".<br/>Table field type characteristics (type, precision, scale, length): Uuid, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Recipe
		{
			get { return (System.Guid)GetValue((int)RecipeCategoryFieldIndex.Recipe, true); }
			set	{ SetValue((int)RecipeCategoryFieldIndex.Recipe, value); }
		}
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END


	}
}

namespace ex_8
{
	public enum RecipeCategoryFieldIndex
	{
		///<summary>Category. </summary>
		Category,
		///<summary>Id. </summary>
		Id,
		///<summary>Recipe. </summary>
		Recipe,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace ex_8.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: RecipeCategory. </summary>
	public partial class RecipeCategoryRelations: RelationFactory
	{

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticRecipeCategoryRelations
	{

		/// <summary>CTor</summary>
		static StaticRecipeCategoryRelations() { }
	}
}
