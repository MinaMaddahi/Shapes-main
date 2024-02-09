using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacementDetector : MonoBehaviour
{
    public AudioClip correctSound;
    public AudioClip incorrectSound;

    private AudioSource audioSource;
    private Renderer renderer;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        renderer = GetComponent<Renderer>();
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the collided object is a fixed position object
        if (other.CompareTag("FixedPosition"))
        {
            // Check if the collided object matches the correct pair
            if (gameObject.CompareTag(other.tag))
            {
                // Play correct sound
                audioSource.clip = correctSound;
                audioSource.Play();

                // Change color to green
                renderer.material.color = Color.green;
            }
            else
            {
                // Play incorrect sound
                audioSource.clip = incorrectSound;
                audioSource.Play();

                // Change color to red
                renderer.material.color = Color.red;
            }
        }
    }
}


