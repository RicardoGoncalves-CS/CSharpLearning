namespace StatePatternExample;

public partial class Computer
{
    private int _state = 0;
    private bool _charging = true;

    public string? message;

    public void PlugCharger()
    {
        if (!_charging) _charging = true;
    }

    public void UnplugCharger()
    {
        if (_charging) _charging = false;
    }

    public void PressPowerButton()
    {
        // off
        if(_state == 0)
        {
            _state = 1;
            message = "Turning computer On";
            return;
        }

        // on
        if(_state == 1)
        {
            if (_charging)
            {
                message = "Computer is going into StandBy";
                _state = 2;
                return;
            }
            message = "Turning computer Off";
            _state = 0;
            return;
        }

        // standby
        message = "Turning computer On";
        _state = 1;
    }
}
