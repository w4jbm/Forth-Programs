\ number guess game
\
\ Starting point came from Rosettacode.org
\
\ Definately a work in progress...
\
\ Use gforth's random.fs for random numbers
require random.fs
utime drop seed ! \ seed the random number generator
\
\ Prompt the user for input
: ASK ( -- )
  CR ." Guess a number between 1 and 100? " ;
\
\ Get the user's guess
: GUESS ( -- n)
  PAD DUP 4 ACCEPT EVALUATE ;
\
\ Is the guess too high or too low?
: NOPE ( n n' -- n)
  2DUP > IF CR DUP . ." is too low. " ELSE
  2DUP < IF CR DUP . ." is too high. "
  THEN THEN ;
 
: GAME ( -- )
  100 random 1+
  begin ask guess nope over = until
  cr ." Yes! The number was " . ." ... Good guess!" ;

\
\ random number tests to make sure the functions
\ are behaving somewhat reasonably...
: rtest1 ( -- )
  20 0 do i cr . 100 random . loop ;

: rtest2 ( -- )
  cr 200 0 do 100 random . loop cr ;
