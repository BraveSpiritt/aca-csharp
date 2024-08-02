using System.Collections;

namespace Task_5
{
    public class CityAttractionsEnumerator : IEnumerator<Attraction>
    {
        private readonly List<Attraction> _attractions;
        private int _position = -1;

        public CityAttractionsEnumerator(List<Attraction> attractions)
        {
            _attractions = attractions ?? throw new ArgumentNullException(nameof(attractions));
        }
        public Attraction Current
        {
            get
            {
                if (_position < 0 || _position >= _attractions.Count)
                {
                    throw new InvalidOperationException();
                }
                return _attractions[_position];
            }
        }
        object IEnumerator.Current => Current;
        public bool MoveNext()
        {
            _position++;
            return (_position < _attractions.Count);
        }
        public void Reset()
        {
            _position = -1;
        }
        public void Dispose() { }
    }
}
