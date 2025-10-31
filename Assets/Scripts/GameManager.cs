using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GridManager gridManager;
    public VisualGridManager visualGridManager;

    /*
     * 0 muro
     * 1 piso
     * 2 arbol
     * 3 personaje
     * 
     */

    void Start()
    {
        gridManager.SetGrid();
        gridManager.ChangeAllTiles(1, gridManager.GetGrid());
        gridManager.SetPlayer( gridManager.ChangeTileRandom(3, gridManager.GetGrid()));
        gridManager.ShowGrid(gridManager.GetGrid());
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            Vector2Int playerPos = gridManager.GetPlayerPos();
            Vector2Int NewPlayerPos = new Vector2Int(playerPos.x, playerPos.y +1);
            if (NewPlayerPos.y < gridManager.GetGrid().GetLength(0) && NewPlayerPos.y >= 0)
            {
                gridManager.MovePlayerToPos(NewPlayerPos, gridManager.GetGrid());
                gridManager.ShowGrid(gridManager.GetGrid());
            }
            else
            {
                print("Limite Y");
            }

        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Vector2Int playerPos = gridManager.GetPlayerPos();
            Vector2Int NewPlayerPos = new Vector2Int(playerPos.x, playerPos.y -1 );
            if (NewPlayerPos.y < gridManager.GetGrid().GetLength(0)  && NewPlayerPos.y >= 0)
            {
                gridManager.MovePlayerToPos(NewPlayerPos, gridManager.GetGrid());
                gridManager.ShowGrid(gridManager.GetGrid());
            }
            else
            {
                print("Limite Y");
            }

        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Vector2Int playerPos = gridManager.GetPlayerPos();
            Vector2Int NewPlayerPos = new Vector2Int(playerPos.x+1, playerPos.y );
            if (NewPlayerPos.x < gridManager.GetGrid().GetLength(1) && NewPlayerPos.x >= 0)
            {
                gridManager.MovePlayerToPos(NewPlayerPos, gridManager.GetGrid());
                gridManager.ShowGrid(gridManager.GetGrid());
            }
            else
            {
                print("Limite X");

                /*gridManager.MovePlayerToPos(new Vector2Int(0, NewPlayerPos.y), gridManager.GetGrid());
                gridManager.ShowGrid(gridManager.GetGrid());*/
            }

        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Vector2Int playerPos = gridManager.GetPlayerPos();
            Vector2Int NewPlayerPos = new Vector2Int(playerPos.x - 1, playerPos.y);
            if (NewPlayerPos.x < gridManager.GetGrid().GetLength(1) && NewPlayerPos.x >= 0)
            {
                gridManager.MovePlayerToPos(NewPlayerPos, gridManager.GetGrid());
                gridManager.ShowGrid(gridManager.GetGrid());
            }
            else
            {
                print("Limite X");
            }

        }
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