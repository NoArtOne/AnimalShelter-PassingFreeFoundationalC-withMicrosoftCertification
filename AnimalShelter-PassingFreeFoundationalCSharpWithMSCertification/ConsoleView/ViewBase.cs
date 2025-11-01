using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleView;
/// <summary>
/// Получить текста из json
/// </summary>
public abstract class ViewBase
{
    protected readonly Dictionary<string, string> root;

    protected ViewBase()
    {
        string jsonPath = Path.Combine(AppContext.BaseDirectory, "Resources", "Strings.en.json");
        var jsonText = File.ReadAllText(jsonPath);
        root = JsonSerializer.Deserialize<Dictionary<string, string>>(jsonText) ?? new Dictionary<string, string>();
    }

    protected string GetString(string key)
    {
        return root.TryGetValue(key, out var value) ? value : $"[{key} not found]";
    }
}
