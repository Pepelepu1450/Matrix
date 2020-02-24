using System;

namespace Matrix
{
    class Matrix
    {
        private int[,] grid;

        private int girdSize;

        public Matrix(int [,] girdValues, int girdSize) {
            this.grid = girdValues;
            this.girdSize = girdSize;
        }

        public void PrintMatrix () {
            //iterar filas
            for (int y = 0; y < this.girdSize; y++){
                //iterar columnas
                for(int x = 0; x < this.girdSize; x++){
                    //imprimir 
                    Console.Write(this.grid[y,x]);
                }
                Console.WriteLine();
            }
        }
    }
}
