import sys


def spin_words(words):
    # Your code goes here
    words = words.split()
    result = []
    
    for word in words:
        if (len(word) > 3):
            result.append(word[::-1])
        else:
            result.append(word)
    
    return ' '.join(result)


def main(words):
    spin_words(words)


if __name__ == '__main__':
    main(sys.argv[1])