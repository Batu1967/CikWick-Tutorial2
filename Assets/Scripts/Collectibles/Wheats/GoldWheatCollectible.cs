using UnityEngine;

public class GoldWheatCollectible : MonoBehaviour, iCollectible
{
    [SerializeField] private WheatDesignSO _wheatDesignSO;
    [SerializeField] private PlayerController _playerController;

    public void Collect()
    {
        if (_playerController != null && _wheatDesignSO != null)
        {
            // Alt çizgisiz ve büyük harf ile başlayan yeni isimleri kullanıyoruz
            _playerController.SetMovementSpeed(_wheatDesignSO.IncreaseDecreaseMultiplier, _wheatDesignSO.ResetBoostDuration);
            Destroy(gameObject);
        }
    }
}