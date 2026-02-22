using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class PuzzleManager : MonoBehaviour
{
    public static bool trophyOne = false;
    public static bool trophyTwo = false;

    public GameObject pedestalSocket;

    public void rabbitDrawer()
    {
        gameObject.GetComponent<ConfigurableJoint>().xMotion = ConfigurableJointMotion.Limited;
    }

    public void iceGrab()
    {
        gameObject.GetComponent<Rigidbody>().isKinematic = false;
        gameObject.GetComponent<XRGrabInteractable>().enabled = true;
    }

    public void trophyOneInserted()
    {
        trophyOne = true;
        checkTrophies();
    }

    public void trophyOneOut()
    {
        trophyOne = false;
        checkTrophies();
    }

    public void trophyTwoInserted()
    {
        trophyTwo = true;
        checkTrophies();
    }

    public void trophyTwoOut()
    {
        trophyTwo = false;
        checkTrophies();
    }

    public void checkTrophies()
    {
        if(trophyOne == true && trophyTwo == true)
        {
            pedestalSocket.GetComponent<XRSocketInteractor>().enabled = true;
        }
        else
        {
            pedestalSocket.GetComponent<XRSocketInteractor>().enabled = false;
        }
    }

    public void winUI()
    {
        if(trophyOne == true && trophyTwo == true)
        {
            gameObject.SetActive(true);
        }
    }
    
}
