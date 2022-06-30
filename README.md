# https-github.com-Varsity-College-Durban-North-prog-poe-Ravelle12
WpfApp1__PropertyApp -Poe-Prog6211
Read me file: The application built is PropertyApp, PropertyApp was built for a purpose to make easier for users having a personal budget plan. Part 1 fixes have been made. prior to part 2 we have sever issues with error code 404. Which has now beeen sorted. i have debugged the PropertyApp. fixed errors. //Part 2 i added purchase of vehicles and made it easier for users to use the Application
it was a challenge to make the application run smoothly but after abit of soring days working on refinering the app. i finally managed to get the app running smoothly and i feel like the users will enjoy the application

included:
All source files (.cc, .hh, .cpp, .h)
this README
Makefile
Output dumped by gprof for 5 tests (see below on why I don't have profiling data for BST/words.txt test)

I'd like to first mention that the biggest problems I encountered during this project were really stupid and idiotic typos; simple things like accidentally putting a colon where a semicolon belong (for the last method of a class of all cases! Gave me weird errors about no constructor body) or dumb errors in my Makefile, which caused all sorts of weird compiling issues.
One thing you may notice is that I migrated over to strings.  My previous assignments used char arrays, but for this assignment where lots of comparisons are needed, it made it easier to just use strings.
I used words.txt and note pad .txt to profile my results and create a manual and read me file.

bool <function>(param& , param&) signatures
We wanted to have a way to notify the user of invalid find operations.  Since
the code is templatized we dont know what type to return for the function.  Thus
the bool return.  Essentially, if the operation is successful, return true and
modify the appropriate parameter that was passed in by reference.  If the
operation fails, return false, and leave the parameter alone.  With this design
decision made, other similar functions needed to have similar feels to maintain
a consistant API.
Insertion
An interative insert function was written to give better performance because
recursive functions has to allocate/deallocate multiple stack frames
Small functions:
They are easier to test, easier to code, easier to read,and definitely easier to
understand. The general concept is to minimize the syntax baggage for public
interface functions, letting them act as drivers, and have protected functions
do the gruntwork.

INSTRUCTIONS:///

Start the application PropertyApp
Follow the on screen instructions
Fill out your details below in the boxes
Once done click "confirm"
run the program ////////// Enjoy the Application.
