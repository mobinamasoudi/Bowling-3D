using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class progres_Bar : MonoBehaviour
{
    public RectTransform Line;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Set_Progrees_Bar_Ammount(float Ammount)
    {
        Line.localScale = new Vector3(Line.localScale.x,  Ammount, Line.localScale.z);
    }


}
