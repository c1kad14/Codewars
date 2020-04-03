import sys

# Write a function that takes in a string of one or more words, and returns the same string, 
# but with all five or more letter words reversed (Just like the name of this Kata). 
# Strings passed in will consist of only letters and spaces. 
# Spaces will be included only when more than one word is present.
# Examples: spinWords( "Hey fellow warriors" ) => returns "Hey wollef sroirraw" 
# spinWords( "This is a test") => returns "This is a test" 
# spinWords( "This is another test" )=> returns "This is rehtona test"


def spin_words(words):
    # Your code goes here
    words = words.split()
    result = []
    
    for word in words:
        if (len(word) > 3):
            result.append(word[::-1])
        else:
            result.append(word)
    print(' '.join(result))
    return ' '.join(result)


def main(words):
    spin_words(words)


if __name__ == '__main__':
    main(sys.argv[1])