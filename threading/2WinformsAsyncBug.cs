// Application.Run(new MainFormThree());
// public class MainFormOne : Form
// {
//     public MainFormOne()
//     {
//         var button = new Button
//         {
//             Text = "Post",
//             Location = new System.Drawing.Point(10, 10)
//         };
//         Controls.Add(button);
//         button.Click += Button_Click;
//     }

//     private async void Button_Click(object? sender, EventArgs e)
//     {
//         await DoPost().ConfigureAwait(false);

//     }
//     private async Task DoPost()
//     {
//         await Task.Delay(1000);
//         throw new Exception("Post failed");
//     }
// }
// public class MainFormTwo : Form
// {
//     public MainFormTwo()
//     {
//         var button = new Button
//         {
//             Text = "Post",
//             Location = new System.Drawing.Point(10, 10)
//         };
//         Controls.Add(button);
//         button.Click += Button_Click;
//     }

//     private async void Button_Click(object? sender, EventArgs e)
//     {
//         try
//         {
//             await DoPost().ConfigureAwait(false);
//         }
//         catch (Exception ex)
//         {
//             var logLabel = new Label
//             {
//                 Text = ex.Message,
//                 Location = new System.Drawing.Point(10, 40),
//                 AutoSize = true
//             };
//             Controls.Add(logLabel);
//         }
//     }
//     private async Task DoPost()
//     {
//         await Task.Delay(1000);
//         throw new Exception("Post failed");
//     }
// }
// public class MainFormThree : Form
// {
//     public MainFormThree()
//     {
//         var button = new Button
//         {
//             Text = "Post",
//             Location = new System.Drawing.Point(10, 10)
//         };
//         Controls.Add(button);
//         button.Click += Button_Click;
//     }

//     private async void Button_Click(object? sender, EventArgs e)
//     {
//         try
//         {
//             await DoPost();
//         }
//         catch (Exception ex)
//         {
//             var logLabel = new Label
//             {
//                 Text = ex.Message,
//                 Location = new System.Drawing.Point(10, 40),
//                 AutoSize = true
//             };
//             Controls.Add(logLabel);
//         }
//     }
//     private async Task DoPost()
//     {
//         await Task.Delay(1000);
//         throw new Exception("Post failed");
//     }
// }
