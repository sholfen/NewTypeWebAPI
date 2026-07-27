using DataRepository;

namespace NewTypeTestProject
{
    public class DBToolUnitTest
    {
        [Fact]
        public void LoadSQLtoCacheTest()
        {
            DBTools.LoadSQLtoCache();
            //DBTools.GetSQL()
        }

        [Fact]
        public void LoadSQLtoCacheTest2()
        {
            DBTools.LoadSQLtoCache();
            GetSQLCommandTest();
        }

        [Fact]
        public void GetSQLCommandTest()
        {
            string id = "Employee";
            string key = "Select";
            string command = DBTools.GetSQL(id, key);
            if (string.IsNullOrEmpty(command))
            {
                Assert.Fail("command is null");
                return;
            }
            Assert.True(true);
            Console.WriteLine($"SQL Command is: {command}");
        }
    }
}