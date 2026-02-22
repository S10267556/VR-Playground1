using UnityEngine;

public class SmashBox : MonoBehaviour
{
    [SerializeField]
    private GameObject trophyItem;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Weapon"))
        {
            Destroy(gameObject);
            Instantiate(trophyItem, transform.position, Quaternion.identity); //instanciates trophy item where the box used to be
        }
    }
}
