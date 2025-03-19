// int counter = 0;
// async Task IncrementCounterAsync()
// {
//     for (int i = 0; i < 1000; i++)
//     {
//         await Task.Delay(1);
//         counter++;
//     }
// }
// int numberOfTasks = 10;
// Task[] tasks = new Task[numberOfTasks];
// for (int i = 0; i < numberOfTasks; i++)
// {
//     tasks[i] = IncrementCounterAsync();
// }
// await Task.WhenAll(tasks);
// Console.WriteLine(counter);

// Console.WriteLine("Expected counter value: " + (numberOfTasks * 1000));
// Console.WriteLine("Actual counter value: " + counter);



// int counter = 0;
// object lockObject = new object();
// async Task IncrementCounterAsync()
// {
//     for (int i = 0; i < 1000; i++)
//     {
//         await Task.Delay(1);
//         lock (lockObject)
//         {
//         counter++;
//             }
//                 }
// }
// int numberOfTasks = 10;
// Task[] tasks = new Task[numberOfTasks];
// for (int i = 0; i < numberOfTasks; i++)
// {
//     tasks[i] = IncrementCounterAsync();
// }
// await Task.WhenAll(tasks);
// Console.WriteLine(counter);

// Console.WriteLine("Expected counter value: " + (numberOfTasks * 1000));
// Console.WriteLine("Actual counter value: " + counter);

