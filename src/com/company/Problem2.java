package com.company;

public class Problem2 {
    public int GetResult() {
        int sum = 2;
        int i = 1;
        int j = 2;
        int k;

        while (j < 4000000) {
            k = i + j;
            if (k % 2 == 0) {
                sum += k;
            }
            i = j;
            j = k;
        }

        return sum;
    }
}
