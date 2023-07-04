using System.Runtime.InteropServices;
using System.Text;

namespace ArrayPOOO2023.Entidades
{
    public class MiArray
    {
        private int _cantidad;
        private int[] _elementos;
        private int _tope;//Variable para controlar si el array está vacío o lleno
        public MiArray(int cantidad)
        {
            _cantidad = cantidad;
            _elementos = new int[_cantidad];
            _tope = 0;
        }
        public MiArray() : this(10) { }
        public int GetCantidad() => _cantidad;
        public int GetTope() => _tope;
        public bool IsEmpty() => _tope == 0;
        public bool IsFull() => _tope == _cantidad;

        public void Fill(int minimum, int maximum)
        {
            if (IsFull()) { return; }

            Random r = new Random();
            for (int i = _tope; i < _cantidad; i++)
            {
                _elementos[i] = r.Next(minimum, maximum + 1);
            }
            _tope = _cantidad;
        }
        public string ShowArray()
        {
            StringBuilder sb = new StringBuilder();
            if (IsEmpty())
            {
                sb.Append("Array is empty");
            }
            else
            {
                foreach (var item in _elementos)
                {
                    sb.Append($"{item} ");
                }
            }
            return sb.ToString();
        }

        public void Sort(bool ascending)
        {
            for (int i = 0; i < _cantidad - 1; i++)
            {
                for (int j = i + 1; j < _cantidad; j++)
                {
                    if (ascending)
                    {
                        if (_elementos[i] > _elementos[j])
                        {
                            Change(ref _elementos[i], ref _elementos[j]);
                        }

                    }
                    else
                    {
                        if (_elementos[i] < _elementos[j])
                        {
                            Change(ref _elementos[i], ref _elementos[j]);
                        }

                    }
                }
            }
        }
        private void Change(int x, int y)
        {
            int aux = x;
            x = y;
            y = aux;

        }
        private void Change(ref int x, ref int y)
        {
            int aux = x;
            x = y;
            y = aux;

        }

        public static bool operator +(MiArray miArray, int x)
        {
            if (miArray.IsFull())
            {
                return false;
            }
            int posicion = miArray.GetTope();
            miArray._elementos[posicion] = x;
            miArray._tope++;
            return true;

        }
        public static bool operator ==(MiArray miArray, int x)
        {
            if (miArray.IsEmpty()) { return false; }
            foreach (var item in miArray._elementos)
            {
                if (item == x)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(MiArray miArray, int x)
        { return !(miArray == x); }

        public static implicit operator int(MiArray miArray)
        {
            int suma = 0;
            if (miArray.IsEmpty())
            {
                return 0;
            }
            foreach (var item in miArray._elementos)
            {
                suma += item;
            }
            return suma;
        }

        public Tuple<bool,int> IfExist(int nro)
        {
            if (IsEmpty())
            {
                return new Tuple<bool, int>(false, -1);
            }
            if (this==nro)
            {
                for (int i = 0; i < _cantidad; i++)
                {
                    if (this._elementos[i]==nro)
                    {
                        return Tuple.Create(true, i);
                    }
                }

            }
            return Tuple.Create(false, -1);
        }
        public int GetElemento(int posicion)
        {
            if (posicion < 0 || posicion > _cantidad)
            {
                throw new ArgumentException("Posición mal ingresada");
            }
            return _elementos[posicion];
        }
    }
}