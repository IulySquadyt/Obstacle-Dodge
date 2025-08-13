using Unity.Hierarchy;
using UnityEngine;

public class Dropper : MonoBehaviour
{   
    [SerializeField]float timeToDrop = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToDrop)
        {
            Debug.Log("Look out below!");
        }
    }
}
