using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Grid
{

    private int width;
    private int height;
    private float cellsize;
    private int[,] gridArray;
    

    public Grid(int width, int height ,float cellsize)
    {
        this.width = width;
        this.height = height;
        this.cellsize = cellsize;

        gridArray = new int[width, height];

        for (int x = 0; x < gridArray.GetLength(0); x++)    
        {
            for (int y =0; y <gridArray.GetLength(1); y++)
            {
               
               
            }
        }
       
    }

}
