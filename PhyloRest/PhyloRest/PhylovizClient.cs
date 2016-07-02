using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PhyloRest
{
    public static class PhylovizClient
    {
        private static string currentRoot = "https://online.phyloviz.net";
        private static CookieContainer cookies = new CookieContainer();

        private static StreamContent AddContent(Stream stream, string filename)
        {
            var fileContent = new StreamContent(stream);
            fileContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
            {
                Name = "\"" + filename + "\"",
                FileName = "\"" + filename + "\""
            };
            fileContent.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
            return fileContent;
        }
        private static StringContent addContent(string name, string content)
        {
            var fileContent = new StringContent(content);
            fileContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
            {
                Name = "\"" + name + "\""
            };
            return fileContent;
        }

        public static async Task<string> Login(string login, string pass)
        {
            var resultString = "";
            using (var handler = new HttpClientHandler())
            {
                handler.CookieContainer = cookies;
                using (var client = new HttpClient(handler))
                {
                    var requestContent = new FormUrlEncodedContent(new[] {
                        new KeyValuePair<string, string>("username", login),
                        new KeyValuePair<string, string>("password", pass)
                    });
                    try
                    {
                        var response = await client.PostAsync(currentRoot + @"/users/api/login", requestContent);

                        HttpContent responseContent = response.Content;
                        using (var reader = new StreamReader(await responseContent.ReadAsStreamAsync()))
                        {
                            resultString = await reader.ReadToEndAsync();
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
            return resultString;
        }

        public static async Task<string> Upload(string login, string pass, string profile, string meta)
        {
            var datasetId = "";
            using (var handler = new HttpClientHandler())
            {
                handler.CookieContainer = cookies;
                using (var client = new HttpClient(handler))
                {
                    using (var content = new MultipartFormDataContent())
                    {
                        content.Add(addContent("datasetName", "test" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + "_" + DateTime.Now.Ticks.ToString()));
                        content.Add(addContent("dataset_description", "newdescription"));
                        content.Add(addContent("makePublic", "false"));

                        content.Add(AddContent(new FileStream(profile, FileMode.Open), "fileProfile"));
                        content.Add(AddContent(new FileStream(meta, FileMode.Open), "fileMetadata"));
                        content.Add(addContent("numberOfFiles", "2"));

                        try
                        {
                            var response = await client.PostAsync(new Uri(currentRoot + @"/api/db/postgres/upload"), content);

                            HttpContent responseContent = response.Content;
                            using (var reader = new StreamReader(await responseContent.ReadAsStreamAsync()))
                            {
                                var result = await reader.ReadToEndAsync();
                                dynamic json = JObject.Parse(result);
                                datasetId = json.datasetID;
                            }
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }
                }
            }
            return datasetId;
        }

        public static async Task<string> MakeVisible(string datasetId)
        {
            var result = "";
            using (var handler = new HttpClientHandler())
            {
                handler.CookieContainer = cookies;
                using (var client = new HttpClient(handler))
                {
                    var requestContent = new FormUrlEncodedContent(new[] {
                        new KeyValuePair<string, string>("dataset_id", datasetId),
                        new KeyValuePair<string, string>("change", "true")
                    });
                    try
                    {
                        var response = await client.PutAsync(currentRoot + @"/api/db/postgres/update/all/is_public", requestContent);

                        HttpContent responseContent = response.Content;
                        using (var reader = new StreamReader(await responseContent.ReadAsStreamAsync()))
                        {
                            result = await reader.ReadToEndAsync();
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
            return result;
        }

        public static async Task<string> GoeBurst(string dataset)
        {
            var datasetId = "";
            using (var handler = new HttpClientHandler())
            {
                handler.CookieContainer = cookies;
                using (var client = new HttpClient(handler))
                {
                    try
                    {
                        var response = await client.GetAsync(new Uri(currentRoot + @"/api/algorithms/goeBURST?dataset_id=" + dataset + @"&save=true"));

                        HttpContent responseContent = response.Content;
                        using (var reader = new StreamReader(await responseContent.ReadAsStreamAsync()))
                        {
                            var result = await reader.ReadToEndAsync();
                            dynamic json = JObject.Parse(result);
                            datasetId = json.datasetID;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
            return datasetId;
        }

        public static async Task<string> MakeLink(string dataset)
        {
            var link = "";

            using (var handler = new HttpClientHandler())
            {
                handler.CookieContainer = cookies;
                using (var client = new HttpClient(handler))
                {
                    try
                    {
                        var response = await client.GetAsync(new Uri(currentRoot + @"/api/utils/publiclink?dataset_id=" + dataset));

                        HttpContent responseContent = response.Content;
                        using (var reader = new StreamReader(await responseContent.ReadAsStreamAsync()))
                        {
                            var result = await reader.ReadToEndAsync();
                            dynamic json = JObject.Parse(result);
                            link = json.url;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
            return link;
        }

    }
}
