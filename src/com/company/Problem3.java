package com.company;

import java.math.BigInteger;
import java.math.MathContext;

import static java.math.MathContext.DECIMAL32;

public class Problem3 {

    public String GetResult() {
        BigInteger number = new BigInteger("600851475143");
        BigInteger range = number.sqrt();

        for (BigInteger i = new BigInteger("3"); i.compareTo(range) != 1; i = i.add(new BigInteger("2"))) {
            while (number.remainder(i).signum() == 0) {
                number = number.divide(i);
            }

            if (number.compareTo(new BigInteger("2")) != 1)
                return i.toString();
        }

        return "";
    }
}
