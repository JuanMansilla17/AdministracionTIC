using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace AdministracionTIC.Test
{
    [TestClass]
    public class FechaHoraPrestamo
    {
        //GestorPrestamo gestorPrestamo = new GestorPrestamo();

        [TestMethod]
        public void FechaHora_SeConstruyenCorrectamente()
        {
            //Arrange
            GestorPrestamo gestorPrestamo = new GestorPrestamo();

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
            //VistaPrestamo vistaPrestamo = new VistaPrestamo();
            GestorPrestamo gestorPrestamo = new GestorPrestamo();

            DateTime fecha = DateTime.Now.AddDays(32);

            //Act
            Boolean fechaValida = gestorPrestamo.FechaValida(fecha);

            //Assert
            Assert.IsTrue(fechaValida);

        }

        [TestMethod]
        public void DetectaHorario_FueraDeRangoDeHorayMinuto()
        {
            String horaEntrega = "22";
            String minutoEntrega = "0";
            String horaDevolucion = "22";
            String minutoDevolucion = "30";

            //VistaPrestamo vistaPrestamo = new VistaPrestamo();
            GestorPrestamo gestorPrestamo = new GestorPrestamo();

            Boolean horarioValido = gestorPrestamo.HorarioValido(horaEntrega,
                minutoEntrega,
                horaDevolucion,
                minutoDevolucion);

            Assert.IsTrue(horarioValido);
        }
    }
}
