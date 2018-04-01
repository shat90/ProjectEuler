package com.company;

import java.awt.*;
import java.util.HashSet;

public class Problem24 {


    public StringBuilder GetResult() {
        // there will be 9! combinations for every base number
        int numbers[] = new int[]{0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
        long tenFactorial = getFactorial(10); //every base number would have nine factorial combinations since the first number is 0
        HashSet hs = new HashSet();
        StringBuilder sb = new StringBuilder();

        long million = 1000000 - 1;
        int count;
        int factorialDivider = 1;
        for (int i = 0; i < 10; i++) {
            count = 0;
            factorialDivider = factorialDivider * (10 - i);
            long newFactorial = tenFactorial / factorialDivider;
            while (million >= newFactorial) {
                million = million - newFactorial;
                count++;
            }

            for (int index = 0; index < numbers.length; index++) {
                if (hs.contains(numbers[index]))
                    continue;

                if (count > 0)
                    count--;
                else if (!hs.contains(numbers[index])) {
                    hs.add(numbers[index]);
                    sb.append(numbers[index]);
                    break;
                }

            }


        }


        return sb;

    }

    private long getFactorial(int x) {
        if (x == 1)
            return x;
        return x * getFactorial(x - 1);
    }


}


