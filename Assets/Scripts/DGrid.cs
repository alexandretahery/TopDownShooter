using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DGrid 
{
    private int _width;
    private int _height;
    private float _cellSize;
    private int[,] _gridArray;

    public DGrid(int width, int height, float _cellSize)
    {
        this._width = width;
        this._height = height;
        this._cellSize = _cellSize;

        _gridArray = new int[width, height];

        for(int x = 0; x < _gridArray.GetLength(0); x++)
        {
            for (int y = 0;  y < _gridArray.GetLength(1); y++)
            {
                //WorldText.CreateWorldText(_gridArray[x, y].ToString(), null, _cellSize,);
            }
        }
    }
}
