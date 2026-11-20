using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class SelfDestructScript : MonoBehaviour
{
    [SerializeField] UnityEvent OnDestroy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void SelfDestruct()
    {
        Debug.Log("SelfDestruct");
        OnDestroy.Invoke();
        StartCoroutine(DestroySelf());
    }
    IEnumerator DestroySelf()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}
