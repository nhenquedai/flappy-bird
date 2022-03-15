using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Bird : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    public float JumpForce;
    public GameObject control;
    private bool Start;
    private int score;
    public Text scoreText;
    public GameObject message;
    
    private void Awake(){
         rigidbody = this.gameObject.GetComponent<Rigidbody2D>();
         Start = false;
         rigidbody.gravityScale = 0;
         score = 0;
         message.GetComponent<SpriteRenderer>().enabled = true;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            sound.instance.playSound("wing", 0.7f);
            if(Start == false){
                Start = true;
                rigidbody.gravityScale = 8;
                control.GetComponent<BornPipe>().enableBornPipe = true;
                message.GetComponent<SpriteRenderer>().enabled = false;
            }
            BirdJump();
        }
    }

    private void BirdJump(){
        rigidbody.velocity = Vector2.up*JumpForce;
    }

    private void OnCollisionEnter2D(Collision2D collision){
        GameOver();
        score = 0;
    }

    public void GameOver(){
        sound.instance.playSound("hit", 0.7f);
        SceneManager.LoadScene("flappy bird");
    }
    
    private void OnTriggerEnter2D(Collider2D collision){
        sound.instance.playSound("point", 0.7f);
        score += 1;
        scoreText.text = score.ToString();
    }
}
