using Bunit;
using Microsoft.Extensions.DependencyInjection;
using InventoryManagement.Pages;

namespace TestInventoryManagement
{
	[Collection("InventoryManagement")]
	public class TestCustomers
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			var componentUnderTest = ctx.RenderComponent<Customers>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
