\ Survey One
\ Brackets are used instead of parans due to FORTH comment conventions
\ To run: gforth survey_one.fs -e bye

\Helper words
: stkln
    .s 10 EMIT ;

\Catalan
: cat ( n -- [1 / [n + 1]] * 2n!/[n![2n-n]]!)
    ;
  
: bin ( n,k -- n!/[k![n-k]]!) 
    ;

: fact ( n -- n!) \ Brackets are used 
    DUP            \ Currently (n -- (n-1)!)
    1 -
    DUP
    2 > IF recurse * THEN EXIT ;
  
10 0 DO i 

    .s ;
