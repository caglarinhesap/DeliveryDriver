using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor;
    [SerializeField] Color32 noPackageColor;
    [SerializeField] float destroyDelay = 0.5f;
    bool hasPackage;
    SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision!");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Package" && !hasPackage)
        {
            Debug.Log("Packet Picked Up");
            hasPackage = true;
            Destroy(collision.gameObject, destroyDelay);
            spriteRenderer.color = hasPackageColor;
        }

        if (collision.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package Delivered");
            hasPackage = false;
            Destroy(collision.gameObject, destroyDelay);
            spriteRenderer.color = noPackageColor;
        }
    }
}
