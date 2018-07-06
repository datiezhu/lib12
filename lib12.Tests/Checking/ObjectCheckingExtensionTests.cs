﻿using lib12.Checking;
using Shouldly;
using Xunit;

namespace lib12.Tests.Checking
{
    enum TestEnum
    {
        First,
        Second,
        Third,
        Fourth,
        Fifth
    }

    public class ObjectCheckingExtensionTests
    {
        [Fact]
        public void is_one_element_true()
        {
            var value = TestEnum.First;

            value.Is(TestEnum.First).ShouldBeTrue();
        }

        [Fact]
        public void is_one_element_false()
        {
            var value = TestEnum.First;

            value.Is(TestEnum.Second).ShouldBeFalse();
        }

        [Fact]
        public void is_in_collection_true()
        {
            var value = TestEnum.First;

            value.Is(TestEnum.First, TestEnum.Second, TestEnum.Fifth).ShouldBeTrue();
        }

        [Fact]
        public void is_in_collection_false()
        {
            var value = TestEnum.First;

            value.Is(TestEnum.Fourth, TestEnum.Second, TestEnum.Fifth).ShouldBeFalse();
        }

        [Fact]
        public void is_not_one_element_true()
        {
            var value = TestEnum.First;

            value.IsNot(TestEnum.Second).ShouldBeTrue();
        }

        [Fact]
        public void is_not_one_element_false()
        {
            var value = TestEnum.First;

            value.IsNot(TestEnum.First).ShouldBeFalse();
        }

        [Fact]
        public void is_not_in_collection_true()
        {
            var value = TestEnum.First;

            value.IsNot(TestEnum.Third, TestEnum.Second, TestEnum.Fifth).ShouldBeTrue();
        }

        [Fact]
        public void is_not_in_collection_false()
        {
            var value = TestEnum.First;

            value.IsNot(TestEnum.First, TestEnum.Second, TestEnum.Fifth).ShouldBeFalse();
        }

        [Fact]
        public void is_int_test()
        {
            4.IsNot(5, 6, 6).ShouldBeTrue();
        }

        [Fact]
        public void in_test()
        {
            var array = new[] { 3, 4, 12 };
            12.In(array).ShouldBeTrue();
        }

        [Fact]
        public void not_in_test()
        {
            var array = new[] { 3, 4, 12 };
            11.NotIn(array).ShouldBeTrue();
        }
    }
}