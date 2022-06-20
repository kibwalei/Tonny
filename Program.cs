int x  = 100;
int y = 0;
int result;

result = x/y;

try{
    result= x/y ;
    Console.WriteLine("the result is : {0}" , result);

}
catch {
    Console.WriteLine("Error");
}