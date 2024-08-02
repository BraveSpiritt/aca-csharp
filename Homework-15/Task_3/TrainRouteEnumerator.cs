using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class TrainRouteEnumerator : IEnumerator<Stop>
    {
        private List<Stop> stops;
        private int position = -1;
        public TrainRouteEnumerator(List<Stop> stops)
        {
            this.stops = stops;
        }
        public Stop Current
        {
            get
            {
                try
                {
                    return stops[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
        object IEnumerator.Current => Current;
        public bool MoveNext()
        {
            position++;
            return (position < stops.Count);
        }
        public void Reset()
        {
            position = -1;
        }

        public void Dispose() { }
    }

}
