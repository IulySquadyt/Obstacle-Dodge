using Unity.Hierarchy;
using UnityEngine;

public class Dropper : MonoBehaviour
{   
    [SerializeField]float timeToDrop = 3f;

    MeshRenderer myMeshRenderer;

    Rigidbody myRigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myMeshRenderer.enabled = false;
        myRigidbody = GetComponent<Rigidbody>();
        myRigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToDrop)
        {
            myMeshRenderer.enabled = true;
            myRigidbody.useGravity = true;
            Debug.Log("Look out below!");
        }
    }
}
