# ConsoleAppProgress

Some async/await Progress<T> console app for testing

### Output:
![Output](img/output.png)

### Notes:
- As you can see in output above, SynchronizationContext.Current is still null in a .NET 6 Console App.
- Therefore a `Progress.Report()` (and it´s `Post()` inside) is spooled onto some ThreadPool WorkerItem.
- The result is: Some random occurrence of that `Post()`´s happens (the printing of 'X').
- Running the app multiple times always produce other results (random).
- It´s not guaranteed _when_ threadpool thread(s) are executed (the spooled `Post()`´s), so they are random.
- One solution is to write an own `IProgress<T>` implementation.
- Another solution is to use some own specific `SynchronizationContext`.
- The only way of waiting "_from the outside_" is to bundle `TaskCompletionSource` tasks in Progress-Handler.
- So you could `await` the whole bunch of tasks via `await Task.WhenAll(taskBundle)` in main().
- But since this has to happen in user-code-land, it´s not that awesome type of a solution.

### Links:
- https://devblogs.microsoft.com/pfxteam/await-synchronizationcontext-and-console-apps/
- https://devblogs.microsoft.com/pfxteam/await-synchronizationcontext-and-console-apps-part-2/

#### Have fun.
