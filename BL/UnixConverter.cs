using System;

namespace tGhWebsite.BL
{
    public static class UnixConverter
    {
        /// <summary>
        /// Converts DateTime naar Unix timestamp
        /// </summary>
        /// <param name="value">Een DateTime Value</param>
        /// <returns>UnixTime</returns>
        public static int ToUnix(this DateTime value)
        {
            return (int)Math.Truncate((value.ToUniversalTime().Subtract(new DateTime(1970, 1, 1))).TotalSeconds);
        }

        /// <summary>
        /// Converts UnixTime naar DateTime
        /// </summary>
        /// <param name="unixtime">Een UnixTime Value</param>
        /// <returns>DateTime</returns>
        public static DateTime ToDateTime(int unixtime)
        {
            var sTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return sTime.AddSeconds(unixtime);
        }
    }
}