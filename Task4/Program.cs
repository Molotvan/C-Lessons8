int[,,] matrix3D = new int[3, 3, 3];
FillArray(matrix3D);
PrintArray(matrix3D);

void FillArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++){
                Random rand = new Random();
                int n = rand.Next(10,99);
            array[i,j,k] = SetElement(array, n, i, j, k );
            }

            }
        }
    }


int SetElement(int[,,] array, int n, int m, int x, int y){
    Random r = new Random();
    for(int i = m-1; i>=0; i--){{
        for(int j = x-1; j>=0; j--){
            for(int k = y-1; k>=0; k--){
                if(array[i,j,k] == n){
                    SetElement(array, r.Next(10,99), m, x, y);
                }
            }
        }
    }   
}
return n;
}


void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine();
            for(int k = 0; k < array.GetLength(2); k++){
            
            Console.Write(array[i, j, k] + "( " + i + ", " + j  + ", " + k +")");
            }
            
        }
    }
}
