# ConsoleAppProgress

Some async/await Progress<T> console app for testing

### Output:
![Output](img/output.png)

### Notes:
- As you can see in output above, SynchronizationContext.Current is still null in a .NET 6 Console App.
- Progress.Report() (and it´s Post() inside) therefore is spooled onto some ThreadPool WorkerItem.
- The result is: Some random occurrence of that Post()´s happens (the printing of 'X').
- Running the app multiple times always produce other results (random).
- Since it´s not guaranteed when threadpool thread(s) are executed (the spooled Post()´s), they are random.
- As long as Post() inside Progress.Report() is just spooled onto some ThreadPool WorkerItem, there is no chance to wait for it.
- The only way i see here, is to write an own IProgress<T> implementation or use some own specific SynchronizationContext.

### Links:
- https://devblogs.microsoft.com/pfxteam/await-synchronizationcontext-and-console-apps/
- https://devblogs.microsoft.com/pfxteam/await-synchronizationcontext-and-console-apps-part-2/

#### Have fun.
