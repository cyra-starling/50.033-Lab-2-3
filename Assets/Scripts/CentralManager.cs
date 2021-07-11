using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CentralManager : MonoBehaviour
{
	public  GameObject powerupManagerObject;
	private  PowerupController powerUpManager;
    public  GameObject gameManagerObject;
	private  GameManager gameManager;
	public  static  CentralManager centralManagerInstance;
	
	void  Awake(){
		centralManagerInstance  =  this;
	}

	void  Start()
	{
		powerUpManager  =  powerupManagerObject.GetComponent<PowerupController>();
		gameManager = gameManagerObject.GetComponent<GameManager>();
	}

	public  void  increaseScore(){
		gameManager.increaseScore();
	}

    public void damagePlayer(){
        gameManager.damagePlayer();
    }

	public  void  consumePowerup(KeyCode k, GameObject g){
		powerUpManager.consumePowerup(k,g);
	}

	public  void  addPowerup(Sprite s, int i, ConsumableInterface c){
		powerUpManager.addPowerup(s, i, c);
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
