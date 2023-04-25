using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int pigCount;
    public GameObject Ingame;
    public GameObject Level;
    public void PigDestroyed()
    {
        pigCount = pigCount - 1;
        if(pigCount ==0)
        {
            Ingame.gameObject.SetActive(true);
            Level.gameObject.SetActive(true);
        }
    }
}
