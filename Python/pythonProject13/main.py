#finall project
#dork vader
# due 8/15/2022

class myname():
    yahoo = 0
    def __init__(self, user_input, user_input2, user_input3, user_input4, user_input5, user_input6, user_input7, answer):
        self.user_input1 = user_input
        self.name = user_input2
        self.mid = user_input3
        self.phone = user_input4
        self.email = user_input5
        self.major = user_input6
        self.CIS117 = user_input7
        self.gpa = answer
list = []
letter = 'a'
count1 = 0
count2 = 0
while letter != 'q':
    try:
        user_input = input("Enter First Name (dont enter ! as these marks are banned and will cause an error)")
        if user_input == '!':
            raise ValueError
        user_input2 = input('Enter Last Name ')
        if user_input2 == '!':
            raise ValueError
        user_input3 = input('Middle initial ')
        if user_input3 == '!':
            raise ValueError
        user_input4 = input('enter phone number ')
        if user_input4 == '!':
            raise ValueError
        user_input5 = input('enter your email address')
        if user_input5 == '!':
            raise ValueError
        user_input6 = input('enter your Major')
        if user_input6 == '!':
            raise ValueError
        user_input7 = input('are you taking cis 117 with joseph carmon?')
        if user_input7 == '!':
            raise ValueError
        count1 = count1 + 1
# i entered this code to calculate the gpa and add it to my class myname then i called it in the for loop
        try:
            print(" enter in the scores you had for Math, English, History, Science, and Lunch class to learn your gpa")
            quest = float(input(" math score"))
        except:
            print("thats not a number!")
            quit()
        try:
            quest2 = float(input(" English score"))
        except:
            print("thats not a number")
        try:
            quest3 = float(input(" history score"))
        except:
            print("thats not a number")
        try:
            quest4 = float(input(" science score"))
        except:
            print("thats not a number")

        try:
            quest5 = float(input("lunch score."))
        except:
            print("thats not a number")
        answer = quest + quest2 + quest3 + quest4 + quest5
        answer = answer // 5
    except:
        print(' please do not enter a ! mark we will now quit the program')
        quit()

    if user_input7 == 'yes' or user_input7 == 'Yes' or user_input7 != "no":
        count2 = count2 + 1
    list.append(myname(user_input, user_input2, user_input3, user_input4, user_input5, user_input6, user_input7, answer))
    letter = input('press letter q to quit')
# this code should open a file and if the file does not exsist  then it will create one and write the table to the file
Gfileman = open('myfileman.txt', 'a')
Gfileman.write('\n')
Gfileman.write(f'{"Last":<7}{"First ":<8}{"Middle ":<12}{"Phone ":<14}{" _Email_":<14}{"Major ":>15}{"Taking ":>6}{"_GPA:_":>13}')
Gfileman.write('\n')
Gfileman.write('-' * 120)
Gfileman.write('\n')

Gfileman.close
q = 0
print(f'{"Last":<7}{"First ":<8}{"Middle ":<12}{"Phone ":<14}{" _Email_":<14}{"Major ":>15}{"     Taking   ":>17}{"GPA:_3"}')
print('-' * 100)
for q in list :
    # this code should copy entry results to the table
    Gfileman = open('myfileman.txt', 'a')
    Gfileman.write(f'\n{q.name:<8},{q.user_input1:<8},{q.mid:<7},{q.phone:<6},  ,{q.email:<12},   {q.major:<12},{q.CIS117:<12}{q.gpa:<6}')
    Gfileman.write('\n')
    Gfileman.close
    print(f'{q.name:<8},{q.user_input1:<8},{q.mid:<7},{q.phone:<6},  ,{q.email:<12},   {q.major:<12},{q.CIS117:<12}{q.gpa}')
print("{0}, Total number of people in list".format(count1))
print("{0}, Total number taking CIS117 from Pofessor Carmon".format(count2))
#this code should ask you if you want to read the table entries printed on the document and if you select the letter y
# it should print it for you here so you do not have to check
#just a note python never prints the last line but i assure you it is on the created document.
question = input(" all the data you entered was saved to a file, to view it press y, the last line of the table will not show up in pycharm")
if question == 'y' or question == 'Y':
    myjournal = open('myfileman.txt')
    contents = myjournal.read()
    print(contents)
    myjournal.close
    print("end of report")