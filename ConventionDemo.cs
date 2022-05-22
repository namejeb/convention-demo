using UnityEngine;

public class Gun : MonoBehaviour
{
    private const string Name = "SMG";
    
    [SerializeField] private Transform firePoint;       //relevant to firing
    [SerializeField] private float fireRate = 1f;   
    private float _nextFireTime;
    
    [SerializeField] private float coolDownTime = 1f;       //relevant to cooldown
    public bool isOnCooldown;
    private bool _canUse;
    
    private bool _isEquipped;                //relevant to equipping
    
    
    public Vector3 BulletDirection { get; private set; }
    public bool IsEquipped { get => _isEquipped; }

    private void Awake()
    {
        
    }

    private void Start()
    {
        
    }

    private void ChangeBulletType()
    {
        if (!_isEquipped)
        {
            //do task 1
            return;
        }
    }
}

