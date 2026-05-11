    // var result = await ProcessDataAsync("input", CancellationToken.None);
    // Console.WriteLine(result);

    // async Task<string> ProcessDataAsync(string input, CancellationToken ct)
    // {
    //     // Step 1: Start a nested asynchronous operation with multiple continuations.
    //     var step1 = Task.Run(() =>
    //     {
    //         // Start an inner task via Task.Factory.StartNew, then unwrap it.
    //         return Task.Factory.StartNew(async () =>
    //         {
    //             // Simulate a delay
    //             await Task.Delay(100, ct).ConfigureAwait(false);
    //             // Process the input in a simple way
    //             string intermediateResult = input + "-Processed";
    //             return intermediateResult;
    //         }, ct, TaskCreationOptions.AttachedToParent, TaskScheduler.Default)
    //         .Unwrap()
    //         // Continue with additional processing, executed synchronously.
    //         .ContinueWith(antecedent =>
    //         {
    //             if (antecedent.IsFaulted)
    //                 throw antecedent.Exception ?? new Exception("Step1 failure");
    //             return antecedent.Result + "-Step1";
    //         }, ct, TaskContinuationOptions.ExecuteSynchronously, TaskScheduler.Default);
    //     }, ct);  // Removed the outer .Unwrap()

    //     // Step 2: Create another task with nested continuations and error handling.
    //     var step2 = Task.Delay(50, ct).ContinueWith(async _ =>
    //     {
    //         try
    //         {
    //             await Task.Delay(50, ct).ConfigureAwait(false);
    //             return input + "-Delayed";
    //         }
    //         catch (Exception ex)
    //         {
    //             return "ErrorInStep2:" + ex.Message;
    //         }
    //     }, ct, TaskContinuationOptions.LongRunning, TaskScheduler.Default).Unwrap();

    //     // Step 3: Combine the results of step1 and step2 in a convoluted manner.
    //     var combined = Task.WhenAll(step1, step2).ContinueWith(async t =>
    //     {
    //         if (t.IsFaulted)
    //             throw new AggregateException("Combined step failed", t.Exception);
    //         var results = t.Result;
    //         // Join the results with a delimiter, then add another delay unnecessarily.
    //         string combinedResult = string.Join("||", results);
    //         await Task.Delay(10, ct).ConfigureAwait(false);
    //         return combinedResult;
    //     }, ct, TaskContinuationOptions.NotOnCanceled, TaskScheduler.Default).Unwrap();

    //     // Step 4: Await the final result.
    //     try
    //     {
    //         return await combined.ConfigureAwait(false);
    //     }
    //     catch (Exception e)
    //     {
    //         // Deeply nested exception handling that combines inner exception messages.
    //         return "Failure:" + e.InnerException?.Message + "-" + e.Message;
    //     }
    // }
    // async Task<string> ProcessDataAsyncSimplified(string input, CancellationToken ct)
    // {
    //     try
    //     {
    //         // Step 1: Simulate processing with a delay and append "-Processed-Step1"
    //         await Task.Delay(100, ct).ConfigureAwait(false);
    //         string step1 = input + "-Processed-Step1";

    //         // Step 2: Simulate a delay and append "-Delayed"
    //         await Task.Delay(100, ct).ConfigureAwait(false);
    //         string step2 = input + "-Delayed";

    //         // Step 3: Combine the two results after an additional delay
    //         await Task.Delay(10, ct).ConfigureAwait(false);
    //         return $"{step1}||{step2}";
    //     }
    //     catch (Exception e)
    //     {
    //         // Handle any errors and return a failure message
    //         return $"Failure: {e.Message}";
    //     }
    // }
