using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Grid : MonoBehaviour
{
    public static int rows = 22;
    public static int col = 10;
    // x posicionar el grid en la pantalla 
    public static Transform[,] grid = new Transform[col, rows];

    // Use this for initialization
    void Start()
    {

        transform.position = new Vector3(Screen.width / 2, 444, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public static Vector2 roundVec2(Vector2 v)
    {
        return new Vector2(Mathf.Round(v.x), Mathf.Round(v.y));
    }

    public static bool insideBorder(Vector2 pos)
    {
        return ((int)pos.x >= 0.0f && (int)pos.x < col && (int)pos.y >= 0.0f);
    }

    public static void deleteRow(int y)
    {
        for (int x = 0; x < col; ++x)
        {
            Destroy(grid[x, y].gameObject);
            grid[x, y] = null;
        }
        GameManager.Instance.AddPoints(5);

    }
    public static void deleteAllPiecesOneColor(Color? color=null)
    {
        for(var x = 0; x < col; ++x)
        {
            for(var y = 0; y < rows; ++y)
            {
                if (grid[x, y]!= null) {
                    if (grid[x, y].parent.GetComponent<SpriteRenderer>().color.Equals(color))
                    {
                        Destroy(grid[x, y].gameObject);
                        grid[x, y] = null;
                    }
                }
            }
        }
    }
    public static void decreaseRowsAbove(int y)
    {
        for (int i = y; i < rows; ++i)
            decreaseRow(i);
    }

    public static void decreaseRow(int y)
    {
        for (int x = 0; x < col; ++x)
        {
            if (grid[x, y] != null)
            {
                grid[x, y - 1] = grid[x, y];
                grid[x, y] = null;
                grid[x, y - 1].position += new Vector3(0, -1, 0);
            }
        }
    }

    public static bool isRowFull(int y)
    {
        for (int x = 0; x < col; ++x) { 
        if (grid[x, y] == null)
            return false;
    }
        return true;
    }

    public static void deleteFullRows(  )
    {
        for (int y = 0; y < rows; ++y)
        {
            if (isRowFull(y))
            {
                deleteRow(y);
                decreaseRowsAbove(y + 1);
                --y;
            }
        }
    }
 
    public static bool CheckColorRowsGrid( Color color)
    {

        for (var y = 0; y < rows; y++)
        {
            bool FilaMateixColor = true;
            
            for (var x = 0; x < col; x++)
            {
               
                if (grid[x, y] != null) //quan es != null es quan es plena
                {


                    if (!isRowFull(y)
                         || grid[x, y].parent.GetComponent<SpriteRenderer>().color != color)
                    {
                        FilaMateixColor = false;
                    }
             


                }
                else //quan es null
                {
                    FilaMateixColor = false;
                }
            }
            if (FilaMateixColor== true ) {  //eliminarem la fila ok
             deleteAllPiecesOneColor(color);
                decreaseRowsAbove(y + 1);
                y--;
            }
            else
            {
                if (isRowFull(y))
                {
                    deleteRow(y);
                    decreaseRowsAbove(y + 1);
                    --y;
                }
            }


        }
        return true;
    }
}
