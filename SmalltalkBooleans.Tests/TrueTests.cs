using System;
using SmalltalkBooleans;
using Xunit;


namespace SmalltalkBooleans.Tests
{
    public class TrueTests
    {
        private bool _actionWasCalled;
        private readonly int _five = 5;

        [Fact]
        public void IfTrueExecutesAction()
        {
            (_five > 1).IfTrue(() => SpyAction());

            Assert.True(_actionWasCalled, "Action should have been called");
        }

        [Fact]
        public void IfFalseDoesntExecuteAction()
        {
            (_five > 1).IfFalse(() => SpyAction());

            Assert.False(_actionWasCalled, "Action should not have been called");
        }

        [Fact]
        public void NotReturnsBooleanOfTypeFalse()
        {
            var result = (_five > 1).Not();

            Assert.IsType<False>(result);
        }

        [Fact]
        public void IfTrueExecutesActionWhenOrExpressionIsFalse()
        {
            var result = (_five > 1).Or(_five > 10).IfTrue(() => SpyAction());

            Assert.True(_actionWasCalled, "Action should have been called");
        }

        [Fact]
        public void IfTrueExecutesActionWhenOrExpressionIsTrue()
        {
            var result = (_five > 1).Or(_five > 2).IfTrue(() => SpyAction());

            Assert.True(_actionWasCalled, "Action should have been called");
        }

        [Fact]
        public void IfTrueDoesntExecuteActionWhenAndExpressionIsFalse()
        {
            var result = (_five > 1).And(_five > 10).IfTrue(() => SpyAction());

            Assert.False(_actionWasCalled, "Action should not have been called");
        }

        [Fact]
        public void IfTrueExecutesActionWhenAndExpressionIsTrue()
        {
            var result = (_five > 1).And(_five > 2).IfTrue(() => SpyAction());

            Assert.True(_actionWasCalled, "Action should have been called");
        }

        private void SpyAction()
        {
            _actionWasCalled = true;
        }
    }
}
