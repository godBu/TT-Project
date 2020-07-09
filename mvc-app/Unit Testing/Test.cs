using System;
using System.Linq;
using mvc_app.Controllers;
using Xunit;

namespace mvc_app.UnitTesting
{
    public class Tests
    {
        [Fact]

        public void GetAllTest()
        {
            var controller = new MovieController();
            var result = controller.Get();
            Assert.Equal(3, result.Count());
        }
    }
}
        //[Fact]

        //public void AddTest()
        //{
        //    var controller = new MovieController();
        //    var resulty = (result + 1);
        //    Assert.Equal(4, resulty.Count());
        //}

        //[Fact]

        //public void UpdateTest()
        //{
        //    var controller = new MovieController();
        //    var result = controller.UpdateMovies();
        //    Assert.Equal(4, result.Count());
        //}

        //[Fact]

        //public void DeleteTest()
        //{
        //    var controller = new MovieController();
        //    var result = controller.Delete();
        //    Assert.Equal(4, result.Count());
        //}
//    }
//}