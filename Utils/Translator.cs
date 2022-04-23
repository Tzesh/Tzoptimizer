using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows;

namespace Tzoptimizer.Utils
{
    internal class Translator
    {
        public static string TranslateViaGoogle(string text, string lang)
        {
            string fromLang = "en";
            string url = $"https://translate.googleapis.com/translate_a/single?client=gtx&sl={fromLang}&tl={lang}&dt=t&q={HttpUtility.UrlEncode(text)}";
            WebClient webClient = new WebClient
            {
                Encoding = System.Text.Encoding.UTF8
            };
            string result = webClient.DownloadString(url);
            try
            {
                result = result.Substring(4, result.IndexOf("\"", 4, StringComparison.Ordinal) - 4);
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during translation process: \n" + ex.ToString(), "Tzoptimizer - Translation Service", MessageBoxButton.OK, MessageBoxImage.Error);
                return string.Empty;
            }
        }
    }
}
