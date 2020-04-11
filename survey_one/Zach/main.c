// Zach
#include <stdio.h>

double Factorial(double n);
double Binomial(double n, double k);
double Catalan(double n);


int main()
{
    for(int i = 0; i<10; i++){
        printf("%.2f\n", Catalan(i));
    }
}

double Factorial(double n){
    if(n<=1){
        return 1;
    }
    else{
        return n * Factorial(n-1);
    }
}

double Binomial(double n, double k){
    return Factorial(n)/(Factorial(k)*Factorial(n-k));
}
