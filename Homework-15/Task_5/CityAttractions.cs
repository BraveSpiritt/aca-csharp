using System.Collections;
namespace Task_5
{
    public class CityAttractions : IEnumerable<Attraction>
    {
        private readonly List<Attraction> _attractions;
        public void AddAttraction(Attraction attraction)
        {
            _attractions.Add(attraction);
        }
        public CityAttractions(List<Attraction> attraction)
        {
            _attractions = attraction;
        }
        public IEnumerator<Attraction> GetEnumerator()
        {
            return new CityAttractionsEnumerator(_attractions);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
