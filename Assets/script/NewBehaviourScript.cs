using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public Text t;
    public GameObject panel;
    private float zaman;
   

    
    // Start is called before the first frame update
    void Start()
    {
        zaman = 50f;
        panel.SetActive(false);

            
    }

    // Update is called once per frame
    void Update()
    {
        if (zaman > 0)
            zaman -= Time.deltaTime; // zaman azalsýn
        else
            zaman = 0;
        if (zaman == 0)
            panel.SetActive(true);

        t.text = (int)zaman + "";
      
      
    }
}
