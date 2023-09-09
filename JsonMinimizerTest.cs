namespace JsonMinimizerTest
{
    [TestClass]
    public class JsonMinimizerTest
    {
        [TestMethod]
        public void TestMethod()
        {
            String json = @"{""name"": ""John"", ""age"": 20}";
            JsonMinimizer.JsonMinimizer jsonMinimizer = new JsonMinimizer.JsonMinimizer(json);
            jsonMinimizer.Minimize();
            String minimizedJson = jsonMinimizer.getString();
        }
    }
}