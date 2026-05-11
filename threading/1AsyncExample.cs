// async Task<string> CountUp(int stop)
// {
//     var x = 0;
//     while (x < stop)
//     {
//         Console.WriteLine("Up " + x);
//         await Task.Delay(1000);
//         x++;
//     }
//     return "Done";
// }

// async Task<string> CountDown(int n)
// {
//     while (n > 0)
//     {
//         Console.WriteLine("Down " + n);
//         await Task.Delay(1000);
//         n--;
//     }
//     return "Done";
// }

// // A
// // Task.WaitAll(CountUp(5), CountDown(5));
// // B
// // await CountUp(5);
// // await CountDown(5);
// // C
// // var x = new Thread(() => CountUp(5));
// // var y = new Thread(() => CountDown(5));
// // x.Start();
// // y.Start();
// // D
// // CountUp(5);
// // CountDown(5);


