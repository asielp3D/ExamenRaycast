using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayoMagico : MonoBehaviour
{
    public Camera camaraPrincipal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Rayo();
        }
    }

    void Rayo()
    {
        Ray ray = camaraPrincipal.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitRayo;

        if(Physics.Raycast(ray, out hitRayo, Mathf.Infinity))
        {
            Debug.DrawLine(Camera.main.transform.position, hitRayo.point);
            
            if(hitRayo.transform.gameObject.layer == 6)
            {
                Debug.Log("impacto bola");
            }

            if(hitRayo.transform.gameObject.layer == 7)
            {
                Debug.Log("impacto cubo grande");
            }

            if(hitRayo.transform.gameObject.layer == 8)
            {
                Debug.Log("impacto cubo pequeño");
            }
        } 
    }
}