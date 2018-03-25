using System;
using System.Configuration;

namespace NHapi.Base
{
	public class ConfigurationSettings
	{
		public static bool UseFactory
		{
			get
			{
#if NETCOREAPP2_0
				throw new NotImplementedException();
#else
				bool useFactory = false;
				string useFactoryFromConfig = ConfigurationManager.AppSettings["UseFactory"];
				if (useFactoryFromConfig != null && useFactoryFromConfig.Length > 0)
				{
					useFactory = Convert.ToBoolean(useFactoryFromConfig);
				}
				return useFactory;
#endif
			}
		}

		private static string _connectionString = string.Empty;

		public static string ConnectionString
		{
			get
			{
#if NETCOREAPP2_0
				throw new NotImplementedException();
#else
				string connFromConfig = ConfigurationManager.AppSettings["ConnectionString"];
				if (string.IsNullOrEmpty(_connectionString) && !string.IsNullOrEmpty(connFromConfig))
				{
					_connectionString = connFromConfig;
				}
				return _connectionString;
#endif
			}
			set { _connectionString = value; }
		}
	}
}