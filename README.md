# ConsoleAppProgress
Some async/await Progress<T> console app for testing 

### Screenshot of result:
![Output](img/output.png)
  
### Notes:
- As you can see in output above, SynchronizationContext.Current is still null in .NET 6 Console App.
- As you can see above, Progress.Report() is spooled onto ThreadPool and has some random occurence.
- Running the app multiple times always produce other (random) results, since it´s not guaranteed when the Post()´s are executed on threadpool thread.
