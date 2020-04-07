\ Survey One
\ Brackets are used instead of parans due to FORTH comment conventions
\ To run: gforth survey_one.fs -e bye


\Helper words
: stkln
    .s 10 EMIT ;

\Catalan
: cat ( n -- [1 / [n + 1]] * 2n!/[n![2n-n]]!)
    DUP
    VARIABLE N
    N !
    1e SWAP /
    ;

\Binomial    
: bin ( n, k -- n!/[k![n-k]]!) 
    VARIABLE N
    N !
    VARIABLE K
    K !
    N @ K @ -
    fact
    K @ fact
    N @ fact
    /
    ;

\Factorial
: fact ( n -- n!) \ Brackets are used 
    DUP            \ Currently (n -- (n-1)!)
    1 -
    DUP
    2 > IF recurse ELSE THEN * EXIT ;
  
10 0 DO i 
    cat . ;
