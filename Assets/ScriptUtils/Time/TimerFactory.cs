namespace Utilities.ScriptUtils.Time
{
    public static class TimerFactory
    {
        public static ITimer ConstructTimer(float delay = 0f)
        {
            return new Timer(delay);
        }
    }
}