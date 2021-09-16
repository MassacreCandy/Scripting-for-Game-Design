using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyColor : MonoBehaviour
{
    public Gradient cycleColors;

    public Color startColor;
    public Color midColor;
    public Color endColor;
    public float fullCycleTime = 18;
    float currentLerping = 0;


    // Start is called before the first frame update
    void Start()
    {
        Camera.main.backgroundColor = cycleColors.Evaluate(0);
    }

    // Update is called once per frame
    void Update()
    {
        //Method A (Inverse Lerp Value)
        /*currentLerping += (1 / (fullCycleTime / 3)) * Time.deltaTime;*/

        //Method B use inverse lerp to caluculate how much time has pass since the start of the cycle
        //By multiplying it for how long a section of said cycle
        currentLerping =
            Mathf.InverseLerp(0,
            fullCycleTime,
            currentLerping * (fullCycleTime) + Time.deltaTime);

        //Method C
        //Keep track of the time and simply inverse lerp it

        Camera.main.backgroundColor = cycleColors.Evaluate(currentLerping);

        //    if (currentLerping >= 0 && currentLerping < (1f/3) )
        //    {
        //        Camera.main.backgroundColor = Color.Lerp(startColor, midColor, currentLerping * 3);

        //    }
        //    else if (currentLerping >= (1f / 3) && currentLerping < (2f/3) )
        //    {
        //        Camera.main.backgroundColor = Color.Lerp(midColor, endColor, 
        //            (currentLerping - ( 1f/3)) * 3);
        //    }
        //    else if (currentLerping >= (2f / 3) && currentLerping < (3f/3) )
        //    {
        //        Camera.main.backgroundColor = Color.Lerp(endColor, startColor, 
        //            (currentLerping - (2f/3)) * 3);
        //    }
        //    else
        //    {
        //        currentLerping = 0;
        //    }
    }
}
