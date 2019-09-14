using CheckoutOrderTotalKata;
using Xunit;

namespace CheckoutOrderTotalKataTests
{
    public class CheckoutTests
    {
        [Fact]
        public void ItemScan()
        {
            // Arrange
            var checkout = new Checkout();
            var expectedInventory = new Inventory();
            var expectedItem = new Item { Name = "meat", Price = 2.89m };

            // Act  
            var expectedPrice = checkout.ItemScan(expectedItem.Name);


            //Assert
            Assert.Equal(expectedItem.Price, expectedPrice);
        }

    }
}