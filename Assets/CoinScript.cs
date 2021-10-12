using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScript : MonoBehaviour
{
    public GameManager gm;
    public GameObject particle;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       // CoinText.text = "Coin: " + CoinCount;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {            
            print("Plus 10");
            gm.CoinScore();
            SpawnParticle();
            StartCoroutine(waitB4Destroy());
        }
    }
    IEnumerator waitB4Destroy()
    {
        yield return new WaitForSeconds(0.3f);
        Destroy(gameObject);
    }    

    public void SpawnParticle()
    {
        Instantiate(particle, transform.position, transform.rotation);
    }
   

}
