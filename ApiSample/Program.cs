#region License

// Distributed under the MIT License
// ============================================================
// Copyright (c) 2019 Hotcakes Commerce, LLC
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software 
// and associated documentation files (the "Software"), to deal in the Software without restriction, 
// including without limitation the rights to use, copy, modify, merge, publish, distribute, 
// sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is 
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or 
// substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR 
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE 
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN 
// THE SOFTWARE.

#endregion

using System;
using Hotcakes.CommerceDTO.v1.Client;

namespace ApiSample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
      
            var url = string.Empty;
            var key = string.Empty;

            

            if (url == string.Empty) url = "http://20.234.113.211:8101/";
            if (key == string.Empty) key = "1-cc3cd448-3f46-40e8-9159-3907be066ba6";

            var proxy = new Api(url, key);

            var snaps = proxy.ProductsFindAll();
            if (snaps.Content != null)
            {
             
                for (var i = 0; i < 100; i++)
                {
                    if (i < snaps.Content.Count)
                    {
                        string nev = snaps.Content[i].ProductName;
                        decimal ar = snaps.Content[i].SitePrice;

                        Console.WriteLine(i + ") " + nev + " [" + Decimal.Round(ar) + " Ft" + "]");
                    }
                }
            }

            
            Console.ReadKey();
        }
    }
}