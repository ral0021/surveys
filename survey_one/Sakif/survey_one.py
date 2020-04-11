#Sakif
def catalan(n):
    def binomial(n,k):
        def factorial(n):
            if n==0:
                return 1
 
            return n*factorial(n-1)
   
        return factorial(n)/(factorial(k)*factorial(n-k))
        
    return binomial(2*n,n)*(1/(n+1))
def main():
    for n in range(0,10):
        print(catalan(n))

if __name__== "__main__" :
    main()
