using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    void OnTriggerEnter2D(Collider2D collision)
    {
        // if (the tag is package)
        // then (print picked up package to console)
        if(collision.CompareTag("Package"))
        {
         Debug.Log("Picked up package");
            hasPackage = true;
        }

        if (collision.CompareTag("Customer") && hasPackage)
        {
            Debug.Log("Delivered package");
            hasPackage = false;
        }
    }
}
