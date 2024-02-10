using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceColorChange : MonoBehaviour
{
    public GameObject grabbableCube;
    public GameObject typicalCube;
    public GameObject cylinder;
    public GameObject square;
    public AudioClip correctPlacementAudio;
    public AudioClip incorrectPlacementAudio;
    private AudioSource audioSource;

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

        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision detected with: " + other.gameObject.name);

        if (other.gameObject == typicalCube)
        {
            Debug.Log("Collided with typical cube!");
            // Change the color of the grabbable cube to green
            grabbableRenderer.material.color = Color.green;
            // Play correct placement audio
            audioSource.PlayOneShot(correctPlacementAudio);
        }
        else if (other.gameObject == cylinder || other.gameObject == square)
        {
            Debug.Log("Collided with cylinder or square!");
            // Change the color of the collided object to red
            Renderer collidedRenderer = other.gameObject.GetComponent<Renderer>();
            collidedRenderer.material.color = Color.red;
            // Play incorrect placement audio
            audioSource.PlayOneShot(incorrectPlacementAudio);
        }
    }
}
