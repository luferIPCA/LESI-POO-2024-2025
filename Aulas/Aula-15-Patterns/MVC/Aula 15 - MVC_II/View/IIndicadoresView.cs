using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_II.View
{
    public interface IIndicadoresView
    {
        void QuantasMortes();
        void QuantosRecuperados();
        void QuantosInfetados();
        void ShowAll();
        void ShowHistory();
    }
}
