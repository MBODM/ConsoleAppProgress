# ConsoleAppProgress
Some async/await Progress<T> console app for testing 

### Screenshot of result:
![Output](img/output.png)
  
### Notes:
- As you can see in output above, SynchronizationContext.Current is still null in .NET 6 Console App.
- Progress.Report() is spooled onto ThreadPool and shows some random occurrence (the printing of 'X').
- Running the app multiple times always produce other results (random).
- This happens, cause since it´s not guaranteed when the Post()´s are executed on threadpool thread, they have random occurrence.
