//using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private AudioClip clipsound;
    private int count = 0;
   


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Collectible"))
        {
            count++;
            AudioSource.PlayClipAtPoint(clipsound, other.transform.position);
            Destroy(other.gameObject);
        }
    }
}
