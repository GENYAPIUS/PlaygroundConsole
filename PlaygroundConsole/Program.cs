// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using PlaygroundConsole;
using PlaygroundConsole.Models;
using PlaygroundConsole.Services;

Console.WriteLine("Hello, World!");

// SampleClass 需要引入的是有實作 INumberService 介面的 Class，因為 NumberService 與 FakeNumberService 都有實作 INumberService 介面，故都可以引入，達成可抽換的目的，也使單元測試可以使用假資料的類別來提高可測試性
SampleClass sampleInstance = new SampleClass(new NumberService());
SampleClass sampleInstance2 = new SampleClass(new FakeNumberService());


// 如何使用 System.Text.Json.JsonSerializer 來映射到型別是 JsonModel 或 IEnumerable<JsonModel> 的變數中

// 使用 File.OpenRead 來讀取檔案，記得要把 .json 檔複製到編譯後的資料夾中，否則開啟 Debug 時會找不到檔案
using FileStream jsonStream = File.OpenRead("Data.json");

// 使用 System.Text.Json.JsonSerializer.Deserialize<>() 來映射，此處使用 IEnumerable<JsonModel>
IEnumerable<JsonModel> json = JsonSerializer.Deserialize<IEnumerable<JsonModel>>(jsonStream);

// IEnumerable<> 可以使用 foreach 來逐筆讀取
foreach (var item in json)
// 逐筆讀取並印出在 Console 畫面中
    Console.WriteLine($"{item.Id}, {item.Name}, {item.Address}");