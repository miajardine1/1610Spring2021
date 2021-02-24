using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownBehaviour : MonoBehaviour
{
    
    public float holdTime = 1f;
    public int number = 3;
    public Text countDownText;

    private WaitForSeconds wfsObj;
   
    IEnumerator Start()
    {
        wfsObj = new WaitForSeconds(holdTime);
        
        while (number > 0) 
        { 
            countDownText.text = number.ToString();
            number--;
            yield return wfsObj;
        }

        countDownText.text = "Go!";

        yield return wfsObj;

        countDownText.text = null;

    }

}
