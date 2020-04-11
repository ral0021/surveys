\ Survey One
\ Brackets are used instead of parans due to FORTH comment conventions
\ To run: gforth survey_one.fs -e bye
\ Team Zeta

require float.fs

\ Print float stack and newline
: stkln
    f. 10 EMIT ;

\ Factorial
: fact ( n -- n!)
    FDUP 
    1e f-
    FDUP
    2e f> IF recurse ELSE THEN f* EXIT ;
    
\ Binomial    
: binom { n k -- n k } ( n, k -- n!/[k![n-k]]!) 
    n k - fact  
    k fact n fact / 
    ;
 
\ Catalan
: cat { n -- n } ( n -- [1 / [n + 1]] * 2n!/[n![2n-n]]!)
    1e n s>f 1e f+ f/  \ [1 / [n + 1]]
    n n 2 * binom \ 2n!/[n![2n-n]]!
    s>f f* ;
    
\ Main      
 10 cat
