using TransactionSample;
var transactionIds = FileProcessor.ReadExcel(Directory.GetCurrentDirectory() + "/transactionLogs.xlsx");

Parallel.ForEach(transactionIds, FileProcessor.CreateDirectory);