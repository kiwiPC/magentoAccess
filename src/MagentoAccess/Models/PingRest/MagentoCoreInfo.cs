﻿namespace MagentoAccess.Models.PingRest
{
	public class PingRestInfo
	{
		public bool RestWorks { get; private set; }

		public PingRestInfo( bool restWorks )
		{
			this.RestWorks = restWorks;
		}

		public string ToJson()
		{
			return $"{{RestWorks:{this.RestWorks}}}";
		}
	}
}