using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class HealthCollectible : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>(); // CONTROLLER == RUBY

        if (controller != null)
        {
            if (controller.health < controller.maxHealth) // SI RUBY A MOINS d'HP QUE SON MAXIMUM HP
            {
                controller.ChangeHealth(1);
                Destroy(gameObject);
            }
        }
    }
}
