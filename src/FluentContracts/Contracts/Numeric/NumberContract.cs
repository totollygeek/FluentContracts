using System.Diagnostics.Contracts;
using FluentContracts.Infrastructure;

namespace FluentContracts.Contracts.Numeric;

public abstract class NumberContract<TArgument, TContract> : ComparableContract<TArgument, TContract>
    where TContract : NumberContract<TArgument, TContract>
{
    private readonly Linker<TContract> _linker;
    protected abstract TArgument Zero { get; }

    protected NumberContract(TArgument argumentValue, string argumentName)
        : base(argumentValue, argumentName)
    {
        _linker = new Linker<TContract>((TContract) this);
    }
    
    /// <summary>
    /// Checks if the value of the argument is equal to zero
    /// </summary>
    /// <param name="message">The optional message to include in the exception if the condition is not satisfied.</param>
    /// <returns>Linker for chaining more checks</returns>
    [Pure]
    public Linker<TContract> BeZero(string? message = null)
    {
        Validator.CheckForSpecificValue(Zero, ArgumentValue, ArgumentName, message);
        return _linker;
    }
    
    /// <summary>
    /// Checks if the value of the argument is not equal to zero
    /// </summary>
    /// <param name="message">The optional message to include in the exception if the condition is not satisfied.</param>
    /// <returns>Linker for chaining more checks</returns>
    [Pure]
    public Linker<TContract> NotBeZero(string? message = null)
    {
        Validator.CheckForNotSpecificValue(Zero, ArgumentValue, ArgumentName, message);
        return _linker;
    }
}