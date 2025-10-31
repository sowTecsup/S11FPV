using UnityEngine;

public class GameManager : MonoBehaviour
{
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
        }*/
        //print(mapaDemoV2[0, 0])

        /*for (int i = 0; i < mapaDemoV2.GetLength(0); i++)
        {
            //print(mapaDemoV2[i, 0]);
            for (int j = 0; j < mapaDemoV2.GetLength(1); j++)
            {
                print(mapaDemoV2[i, j]);
            }
        }*/



        //print(mapaDemoV3.Length);

        int countElements = 0;
        for (int i = 0; i < mapaDemoV3.Length; i++)
        {
            /*for (int j = 0; j < mapaDemoV3.Length; j++)
            {

            }*/
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
