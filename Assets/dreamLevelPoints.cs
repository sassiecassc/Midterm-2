using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dreamLevelPoints : MonoBehaviour
{

    public int dreampoints;
    public Text DreamPointsText;

    

    // Start is called before the first frame update
    void Start()
    {
      
    }

    public void IncreasePoints()
    {

        dreampoints++;
        DreamPointsText.text = ("dream stuffies: " + dreampoints.ToString());

    }
}
