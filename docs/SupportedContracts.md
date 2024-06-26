# Supported Contracts

> Note: Check the [CHANGELOG](../CHANGELOG.md) to see which of the methods below are released and which ones are still in the making.

## `Base`

- `Satisfy`

## `Nullable` (extends `Base`)

- `(Not)BeNull`

## `Equality` (extends `Nullable`)

- `(Not)Be`
- `(Not)BeAnyOf`

## `Collection` (extends `Equality`)

- `(Not)BeEmpty`
- `(Not)HaveCountEqualTo`
- `HaveCountBetween`
- `HaveCountGreaterOrEqualTo`
- `HaveCountGreaterThan`
- `HaveCountLessOrEqualTo`
- `HaveCountLessThan`

## `Comparable` (extends `Equality`)

- `BeBetween`
- `BeGreaterOrEqualTo`
- `BeGreaterThan`
- `BeLessOrEqualTo`
- `BeLessThan`

## `Char` (extends `Nullable`)

- `(Not)Be`
- `(Not)BeAlphanumeric`
- `(Not)BeAnyOf`
- `(Not)BeAscii`
- `(Not)BeDigit`
- `(Not)BeLetter`
- `(Not)BeLowercase`
- `(Not)BeUppercase`
- `(Not)BeWhiteSpace`
- `BeBetween`
- `BeGreaterOrEqualTo`
- `BeGreaterThan`
- `BeLessOrEqualTo`
- `BeLessThan`

## `String` (extends `Comparable`)

- `(Not)BeAlphanumeric`
- `(Not)BeBase64`
- `(Not)BeCreditCardNumber`
- `(Not)BeEmailAddress`
- `(Not)BeEmpty`
- `(Not)BeExistingDirectory`
- `(Not)BeExistingFile`
- `(Not)BeGuid`
- `(Not)BeHexadecimal`
- `(Not)BeIpAddress`
- `(Not)BeLowercase`
- `(Not)BeMatching`
- `(Not)BeNullOrEmpty`
- `(Not)BeNullOrWhiteSpace`
- `(Not)BePalindrome`
- `(Not)BeUppercase`
- `(Not)BeUrl`
- `(Not)BeWhiteSpace`
- `(Not)Contain`
- `(Not)EndWith`
- `(Not)HaveLengthEqualTo`
- `(Not)StartWith`
- `HaveLengthBetween`
- `HaveLengthGreaterOrEqualTo`
- `HaveLengthGreaterThan`
- `HaveLengthLessOrEqualTo`
- `HaveLengthLessThan`

## `Bool` (extends `Nullable`)

- `(Not)Be`
- `(Not)BeAnyOf`
- `BeFalse`
- `BeTrue`

## `DateTime` (extends `Base`)

- `(Not)Be`
- `(Not)BeAnyOf`
- `(Not)BeFriday`
- `(Not)BeInApril`
- `(Not)BeInAugust`
- `(Not)BeInCurrentMonth`
- `(Not)BeInCurrentYear`
- `(Not)BeInDaylightSaving`
- `(Not)BeInDecember`
- `(Not)BeInFebruary`
- `(Not)BeInJanuary`
- `(Not)BeInJuly`
- `(Not)BeInJune`
- `(Not)BeInMarch`
- `(Not)BeInMay`
- `(Not)BeInMonth`
- `(Not)BeInNovember`
- `(Not)BeInOctober`
- `(Not)BeInSeptember`
- `(Not)BeInTheFuture`
- `(Not)BeInThePast`
- `(Not)BeInYear`
- `(Not)BeLeapYear`
- `(Not)BeLocal`
- `(Not)BeMonday`
- `(Not)BeNull`
- `(Not)BeOnCurrentDay`
- `(Not)BeOnDate`
- `(Not)BeOnDay`
- `(Not)BeOnDayOfYear`
- `(Not)BeSaturday`
- `(Not)BeSunday`
- `(Not)BeThursday`
- `(Not)BeToday`
- `(Not)BeTomorrow`
- `(Not)BeTuesday`
- `(Not)BeUtc`
- `(Not)BeWednesday`
- `(Not)BeWeekday`
- `(Not)BeWeekend`
- `(Not)BeYesterday`
- `BeBetween`
- `BeGreaterOrEqualTo`
- `BeGreaterThan`
- `BeLessOrEqualTo`
- `BeLessThan`

## `Enum` (extends `Nullable`)

