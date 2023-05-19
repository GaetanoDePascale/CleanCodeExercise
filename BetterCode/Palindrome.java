package BetterCode;

public class Palindrome {
    public static boolean isPalindrome(String s) {
        String reversed = new StringBuilder(s).reverse().toString();
        return s.equals(reversed);
    }

    public static void main(String[] args) {
        String input = "racecar";
        boolean isPal = isPalindrome(input);
        System.out.println("Is '" + input + "' a palindrome? " + isPal);
    }
}
