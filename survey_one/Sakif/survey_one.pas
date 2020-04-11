//fpc 3.0.0
//Sakif

program main;

var
    result: Longint;
    i: integer;
function catalan(c: Longint): Longint;    
    function binomial (n,k : Longint): Longint;

        function factorial(num : Longint): Int64;
        begin
            if num <= 0 then
                factorial := 1
            else    
                factorial := (num*factorial(num-1));
        end;
    begin
        binomial:= ((factorial(n) div factorial(k)) div factorial(n-k));
    end;
begin
    catalan := binomial((2*c),c) div (c+1);
end;
begin
    for i:=0 to 9 do
    begin
        result := catalan(i);
        writeln('result=',result);
    end;
end.
