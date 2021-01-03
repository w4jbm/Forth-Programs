\ misc.fs - Odds and ends of Forth code
\
\ Jim McClanahan W4JBM (Jan 2021)
\
\ Under gforth, you can import this file using:
\   include misc.fs
\
\ square of a number
: squared ( n -- n^2 )
  dup * ;
\
\ cube of a number
: cubed ( n -- n^3 )
  dup squared * ;
\
\ endless loop
: endless ( -- )
  0 begin
  dup . cr 1+
  again ;
\
\ count to 10
: count10 ( -- )
  0 begin
  dup . cr 1+
  dup 10 > until
  drop ;
\
\ count from zero to number on top of stack
: countx ( n --)
  cr 0 begin
  dup . cr 1+
  over over < until
  drop drop ;
\
\ count down from number on top of stack
: countdown ( n -- )
  0 swap
  do cr i . \ i puts the current loop index on stack
  -1 +loop
  cr ;
\
\ table of squares up to number on top of stack
: squaresx ( n -- )
  cr 1 begin
  dup . dup dup * . cr 1+
  over over < until
  drop drop ;
\
\ recursive factorial calculation
: factr ( n -- n! )
  dup 0> if
    dup 1- recurse *
  else
    drop 1
  endif ;
\
\ print a table of byte value and ascii equivalent
: asciinums ( -- )
  cr 48 begin
  dup . dup emit cr 1+
  dup 57 > until
  drop ;
\
\ even or odd number?
: evorod ( n --)
  dup cr 2 mod if . ." is Odd" else . ." is Even" endif
  cr ;
