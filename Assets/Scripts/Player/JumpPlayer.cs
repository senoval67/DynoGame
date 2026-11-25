using UnityEngine;

public class JumpPlayer : MonoBehaviour
{
    [SerializeField] private AnimationCurve _jumpCurve;

    [SerializeField] private float _jumpMaxValue = 3f;
    [SerializeField] private float _jumpTime = 2f;

    private float _playerStartPositionY;
    private float _timer;

    private bool _jump = false;

    public void Init()
    {
        _playerStartPositionY = transform.position.y;
    }

    public void Tick()
    {
        if (CanJump() && NeedJump())
        {
            _jump = true;
            _timer = 0;
        }

        TryHandleJump();
    }

    private bool CanJump()
    {
        return !_jump && IsInStartPosition();
    }

    private bool NeedJump()
    {
        return Input.GetKeyDown(KeyCode.Space);
    }

    private bool IsInStartPosition()
    {
        return transform.position.y <= _playerStartPositionY;
    }

    public void TryHandleJump()
    {
        if (_jump)
        {
            HandleJump();
        }
    }

    private void HandleJump()
    {
        _timer += Time.fixedDeltaTime;

        SetPosition(GetJumpValue());

        if (_timer >= _jumpTime)
        {
            _jump = false;
        }
    }

    private float GetJumpValue()
    {
        var timer01 = _timer / _jumpTime;
        var curveValue = GetAnimationCurveValue(Mathf.Clamp01(timer01));
        return curveValue * _jumpMaxValue;
    }

    private void SetPosition(float jumpValue)
    {
        var newPos = new Vector2(transform.position.x, _playerStartPositionY + jumpValue);
        transform.position = newPos;
    }

    private float GetAnimationCurveValue(float time)
    {
        if (time > 1 || time < 0f)
        {
            Debug.LogError(nameof(JumpPlayer) + " incorrect index");
            return 0;
        }

        return _jumpCurve.Evaluate(time);
    }
}