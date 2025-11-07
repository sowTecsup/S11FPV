using UnityEngine;

public enum Direction
{
    None,
    Up,
    Down,
    Left,
    Right
}

public class GameManager : MonoBehaviour
{
    public GridManager gridManager;
    public VisualGridManager visualGridManager;

    void Start()
    {
        gridManager.SetGrid();
        gridManager.ChangeAllTiles(1, gridManager.GetGrid());
        gridManager.SetPlayer( gridManager.ChangeTileRandom(3, gridManager.GetGrid()));
        ShowGrid();
        UpdateVisualGrid();
    }

    public void Update()
    {
        MovementMechanic();
    }
    public void UpdateVisualGrid()
    {
        visualGridManager.ShowVisualMap(gridManager.GetGrid());
    }
    public void MovementMechanic()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Vector2Int NewPlayerPos = GetPlayerNewDirection(Direction.Down);
            if (VerifyMovement(NewPlayerPos))
            {
                ShowGrid();
                UpdateVisualGrid();
            }

        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Vector2Int NewPlayerPos = GetPlayerNewDirection(Direction.Up);
            if (VerifyMovement(NewPlayerPos))
            {
                ShowGrid();
                UpdateVisualGrid();
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Vector2Int NewPlayerPos = GetPlayerNewDirection(Direction.Right);
            if (VerifyMovement(NewPlayerPos))
            {
                ShowGrid();
                UpdateVisualGrid();
            }
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Vector2Int NewPlayerPos = GetPlayerNewDirection(Direction.Left);
            if (VerifyMovement(NewPlayerPos))
            {
                ShowGrid();
                UpdateVisualGrid();
            }
        }
    }
    public bool VerifyMovement(Vector2Int coor)
    {
        if ((coor.x < gridManager.GetGrid().GetLength(1) && coor.x >= 0 ) && (coor.y < gridManager.GetGrid().GetLength(0) && coor.y >= 0))
        {
            gridManager.MovePlayerToPos(coor, gridManager.GetGrid());
            return true;
        }
        print("Limit Reach");
        return false;
        
    }
    public Vector2Int GetPlayerNewDirection(Direction direction)
    {
        Vector2Int playerPos = gridManager.GetPlayerPos();

        switch (direction)
        {
            case Direction.None:  return Vector2Int.zero;
            case Direction.Up:    return new Vector2Int(playerPos.x, playerPos.y - 1);
            case Direction.Down:  return new Vector2Int(playerPos.x, playerPos.y + 1);
            case Direction.Left:  return new Vector2Int(playerPos.x - 1, playerPos.y);
            case Direction.Right: return new Vector2Int(playerPos.x + 1, playerPos.y);
        }
        return playerPos;

    }

    public void ShowGrid()
    {
        gridManager.ShowGrid(gridManager.GetGrid());
    }

}


/*
 
private string[] mapaDemoV1 = new string[] { "Bosque", "Piedra", "Personaje", "Piedra" };
    // private string[,] mapaDemoV2 = new string[10,4];
    private string[,] mapaDemoV2 = new string[,] 
    {
    // C   ,   , 
        {"a","b","c" },//
        {"d","e","f" },//
        {"g","h","i" }//
    };

    private string[][] mapaDemoV3 = new string[2][]
    {
        new string[]{"a","b","c" },
        new string[]{ "d", "e", "f" ,"g","h","i" }
    };
    void Start()
    {
        /*for (int i = 0; i < mapaDemoV1.Length; i++)//4
        {
            print(mapaDemoV1[i]);
        }
//print(mapaDemoV2[0, 0])

for (int i = 0; i < mapaDemoV2.GetLength(0); i++)
{
    //print(mapaDemoV2[i, 0]);
    for (int j = 0; j < mapaDemoV2.GetLength(1); j++)
    {
        print(mapaDemoV2[i, j]);
    }
}



//print(mapaDemoV3.Length);

int countElements = 0;
for (int i = 0; i < mapaDemoV3.Length; i++)
{
    for (int j = 0; j < mapaDemoV3.Length; j++)
    {

    }
    countElements += mapaDemoV3[i].Length;
}
print("La cantidad total de elementos es :" + countElements);


for (int i = 0; i < mapaDemoV3.Length; i++)
{
    for (int j = 0; j < mapaDemoV3[i].Length; j++)
    {
        print(mapaDemoV3[i][j]);
    }

}
    }
*/