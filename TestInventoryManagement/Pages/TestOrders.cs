using Bunit;
using Microsoft.Extensions.DependencyInjection;
using InventoryManagement.Pages;
using InventoryManagement.Northwind;

namespace TestInventoryManagement
{
	[Collection("InventoryManagement")]
	public class TestOrders
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbInputModule),
				typeof(IgbGridModule));
			ctx.Services.AddScoped<INorthwindService>(sp => new MockNorthwindService());
			var componentUnderTest = ctx.RenderComponent<Orders>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
