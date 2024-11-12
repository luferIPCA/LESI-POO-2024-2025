/*
    Definição de Interfaces
    lufer
*/

namespace Aula_08_Agregacao
{
    public interface IVeiculo
    {
        int QualDia();
    }

    /// <summary>
    /// Define os métodos públicos para lidar com uma garagem
    /// </summary>
    public interface IGaragem
    {
        bool Estaciona(Veiculo v);
        //bool ExisteCarro(string mat);

    }
}
