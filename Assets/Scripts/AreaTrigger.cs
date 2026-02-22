using UnityEngine;

public class AreaTrigger : MonoBehaviour
{
    private MeshRenderer[] meshRenderers;

    //All transparent materials
    [SerializeField]
    private Material[] transparentMaterials;

    //All opaque materials
    [SerializeField]
    private Material[] opaqueMaterials;

    [SerializeField]
    private GameObject MovementManager;


    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            meshRenderers = GetComponentsInChildren<MeshRenderer>(); //returns an array of all the mesh renderers in the children of the object this script is attached to

            foreach (MeshRenderer renderer in meshRenderers)
            {
                for (int i = 0; i < transparentMaterials.Length; i++)
                {
                    if (renderer.sharedMaterial == transparentMaterials[i])
                    {
                        renderer.material = opaqueMaterials[i];
                        break;
                    }
                }
            }

        }

        if (MovementBehaviour.area1Done == false)
        {
            MovementBehaviour.area1Done = true;
            MovementManager.GetComponent<MovementBehaviour>().nextArea();
        }
        else if (MovementBehaviour.area2Done == false)
        {
            MovementBehaviour.area2Done = true;
            MovementManager.GetComponent<MovementBehaviour>().nextArea();
        }
        else if (MovementBehaviour.area3Done == false)
        {
            MovementBehaviour.area3Done = true;
            MovementBehaviour.allAreasDone = true;
            MovementManager.GetComponent<MovementBehaviour>().nextArea();
            MovementManager.GetComponent<MovementBehaviour>().startTele();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameObject.GetComponent<BoxCollider>().enabled = false; //disables the box collider of the object this script is attached to, so that the script is not constantly activated
        }
    }
}
