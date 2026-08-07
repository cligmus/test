using DG.Tweening;
using UnityEngine;

public class Weaponswing : MonoBehaviour
    
{
    public float duration;
    public int loopCount;
    private Tween rotationTween;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     
    }
    public void SweepWeapon()
    {
        transform.localRotation = Quaternion.Euler(0f, -90, 0f);
        rotationTween = transform.DOLocalRotate(new Vector3(0, 90, 0), duration).SetEase(Ease.InOutSine).SetLoops(loopCount, LoopType.Yoyo);
    }
    private void OnDestroy()
    {
        rotationTween?.Kill();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
