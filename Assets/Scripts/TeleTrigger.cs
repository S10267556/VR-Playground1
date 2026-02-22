using UnityEngine;

public class TeleTrigger : MonoBehaviour
{
    [SerializeField]
    private GameObject MovementManager;


    void OnTriggerEnter(Collider other)
    {
        MovementManager.GetComponent<MovementBehaviour>().nextTele();
    }
}
