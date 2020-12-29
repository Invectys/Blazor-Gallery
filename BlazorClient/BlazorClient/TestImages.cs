using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BlazorClient
{
    public class TestImages
    {

        public List<byte[]> Loaded => _images;

        private List<byte[]> _images = new List<byte[]>();

        private int _lastImageInd = 9;
        private HttpClient _client;

        public TestImages(HttpClient client)
        {
            _client = client;
        }

        public async Task LoadImages()
        {
            
            for(int i = 1; i <= _lastImageInd; i++)
            {
                var result = await _client.GetAsync("/TestImages/" + i + ".jpg");
                var bytes = await result.Content.ReadAsByteArrayAsync();
                _images.Add(bytes);
            }

        }


    }
}
