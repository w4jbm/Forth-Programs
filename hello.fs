\ hello.fs - Hello World in Forth
\
\ Jim McClanahan W4JBM (Jan 2021)
\
\ Run by:
\   gforth hello.fth
\
\ Define our function...
: HELLO ( -- ) ." Hello, World!" ;
\
\ Run it...
HELLO
\
\ And exit...
cr bye 
