﻿namespace MagentoAccess.Models.Services.Rest.v1x.GetStockItems
{
	public class StockItem
	{
		//stock item id
		public string ItemId { get; set; }
		//product id
		public string ProductId { get; set; }
		public string Qty { get; set; }
		public string BackOrders { get; set; }
	}
}