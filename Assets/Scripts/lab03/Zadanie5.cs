using UnityEngine;
using System.Collections.Generic;

public class InstantiationExample : MonoBehaviour 
{
    public GameObject myPrefab;
    public int NumberOfObjects = 10;

    void Start()
    {
        List<Vector3> taken_position = new List<Vector3>();

       for (int i = 0; i < NumberOfObjects; i++)
        {
            Vector3 random_position = GetPosition(taken_position);
            Instantiate(myPrefab, random_position, Quaternion.identity);
            taken_position.Add(random_position);
        }
    }

    Vector3 GetPosition(List<Vector3> taken_position)
    {
        Vector3 position = new Vector3(Random.Range(-10f, 10f), 0f, Random.Range(-10f, 10f));

        while(taken_position.Contains(position))
        {
            position = new Vector3(Random.Range(-5f, 5f), 0f, Random.Range(-5f, 5f));
        }

        return position;
    }    
}