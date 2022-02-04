using System;
using System.Collections.Generic;

namespace Benchmarks;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class Validations
{
    [Benchmark(Baseline = true)]
    public void NotificationValidations()
    {
        var errors = new List<string>();

        for(var count = 0; count < 10; count++)
        {
            if(count == 5)
            {
                errors.Add(count.ToString());
            }
        }
    }


    [Benchmark]
    public void ThrowingExceptions()
    {
        var errors = new List<string>();

        for(var count = 0; count < 10; count++)
        {
            try
            {
                if(count == 5)
                {
                    throw new Exception();
                }
            }
            catch
            {
                errors.Add(count.ToString());
            }
        }
    }
}
