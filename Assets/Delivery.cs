using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
  [SerializeField] float destroyDelay = 0.5f;
  bool hasPackage;
  void OnCollisionEnter2D(Collision2D other)
  {
    Debug.Log("Collision!");
  }

  void OnTriggerEnter2D(Collider2D other)
  {
    if (other.tag == "Package" && !hasPackage)
    {
      Debug.Log("Package pick up!");
      hasPackage = true;
      Destroy(other.gameObject, destroyDelay);
    }

    if (other.tag == "Customer" && hasPackage)
    {
      hasPackage = false;
      Debug.Log("Package delivered!");
    }
  }
}
