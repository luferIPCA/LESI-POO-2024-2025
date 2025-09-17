using MVC_II.Model;
using MVC_II.View;

namespace MVC_II.Controller
{
    public interface IIndicadoresControl
    {

        //controlar Model
        void SetModel(IIndicadoresModel m);
        void MoreDeads(int v);
        void MoreInfected(int v);
        void MoreRecovered(int v);
        //void tLessInfected(int v);

        int Mortes();
        int Recuperados();
        int Infetados();

        //controlar View
        void SetView(IIndicadoresView v);
        void RequestMoreDeads(int v);
        void RequestMoreInfected(int v);
        //void RequestMoreRecovered(int v);
        //void RequestLessInfected(int v);

    }
}
