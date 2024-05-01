using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using FluentContracts.Contracts.Collections;

namespace FluentContracts;

public static partial class ContractExtensions
{
    #region List
    
    /// <summary>
    /// Indicates a start in the fluent chain of validations for an argument of type <see cref="IList{T}"/>
    /// </summary>
    /// <param name="argument">Argument to be validated</param>
    /// <param name="argumentName">Optional parameter to overwrite the argument name</param>
    /// <returns>A new instance of the ListContract class.</returns>
    [Pure]
    public static ListContract<T> Must<T>(
        this IList<T> argument,
        [CallerArgumentExpression("argument")] string argumentName = DefaultArgumentName)
    {
        return new ListContract<T>(argument, argumentName);
    }
    
    /// <summary>
    /// Indicates a start in the fluent chain of validations for an argument of type <see cref="List{T}"/>
    /// </summary>
    /// <param name="argument">Argument to be validated</param>
    /// <param name="argumentName">Optional parameter to overwrite the argument name</param>
    /// <returns>A new instance of the ListContract class.</returns>
    [Pure]
    public static ListContract<T> Must<T>(
        this List<T> argument,
        [CallerArgumentExpression("argument")] string argumentName = DefaultArgumentName)
    {
        return new ListContract<T>(argument, argumentName);
    }
    
    #endregion
    
    #region Array
    
    /// <summary>
    /// Indicates a start in the fluent chain of validations for an argument of type <see cref="Array"/> of {T}
    /// </summary>
    /// <param name="argument">Argument to be validated</param>
    /// <param name="argumentName">Optional parameter to overwrite the argument name</param>
    /// <returns>A new instance of the ListContract class.</returns>
    [Pure]
    public static ListContract<T> Must<T>(
        this T[] argument,
        [CallerArgumentExpression("argument")] string argumentName = DefaultArgumentName)
    {
        return new ListContract<T>(argument, argumentName);
    }
    
    #endregion
}