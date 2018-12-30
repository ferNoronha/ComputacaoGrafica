using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1
{
    class Hsi
    {
        protected double h, s, i;

        public Hsi(double h, double s, double i)
        {
            this.h = h;
            this.s = s;
            this.i = i;
        }
        public Hsi()
        {
            h = s = i = 0;
        }

        public Double getH()
        {
            return h;
        }

        public Double getS()
        {
            return s;
        }

        public Double getI()
        {
            return i;
        }
        public void setH(double h)
        {
            this.h = h;
        }
        public void setS(double s)
        {
            this.s = s;
        }
        public void setI(double i)
        {
            this.i = i;
        }
    }
}
