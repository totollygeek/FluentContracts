﻿
using System.Runtime.CompilerServices;
using FluentContracts.Contracts;
using FluentContracts.Infrastructure;

namespace FluentContracts;

public static class ObjectExtensions
{
    /// <summary>
    /// Indicates a start in the fluent chain of validations for an argument of type <see cref="T"/>
    /// </summary>
    /// <param name="argument">Argument to be validated</param>
    /// <param name="argumentName">Optional parameter to overwrite the argument name</param>
    /// <returns>A new instance of the NullableContract class.</returns>
    
    public static NullableContract<T> Must<T>(
        this T argument,
        [CallerArgumentExpression("argument")] string argumentName = Constants.DefaultArgumentName)
        where T : class
    {
        return new NullableContract<T>(argument, argumentName);
    }
}
