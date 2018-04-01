package com.company;

public class Problem6 {

    public long GetResult() {
        long sum1 = 0;
        long sum2 = 0;
        for (int i = 1; i <= 100; i++) {
            sum1 += Math.pow(i, 2);
            sum2 += i;
        }
        sum2 = ((Double) Math.pow(sum2, 2)).longValue();

        return sum2 - sum1;
    }
}
