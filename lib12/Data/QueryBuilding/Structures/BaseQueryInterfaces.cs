﻿namespace lib12.Data.QueryBuilding.Structures
{
    /// <summary>
    /// IWherePossible
    /// </summary>
    public interface IWherePossible
    {
        /// <summary>
        /// Adds the WHERE statement to query
        /// </summary>
        /// <param name="cnd">The condition</param>
        /// <returns></returns>
        IWhere Where(Condition cnd);

        /// <summary>
        /// Adds the WHERE statement to query
        /// </summary>
        /// <param name="field">The field on which comparison occurs</param>
        /// <param name="comparison">The comparison type</param>
        /// <param name="argument">The argument for comparison</param>
        /// <returns></returns>
        IWhere Where(string field, Compare comparison, object argument);

        /// <summary>
        /// Adds the WHERE statement to query
        /// </summary>
        /// <param name="condition">The condition as text</param>
        /// <returns></returns>
        IWhere Where(string condition);

        /// <summary>
        /// Adds the WHERE BETWEEN statement to query
        /// </summary>
        /// <param name="field">The field on which comparison occurs</param>
        /// <param name="argument1">The first argument for between</param>
        /// <param name="argument2">The second argument for between</param>
        /// <returns></returns>
        IWhere WhereBetween(string field, object argument1, object argument2);

        /// <summary>
        /// Adds the WHERE IS NULL statement to query
        /// </summary>
        /// <param name="field">The field to check</param>
        /// <returns></returns>
        IWhere WhereIsNull(string field);

        /// <summary>
        /// Adds the WHERE IS NOT NULL statement to query
        /// </summary>
        /// <param name="field">The field to check</param>
        /// <returns></returns>
        IWhere WhereIsNotNull(string field);
    }

    /// <summary>
    /// IBracketPossible
    /// </summary>
    public interface IBracketPossible
    {
        /// <summary>
        /// Opens the bracket for next statements
        /// </summary>
        /// <returns></returns>
        IOpenBracket OpenBracket();
    }

    /// <summary>
    /// IConcatPossible
    /// </summary>
    public interface IConcatPossible
    {
        /// <summary>
        /// Adds AND statement
        /// </summary>
        IConcat And { get; }

        /// <summary>
        /// Adds OR statement
        /// </summary>
        IConcat Or { get; }
    }

    /// <inheritdoc />
    /// <seealso cref="T:lib12.Data.QueryBuilding.Structures.IWherePossible" />
    public interface IOpenBracket : IWherePossible
    {

    }

    /// <summary>
    /// ICloseBracket
    /// </summary>
    /// <seealso cref="T:lib12.Data.QueryBuilding.Structures.IConcatPossible" />
    /// <seealso cref="T:lib12.Data.QueryBuilding.Structures.IBuild" />
    public interface ICloseBracket : IConcatPossible, IBuild
    {

    }

    /// <summary>
    /// IConcat
    /// </summary>
    /// <seealso cref="lib12.Data.QueryBuilding.Structures.IBracketPossible" />
    /// <seealso cref="lib12.Data.QueryBuilding.Structures.IWherePossible" />
    public interface IConcat : IBracketPossible, IWherePossible
    {

    }

    /// <summary>
    /// IWhere
    /// </summary>
    /// <seealso cref="lib12.Data.QueryBuilding.Structures.IConcatPossible" />
    /// <seealso cref="lib12.Data.QueryBuilding.Structures.IBuild" />
    public interface IWhere : IConcatPossible, IBuild
    {
        /// <summary>
        /// Closes the bracket
        /// </summary>
        /// <returns></returns>
        ICloseBracket CloseBracket();
    }
}