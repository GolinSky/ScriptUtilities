using UnityEngine;

namespace Utilities.ScriptUtils.Time
{
    internal class Timer : ITimer
    {
        private float _delay;
        private float _timer;
        private bool _isComplete;
        private bool _hasStarted;
        
        private float CurrentTime => UnityEngine.Time.time;
        public float TimeLeft => IsComplete ? default : Mathf.Abs(CurrentTime - _timer);
        public bool IsComplete => _timer < CurrentTime;
        
        public bool HasStarted => _hasStarted;
            
        public Timer(float delay)
        {
            _delay = delay;
        }
      
        public void StartTimer()
        {
            _hasStarted = true;
            _timer = CurrentTime + _delay;
        }

        public ITimer ChangeDelay(float newDelay)
        {
            _delay = newDelay;
            return this;
        }

        public ITimer ForceFinish()
        {
            _timer = default;
            return this;
        }

        public ITimer AppendTime(float appendDelay)
        {
            _timer += appendDelay;
            return this;
        }
    }
}