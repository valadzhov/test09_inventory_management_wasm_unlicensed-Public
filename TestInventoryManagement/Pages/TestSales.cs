using Bunit;
using Microsoft.Extensions.DependencyInjection;
using InventoryManagement.Pages;
using InventoryManagement.ECommerce;

namespace TestInventoryManagement
{
	[Collection("InventoryManagement")]
	public class TestSales
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbComboModule),
				typeof(IgbCategoryChartModule));
			ctx.Services.AddScoped<IECommerceService>(sp => new MockECommerceService());
			var componentUnderTest = ctx.RenderComponent<Sales>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
