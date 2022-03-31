using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour{

    public bool isPlayer1Goal;

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.CompareTag("Ball")){
            if(!isPlayer1Goal){
                Debug.Log("Joueur 1 a marqué !");
                GameObject.Find("GameManager").GetComponent<GameManager>().Player1Scored();
            }
            else{
                Debug.Log("Joueur 2 a marqué !");
                GameObject.Find("GameManager").GetComponent<GameManager>().Player2Scored();
            }
        }
    }

}
