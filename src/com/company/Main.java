package com.company;

public class Main {

    public static void main(String[] args) {
        final long startTime = System.currentTimeMillis();

        Problem4 problem = new Problem4();
        String result = String.valueOf(problem.GetResult());
        final long endTime = System.currentTimeMillis();
        System.out.println(result);
        System.out.println("Execution time " + (endTime - startTime) + "ms");
    }
}
