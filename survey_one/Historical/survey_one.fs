\ Survey One
\ Brackets are used instead of parans due to FORTH comment conventions
\ To run: gforth survey_one.fs -e bye
\ Team Zeta

\ require float.fs 
\ Not required when interpreted in gforth

\ Print top of float stack
\ converted to single cell value and newline
: prtln
    f>s . 10 EMIT ;

\ Factorial
: fact ( n -- n!)
	\ If Greater than 2 recurse else exit 
	\ with last result on stack
	DUP 2 > IF DUP 1 - recurse * THEN EXIT ;
    
\ Combin   
: combin { n k -- n k } ( n, k -- n!/[k![n-k]]!) 
    n k - fact k fact * \ push [n-k]! and k! onto stack then multiply
    n fact \ Push n! on to the stack
    s>f s>f f/ f>s ; \ Convert for division then turnicate
 
\ Catalan
: cat { n -- n } ( n -- [1 / [n + 1]] * 2nCn)
    n DUP 2 * combin s>f \ 2n!/[n![2n-n]]!
    1 n + s>f f/ ;
     
    \ s>f converts from single cell stack object to 
    \ floating point stack object and pushs it to the appropriate stack
    
\ Main      
1 cat prtln
2 cat prtln
3 cat prtln
4 cat prtln

