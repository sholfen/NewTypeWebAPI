using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace UtilitiesClassLibrary.Utilities
{
    public class XMLHelper
    {
        /// <summary>
        /// 將物件序列化並寫入到 XML 檔案。
        /// </summary>
        /// <typeparam name="T">物件型別</typeparam>
        /// <param name="data">要寫入的物件</param>
        /// <param name="filePath">XML 檔案路徑</param>
        /// <param name="encoding">文字編碼，預設 UTF-8</param>
        public static void Save<T>(T data, string filePath, Encoding? encoding = null)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            encoding ??= new UTF8Encoding(false);

            var serializer = new XmlSerializer(typeof(T));

            // 確保目錄存在
            var directory = Path.GetDirectoryName(filePath);
            if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
                
            // 寫入 XML 檔
            using var writer = new StreamWriter(filePath, false, encoding);
            serializer.Serialize(writer, data);
        }

        /// <summary>
        /// 從 XML 檔案讀取並轉成物件。
        /// </summary>
        /// <typeparam name="T">目標物件型別</typeparam>
        /// <param name="filePath">XML 檔案路徑</param>
        /// <param name="defaultValue">若檔案不存在或錯誤，回傳的預設值</param>
        /// <returns>物件實例</returns>
        public static T Load<T>(string filePath, T? defaultValue = default)
        {
            if (!File.Exists(filePath))
            {
                return defaultValue!;
            }
                

            try
            {
                var serializer = new XmlSerializer(typeof(T));
                using var reader = new StreamReader(filePath);
                return (T)serializer.Deserialize(reader)!;
            }
            catch (Exception)
            {
                return defaultValue!;
            }
        }

        /// <summary>
        /// 將物件轉換為 XML 字串。
        /// </summary>
        public static string ToXmlString<T>(T data, Encoding? encoding = null)
        {
            encoding ??= new UTF8Encoding(false);
            var serializer = new XmlSerializer(typeof(T));

            using var memoryStream = new MemoryStream();
            using (var writer = new StreamWriter(memoryStream, encoding))
            {
                serializer.Serialize(writer, data);
            }

            return encoding.GetString(memoryStream.ToArray());
        }

        /// <summary>
        /// 將 XML 字串轉換為物件。
        /// </summary>
        public static T? FromXmlString<T>(string xml)
        {
            if (string.IsNullOrWhiteSpace(xml))
            {
                return default;
            }

            var serializer = new XmlSerializer(typeof(T));
            using var reader = new StringReader(xml);
            return (T?)serializer.Deserialize(reader);
        }
    }
}

