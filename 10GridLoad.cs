// // we are creating a control with a grid and a label that displays number of rows in the grid
// var control = new Control();
// control.CreateAGrid();
// class Control
// {
//     List<string> _data;
//     public void CreateAGrid()
//     {
//         // we are creating a grid.
//         // blabla grid code
//         // then we are binding data to the grid
//         BindData();
//         // mock a label
//         // Then we have control that displays number of rows
//         Console.WriteLine("Number of rows: " + _data.Count);
//     }
//     async void BindData()
//     {
//         _data = await LoadHint();
//     }
//     async Task<List<string>> LoadHint()
//     {
//         await Task.Delay(5000);
//         return new List<string>()
//         {
//             "Hint 1",
//             "Hint 2",
//             "Hint 3"
//         };
//     }
// }

