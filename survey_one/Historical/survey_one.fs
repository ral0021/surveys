\ Survey One
\ Brackets are used instead of parans due to FORTH comment conventions
\ To run: gforth survey_one.fs -e bye
\ Team Zeta

\ require float.fs 
\ Not required when interpreted in gforth

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
    n k - fact  
    k fact n fact / 
    ;
 
\ Catalan
: cat { n -- n } ( n -- [1 / [n + 1]] * 2n!/[n![2n-n]]!)
    1e n s>f 1e f+ f/  \ [1 / [n + 1]]
    n DUP 2 * binom \ 2n!/[n![2n-n]]!
    s>f f* ;
    
\ Main      
 10 cat stkln
