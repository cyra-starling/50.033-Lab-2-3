using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakBrick : MonoBehaviour
{
    private bool broken = false;
    public GameObject brick;
    private AudioSource brickSound;
    public GameObject coin;
    public GameConstants gameConstants;
    // Start is called before the first frame update
    void Start()
    {
        brickSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void  OnTriggerEnter2D(Collider2D col){
        if (col.gameObject.CompareTag("Player") &&  !broken){
            this.transform.parent.GetComponent<SpriteRenderer>().enabled = false;
            Instantiate(coin, new Vector3(this.transform.position.x, this.transform.position.y + 5f, this.transform.position.z), transform.rotation);
            //play sound
            StartCoroutine(playShatterSound());
        }
    }

    IEnumerator playShatterSound(){
        Debug.Log("Sound gonna be play");
        brickSound.Play();
        for (int x =  0; x<gameConstants.spawnNumberOfDebris; x++){
			Instantiate(brick, transform.position, Quaternion.identity);
		}
        yield return new WaitForSeconds(1f);
        broken  =  true;
        Destroy(transform.parent.gameObject);
    }
}
