using PlaygroundConsole.Services.Interface;

namespace PlaygroundConsole.Services;

// 實際在主程式使用的服務
public class NumberService : INumberService
{
    // 核心邏輯是取得數字，使用 Random 來假設會被外界影響
    public int GetNumber()
    {
        Random random = new Random();
        int result = random.Next();
        return result;
    }
}

// 提供給單元測試使用，不受外界影響的服務
public class FakeNumberService : INumberService
{
    // 永遠回傳同一個數字，使測試能夠保持結果一致性
    public int GetNumber()
    {
        int result = 200;
        return result;
    }
}