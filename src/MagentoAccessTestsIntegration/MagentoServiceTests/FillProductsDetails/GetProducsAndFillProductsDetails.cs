using System;
using System.Linq;
using FluentAssertions;
using MagentoAccess;
using MagentoAccess.Misc;
using MagentoAccessTestsIntegration.TestEnvironment;
using NUnit.Framework;

namespace MagentoAccessTestsIntegration.MagentoServiceTests.FillProductsDetails
{
	[ TestFixture ]
	[ Category( "ReadSmokeTests" ) ]
	[ Parallelizable ]
	internal class GetProducsAndFillProductsDetails : BaseTest
	{
		[ Test ]
		[ TestCaseSource( typeof( GeneralTestCases ), "TestStoresCredentials" ) ]
		public void ReceiveProducts( MagentoServiceSoapCredentials credentials )
		{
			// ------------ Arrange
			var magentoService = this.CreateMagentoService( credentials.SoapApiUser, credentials.SoapApiKey, "null", "null", "null", "null", credentials.StoreUrl, "http://w.com", "http://w.com", "http://w.com", credentials.MagentoVersion, credentials.GetProductsThreadsLimit, credentials.SessionLifeTimeMs, false, ThrowExceptionIfFailed.AllItems );
			var updatedFrom = DateTime.UtcNow.AddMonths( -15 );

			// ------------ Act
			var productsAsync = magentoService.GetProductsAsync( new[] { 0, 1 }, stockItemsOnly : false, updatedFrom : updatedFrom );
			productsAsync.Wait();

			var fillProductsDetailsAsync = magentoService.FillProductsDetailsAsync( productsAsync.Result );
			fillProductsDetailsAsync.Wait();

			// ------------ Assert
			productsAsync.Result.Should().NotBeNullOrEmpty();
			productsAsync.Result.All( x => x.UpdatedAt.ToDateTimeOrDefault() >= updatedFrom ).Should().BeTrue();
			fillProductsDetailsAsync.Result.Should().NotBeNullOrEmpty();
			fillProductsDetailsAsync.Result.Count().Should().Be( productsAsync.Result.Count() );
			fillProductsDetailsAsync.Result.All( x => x.Categories != null && x.Images != null ).Should().BeTrue();
		}
	}
}