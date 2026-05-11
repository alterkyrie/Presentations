// CancellationTokenSource source = new CancellationTokenSource();
// CancellationToken token = source.Token;
// Task.WaitAll(GetDataAsync(token), StopTaskAsync(source));

// async Task GetDataAsync(CancellationToken ct)
// {
//     await Task.Delay(5000, ct);
//     Console.WriteLine("Data loaded");
// }

// async Task StopTaskAsync(CancellationTokenSource source)
// {
//     await Task.Delay(1000);
//     Console.WriteLine("Canceled");
//     source.Cancel();

// }



