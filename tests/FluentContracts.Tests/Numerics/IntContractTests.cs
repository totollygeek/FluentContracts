using System;
using FluentContracts.Contracts.Numeric;
using FluentContracts.Tests.Mocks.Data;
using FluentContracts.Tests.TestAttributes;
using Xunit;

namespace FluentContracts.Tests.Numerics;

[ContractTest("Int")]
public class IntContractTests : Tests
{
    [Fact]
    public void Test_Must_BeNull()
    {
        TestContract<int?, NullableIntContract, ArgumentOutOfRangeException>(
            null,
            DummyData.GetInt(),
            (testArgument, message) => testArgument.Must().BeNull(message),
            "testArgument");
    }

    [Fact]
    public void Test_Must_NotBeNull()
    {
        TestContract<int?, NullableIntContract, ArgumentNullException>(
            DummyData.GetInt(),
            null,
            (testArgument, message) => testArgument.Must().NotBeNull(message),
            "testArgument");
    }

    [Fact]
    public void Test_Must_Be()
    {
        var pair = DummyData.GetIntPair();

        TestContract<int, IntContract, ArgumentOutOfRangeException>(
            pair.TestArgument,
            pair.DifferentArgument,
            (testArgument, message) => testArgument.Must().Be(pair.TestArgument, message),
            "testArgument");
    }

    [Fact]
    public void Test_Must_NotBe()
    {
        var pair = DummyData.GetIntPair();

        TestContract<int, IntContract, ArgumentOutOfRangeException>(
            pair.DifferentArgument,
            pair.TestArgument,
            (testArgument, message) => testArgument.Must().NotBe(pair.TestArgument, message),
            "testArgument");
    }

    [Fact]
    public void Test_Must_BeAnyOf()
    {
        var pair = DummyData.GetIntPair();
        var array = DummyData.GetArray(() => DummyData.GetInt(), pair.TestArgument, pair.DifferentArgument);

        TestContract<int, IntContract, ArgumentOutOfRangeException>(
            pair.TestArgument,
            pair.DifferentArgument,
            (testArgument, message) =>
                message == null ? testArgument.Must().BeAnyOf(array) : testArgument.Must().BeAnyOf(message, array),
            "testArgument");
    }

    [Fact]
    public void Test_Must_NotBeAnyOf()
    {
        var pair = DummyData.GetIntPair();
        var array = DummyData.GetArray(() => DummyData.GetInt(), pair.TestArgument, pair.DifferentArgument);

        TestContract<int, IntContract, ArgumentOutOfRangeException>(
            pair.DifferentArgument,
            pair.TestArgument,
            (testArgument, message) =>
                message == null
                    ? testArgument.Must().NotBeAnyOf(array)
                    : testArgument.Must().NotBeAnyOf(message, array),
            "testArgument");
    }

    [Fact]
    public void Test_Must_BeBetween()
    {
        var success = DummyData.GetInt();
        var lower = success - 10;
        var higher = success + 10;
        var outOfRange = higher + 10;

        TestContract<int, IntContract, ArgumentOutOfRangeException>(
            success,
            outOfRange,
            (testArgument, message) =>
                testArgument.Must().BeBetween(lower, higher, message),
            "testArgument");
    }

    [Fact]
    public void Test_Must_BeGreaterThan()
    {
        var success = DummyData.GetInt();
        var lower = success - 10;
        var outOfRange = lower - 10;

        TestContract<int, IntContract, ArgumentOutOfRangeException>(
            success,
            outOfRange,
            (testArgument, message) =>
                testArgument.Must().BeGreaterThan(lower, message),
            "testArgument");
    }

    [Fact]
    public void Test_Must_BeGreaterOrEqualThan()
    {
        var success = DummyData.GetInt();
        var outOfRange = success - 10;

        TestContract<int, IntContract, ArgumentOutOfRangeException>(
            success,
            outOfRange,
            (testArgument, message) =>
                testArgument.Must().BeGreaterOrEqualTo(success, message),
            "testArgument");
    }

    [Fact]
    public void Test_Must_BeLessThan()
    {
        var success = DummyData.GetInt();
        var higher = success + 10;
        var outOfRange = higher + 10;

        TestContract<int, IntContract, ArgumentOutOfRangeException>(
            success,
            outOfRange,
            (testArgument, message) =>
                testArgument.Must().BeLessThan(higher, message),
            "testArgument");
    }

    [Fact]
    public void Test_Must_BeLessOrEqualThan()
    {
        var success = DummyData.GetInt();
        var outOfRange = success + 10;

        TestContract<int, IntContract, ArgumentOutOfRangeException>(
            success,
            outOfRange,
            (testArgument, message) =>
                testArgument.Must().BeLessOrEqualTo(success, message),
            "testArgument");
    }
    
    [Fact]
    public void Test_Must_BeZero()
    {
        TestContract<int, IntContract, ArgumentOutOfRangeException>(
            0,
            42,
            (testArgument, message) =>
                testArgument.Must().BeZero(message),
            "testArgument");
        
        
        TestContract<int?, NullableIntContract, ArgumentOutOfRangeException>(
            0,
            42,
            (testArgument, message) =>
                testArgument.Must().BeZero(message),
            "testArgument");
    }
    
    [Fact]
    public void Test_Must_NotBeZero()
    {
        TestContract<int, IntContract, ArgumentOutOfRangeException>(
            69,
            0,
            (testArgument, message) =>
                testArgument.Must().NotBeZero(message),
            "testArgument");
        
        
        TestContract<int?, NullableIntContract, ArgumentOutOfRangeException>(
            69,
            0,
            (testArgument, message) =>
                testArgument.Must().NotBeZero(message),
            "testArgument");
    }

    [Fact]
    public void Test_Must_BePositive()
    {
        var success = DummyData.GetInt(NumberOption.Positive);
        var fail = DummyData.GetInt(NumberOption.Negative);

        TestContract<int, IntContract, ArgumentOutOfRangeException>(
            success,
            fail,
            (testArgument, message) =>
                testArgument.Must().BePositive(message),
            "testArgument");
    }

    [Fact]
    public void Test_Must_NotBePositive()
    {
        var success = DummyData.GetInt(NumberOption.Negative);
        var fail = DummyData.GetInt(NumberOption.Positive);

        TestContract<int, IntContract, ArgumentOutOfRangeException>(
            success,
            fail,
            (testArgument, message) =>
                testArgument.Must().NotBePositive(message),
            "testArgument");
    }

    [Fact]
    public void Test_Must_BeNegative()
    {
        var success = DummyData.GetInt(NumberOption.Negative);
        var fail = DummyData.GetInt(NumberOption.Positive);

        TestContract<int, IntContract, ArgumentOutOfRangeException>(
            success,
            fail,
            (testArgument, message) =>
                testArgument.Must().BeNegative(message),
            "testArgument");
    }

    [Fact]
    public void Test_Must_NotBeNegative()
    {
        var success = DummyData.GetInt(NumberOption.Positive);
        var fail = DummyData.GetInt(NumberOption.Negative);

        TestContract<int, IntContract, ArgumentOutOfRangeException>(
            success,
            fail,
            (testArgument, message) =>
                testArgument.Must().NotBeNegative(message),
            "testArgument");
    }
}