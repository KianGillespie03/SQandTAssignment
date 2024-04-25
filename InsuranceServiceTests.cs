using NUnit.Framework;
using Moq;

namespace SQA_Assign.Tests
{


    [TestFixture]
    public class InsuranceServiceTests
    {
        [Test]
        public void GetInsurancePremium()
        {
            // Arrange
            var mockInsuranceService = new Mock<IDiscountService>();
            mockInsuranceService.Setup(x => x.GetDiscount()).Returns(2);
            var Insurance = new InsuranceService(mockInsuranceService.Object);

            // Act
            double Premium = Insurance.CalcPremium(20, "rural");

            // Assert
            Assert.That(Premium, Is.EqualTo(5));
        }

        [Test]
        public void GetInsurancePremium2()
        {
            // Arrange
            var mockInsuranceService = new Mock<IDiscountService>();
            mockInsuranceService.Setup(x => x.GetDiscount()).Returns(2);
            var Insurance = new InsuranceService(mockInsuranceService.Object);

            // Act
            double Premium = Insurance.CalcPremium(35, "rural");

            // Assert
            Assert.That(Premium, Is.EqualTo(2.5)); // constraint

        }

        [Test]
        public void GetInsurancePremium3()
        {
            // Arrange
            var mockInsuranceService = new Mock<IDiscountService>();
            mockInsuranceService.Setup(x => x.GetDiscount()).Returns(2);
            var Insurance = new InsuranceService(mockInsuranceService.Object);

            // Act
            double Premium = Insurance.CalcPremium(15, "rural");

            // Assert
            Assert.That(Premium, Is.EqualTo(0)); // constraint

        }

        [Test]
        public void GetInsurancePremium4()
        {
            // Arrange
            var mockInsuranceService = new Mock<IDiscountService>();
            mockInsuranceService.Setup(x => x.GetDiscount()).Returns(2);
            var Insurance = new InsuranceService(mockInsuranceService.Object);

            // Act
            double Premium = Insurance.CalcPremium(25, "urban");

            // Assert
            Assert.That(Premium, Is.EqualTo(6)); // constraint

        }

        [Test]
        public void GetInsurancePremium5()
        {
            // Arrange
            var mockInsuranceService = new Mock<IDiscountService>();
            mockInsuranceService.Setup(x => x.GetDiscount()).Returns(2);
            var Insurance = new InsuranceService(mockInsuranceService.Object);

            // Act
            double Premium = Insurance.CalcPremium(40, "urban");

            // Assert
            Assert.That(Premium, Is.EqualTo(5)); // constraint

        }

        [Test]
        public void GetInsurancePremium6()
        {
            // Arrange
            var mockInsuranceService = new Mock<IDiscountService>();
            mockInsuranceService.Setup(x => x.GetDiscount()).Returns(2);
            var Insurance = new InsuranceService(mockInsuranceService.Object);

            // Act
            double Premium = Insurance.CalcPremium(15, "urban");

            // Assert
            Assert.That(Premium, Is.EqualTo(0)); // constraint

        }

        [Test]
        public void GetInsurancePremium7()
        {
            // Arrange
            var mockInsuranceService = new Mock<IDiscountService>();
            mockInsuranceService.Setup(x => x.GetDiscount()).Returns(2);
            var Insurance = new InsuranceService(mockInsuranceService.Object);

            // Act
            double Premium = Insurance.CalcPremium(30, "suburban");

            // Assert
            Assert.That(Premium, Is.EqualTo(0)); // constraint

        }

        [Test]
        public void GetInsurancePremium8()
        {
            // Arrange
            var mockInsuranceService = new Mock<IDiscountService>();
            mockInsuranceService.Setup(x => x.GetDiscount()).Returns(2);
            var Insurance = new InsuranceService(mockInsuranceService.Object);

            // Act
            double Premium = Insurance.CalcPremium(55, "rural");

            // Assert
            Assert.That(Premium, Is.EqualTo(10)); // constraint

        }

    }
}



