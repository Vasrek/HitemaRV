using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class HealthCollectible : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
        {
            if (controller.health < controller.maxHealth) // SI RUBY EST FULL HP ELLE NE PEUT SE SOIGNER
            {
                controller.ChangeHealth(1);
                Destroy(gameObject);
            }
        }
    }
}
