using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [Range(0f, 5f)] float currentSpeed =1f;
    [SerializeField] float enemyHealth = 100f;


    void Update()
    {
        transform.Translate(Vector2.left * currentSpeed *Time.deltaTime);
    }

    public void SetMovementSpeed(float speed) //you missed the var type declaration
    {
        currentSpeed = speed;
    }
}


// create health variable on lizard
// create damage variable on zucchini
// create collision2d and rigidbody2d on zucchini and lizard
// set to trigger event on projectile
// create health script
// create DealDamage()
// create on trigger2d event
// check collision is attacker
// call DealDamage()
// decrease health by damage amount
// if health < 0 then destroy
// play death VFX