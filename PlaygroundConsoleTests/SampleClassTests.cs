using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlaygroundConsole;
using PlaygroundConsole.Services;

namespace PlaygroundConsoleTests;

[TestClass]
public class SampleClassTests
{
    // 測試方法命名 => 方法名稱_核心邏輯_期望的回傳值

    /*
     * 此時這個測試一定測不了，由於每次 Get() 回傳的值會受外界影響而都不一樣，失去測試所需要的結果一致性與可測試性
     */
    [TestMethod]
    public void Get_取得數字_100()
    {
        // Arrange
        SampleClass sampleClass = new SampleClass(new NumberService());
        // Actual
        int actual = sampleClass.Get();
        // Assert
        int expected = 100;
        Assert.AreEqual(expected, actual);
    }

    /*
     * 抽換成使用假資料類別，使回傳值具有結果一致性，如此就能夠測試方法的核心邏輯
     */
    [TestMethod]
    public void Get_取得數字_200()
    {
        // Arrange
        SampleClass sampleClass = new SampleClass(new FakeNumberService());
        // Actual
        int actual = sampleClass.Get();
        // Assert
        int expected = 200;
        Assert.AreEqual(expected, actual);
    }
}