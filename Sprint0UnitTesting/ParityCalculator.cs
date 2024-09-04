using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parity {
  public class ParityCalculator {
    public bool IsEven(int x) {
      if (x % 2 == 0) {
        return true;
      } else {
        return false;
      }
    }
  }
}