using System;
using System.Collections.Generic;
#if NETCOREAPP2_0
using System.Data.Common;
#else
using System.Data.OleDb;
#endif
using System.IO;
using System.Text;

namespace NHapi.Base.SourceGeneration
{
	public class EventMappingGenerator
	{
		public static void makeAll(String baseDirectory, String version)
		{
			//make base directory
			if (!(baseDirectory.EndsWith("\\") || baseDirectory.EndsWith("/")))
			{
				baseDirectory = baseDirectory + "/";
			}
			FileInfo targetDir =
				SourceGenerator.makeDirectory(baseDirectory + PackageManager.GetVersionPackagePath(version) + "EventMapping");

			//get list of data types
			DbConnection conn = NormativeDatabase.Instance.Connection;
			String sql =
				"SELECT * from HL7EventMessageTypes inner join HL7Versions on HL7EventMessageTypes.version_id = HL7Versions.version_id where HL7Versions.hl7_version = '" +
				version + "'";
#if NETCOREAPP2_0
			DbCommand temp_DbCommand = conn.CreateCommand();
#else
			DbCommand temp_DbCommand = new DbCommand();
			temp_DbCommand.Connection = conn;
#endif
			temp_DbCommand.CommandText = sql;
			DbDataReader rs = temp_DbCommand.ExecuteReader();


			using (StreamWriter sw = new StreamWriter(targetDir.FullName + @"\EventMap.properties", false))
			{
				sw.WriteLine("#event -> structure map for " + version);
				while (rs.Read())
				{
					string messageType = string.Format("{0}_{1}", rs["message_typ_snd"], rs["event_code"]);
					string structure = (string) rs["message_structure_snd"];

					sw.WriteLine(string.Format("{0} {1}", messageType, structure));
				}
			}
		}
	}
}