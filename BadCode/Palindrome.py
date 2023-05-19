# Bad Code

def is_palindrome(s):
    start = 0
    end = len(s) - 1

    while start < end:
        if s[start] != s[end]:
            return False
        start += 1
        end -= 1

    return True


input_str = "racecar"
is_pal = is_palindrome(input_str)
print(f"Is '{input_str}' a palindrome? {is_pal}")
