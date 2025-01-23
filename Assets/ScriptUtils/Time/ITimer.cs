namespace Utilities.ScriptUtils.Time
{
    public interface ITimer
    {
        bool IsComplete { get; }
        float TimeLeft { get; }
        void StartTimer();
        ITimer ChangeDelay(float newDelay);
        ITimer AppendTime(float appendDelay);
        ITimer ForceFinish();
    }
}