using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SmalltalkBooleans.Tests
{
    public class FalseTests
    {
        private bool _actionWasCalled;
        private readonly int _five = 5;

        [Fact]
        public void IfTrueDoesntExecuteAction()
        {
            (_five > 10).IfTrue(() => SpyAction());

            Assert.False(_actionWasCalled, "Action should not have been called");
        }

        [Fact]
        public void IfFalseExecutesAction()
        {
            (_five > 10).IfFalse(() => SpyAction());

            Assert.True(_actionWasCalled, "Action should have been called");
        }

        [Fact]
        public void NotReturnsBooleanOfTypeTrue()
        {
            var result = (_five > 10).Not();

            Assert.IsType<True>(result);
        }

        [Fact]
        public void IfTrueDoesntExecuteActionWhenOrExpressionIsFalse()
        {
            var result = (_five > 10).Or(_five > 15).IfTrue(() => SpyAction());

            Assert.False(_actionWasCalled, "Action should not have been called");
        }

        [Fact]
        public void IfTrueExecutesActionWhenOrExpressionIsTrue()
        {
            var result = (_five > 10).Or(_five > 2).IfTrue(() => SpyAction());

            Assert.True(_actionWasCalled, "Action should have been called");
        }

        [Fact]
        public void IfTrueDoesntExecuteActionWhenAndExpressionIsFalse()
        {
            var result = (_five > 10).And(_five > 15).IfTrue(() => SpyAction());

            Assert.False(_actionWasCalled, "Action should not have been called");
        }

        [Fact]
        public void IfTrueDoesntExecuteActionWhenAndExpressionIsTrue()
        {
            var result = (_five > 10).And(_five > 2).IfTrue(() => SpyAction());

            Assert.False(_actionWasCalled, "Action should not have been called");
        }

        private void SpyAction()
        {
            _actionWasCalled = true;
        }
    }
}
