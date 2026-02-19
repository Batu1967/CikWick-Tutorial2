using UnityEngine;

public class HolyWheatCollectible : MonoBehaviour, iCollectible
{
    [SerializeField] private WheatDesignSO _wheatDesignSO;
    [SerializeField] private PlayerController _playerController;

    public void Collect()
    {
        _playerController.SetJumpForce(_wheatDesignSO.IncreaseDecreaseMultiplier, _wheatDesignSO.ResetBoostDuration);
        Destroy(gameObject);
    }
}