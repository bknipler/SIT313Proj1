# SIT313Proj1
First project for Deakin University unit SIT313 Mobile Computing. A simple android app that will attempt to decode cryptic messages using 4 different methods: Caesar - replace letter with next letter i.e A becomes B, B becomes C; Transpostition (backwards) - words read backwards i.e 'hello friend' becomes 'olleh dneirf'; Transpostition(pair switch) - switches every pair of letters i.e 'hello friend' becomes 'eh ll fo ei dn'; and Monoalphabetic Substitution - looks for the most commonly used letter int he message and assumes its 'E', which is the most commonly used letter in the English language, the second most commonly used letter is 'T'. This information can then be used to help form words and find out the other letters, but my program will only find the two most commonly used letters and assign their value as 'E' and 'T' respectivly.

The project will have two screens: the main menu where the user can input a cryptic message, select the method of which to solve the message (will use a spinner) and then click a button to solve it, the solved message will then display instead of the original message and the user will get the chance to save the message. Clicking on the button to display saved massages takes the user to the second screen where the messages are.

Project is called 'Cipher Slayer'.

Update - Project ended up being very disappointing, I tried to do more than I should have and ran into a lot of unexpected errors that sucked up all my time. Only the Caesar cipher is implemented and that runs directly off the button, I could not work out how to make clicking the button corrispond with a specific selection from the spinner.
I spent a long time thinking my code was so broken that it didn't run at all because whenever I went to debug the project it would come up with random errors. I then worked out it was the emulator that wasn't working and also spent a lot of time trying to get the that to work. After hours of fiddling around and lurking forums I found out that a setting was disabled in the BIOS that stopped virtual machines from running multiply cores, this stopped certain parts of Xamarin and virtual box and HAXM from installing properly, which meant they all had to be reinstalled after the setting was changed.

Bits of code taken from https://developer.xamarin.com/guides/android/getting_started/hello,android/

To run just download and unpack, enter the folder and open up 'SIT313Proj1' with visual studios. Should work on all devices past API 19 but best to run on the newest API possible (I used Android_Accelerated_x86 (Android 6.0 - API 23).

Have fun!
