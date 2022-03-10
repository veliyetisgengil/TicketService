using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace TicketService.Helper.Utilites
{
    public static class XmlParser
    {
		public static T DeserializeObject<T>(string xml) where T : new()
		{
			if (string.IsNullOrEmpty(xml))
			{
				return new T();
			}
			try
			{
				using (var stringReader = new StringReader(xml))
				{
					var serializer = new XmlSerializer(typeof(T));
					return (T)serializer.Deserialize(stringReader);
				}
			}
			catch (Exception ex)
			{
				return new T();
			}
		}

		public static string Serialize<T>(this T value)
		{
			if (value == null)
			{
				return string.Empty;
			}
			try
			{
				var xmlserializer = new XmlSerializer(typeof(T));
				var stringWriter = new StringWriter();
				using (var writer = XmlWriter.Create(stringWriter))
				{
					xmlserializer.Serialize(writer, value);
					return stringWriter.ToString();
				}
			}
			catch (Exception ex)
			{
				throw new Exception("An error occurred", ex);
			}
		}
	}
}
