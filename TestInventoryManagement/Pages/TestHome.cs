using Bunit;
using Microsoft.Extensions.DependencyInjection;
using InventoryManagement.Pages;
using InventoryManagement.InventoryApp;
using InventoryManagement.ECommerce;

namespace TestInventoryManagement
{
	[Collection("InventoryManagement")]
	public class TestHome
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbCardModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbListModule),
				typeof(IgbAvatarModule),
				typeof(IgbPieChartModule),
				typeof(IgbCategoryChartModule));
			ctx.Services.AddScoped<IInventoryAppService>(sp => new MockInventoryAppService());
			ctx.Services.AddScoped<IECommerceService>(sp => new MockECommerceService());
			var componentUnderTest = ctx.RenderComponent<Home>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
