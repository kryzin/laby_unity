using UnityEngine;

public class InstantiationExample : MonoBehaviour 
{
    public GameObject myPrefab;
    public int NumberOfObjects = 10;

    void Start()
    {
       for (int i = 0; i < NumberOfObjects; i++)
        {
            Vector3 randomPos = new Vector3(Random.Range(-5f, 5f), 0f, Random.Range(-5f, 5f));
            Instantiate(myPrefab, randomPos, Quaternion.identity);
        }
        
    }
}