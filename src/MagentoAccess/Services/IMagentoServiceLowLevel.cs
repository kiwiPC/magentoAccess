﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MagentoAccess.Models.GetOrders;
using MagentoAccess.Models.GetProduct;
using MagentoAccess.Models.GetProducts;
using MagentoAccess.Models.GetSrockItems;
using MagentoAccess.Models.PutStockItems;

namespace MagentoAccess.Services
{
	public interface IMagentoServiceLowLevel
	{
		string AccessToken { get; }

		string AccessTokenSecret { get; }

		Task PopulateAccessToken();

		Task< GetProductResponse > GetProductAsync( string id );

		Task< GetProductsResponse > GetProductsAsync( int page, int limit );

		Task< GetStockItemsResponse > GetInventoryAsync( int page, int limit );

		Task< PutStockItemsResponse > PutInventoryAsync( IEnumerable< InventoryItem > inventoryItems );

		Task< GetOrdersResponse > GetOrdersAsync();

		Task< GetOrdersResponse > GetOrdersAsync( DateTime dateFrom, DateTime dateTo );
	}
}