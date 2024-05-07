using primer_parcial_unit_test_procesador_matematico;

namespace procesadorMatematicoTest
{
    public class procesadorMatematicoTest
    {
        private readonly primer_parcial_unit_test_procesador_matematico.ProcesadorMatematico prosc;

        public procesadorMatematicoTest()
        {
            this.prosc = new primer_parcial_unit_test_procesador_matematico.ProcesadorMatematico();
        }



        [Fact]
        public void SumarCuandoSeLlama()
        {
            // Arrange
            int primerNumero = 1;
            int segundoNumero = 2;

            // Act
            int result = prosc.Sumar(primerNumero,segundoNumero);

            // Assert
            Assert.Equal(3, result);
        }


        [Fact]
        public void DividirCuandoSeLlama()
        {
            // Arrange
            int dividendo = 2;
            int divisor = 1;

            // Act
            int result2 = prosc.Dividir(dividendo, divisor);

            // Assert
            Assert.Equal(0, result2);
        }

        [Fact]
        public void CalcularMayorTest()
        {
            // Arrange
            int primerNumero = 1;
            int segundoNumero = 2;

            // Act
            int result3 = prosc.CalcularMayor(primerNumero, segundoNumero);

            // Assert
            Assert.Equal(2, result3);
        }

        

    }
}
