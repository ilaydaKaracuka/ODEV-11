using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using UnityEngine.UI;
public class OyuncuHareket : NetworkBehaviour
{
    private Animator animator;
    private Rigidbody rb;
    public Text text1;
    public int i;
 

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        i = 0;
      

    }
    private void Update()
    {
        i=GetComponent<collision>().toplanan;
        text1.text = i.ToString();
        print("\n");

    }


    private void FixedUpdate()
    {  if (!isLocalPlayer) return; //baska oyuncuyu kontrol etmemek icin
        if (Input.GetKey(KeyCode.W)) //ileri
        {
            animator.SetBool("isrun", true);
            transform.Translate(new Vector3(0, 0, 10f) * Time.deltaTime); //z de hareket etsin konum deðiþtirsin
        }
        

        else if (Input.GetKey(KeyCode.S)) //geri
        {
            animator.SetBool("isrun", true);
            transform.Translate(new Vector3(0, 0, -10f) * Time.deltaTime); //z de hareket etsin konum deðiþtirsin
        }
        else if (Input.GetKey(KeyCode.A)) //sola
        {
            animator.SetBool("isrun", true);
            transform.Translate(new Vector3(-10f, 0, 0) * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D)) //saga
        {
            animator.SetBool("isrun", true);
            transform.Translate(new Vector3(10f, 0, 0) * Time.deltaTime);
        }
        else
            animator.SetBool("isrun", false); //tikli deðilse dursun

    }
}
