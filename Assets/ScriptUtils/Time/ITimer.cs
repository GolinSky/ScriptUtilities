namespace Utilities.ScriptUtils.Time
{
    public interface ITimer
    {
        bool IsComplete { get; }
        float TimeLeft { get; }
        void StartTimer();
        void ChangeDelay(float newDelay);
        void AppendTime(float appendDelay);
        void ForceFinish();
    }
}