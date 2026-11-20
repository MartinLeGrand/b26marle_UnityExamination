using UnityEngine;

public class SelfDestructScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void SelfDestruct()
    {
        Destroy(gameObject);
    }
}
