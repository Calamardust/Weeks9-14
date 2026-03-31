using UnityEngine;

public class SpawnerC : MonoBehaviour
{
    public GameObject Coconut;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void spawnCoconut()
    {
        Instantiate(Coconut);
    }
}
