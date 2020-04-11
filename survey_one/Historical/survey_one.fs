\ Survey One
\ Brackets are used instead of parans due to FORTH comment conventions
\ To run: gforth survey_one.fs -e bye
\ Team Zeta

\ require float.fs 
\ Not required when interpreted in gforth

\ Print top of stack and newline
: prtln
    f>s . 10 EMIT ;

\ Factorial
: fact ( n -- n!)
	DUP 2 > IF DUP 1 - recurse * THEN EXIT ;
    
\ Binomial    
: binom { n k -- n k } ( n, k -- n!/[k![n-k]]!) 
    n k - fact  
    k fact n fact / ;
 
\ Catalan
: cat { n -- n } ( n -- [1 / [n + 1]] * binomial 2n n)
    n DUP 2 * binom s>f	\ 2n!/[n![2n-n]]!
    1 n + s>f f/ ;
    
\ Main      
1 cat prtln
2 cat prtln
3 cat prtln
4 cat prtln

