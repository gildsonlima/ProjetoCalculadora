using Calculadora;

namespace TestProject1
{
    public class Tests
    {
        Operacoes operacoes = new Operacoes();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSoma()
        {
            if(operacoes.Somar(2, 2) == 4)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
            
        }
        [Test]
        public void TestSubtracao()
        {
            if (operacoes.Subtrair(2, 2) == 0)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }

        }
        [Test]
        public void TestMulticacao()
        {
            if (operacoes.Multiplicar(2, 2) == 4)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }

        }
    }
}