using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mirror;

public class collision : NetworkBehaviour
{
    private Animator animator;
    GameObject g;
    private int a;
    private int k;
    public int toplanan;
    private string b;
    public Text text1;
    float t;
   float c;
    
    // Start is called before the first frame update
    void Start()
    {

        animator = GetComponent<Animator>();
        a = 0;
        k = 2;
        t = 0;
        toplanan = 0;
        c = 1.6f;

    }

    // Update is called once per frame
    void Update()
    {
        b = a.ToString();
        if (a != 0)
        {
            foreach (Transform child in transform)
            {

                if (child.name == b)
                {
                    child.gameObject.SetActive(true);
                    print(b+" numaralý civciv aktif oldu");

                }
            }
        }
        if(k==1)
        {
            t += Time.deltaTime;
            if (t >= c)
            {
                k = 0;
                g.SetActive(false); //eldeki civciv görüntüsünü kapat

            }
        }
        text1.text = toplanan.ToString();
        print("toplanan= " + toplanan);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (!isLocalPlayer) return; //baska oyuncuyu kontrol etmemek icin
        if (collision.gameObject.tag == "chick")
        {
          
            //animator.SetBool("ishold", true);
            Destroy(collision.gameObject);
            
            foreach (Transform child in transform)
            {
                if (child.name == "chick"&&k!=0)
                {
                    g = child.gameObject;
                      g.  SetActive(true);
                    child.gameObject.SetActive(true);
                    k = 1;
                   
                }
            }

           
        }
        else
            animator.SetBool("ishold", false);
        if (collision.gameObject.tag == "cit"&& k==1) //cite carpýnca a 1 artsýn a sayýsý kaç olduysa
                                                      //a numaralý civciv deðilen cit de setactive(true) olsun
        { 
            a++;
            toplanan++;
        }
    }
}