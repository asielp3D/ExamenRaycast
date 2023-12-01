using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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
                StartCoroutine(TimerCoroutine1());
                
                
            }

            if(hitRayo.transform.gameObject.layer == 7)
            {
                Debug.Log("impacto cubo grande");
                StartCoroutine(TimerCoroutine2());
            }

            if(hitRayo.transform.gameObject.layer == 8)
            {
                Debug.Log("impacto cubo pequeño");
                StartCoroutine(TimerCoroutine3());
            }
        } 
    }

    IEnumerator TimerCoroutine1()
    {
        Debug.Log("5");
        yield return new WaitForSeconds (1);
        Debug.Log("4");
        yield return new WaitForSeconds (1);
        Debug.Log("3");
        yield return new WaitForSeconds (1);
        Debug.Log("2");
        yield return new WaitForSeconds (1);
        Debug.Log("1");
        yield return new WaitForSeconds (1);
        SceneManager.LoadScene(1);
    }

    IEnumerator TimerCoroutine2()
    {
        Debug.Log("5");
        yield return new WaitForSeconds (1);
        Debug.Log("4");
        yield return new WaitForSeconds (1);
        Debug.Log("3");
        yield return new WaitForSeconds (1);
        Debug.Log("2");
        yield return new WaitForSeconds (1);
        Debug.Log("1");
        yield return new WaitForSeconds (1);
        SceneManager.LoadScene(2);
    }

    IEnumerator TimerCoroutine3()
    {
        Debug.Log("5");
        yield return new WaitForSeconds (1);
        Debug.Log("4");
        yield return new WaitForSeconds (1);
        Debug.Log("3");
        yield return new WaitForSeconds (1);
        Debug.Log("2");
        yield return new WaitForSeconds (1);
        Debug.Log("1");
        yield return new WaitForSeconds (1);
        SceneManager.LoadScene(3);
    }
}