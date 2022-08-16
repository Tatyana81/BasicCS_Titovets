// функция Аккермана A(m,n)

int recursion(int m, int n)
    {
        
        if (m == 0)
            {
                return n + 1;
            } 
            else if (n == 0 && m > 0)
                {
                    return recursion(m - 1, 1);
                } 
                    else
                    {
                        return recursion(m - 1, recursion(m, n - 1));
                    }
    }
    
Console.Write(recursion(3, 1));
               
    
