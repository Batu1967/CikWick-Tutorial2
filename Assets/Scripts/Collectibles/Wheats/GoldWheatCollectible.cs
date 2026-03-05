using UnityEngine;

public class GoldWheatCollectible : MonoBehaviour, iCollectible
{
    [SerializeField] private WheatDesignSO _wheatDesignSO;
    [SerializeField] private PlayerController _playerController;

    public void Collect()
    {
        if (_playerController != null && _wheatDesignSO != null)
        {
            _playerController.SetMovementSpeed(_wheatDesignSO.IncreaseDecreaseMultiplier, _wheatDesignSO.ResetBoostDuration);
            Destroy(gameObject);
        }
    }
}