using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public GameObject grabbableCube;
    public GameObject typicalCube;
    public GameObject cylinder;
    public GameObject square;

    private Renderer grabbableRenderer;
    private Renderer typicalRenderer;
    private Renderer cylinderRenderer;
    private Renderer squareRenderer;

    void Start()
    {
        grabbableRenderer = grabbableCube.GetComponent<Renderer>();
        typicalRenderer = typicalCube.GetComponent<Renderer>();
        cylinderRenderer = cylinder.GetComponent<Renderer>();
        squareRenderer = square.GetComponent<Renderer>();
    }

    void OnTriggerEnter (Collider other)
{

    Debug.Log("Collision detected with: " + other.gameObject.name);
    
    if (other.gameObject == typicalCube)
    {
        Debug.Log("Collided with typical cube!");
        // Change the color of the grabbable cube to green
        grabbableRenderer.material.color = Color.green;
    }
    else if (other.gameObject == cylinder || other.gameObject == square)
    {
        Debug.Log("Collided with cylinder or square!");
        // Change the color of the collided object to red
        Renderer collidedRenderer = other.gameObject.GetComponent<Renderer>();
        collidedRenderer.material.color = Color.red;
    }


    }
}

