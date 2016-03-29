using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СourseTask
{
    public interface IView
    {
        void OpenDialoge();

        event EventHandler<EventArgs> OpenDialog;
    }
}
