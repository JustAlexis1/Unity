using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool gameEnded = false;
    public GameObject objectToDeactivate;
    public GameObject objectToActivateBad;
    public GameObject objectToActivateGood;

    // Update is called once per frame
    void Update()
    {
        if (gameEnded)
            return;
        if (PlayerStats.Lives <= 0)
        {
            EndGame();
        }
        if (PlayerStats.Waves <= 0)
        {
            HapyEnd();
        }
    }

    void EndGame ()
    {
        gameEnded = true;
        objectToActivateBad.SetActive(true);
        objectToDeactivate.SetActive(false);
    }

    void HapyEnd ()
    {
        gameEnded = true;
        objectToActivateGood.SetActive(true);
        objectToDeactivate.SetActive(false);
    }

}
