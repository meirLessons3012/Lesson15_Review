using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15
{
    internal abstract  class AbsClass
    {
        public abstract void AbsMethod();
        public void NonAbsMethod()
        {

        }
    }

    internal abstract class AbsClass2 : AbsClass
    {
        public abstract void AbsMethod2();

    }

    class C : AbsClass2
    {
        public override void AbsMethod()
        {
            throw new NotImplementedException();
        }

        public override void AbsMethod2()
        {
            throw new NotImplementedException();
        }
    }
}
