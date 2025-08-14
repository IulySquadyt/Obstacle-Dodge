using System.Xml.Schema;
using Unity.VisualScripting;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField]float rotationSpeed = 1f;
    [SerializeField]float xSpeed = 0f;
    [SerializeField]float ySpeed = 0f;
    [SerializeField]float zSpeed = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float xAngle = rotationSpeed * Time.deltaTime * xSpeed;
        float yAngle = rotationSpeed * Time.deltaTime * ySpeed;
        float zAngle = rotationSpeed * Time.deltaTime * zSpeed;
        transform.Rotate(xAngle, yAngle, zAngle);
    }
}
