using AutoMapper;
using IBMiX.Service.Common;
using Moq;
using Xunit;
using IBMiX.Repository;
using Autofac;
using IBMiX.Model;
using AutoMapper.Contrib.Autofac.DependencyInjection;

namespace IBMiX.Service.Test
{
    public class UserUnitTest : TestBase
    {
        [Fact]
        public void TestGetUsersCount()
        {
            var service = Scope.Resolve<IUserService>();

            var count = service.GetUsers().Count;

            Assert.Equal(3, count);
        }
    }
}