using UnityEngine;

public class Delivery : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        // if (the tag is package)
        // then (print picked up package to console)
        if(collision.CompareTag("Package"))
        {
         Debug.Log("Picked up package");
        }

        if (collision.CompareTag("Customer"))
        {
            Debug.Log("Delivered package");
        }
    }
}
