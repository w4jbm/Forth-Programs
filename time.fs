\ time.fs - Measure and print elapsed time...
\
\ Jim McClanahan W4JBM (Jan 2021)
\
\ Run by:
\   gforth time.fth
\
\ Define our function...
: time: ( "word" -- )
  utime 2>R ' EXECUTE
  utime 2R> D-
  <# # # # # # # [CHAR] . HOLD #S #> TYPE ."  seconds" ;
\
\ And let's include a factoral function to play with also...
: fac ( n -- n! ) 1 swap 1+ 1 ?do i * loop ;
\
\ Now run our function for a given ms delay...
750 time: ms
cr
\
\ Now let's time doing something productive...
20 time: fac
\
\ Go to new line and print 20! result...
cr ." 20! is equal to " .
\
\ And exit...
cr bye

