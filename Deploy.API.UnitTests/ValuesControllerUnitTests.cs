using System;
using Deploy.API.Controllers;
using FluentAssertions;
using Moq;
using Xunit;

namespace Deploy.API.UnitTests
{
    public class ValuesControllerUnitTests
    {

        private ValuesController GetValuesController()
        {
            return new ValuesController();
        }

        [Fact]
        public void Get_ReturnRigthMyVersion()
        {
            var controller = GetValuesController();
            var response = controller.Get();

            var result = response.Value;

            result.Should().Be("hello My V1.0");
            
        }

        [Fact]
        public void Get_ReturnRigthOne()
        {
            var controller = GetValuesController();
            var response = controller.Get(1);

            var result = response.Value;

            result.Should().Be("value-1");

        }
    }
}
