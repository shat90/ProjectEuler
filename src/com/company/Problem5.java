package com.company;

public class Problem5 {

    public long GetResult() {
        long lcm = 1;

        for (int i = 1; i <= 20; i++) {
            lcm = i * lcm / gcd(lcm, i);
        }
        return lcm;

    }

    public long gcd(long a, long b) {
        if (a == 0 || b == 0) return a + b;
        return gcd(b, a % b);
    }
}