- `(Not)Be`
- `(Not)BeAnyOf`
- `(Not)HaveFlag`

## `Guid` (extends `Nullable`)

- `(Not)Be`
- `(Not)BeAnyOf`
- `(Not)BeEmpty`
- `BeBetween`
- `BeGreaterOrEqualTo`
- `BeGreaterThan`
- `BeLessOrEqualTo`
- `BeLessThan`

## `Stream` (extends `Nullable`)

- `(Not)BeAbleToTimeout`
- `(Not)BeAtPosition`
- `(Not)BeReadable`
- `(Not)BeSeekable`
- `(Not)BeWithLength`
- `(Not)BeWriteable`

## `Byte` (extends `Nullable`)

- `(Not)Be`
- `(Not)BeAnyOf`
- `(Not)BeZero`
- `BeBetween`
- `BeGreaterOrEqualTo`
- `BeGreaterThan`
- `BeLessOrEqualTo`
- `BeLessThan`

## `Decimal` (extends `Nullable`)

- `(Not)Be`
- `(Not)BeAnyOf`
- `(Not)BeNegative`
- `(Not)BePositive`
- `(Not)BeZero`
- `BeBetween`
- `BeGreaterOrEqualTo`
- `BeGreaterThan`
- `BeLessOrEqualTo`
- `BeLessThan`

## `Double` (extends `Nullable`)

- `(Not)Be`
- `(Not)BeAnyOf`
- `(Not)BeNegative`
- `(Not)BePositive`
- `(Not)BeZero`
- `BeBetween`
- `BeGreaterOrEqualTo`
- `BeGreaterThan`
- `BeLessOrEqualTo`
- `BeLessThan`

## `Float` (extends `Nullable`)

- `(Not)Be`
- `(Not)BeAnyOf`
- `(Not)BeNegative`
- `(Not)BePositive`
- `(Not)BeZero`
- `BeBetween`
- `BeGreaterOrEqualTo`
- `BeGreaterThan`
- `BeLessOrEqualTo`
- `BeLessThan`

## `Int` (extends `Nullable`)

- `(Not)Be`
- `(Not)BeAnyOf`
- `(Not)BeNegative`
- `(Not)BePositive`
- `(Not)BeZero`
- `BeBetween`
- `BeGreaterOrEqualTo`
- `BeGreaterThan`
- `BeLessOrEqualTo`
- `BeLessThan`

## `Long` (extends `Nullable`)

- `(Not)Be`
- `(Not)BeAnyOf`
- `(Not)BeNegative`
- `(Not)BePositive`
- `(Not)BeZero`
- `BeBetween`
- `BeGreaterOrEqualTo`
- `BeGreaterThan`
- `BeLessOrEqualTo`
- `BeLessThan`

## `Sbyte` (extends `Nullable`)

- `(Not)Be`
- `(Not)BeAnyOf`
- `(Not)BeNegative`
- `(Not)BePositive`
- `(Not)BeZero`
- `BeBetween`
- `BeGreaterOrEqualTo`
- `BeGreaterThan`
- `BeLessOrEqualTo`
- `BeLessThan`

## `Short` (extends `Nullable`)

- `(Not)Be`
- `(Not)BeAnyOf`
- `(Not)BeNegative`
- `(Not)BePositive`
- `(Not)BeZero`
- `BeBetween`
- `BeGreaterOrEqualTo`
- `BeGreaterThan`
- `BeLessOrEqualTo`
- `BeLessThan`

## `Uint` (extends `Nullable`)

- `(Not)Be`
- `(Not)BeAnyOf`
- `(Not)BeZero`
- `BeBetween`
- `BeGreaterOrEqualTo`
- `BeGreaterThan`
- `BeLessOrEqualTo`
- `BeLessThan`

## `Ulong` (extends `Nullable`)

- `(Not)Be`
- `(Not)BeAnyOf`
- `(Not)BeZero`
- `BeBetween`
- `BeGreaterOrEqualTo`
- `BeGreaterThan`
- `BeLessOrEqualTo`
- `BeLessThan`

## `Ushort` (extends `Nullable`)

- `(Not)Be`
- `(Not)BeAnyOf`
- `(Not)BeZero`
- `BeBetween`
- `BeGreaterOrEqualTo`
- `BeGreaterThan`
- `BeLessOrEqualTo`
- `BeLessThan`

## `List` (extends `Collection`)

- `(Not)Contain`
- `HaveElementsOfType`
