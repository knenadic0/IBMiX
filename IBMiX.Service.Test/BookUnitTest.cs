using Autofac;
using AutoMapper;
using AutoMapper.Contrib.Autofac.DependencyInjection;
using IBMiX.Model;
using IBMiX.Repository;
using IBMiX.Repository.Common;
using IBMiX.Service.Common;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBMiX.Service.Test
{
    public class BookUnitTest : TestBase
    {
        [Fact]
        public void TestGetBooksCount()
        {
            var service = Scope.Resolve<IBookService>();

            var count = service.GetBooks().Count;

            Assert.Equal(12, count);
        }

        [Fact]
        public void TestBorrowBook()
        {
            var service = Scope.Resolve<IBookService>();
            var repository = Scope.Resolve<IBookRepository>();
            var userRepository = Scope.Resolve<IUserRepository>();
            var user = userRepository.GetUser(1);
            var book = repository.GetBook("bk102");

            var success = service.BorrowBook("bk102", 1);

            Assert.True(success);
            Assert.Equal(user, book.Borrowed);
            Assert.Single(user.Books);
        }

        [Fact]
        public void TestReturnBook()
        {
            var service = Scope.Resolve<IBookService>();
            var repository = Scope.Resolve<IBookRepository>();
            var userRepository = Scope.Resolve<IUserRepository>();
            var user = userRepository.GetUser(1);
            var book = repository.GetBook("bk102");

            service.BorrowBook("bk102", 1);
            var success = service.ReturnBook("bk102");

            Assert.True(success);
            Assert.Null(book.Borrowed);
            Assert.Empty(user.Books);
        }
    }
}
