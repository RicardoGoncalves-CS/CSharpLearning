# PairProgrammingTDD

[Even Fibonacci numbers](https://projecteuler.net/problem=2)

Problem description: By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms. The first 2 numbers should be 1 and 2.

We started by writing tests to assert that the first numbers of the fibonacci sequence matched the expected outputs.
The first 3 values returned the exact same values. 
At the 4th value we had to refactor as the return value didn't match the expected value and at that point we implemented a true fibonacci sequence generator up to an input value.
We then proceeded to calculate the sum of the sequence up to the input value.
After that we changed the code to sum only the even values.
Finally we removed the input value and summed to a maximum value in the fibonacci sequence.
We used test values of 8 and 34 and finally asserted that the terms in the Fibonacci sequence whose values do not exceed four million is equal to 4,613,732.
