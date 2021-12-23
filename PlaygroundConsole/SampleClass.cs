using PlaygroundConsole.Interfaces;
using PlaygroundConsole.Services.Interface;

namespace PlaygroundConsole;

public class SampleClass : ISampleClass
{
    // 讓 SampleClass 與 INumberService 相依
    private readonly INumberService _numberService;

    // 在建構式引入 INumberService 並初始化 SampleClass 的 _numberService
    public SampleClass(INumberService numberService)
    {
        _numberService = numberService;
    }

    // SampleClass 的 Get() 使用 _numberService.GetNumber() 並回傳藉由 _numberService.GetNumber() 所得到的結果
    public int Get()
    {
        var result = _numberService.GetNumber();
        return result;
    }
}