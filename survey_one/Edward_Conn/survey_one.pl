#!/usr/bin/perl
use strict;
use warnings;


sub catalan{
    my $n = $_[0];
    
    local *binom = sub {
        my ($x, $y) = ($_[0], $_[1]);
        
        local *fact = sub{
            
            if($_[0] == 0 || $_[0] == 1){
                $_[0];
            } else {
                $_[0] * fact($_[0] - 1);
            }
        };
        
        fact($x) / (fact($y) * fact($x - $y));
    };
    
    (1 / ($n + 1)) * binom(2 * $n, $n);
}

foreach(1..10){
    print(catalan($_)." ");
}
