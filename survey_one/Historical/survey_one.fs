\ Survey One
\ Brackets are used instead of parans due to FORTH comment conventions
\ To run: gforth survey_one.fs -e bye
\ Team Zeta

\ Helper words
: stkln
    .s 10 EMIT ;

\ Factorial
: fact ( n -- n!)
    DUP
    1 -
    DUP
    2 > IF recurse ELSE THEN * EXIT ;
    
\ Binomial    
: bin { n k -- n k } ( n, k -- n!/[k![n-k]]!) 
    n
    k
    - fact  
    k
    fact 
    n
    fact / 
    ;

Variable M    
\ Catalan
: cat { n -- n } ( n -- [1 / [n + 1]] * 2n!/[n![2n-n]]!)
    n
    DUP
    1e +
    1e SWAP /
    M !       \ [1 / [n + 1]]
    n
    2 * 
    fact      \  2n!
    n
    fact 
    2 *
    /          \ n![2n - n]!
    M @ 
    *
    ;

\ Main      
10 cat
