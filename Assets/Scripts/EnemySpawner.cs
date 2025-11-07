
using UnityEngine;
using System.Collections.Generic;

public class EnemySpawner : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public Transform Target;
    public Transform Holder;
    public float Radius;
    public float Frequency;
    float current;

    public List<GameObject> Spawns;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Spawner();
    }
    public void Spawner()
    {
        current += Time.deltaTime;
        if (current >= Frequency)
        {
            float angle = Random.Range(0, Mathf.PI * 2f);

            Vector3 pos = Target.position + ( new Vector3(Mathf.Cos(angle) , Mathf.Sin(angle)) *Radius);

            GameObject enemy = Instantiate(EnemyPrefab, Holder);
            enemy.transform.position = pos;
            Spawns.Add(enemy);

            current = 0;
        }
    }
}
