using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace livrable.model
{
    public interface ISujet
    {
        public void notifyObserver();
        public void attachObserver(IObserver observer);
        public void detachObserver(IObserver observer);
    }
}
