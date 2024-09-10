using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewardAds : MonoBehaviour
{
    private string _adsUnitOdl = "ca-app-pub-3940256099942544/5224354917";

    RewardedAd _rewardedAd;

    private void Start()
    {
        MobileAds.Initialize(initStatus => { LoadRewardedAd(); });
    }
    public void LoadRewardedAd()
    {
        if (_rewardedAd != null)
        {
            _rewardedAd.Destroy();
            _rewardedAd = null;
        }

        var Adrequest = new AdRequest();

        RewardedAd.Load(_adsUnitOdl, Adrequest, (RewardedAd ad, LoadAdError error) =>
        {
            if (error != null || ad == null)
            {
                Debug.Log("Ödül reklamý yüklenmesi durumunda hata oluþtu." + error);
                return;
            }
            _rewardedAd = ad;
        });
    }

    public void ShowRewardedAd()
    {
        const string rewerdMsg = "Ödüllü reklam kullanýcýya gönderildi. tür: {0}, miktar: {1}";

        if (_rewardedAd != null && _rewardedAd.CanShowAd())
        {
            _rewardedAd.Show((Reward reward) =>
            {
                Debug.Log(string.Format(rewerdMsg, reward.Type, reward.Amount));
            });
        }
        else
        {
            Debug.Log("Ödüllü reklam hazýr deðil");
        }
    }
}