import sys 

#Write a function, which takes a non-negative integer (seconds) as input and returns the time in a human-readable format (HH:MM:SS)

#    HH = hours, padded to 2 digits, range: 00 - 99
#    MM = minutes, padded to 2 digits, range: 00 - 59
#    SS = seconds, padded to 2 digits, range: 00 - 59

#The maximum time never exceeds 359999 (99:59:59)

def make_readable(seconds):
    return f"{seconds//3600:02d}:{(seconds//60)%60:02d}:{seconds%60:02d}"
    

def main(seconds):
    time = make_readable(seconds)
    print(time)


if __name__ == '__main__':
    main(int(sys.argv[1]))