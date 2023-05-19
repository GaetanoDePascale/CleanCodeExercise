# Better Code

def is_palindrome(s):
    reversed_s = s[::-1]
    return s == reversed_s


input_str = "racecar"
is_pal = is_palindrome(input_str)
print(f"Is '{input_str}' a palindrome? {is_pal}")
