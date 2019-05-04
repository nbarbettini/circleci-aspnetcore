using System;
using Xunit;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void True_is_true() => Assert.True(true);

        [Fact]
        public void True_is_false() => Assert.True(false);

    }
}
