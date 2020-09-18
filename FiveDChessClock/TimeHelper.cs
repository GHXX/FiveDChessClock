namespace FiveDChessClock
{
    static class TimeHelper
    {
        internal static string FormatTime(long milliseconds)
        {
            if (milliseconds < 0)
            {
                milliseconds = 0;
            }

            int popMaxAmountFromMs(long valueToPop)
            {
                var ret = milliseconds / valueToPop;
                milliseconds -= ret * valueToPop;
                return (int)ret;
            }

            var hrs = popMaxAmountFromMs(60 * 60 * 1000);
            var mins = popMaxAmountFromMs(60 * 1000);
            var secs = popMaxAmountFromMs(1000);
            var hStr = hrs > 0 ? hrs + "h:" : string.Empty;
            var msStr = hrs == 0 ? $".{milliseconds:D3}ms" : string.Empty;

            return $"{hStr}{mins:D2}m:{secs:D2}s{msStr}";
        }
    }
}
