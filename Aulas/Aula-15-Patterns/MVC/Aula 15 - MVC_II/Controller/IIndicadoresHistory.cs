using MVC_II.Model;

namespace MVC_II.Controller
{
    public interface IIndicadoresHistory
    {
        bool AddIndicador(IIndicadoresModel i);
        bool SaveHistory(string fileName);
        bool LoadHistory(string fileName);

    }
}
