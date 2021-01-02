\ basedemo.fs - demo of changing bases in Forth
\
\ Jim McClanahan W4JBM (Jan 2020)
\
\ This is actually one of the 'tricks' I would play on
\ people just learning Forth (not that I ever progressed
\ much beyond 'just learning' myself). Typing "16 BASE"
\ puts you in hex mode. Typing "10 BASE" seems to do
\ nothing--but that's because you are in hex mode and
\ $10 = 16, so "10 BASE" in hex mode (or any mode) just
\ puts you right back where you are.
\
\ The format is actually "10 BASE !". This executes as:
\   10 - 10 (in current base) pushed to the stack
\   BASE - the address of the variable BASE pushed on stack
\   ! - stores the value 10 into the variable BASE
\
DECIMAL
100 Constant Hun1
HEX
100 Constant Hun2
DECIMAL
100 Constant Hun3
16 BASE !
100 Constant Hun4
10 BASE !
100 Constant Hun5
0A BASE !
100 Constant Hun6
DECIMAL
." Hun1= " Hun1 . CR
." Hun2= " Hun2 . CR
." Hun3= " Hun3 . CR
." Hun4= " Hun4 . CR
." Hun5= " Hun5 . CR
." Hun6= " Hun6 . CR
BYE
