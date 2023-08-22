using Npoi.Mapper;

namespace TransactionSample;

public static class FileProcessor
{
    public static IEnumerable<string> ReadExcel(string fileName)
    {
        var importer = new Mapper(fileName);

        var items = importer.Take<TransactionSampleDto>(0);

        foreach (var item in items)
        {
            var row = item.Value;
            yield return row.TransactionId!;
        }
    }

    public static void CreateDirectory(string directoryName)
    {
        if (Directory.Exists("D:/dotnet/TransactionSample/TransactionSample/data/" + directoryName))
        {
            Console.WriteLine("Found existing and deleting");
            Directory.Delete("D:/dotnet/TransactionSample/TransactionSample/data/" + directoryName);
        }
        Directory.CreateDirectory("D:/dotnet/TransactionSample/TransactionSample/data/" + directoryName);
        Console.WriteLine($"Created new directory for transaction Id {directoryName}");
    }
}