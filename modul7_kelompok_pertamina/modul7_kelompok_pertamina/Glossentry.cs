using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class GlossDef
{
    public string para { get; set; }
    public List<string> GlossSeeAlso { get; set; }
}

public class GlossEntry
{
    public string ID { get; set; }
    public string SortAs { get; set; }
    public string GlossTerm { get; set; }
    public string Acronym { get; set; }
    public string Abbrev { get; set; }
    public GlossDef GlossDef { get; set; }
    public string GlossSee { get; set; }
}

public class GlossList
{
    public GlossEntry GlossEntry { get; set; }
}

public class GlossDiv
{
    public string title { get; set; }
    public GlossList GlossList { get; set; }
}

public class Glossary
{
    public string title { get; set; }
    public GlossDiv GlossDiv { get; set; }
}

public class Root
{
    public Glossary glossary { get; set; }
}

public class DataGlossary_1201210018
{
    public void ReadJSON(string filePath)
    {
        string jsonContent = File.ReadAllText(filePath);

        Root rootObject = JsonSerializer.Deserialize<Root>(jsonContent);

        var entry = rootObject.glossary.GlossDiv.GlossList.GlossEntry;

        Console.WriteLine("=== GlossEntry Detail ===");
        Console.WriteLine($"ID: {entry.ID}");
        Console.WriteLine($"SortAs: {entry.SortAs}");
        Console.WriteLine($"GlossTerm: {entry.GlossTerm}");
        Console.WriteLine($"Acronym: {entry.Acronym}");
        Console.WriteLine($"Abbrev: {entry.Abbrev}");
        Console.WriteLine($"GlossDef: {entry.GlossDef.para}");
        Console.WriteLine("GlossSeeAlso: " + string.Join(", ", entry.GlossDef.GlossSeeAlso));
        Console.WriteLine($"GlossSee: {entry.GlossSee}");
    }
}
