using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library.Web.Controllers;
using System.Net.Http;
using Newtonsoft.Json;
using Library.Core.Shared;

namespace Library.Tests.Controllers
{
    [TestClass]
    public class LibraryControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            LibraryController controller = new LibraryController();

            // Act
            HttpResponseMessage response = controller.Get();
            IEnumerable<Book> result = JsonConvert.DeserializeObject<IEnumerable<Book>>(response.Content.ReadAsStringAsync().Result);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(5, result.Count());
        }

        [TestMethod]
        public void GetByTypeAuthor()
        {
            // Arrange
            LibraryController controller = new LibraryController();

            // Act
            int type = (int)EntityType.Author;
            HttpResponseMessage response = controller.Get(type);
            IEnumerable<Author> result = JsonConvert.DeserializeObject<IEnumerable<Author>>(response.Content.ReadAsStringAsync().Result);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count());
        }

        [TestMethod]
        public void GetByTypeClient()
        {
            // Arrange
            LibraryController controller = new LibraryController();

            // Act
            int type = (int)EntityType.Author;
            HttpResponseMessage response = controller.Get(type);
            IEnumerable<Client> result = JsonConvert.DeserializeObject<IEnumerable<Client>>(response.Content.ReadAsStringAsync().Result);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count());
        }
    }
}
