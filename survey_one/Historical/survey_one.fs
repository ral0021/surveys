\ Survey One
\ Brackets are used instead of parans due to FORTH comment conventions
\ To run: gforth survey_one.fs -e bye
\ Team Zeta


\ Print stack and newline
: stkln
    .s 10 EMIT ;

\ Factorial
: fact ( n -- n!)
    DUP 
    1 -
    DUP
    2 > IF recurse ELSE THEN * EXIT ;
    
\ Binomial    
: binom { n k -- n k } ( n, k -- n!/[k![n-k]]!) 
    n k f- fact  
    k fact n fact f/ 
    ;

Variable M    
\ Catalan
: cat { n -- n } ( n -- [1 / [n + 1]] * 2n!/[n![2n-n]]!)
    1e n 1e f+ f/  \ [1 / [n + 1]]
    n n 2e f* binom \ 2n!/[n![2n-n]]!
    f*
    ;

\ Main      
10e cat
