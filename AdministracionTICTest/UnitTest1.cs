using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using AdministracionTIC;

namespace AdministracionTICTest
{
    [TestClass]
    public class FechaHoraPrestamo
    {
        GestorPrestamo gestorPrestamo = new GestorPrestamo();
        [TestMethod]
        public void FechaHora_SeConstruyenCorrectamente()
        {
            
            //Arrange
            DateTime fecha = new DateTime(2019, 4, 17);
            String hora = "12";
            String minuto = "30";
            DateTime fechaHoraEsperada = new DateTime(2019, 4, 17, 12, 30, 0);

            //Act
            DateTime fechaHora = gestorPrestamo.ConstruirFechaHora(fecha, hora, minuto);

            //Assert
            Assert.AreEqual(fechaHoraEsperada, fechaHora);

        }

        [TestMethod]
        public void FechaPrestamo_NoSuperaLaFechaLimite()
        {

            //Arrange
            DateTime fecha = DateTime.Now.AddDays(32);

            //Act
            Boolean fechaValida = gestorPrestamo.FechaValida(fecha);

            //Assert
            Assert.IsFalse(fechaValida);

        }
    }
}
