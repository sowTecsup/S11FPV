
using UnityEngine;

public class GridManager : MonoBehaviour 
{
    [SerializeField] private int rows;
    [SerializeField] private int columns;
    [SerializeField] private int[,] grid;
    private Vector2Int playerPos;

    #region step
    /*
     * 0 muro
     * 1 piso
     * 2 arbol
     * 3 personaje
     * 
     */

    /* private void Start()
     {
         grid = new int[rows, columns];

         ChangeAllTiles(1, grid);
         playerPos = ChangeTileRandom(3, grid);
}*/
    public void SetGrid()
    {
        grid = new int[rows, columns];
    }

    public void ChangeAllTiles(int _tileType,int[,] _grid)
    {
        for (int i = 0; i < _grid.GetLength(0); i++)
        {
            for(int j = 0; j < _grid.GetLength(1); j++)
            {
                _grid[i, j] = _tileType;
            }
        }
    }
    public void ChangeTile(int _tileType ,Vector2Int coor , int[,] _grid)
    {
        int x = coor.x;
        int y = coor.y; 
        _grid[y, x] = _tileType;
    }
    public Vector2Int ChangeTileRandom(int _tileType, int[,] _grid)
    {
        int x = Random.Range(0, _grid.GetLength(1));
        int y = Random.Range(0, _grid.GetLength(0));

        Vector2Int coor = new Vector2Int(x,y);
        ChangeTile(_tileType, coor, _grid);

        return coor;
    }

    public void ShowGrid(int[,] _grid)
    {
        string gridText = "";
        for (int i = 0; i < _grid.GetLength(0); i++)
        {
            for (int j = 0; j < _grid.GetLength(1); j++)
            {
                gridText += _grid[i, j] + " , ";
            }
            gridText += "\n";
        }
        print(gridText);
    }


    public Vector2Int MovePlayerToPos(Vector2Int coor , int[,] _grid)
    {
        _grid[playerPos.y, playerPos.x] = 1;

        _grid[coor.y, coor.x] = 3;

        playerPos = coor;

        return playerPos;
    }
    #endregion
    public Vector2Int GetPlayerPos()
    {
        return playerPos;
    }
    public void SetPlayer(Vector2Int coor)
        { playerPos = coor; }
    public int[,] GetGrid()
    {
        return grid;
    }
}
