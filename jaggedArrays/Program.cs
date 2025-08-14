// jaggedArrays 
// sao arrays de arrays 
// ou tambem arrays irregulares 
int [][] numbers =
 new int[4][];
 numbers[0] =
  new int [] {1,2,3 };
numbers[1] = 
 new int [] {5,6,7,8,9};
 numbers[3] = 
   new int []{6,5,4};
   int[][] numbers 

   //outra forma de inicializar
   int [][] numbers2 =
   {
        new int []{1},
        new int []{2},
        new int []{3},
        new int []{4},
   };
   for(int i = 0; i < numbers.length; i++)
   {
    console.write ("[")
    fpr (int j = 0; j < numbers[i].length; j+=)
    {
        console.write( $"{numers[i][j]} ");
   }
  console.write("[");
   }
