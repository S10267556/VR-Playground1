using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation;

public class MovementBehaviour : MonoBehaviour
{
    //Movement Areas
    [SerializeField]
    private GameObject[] movementAreas;

    [SerializeField]
    private GameObject[] areaTexts;

    public static bool area1Done = false;
    [SerializeField]
    private GameObject area1Text;

    public static bool area2Done = false;

    public static bool area3Done = false;

    public static bool allAreasDone = false;
    public static int areaIndex = 0;


    //Teleportation Areas
    
    [SerializeField]
    private GameObject[] teleTexts;
    public static bool tele1Done = false;
    [SerializeField]
    private GameObject tele1;

    public static bool tele2Done = false;
    [SerializeField]
    private GameObject tele2;
    [SerializeField]
    private GameObject nextSceneDoor;

    private int teleIndex = 0;

    public void nextArea()
    {
        areaTexts[areaIndex].SetActive(true);
        if(allAreasDone == false)
        {
            areaIndex++;
            movementAreas[areaIndex].GetComponent<BoxCollider>().enabled = true;
        }
        
    }

    public void startTele()
    {
        tele1.SetActive(true);
        teleTexts[0].SetActive(false);
    }

    public void nextTele()
    {   
        if(tele1Done == false)
        {
            tele2.SetActive(true);
            teleTexts[1].SetActive(false);
            //tele2.GetComponentInChildren<TeleportationArea>().enabled = true;
            teleTexts[teleIndex].SetActive(true);
            tele1Done = true;
            teleIndex++;
        }
        else if(tele2Done == false)
        {
            teleTexts[teleIndex].SetActive(true);
            nextSceneDoor.SetActive(true);
            tele2Done = true;
        } 
    }
    
}
