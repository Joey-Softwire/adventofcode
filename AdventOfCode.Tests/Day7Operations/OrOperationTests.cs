﻿using AdventOfCode.Day7Operations;
using System;
using Xunit;

namespace AdventOfCode.Tests.Day7Operations
{
    public class OrOperationTests
    {
        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(1, 0, 1)]
        [InlineData(0, 1, 1)]
        [InlineData(0, 0, 0)]
        public void Or(UInt16 left, UInt16 right, UInt16 expected)
        {
            var operation = new OrOperation(new Constant(left), new Constant(right));
            var actual = operation.Calculate();

            Assert.Equal(expected, actual);
        }
    }
}