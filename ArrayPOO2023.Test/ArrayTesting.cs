using ArrayPOOO2023.Entidades;

namespace ArrayPOO2023.Test
{
    [TestClass]
    public class ArrayTesting
    {
        [TestMethod]
        public void ArrayCreateWithoutParameters()
        {
            int cantidadElementos = 10;
            MiArray miArray = new MiArray();
            Assert.AreEqual(cantidadElementos, miArray.GetCantidad());
        }
        [TestMethod]

        public void ArrayCreateWithParameters()
        {
            int cantidadElementos = 5;
            MiArray miArray = new MiArray(cantidadElementos);
            Assert.AreEqual(cantidadElementos,miArray.GetCantidad());   
        }
        [TestMethod]
        public void ArrayIsEmpty()
        {
            var miArray = new MiArray();
            Assert.IsTrue(miArray.IsEmpty());
        }
        [TestMethod]
        public void ArrayIsFull()
        {
            var miArray = new MiArray();
            miArray.Fill(1, 20);
            Assert.IsTrue(miArray.IsFull());
        }
        [TestMethod]
        public void ArrayShowIsEmpty()
        {
            var mensaje = "Array is empty";
            var miArray = new MiArray();
            Assert.AreEqual(mensaje, miArray.ShowArray());
        }
        [TestMethod]
        public void ArrayShowElements()
        {
            var mensaje = "Array is empty";
            var miArray = new MiArray();
            miArray.Fill(1, 20);
            Assert.AreNotEqual(mensaje,miArray.ShowArray());


        }
    }
}