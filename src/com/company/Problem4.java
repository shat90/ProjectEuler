package com.company;

class Problem4 {

    int GetResult() {
        int number = 0;

        for (int i = 999; i > 100; i--) {
            for (int j = 999; j >= i; j--) {
                int x = i * j;

                char[] input = Integer.toString(x).toCharArray();

                for (int index = input.length - 1; index >= 0; index--) {
                    if (input[index] != input[input.length - index - 1]) {
                        break;
                    }
                    if (index == 0) {
                        number = Math.max(x, number);
                    }

                }
//                if(Integer.toString(x).compareTo(new StringBuilder(Integer.toString(x)).reverse().toString())==0)
//                {
//                    number = Math.max(number,x);
//                }
            }
        }
        return number;
    }

}
