namespace AsyncExample3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = DownloadDataAsync("https://bbc.co.uk");
            Console.WriteLine(data.Result.Substring(0, 100));

            Console.WriteLine();

            var factResult = ComputeFactorialAsync(10);
            Console.WriteLine(factResult.Result);


            async Task<string> DownloadDataAsync(string url)
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    return await response.Content.ReadAsStringAsync();
                }
            }


            async Task<int> ComputeFactorialAsync(int n)
            {
                return await Task.Run(() =>
                {
                    int result = 1;

                    for (int i = 1; i <= n; i++)
                    {
                        result *= i;
                    }

                    return result;
                });
            }
        }
    }
}