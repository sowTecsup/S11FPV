
using System.Collections.Generic;
using UnityEngine;

public class VisualGridManager : MonoBehaviour
{
    public GameObject PlayerPrefab;
    public GameObject TerrainPrefab;

    public float space;


    public Transform holder;
    private List<GameObject> spawned = new();

    void Start()
    {
        
    }

    public void ShowVisualMap(int[,] grid)
    {
        holder.transform.position = Vector3.zero;
        foreach (var item in spawned)
        {
            Destroy(item.gameObject);
        }
        spawned.Clear();    


        for (int i = 0; i < grid.GetLength(0); i++)
        {
            for(int j = 0; j < grid.GetLength(1); j++)
            {

                if (grid[i,j] == 3)
                {
                    GameObject player = Instantiate(PlayerPrefab, holder);
                    spawned.Add(player);

                    player.transform.position = new Vector2(j * space, i * -space);
                }
                else
                {
                    GameObject terrain = Instantiate(TerrainPrefab, holder);
                    spawned.Add(terrain);
                    terrain.transform.position = new Vector2(j * space, i * -space);
                }

               
            }
        }
        //holder.transform.position = new Vector3((grid.GetLength(1) / 2) * space, (grid.GetLength(0) / 2) * -space);

        holder.transform.position = new Vector3((grid.GetLength(1) / 2) * -space, (grid.GetLength(0) / 2) * space);
    }
}
