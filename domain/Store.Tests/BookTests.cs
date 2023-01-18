using System;
using System.Security.Cryptography.X509Certificates;
using Xunit;

namespace Store.Tests
{
    public class BookTests
    {
        [Fact]
        public void IsIsbn_WithNull_ReturnFalse()
        {
            bool actual = Book.IsIsbn(null);

            Assert.False(actual);
        }
        [Fact]
        public void IsIsbn_WithBlankString_ReturnFalse()
        {
            bool actual = Book.IsIsbn("    ");

            Assert.False(actual);
        }
        [Fact]
        public void IsIsbn_WithInvalidIsbn_ReturnFalse()
        {
            bool actual = Book.IsIsbn("ISBN 123");

            Assert.False(actual);
        }
        [Fact]
        public void IsIsbn_WithIsbn13_ReturnFalse()
        {
            bool actual = Book.IsIsbn("IsBN 123-456-789 0123");

            Assert.True(actual);
        }
        [Fact]
        public void IsIsbn_WithTrashStart_ReturnFalse()
        {
            bool actual = Book.IsIsbn("xxx IsBN 123-456-789 0123 yyy");

            Assert.False(actual);
        }
    }

}
