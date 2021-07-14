# List-vs-IList-Benchmark

Save results for IList<T>, IEnumerable<T>, ICollection<T>.

Results are:

1 Iteration

| Method |     Mean |    Error |   StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------- |---------:|---------:|---------:|-------:|------:|------:|----------:|
|  IList | 40.25 ns | 0.810 ns | 0.867 ns | 0.0268 |     - |     - |     112 B |
|   List | 18.59 ns | 0.402 ns | 0.590 ns | 0.0172 |     - |     - |      72 B |

100 Iterations

| Method |       Mean |   Error |  StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------- |-----------:|--------:|--------:|-------:|------:|------:|----------:|
|  IList | 1,353.7 ns | 5.73 ns | 5.08 ns | 0.9727 |     - |     - |   4,072 B |
|   List |   462.7 ns | 5.44 ns | 5.09 ns | 0.0172 |     - |     - |      72 B |
