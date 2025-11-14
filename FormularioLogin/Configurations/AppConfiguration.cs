using DotNetEnv;
using System;
using System.Collections.Generic;
using System.Configuration.Provider;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioLogin.Configurations
{
	

	public static class AppConfiguration
	{
		static AppConfiguration()
		{
			Env.Load();
		}

		// Configuración de Base de Datos
		public static string DatabaseServer => Env.GetString("DB_SERVER");
		public static string DatabaseName => Env.GetString("DB_NAME");
		public static string DatabaseUser => Env.GetString("DB_USER");
		public static string DatabasePassword => Env.GetString("DB_PASSWORD");
		public static string DatabasePort => Env.GetString("DB_PORT");



		public static string GetConnectionString()
		{
			return $"Server={DatabaseServer};Port={DatabasePort};Database={DatabaseName};Uid={DatabaseUser};Password={DatabasePassword};SslMode=None;CharSet=utf8mb4;ConnectionTimeout=15;DefaultCommandTimeout=30;";
		}
	}
}
