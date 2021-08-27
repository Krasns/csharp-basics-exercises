namespace AdApp
{
    public class TVAd: Advert
    {
        private int _airTime;
        private int _peakTime;
        private bool _isPeakTime;
        public TVAd(int fee) : base(fee)
        {
        }

        public TVAd (int fee, int airTime, int peakTime, bool isPeakTime = false) : base(fee)
	    {
            _airTime = airTime;
            _peakTime = peakTime;
            _isPeakTime = isPeakTime;
	    }

        
        public new int Cost() 
        {
            var fee = base.Cost();
            var cost = (_airTime - _peakTime) * fee;
            if (_isPeakTime)
	            cost += _peakTime* fee * 2;
            return cost;
        }

        public override string ToString() 
        {
            return $"\nTVAd: Cost:{Cost()}";
        }
    }
}