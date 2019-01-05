using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float speed = 10f;
    public float attackRange = 5f;

    public float attackRate = 1f;
    float currentTime = 0f;
    float time = 0f;

    public float enemySpeed = 0.5f;
    public Image enemyHealthBar;

    Transform player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        time = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, player.position) <= attackRange)
        {
            AttackPlayer();
        }
        else
        {
            //transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
            transform.position = Vector3.Lerp(transform.position, player.position, enemySpeed * Time.deltaTime);
        }
    }

    void AttackPlayer()
    {

        time -= Time.deltaTime;
        time = time / attackRate * 10;
        Debug.Log("Time:" + time);

        //currentTime = Time.deltaTime;
        if (Time.time > currentTime)
        {
            //Debug.Log("Enemy is attaking!!");
            
            currentTime = Time.time + attackRate;
        }
    }
}
