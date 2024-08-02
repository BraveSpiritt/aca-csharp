using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class TrainRoute : IEnumerable<Stop>
    {
        private List<Stop> stops;

        public TrainRoute(List<Stop> stops)
        {
            this.stops = stops;
        }
        public IEnumerator<Stop> GetEnumerator()
        {
            return new TrainRouteEnumerator(stops);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}
