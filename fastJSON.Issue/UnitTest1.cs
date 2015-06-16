namespace fastJSON.Issue
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Data.Entity;
    using System.Linq;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            PersonContext context =
                fastJSON.JSON.ToObject<PersonContext>(System.IO.File.OpenText(@"Resources\json1.json").ReadToEnd());
            Assert.AreEqual(((IQueryable<Person>)context.Persons).Count(), 3);
        }

        public class PersonContext
        {
            public IDbSet<Person> Persons { get; set; }
        }

        public class Person
        {
            public string FirstName { get; set; }
            public string Surname { get; set; }
        }
    }
}
