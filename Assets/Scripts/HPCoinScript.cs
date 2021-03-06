using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPCoinScript : MonoBehaviour
{
    Animator anim;
    PlayerStatus player_status;
    public bool AlreadyPassed;
    AudioSource my_source;
    // Start is called before the first frame update
    void Start()
    {
        anim = this.gameObject.GetComponent<Animator>();
        player_status = GameObject.FindWithTag("Player").GetComponent<PlayerStatus>();
        my_source = this.gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player"){
            if(!AlreadyPassed){
                anim.SetTrigger("Change");
                my_source.PlayOneShot(my_source.clip);
                player_status.HPSet(3);
                AlreadyPassed = true;
            }

        }
    }
}
