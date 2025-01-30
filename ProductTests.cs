using ProductLibrary;
using System;
using Xunit;

namespace ProductLibrary.Tests
{
	public class ProductTests
	{
		[Fact]
		public void ApplyDiscount_Returns_CorrectPrice_ForValidDiscount()
		{
			//Arrange
			var product = new Product(100);
			double discountPercentage = 20;

			//Act
			var result = product.ApplyDiscount(discountPercentage);

			//Assert
			Assert.Equal(80, result);
		}

		[Theory]
		[InlineData(100, 0, 100)]
        [InlineData(100, 100, 0)]
        [InlineData(100, -10, 100)] //Ei muuta hintaa virheellisellä syötteellä
		public void ApplyDiscount_HandlesEdgeCases(double price, double discountPercentage, double expected)
		{
			//Arrange
			var product = new Product(price);

			//Act
			var result = product.ApplyDiscount(discountPercentage);

			//Assert
			Assert.Equal(expected, result);
		}
    }
}
