using System;
using UnityEngine;

public class Buzzsaw : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent<SelfDestructScript>(out SelfDestructScript selfDestructScript))
        {
            other.SendMessage("SelfDestruct", SendMessageOptions.DontRequireReceiver);
        }
    }
}
