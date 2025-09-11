using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ouch!");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("What the heck was that?");
    }
}
