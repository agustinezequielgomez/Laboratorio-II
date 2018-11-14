using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL
{
    interface ISql<T>
    {
        bool Insertar();
        bool Modificar(T obj);
        bool Borrar(T obj);
        List<T> TraerTodos();
        T TraerUno(int id);
    }
}
