using System;

namespace Utilities.ScriptUtils.Time
{
    public class CustomCoroutine
    {
        public event Action<CustomCoroutine> OnFinished;
        private Action action;
        private ITimer timer;

        private bool isFinished;

        internal CustomCoroutine(Action action, float delay)
        {
            Init(action, delay);
        }

        internal void Init(Action action, float delay)
        {
            this.action = action;
            if (timer == null)
            {
                timer = TimerFactory.ConstructTimer(delay);
            }
            else
            {
                timer.ChangeDelay(delay);
            }
            timer.StartTimer();
            isFinished = false;
        }

        internal void Update()
        {
            if(isFinished) return;
            if (timer.IsComplete)
            {
                action?.Invoke();
                isFinished = true;
                OnFinished?.Invoke(this);
            }
        }

        public void Release(bool invokeCallback = false)
        {
            if (invokeCallback)
            {
                action?.Invoke();
            }
            isFinished = true;
            OnFinished?.Invoke(this);
        }
    }
}