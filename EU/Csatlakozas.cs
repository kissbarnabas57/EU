using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EU
{
  class Csatlakozas
  {
    private string orszag;

    public string Orszag
    {
      get { return orszag; }
      set { orszag = value; }
    }
    private int datum;

    public int Datum
    {
      get { return datum; }
      set { datum = value; }
    }

    public Csatlakozas(string orszag, int datum)
    {
      this.orszag = orszag;
      this.datum = datum;
    }
  }
}
