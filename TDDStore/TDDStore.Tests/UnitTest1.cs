using System;
using System.Linq;
using NUnit.Framework;
using TDDStore.Service;
using Moq;

//using Moq instead of Telerik.JustMock

namespace TDDStore.UnitTests
{
    [TestFixture]
    class OrderServiceTests
    {
        [Test]
        public void WhenUserPlacesACorrectOrderThenAnOrderNumberShouldBeReturned()
        {
            //Arrange
            var shoppingCart = new ShoppingCart();
            shoppingCart.Items.Add(new ShoppingCartItem { ItemId = Guid.NewGuid(), Quantity = 1 });
            var customerId = Guid.NewGuid();
            var expectedOrderId = Guid.NewGuid();
            var orderDataService = new Mock<IOrderDataService>();
                orderDataService.Setup(m=> m.Save(It.IsAny<Order>())).Returns(expectedOrderId);
            OrderService orderService = new OrderService(orderDataService.Object);
            //Act
            var result = orderService.PlaceOrder(customerId, shoppingCart);
            //Assert
           // Assert.AreEqual(expectedOrderId, result);
        }
    }
}