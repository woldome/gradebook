using System;
using Xunit;

namespace GradeBook.test
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
                //arrange
                
                var book = new GradeBook();
                book.addGrade(91.1);
                book.addGrade(19.6);
                book.addGrade(51.9);
                //act
                var stat = book.getStat();
                //assert
                Assert.Equal(19.6,stat.min,1);
                Assert.Equal(91.1,stat.max,1);
                Assert.Equal(54.2,stat.avg,1);
        }
    }
}
