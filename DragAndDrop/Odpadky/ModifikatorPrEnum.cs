using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragAndDrop.Odpadky
{
    public enum ModifikatorPrEnum
    {
        IsPublic,
        IsInternal,
        IsPrivate,
        IsProtected
    }
    public enum TypVztahu
    {
        Kompozice,
        Agregace,
        Asociace,
        Dependence
    }
}
