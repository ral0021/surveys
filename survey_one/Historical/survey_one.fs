\ Survey One
\ Brackets are used instead of parans due to FORTH comment conventions
\ To run: gforth survey_one.fs -e bye

: double ( n -- n^2 )
  2 * ;

: catalan ( n -- [1 / [n + 1]] * 2n!/[n![2n-n]]!)
    ;
  
: binomial ( n,k -- n!/[k![n-k]]!) 
    ;

: factorial ( n -- n!) \ Brackets are used 
    dup 1 - 
    2 < if exit 
        else recurse * 
        then ;    
  
10 0 do i 

    .s ;
