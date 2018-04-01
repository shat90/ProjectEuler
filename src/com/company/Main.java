package com.company;

public class Main {

    public static void main(String[] args) {
        final long startTime = System.currentTimeMillis();

        Problem24 problem = new Problem24();
        String result = new String(problem.GetResult());
        final long endTime = System.currentTimeMillis();
        System.out.println(result);
        System.out.println("Execution time " + (endTime - startTime) + "ms");
    }
}
