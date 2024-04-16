using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int fishes = 0;

    [SerializeField] private Text fishesText;

    [SerializeField] private AudioSource collectionSoundEffect;

   private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Fish"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            fishes++;
            fishesText.text = "fishes:" + fishes; 
        }
    }
}
