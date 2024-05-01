using System;
using FluentContracts.Contracts.Numeric;
using FluentContracts.Tests.Mocks;
using FluentContracts.Tests.TestAttributes;
using Xunit;

namespace FluentContracts.Tests.Numerics;

[ContractTest("Sbyte")]
public class SbyteContractTests : Tests
{
    [Fact]
    public void Test_Must_BeNull()
    {
        TestContract<sbyte?, NullableSbyteContract, ArgumentOutOfRangeException>(
            null,
            DummyData.GetSbyte(),
            (testArgument, message) => testArgument.Must().BeNull(message),
            "testArgument");
    }

    [Fact]
    public void Test_Must_NotBeNull()
    {
        TestContract<sbyte?, NullableSbyteContract, ArgumentNullException>(
            DummyData.GetSbyte(),
            null,
            (testArgument, message) => testArgument.Must().NotBeNull(message),
            "testArgument");
    }

    [Fact]
    public void Test_Must_Be()
    {
        var pair = DummyData.GetSbytePair();

        TestContract<sbyte, SbyteContract, ArgumentOutOfRangeException>(
            pair.TestArgument,
            pair.DifferentArgument,
            (testArgument, message) => testArgument.Must().Be(pair.TestArgument, message),
            "testArgument");
    }

    [Fact]
    public void Test_Must_NotBe()
    {
        var pair = DummyData.GetSbytePair();

        TestContract<sbyte, SbyteContract, ArgumentOutOfRangeException>(
            pair.DifferentArgument,
            pair.TestArgument,
            (testArgument, message) => testArgument.Must().NotBe(pair.TestArgument, message),
            "testArgument");
    }

    [Fact]
    public void Test_Must_BeAnyOf()
    {
        var pair = DummyData.GetSbytePair();
        var array = DummyData.GetArray(DummyData.GetSbyte, pair.TestArgument, pair.DifferentArgument);

        TestContract<sbyte, SbyteContract, ArgumentOutOfRangeException>(
            pair.TestArgument,
            pair.DifferentArgument,
            (testArgument, message) =>
                message == null ? testArgument.Must().BeAnyOf(array) : testArgument.Must().BeAnyOf(message, array),
            "testArgument");
    }

    [Fact]
    public void Test_Must_NotBeAnyOf()
    {
        var pair = DummyData.GetSbytePair();
        var array = DummyData.GetArray(DummyData.GetSbyte, pair.TestArgument, pair.DifferentArgument);

        TestContract<sbyte, SbyteContract, ArgumentOutOfRangeException>(
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
        var success = DummyData.GetSbyte();
        var lower = (sbyte)(success - 10);
        var higher = (sbyte)(success + 10);
        var outOfRange = (sbyte)(higher + 10);

        TestContract<sbyte, SbyteContract, ArgumentOutOfRangeException>(
            success,
            outOfRange,
            (testArgument, message) =>
                testArgument.Must().BeBetween(lower, higher, message),
            "testArgument");
    }

    [Fact]
    public void Test_Must_BeGreaterThan()
    {
        var success = DummyData.GetSbyte();
        var lower = (sbyte)(success - 10);
        var outOfRange = (sbyte)(lower - 10);

        TestContract<sbyte, SbyteContract, ArgumentOutOfRangeException>(
            success,
            outOfRange,
            (testArgument, message) =>
                testArgument.Must().BeGreaterThan(lower, message),
            "testArgument");
    }

    [Fact]
    public void Test_Must_BeGreaterOrEqualThan()
    {
        var success = DummyData.GetSbyte();
        var outOfRange = (sbyte)(success - 10);

        TestContract<sbyte, SbyteContract, ArgumentOutOfRangeException>(
            success,
            outOfRange,
            (testArgument, message) =>
                testArgument.Must().BeGreaterOrEqualTo(success, message),
            "testArgument");
    }

    [Fact]
    public void Test_Must_BeLessThan()
    {
        var success = DummyData.GetSbyte();
        var higher = (sbyte)(success + 10);
        var outOfRange = (sbyte)(higher + 10);

        TestContract<sbyte, SbyteContract, ArgumentOutOfRangeException>(
            success,
            outOfRange,
            (testArgument, message) =>
                testArgument.Must().BeLessThan(higher, message),
            "testArgument");
    }

    [Fact]
    public void Test_Must_BeLessOrEqualThan()
    {
        var success = DummyData.GetSbyte();
        var outOfRange = (sbyte)(success + 10);

        TestContract<sbyte, SbyteContract, ArgumentOutOfRangeException>(
            success,
            outOfRange,
            (testArgument, message) =>
                testArgument.Must().BeLessOrEqualTo(success, message),
            "testArgument");
    }
}