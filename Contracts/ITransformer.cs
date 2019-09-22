using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
  public  interface ITransformer<T,K> where T:class, new() where K:class , new()
    {
      K GetTransform(T sourceValue);
    }
}
