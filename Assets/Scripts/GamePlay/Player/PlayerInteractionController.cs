using UnityEngine;

public class PlayerInteractionController : MonoBehaviour

{
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.TryGetComponent<iCollectible>(out var collectible))
        {
            collectible.Collect();
        }


    }
}
