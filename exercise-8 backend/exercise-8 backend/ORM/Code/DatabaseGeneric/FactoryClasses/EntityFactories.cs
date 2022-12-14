//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.9.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using ex_8.EntityClasses;
using ex_8.HelperClasses;
using ex_8.RelationClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace ex_8.FactoryClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END


	/// <summary>general base class for the generated factories</summary>
	[Serializable]
	public partial class EntityFactoryBase2<TEntity> : EntityFactoryCore2
		where TEntity : EntityBase2, IEntity2
	{
		private readonly bool _isInHierarchy;

		/// <summary>CTor</summary>
		/// <param name="entityName">Name of the entity.</param>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <param name="isInHierarchy">If true, the entity of this factory is in an inheritance hierarchy, false otherwise</param>
		public EntityFactoryBase2(string entityName, ex_8.EntityType typeOfEntity, bool isInHierarchy) : base(entityName, (int)typeOfEntity)
		{
			_isInHierarchy = isInHierarchy;
		}
		
		/// <inheritdoc/>
		public override IEntityFields2 CreateFields() { return ModelInfoProviderSingleton.GetInstance().GetEntityFields(this.ForEntityName); }
		
		/// <inheritdoc/>
		public override IEntity2 CreateEntityFromEntityTypeValue(int entityTypeValue) {	return GeneralEntityFactory.Create((ex_8.EntityType)entityTypeValue); }

		/// <inheritdoc/>
		public override IRelationCollection CreateHierarchyRelations(string objectAlias) { return ModelInfoProviderSingleton.GetInstance().GetHierarchyRelations(this.ForEntityName, objectAlias); }

		/// <inheritdoc/>
		public override IEntityFactory2 GetEntityFactory(object[] fieldValues, Dictionary<string, int> entityFieldStartIndexesPerEntity) 
		{
			return (IEntityFactory2)ModelInfoProviderSingleton.GetInstance().GetEntityFactory(this.ForEntityName, fieldValues, entityFieldStartIndexesPerEntity) ?? this;
		}
		
		/// <inheritdoc/>
		public override IPredicateExpression GetEntityTypeFilter(bool negate, string objectAlias) {	return ModelInfoProviderSingleton.GetInstance().GetEntityTypeFilter(this.ForEntityName, objectAlias, negate);	}
						
		/// <inheritdoc/>
		public override IEntityCollection2 CreateEntityCollection()	{ return new EntityCollection<TEntity>(this); }
		
		/// <inheritdoc/>
		public override IEntityFields2 CreateHierarchyFields() 
		{
			return _isInHierarchy ? new EntityFields2(ModelInfoProviderSingleton.GetInstance().GetHierarchyFields(this.ForEntityName), ModelInfoProviderSingleton.GetInstance(), null) : base.CreateHierarchyFields();
		}
		
		/// <inheritdoc/>
		protected override Type ForEntityType { get { return typeof(TEntity); } }
	}

	/// <summary>Factory to create new, empty CategoryEntity objects.</summary>
	[Serializable]
	public partial class CategoryEntityFactory : EntityFactoryBase2<CategoryEntity> 
	{
		/// <summary>CTor</summary>
		public CategoryEntityFactory() : base("CategoryEntity", ex_8.EntityType.CategoryEntity, false) { }
		/// <inheritdoc/>
		protected override IEntity2 CreateImpl(IEntityFields2 fields) { return new CategoryEntity(fields); }
	}

	/// <summary>Factory to create new, empty IngredientEntity objects.</summary>
	[Serializable]
	public partial class IngredientEntityFactory : EntityFactoryBase2<IngredientEntity> 
	{
		/// <summary>CTor</summary>
		public IngredientEntityFactory() : base("IngredientEntity", ex_8.EntityType.IngredientEntity, false) { }
		/// <inheritdoc/>
		protected override IEntity2 CreateImpl(IEntityFields2 fields) { return new IngredientEntity(fields); }
	}

	/// <summary>Factory to create new, empty InstructionEntity objects.</summary>
	[Serializable]
	public partial class InstructionEntityFactory : EntityFactoryBase2<InstructionEntity> 
	{
		/// <summary>CTor</summary>
		public InstructionEntityFactory() : base("InstructionEntity", ex_8.EntityType.InstructionEntity, false) { }
		/// <inheritdoc/>
		protected override IEntity2 CreateImpl(IEntityFields2 fields) { return new InstructionEntity(fields); }
	}

	/// <summary>Factory to create new, empty RecipeEntity objects.</summary>
	[Serializable]
	public partial class RecipeEntityFactory : EntityFactoryBase2<RecipeEntity> 
	{
		/// <summary>CTor</summary>
		public RecipeEntityFactory() : base("RecipeEntity", ex_8.EntityType.RecipeEntity, false) { }
		/// <inheritdoc/>
		protected override IEntity2 CreateImpl(IEntityFields2 fields) { return new RecipeEntity(fields); }
	}

	/// <summary>Factory to create new, empty RecipeCategoryEntity objects.</summary>
	[Serializable]
	public partial class RecipeCategoryEntityFactory : EntityFactoryBase2<RecipeCategoryEntity> 
	{
		/// <summary>CTor</summary>
		public RecipeCategoryEntityFactory() : base("RecipeCategoryEntity", ex_8.EntityType.RecipeCategoryEntity, false) { }
		/// <inheritdoc/>
		protected override IEntity2 CreateImpl(IEntityFields2 fields) { return new RecipeCategoryEntity(fields); }
	}

	/// <summary>Factory to create new, empty RecipeIngredientEntity objects.</summary>
	[Serializable]
	public partial class RecipeIngredientEntityFactory : EntityFactoryBase2<RecipeIngredientEntity> 
	{
		/// <summary>CTor</summary>
		public RecipeIngredientEntityFactory() : base("RecipeIngredientEntity", ex_8.EntityType.RecipeIngredientEntity, false) { }
		/// <inheritdoc/>
		protected override IEntity2 CreateImpl(IEntityFields2 fields) { return new RecipeIngredientEntity(fields); }
	}

	/// <summary>Factory to create new, empty RecipeInstructionEntity objects.</summary>
	[Serializable]
	public partial class RecipeInstructionEntityFactory : EntityFactoryBase2<RecipeInstructionEntity> 
	{
		/// <summary>CTor</summary>
		public RecipeInstructionEntityFactory() : base("RecipeInstructionEntity", ex_8.EntityType.RecipeInstructionEntity, false) { }
		/// <inheritdoc/>
		protected override IEntity2 CreateImpl(IEntityFields2 fields) { return new RecipeInstructionEntity(fields); }
	}

	/// <summary>Factory to create new, empty UserEntity objects.</summary>
	[Serializable]
	public partial class UserEntityFactory : EntityFactoryBase2<UserEntity> 
	{
		/// <summary>CTor</summary>
		public UserEntityFactory() : base("UserEntity", ex_8.EntityType.UserEntity, false) { }
		/// <inheritdoc/>
		protected override IEntity2 CreateImpl(IEntityFields2 fields) { return new UserEntity(fields); }
	}

	/// <summary>Factory to create new, empty Entity objects based on the entity type specified. Uses  entity specific factory objects</summary>
	[Serializable]
	public partial class GeneralEntityFactory
	{
		/// <summary>Creates a new, empty Entity object of the type specified</summary>
		/// <param name="entityTypeToCreate">The entity type to create.</param>
		/// <returns>A new, empty Entity object.</returns>
		public static IEntity2 Create(ex_8.EntityType entityTypeToCreate)
		{
			var factoryToUse = EntityFactoryFactory.GetFactory(entityTypeToCreate);
			IEntity2 toReturn = null;
			if(factoryToUse != null)
			{
				toReturn = factoryToUse.Create();
			}
			return toReturn;
		}		
	}
		
	/// <summary>Class which is used to obtain the entity factory based on the .NET type of the entity. </summary>
	[Serializable]
	public static class EntityFactoryFactory
	{
		private static Dictionary<Type, IEntityFactory2> _factoryPerType = new Dictionary<Type, IEntityFactory2>();

		/// <summary>Initializes the <see cref="EntityFactoryFactory"/> class.</summary>
		static EntityFactoryFactory()
		{
			foreach(int entityTypeValue in Enum.GetValues(typeof(ex_8.EntityType)))
			{
				var factory = GetFactory((ex_8.EntityType)entityTypeValue);
				_factoryPerType.Add(factory.ForEntityType ?? factory.Create().GetType(), factory);
			}
		}

		/// <summary>Gets the factory of the entity with the .NET type specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory2 GetFactory(Type typeOfEntity) { return _factoryPerType.GetValue(typeOfEntity); }

		/// <summary>Gets the factory of the entity with the ex_8.EntityType specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory2 GetFactory(ex_8.EntityType typeOfEntity)
		{
			switch(typeOfEntity)
			{
				case ex_8.EntityType.CategoryEntity:
					return new CategoryEntityFactory();
				case ex_8.EntityType.IngredientEntity:
					return new IngredientEntityFactory();
				case ex_8.EntityType.InstructionEntity:
					return new InstructionEntityFactory();
				case ex_8.EntityType.RecipeEntity:
					return new RecipeEntityFactory();
				case ex_8.EntityType.RecipeCategoryEntity:
					return new RecipeCategoryEntityFactory();
				case ex_8.EntityType.RecipeIngredientEntity:
					return new RecipeIngredientEntityFactory();
				case ex_8.EntityType.RecipeInstructionEntity:
					return new RecipeInstructionEntityFactory();
				case ex_8.EntityType.UserEntity:
					return new UserEntityFactory();
				default:
					return null;
			}
		}
	}
		
	/// <summary>Element creator for creating project elements from somewhere else, like inside Linq providers.</summary>
	public class ElementCreator : ElementCreatorBase, IElementCreator2
	{
		/// <summary>Gets the factory of the Entity type with the ex_8.EntityType value passed in</summary>
		/// <param name="entityTypeValue">The entity type value.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		public IEntityFactory2 GetFactory(int entityTypeValue) { return (IEntityFactory2)this.GetFactoryImpl(entityTypeValue); }
		
		/// <summary>Gets the factory of the Entity type with the .NET type passed in</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		public IEntityFactory2 GetFactory(Type typeOfEntity) { return (IEntityFactory2)this.GetFactoryImpl(typeOfEntity); }

		/// <summary>Creates a new resultset fields object with the number of field slots reserved as specified</summary>
		/// <param name="numberOfFields">The number of fields.</param>
		/// <returns>ready to use resultsetfields object</returns>
		public IEntityFields2 CreateResultsetFields(int numberOfFields) { return new ResultsetFields(numberOfFields); }
		
		/// <inheritdoc/>
		public override IInheritanceInfoProvider ObtainInheritanceInfoProviderInstance() { return ModelInfoProviderSingleton.GetInstance(); }

		/// <inheritdoc/>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand) { return new DynamicRelation(leftOperand); }

		/// <inheritdoc/>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand, JoinHint joinType, DerivedTableDefinition rightOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, rightOperand, onClause);
		}

		/// <inheritdoc/>
		public override IDynamicRelation CreateDynamicRelation(IEntityFieldCore leftOperand, JoinHint joinType, DerivedTableDefinition rightOperand, string aliasLeftOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, rightOperand, aliasLeftOperand, onClause);
		}

		/// <inheritdoc/>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand, JoinHint joinType, string rightOperandEntityName, string aliasRightOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, (ex_8.EntityType)Enum.Parse(typeof(ex_8.EntityType), rightOperandEntityName, false), aliasRightOperand, onClause);
		}

		/// <inheritdoc/>
		public override IDynamicRelation CreateDynamicRelation(string leftOperandEntityName, JoinHint joinType, string rightOperandEntityName, string aliasLeftOperand, string aliasRightOperand, IPredicate onClause)
		{
			return new DynamicRelation((ex_8.EntityType)Enum.Parse(typeof(ex_8.EntityType), leftOperandEntityName, false), joinType, (ex_8.EntityType)Enum.Parse(typeof(ex_8.EntityType), rightOperandEntityName, false), aliasLeftOperand, aliasRightOperand, onClause);
		}
		
		/// <inheritdoc/>
		public override IDynamicRelation CreateDynamicRelation(IEntityFieldCore leftOperand, JoinHint joinType, string rightOperandEntityName, string aliasLeftOperand, string aliasRightOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, (ex_8.EntityType)Enum.Parse(typeof(ex_8.EntityType), rightOperandEntityName, false), aliasLeftOperand, aliasRightOperand, onClause);
		}
		
		/// <inheritdoc/>
		protected override IEntityFactoryCore GetFactoryImpl(int entityTypeValue) { return EntityFactoryFactory.GetFactory((ex_8.EntityType)entityTypeValue); }

		/// <inheritdoc/>
		protected override IEntityFactoryCore GetFactoryImpl(Type typeOfEntity) { return EntityFactoryFactory.GetFactory(typeOfEntity);	}

	}
}
