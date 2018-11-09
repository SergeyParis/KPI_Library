using Library.Core.Shared;
using Library.Web.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Library.Tests.Library.Core
{
    [TestClass]
    public class ModelEFTest
    {
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void BookModel_should_throw_exception_if_author_is_null()
        {
            // Act
            Book book = new Book("test", "test", null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void BookModel_should_throw_exception_if_name_is_empty_string()
        {
            // Act
            Book book = new Book("", "test", new Author());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void BookModel_should_throw_exception_if_ISBN_is_empty_string()
        {
            // Act
            Book book = new Book("test", "", new Author());
        }

    }
}
