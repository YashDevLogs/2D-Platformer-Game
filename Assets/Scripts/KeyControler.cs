using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyControler : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<PlayerController>()!=null)
        {
            PlayerController playerController = collision.gameObject.GetComponent<PlayerController>();
            playerController.PickUpKey();
            SoundManager.Instance.play(Sounds.KeyPickup);
            Destroy(gameObject);
        }
    }
}
