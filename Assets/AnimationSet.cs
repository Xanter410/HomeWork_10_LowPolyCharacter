using UnityEngine;

public class AnimationSet : MonoBehaviour
{
    private static readonly int AnimatorNumber = Animator.StringToHash("animationNumber");

    [SerializeField] private Animator _animator;

    [SerializeField] private GameObject _weapon1;
    [SerializeField] private GameObject _weapon2;
    [SerializeField] private GameObject _weapon3;

    private void Start()
    {
        SetAnimatorNumber(0);
        ActivateWeapon(0);
    }

    public void SetAnimatorNumber(int value)
    {
        _animator.SetInteger(AnimatorNumber, value);
    }
    public void ActivateWeapon(int value)
    {
        switch (value)
        {
            case 0:
                _weapon1.SetActive(true);
                _weapon2.SetActive(false);
                _weapon3.SetActive(false);
                break;
            case 1:
                _weapon1.SetActive(false);
                _weapon2.SetActive(true);
                _weapon3.SetActive(false);
                break;
            case 2:
                _weapon1.SetActive(false);
                _weapon2.SetActive(false);
                _weapon3.SetActive(true);
                break;
            default:
                break;
        }
    }

}
