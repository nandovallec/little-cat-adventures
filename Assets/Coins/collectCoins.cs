using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class collectCoins : MonoBehaviour
{

    public int coins = 0;
    public TMP_Text coinCounter;
    // Start is called before the first frame update
    void Start(){
    }

    public void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Coin"){
            Debug.Log("Coin collected");
            coins = coins + 1;
            Destroy(other.gameObject);
            coinCounter.text = "Coins: " + coins;
        }
    }

    // Update is called once per frame
    void Update(){
                
    }
}
