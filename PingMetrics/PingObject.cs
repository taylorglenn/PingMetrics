using System.Net.NetworkInformation;
using System.Collections.Generic;
using System.Linq;

namespace PingMetrics
{
    public class PingObject : Ping
    {
        public Ping pingObject = new Ping();
        public int TotalPings { get; set; }
        public long LastRoundTripTime { get; set; }
        public int GoodRx { get; set; }
        public int BadRx { get; set; }
        public double PercentLoss { get; set; }
        public long LongestRoundTripTime { get; set; }
        public long ShortestRoundTripTime { get; set; }
        public long AverageRoundTripTime { get; set; }
        private List<long> _pingTimes;
        private string _hostAddress;
        private byte[] _packet;
        private int _timeoutInMilliseconds;

        public PingObject(string hostAddress, int packetSize, int timeoutInMilliseconds)
        {
            _pingTimes = new List<long>();
            _hostAddress = hostAddress;
            _packet = new byte[packetSize];
            _timeoutInMilliseconds = timeoutInMilliseconds;
            GoodRx = 0;
            BadRx = 0;
            PercentLoss = 0.0;
            LastRoundTripTime = 0;
            LongestRoundTripTime = int.MinValue;
            ShortestRoundTripTime = int.MaxValue;
            AverageRoundTripTime = 0;
        }
        private void UpdatePingTimes(long time)
        {
            if(_pingTimes.Count > 1000)
            {
                _pingTimes.Clear();
            }
            _pingTimes.Add(time);
        }
        private long PingTimeAverage()
        {
            return _pingTimes.Sum()/_pingTimes.Count;
        }
        public bool DoOnePing()
        {
            TotalPings++;
            try
            {
                var pingReplyObject = pingObject.Send(_hostAddress);
                bool pingSuccessResult = pingReplyObject.Status == IPStatus.Success;
                if (pingSuccessResult)
                {
                    GoodRx++;
                    LastRoundTripTime = pingReplyObject.RoundtripTime;
                    UpdatePingTimes(LastRoundTripTime);
                    LongestRoundTripTime = LastRoundTripTime > LongestRoundTripTime ? LastRoundTripTime : LongestRoundTripTime;
                    ShortestRoundTripTime = LastRoundTripTime < ShortestRoundTripTime ? LastRoundTripTime : ShortestRoundTripTime;
                    AverageRoundTripTime = ShortestRoundTripTime > 0 ? PingTimeAverage() : AverageRoundTripTime;
                } else
                {
                    BadRx++;
                    LastRoundTripTime = 0;
                }
                return pingSuccessResult;
            }
            catch (PingException)
            {
                return false;
            }
        }
    }
}
