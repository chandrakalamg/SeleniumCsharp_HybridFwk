using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridFwk_POM_SeleniumProject.util
{
    public class CSVReader
    {
        public static IEnumerable<Dictionary<string, string>> Read(string fileName)
        {
            //var filePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);
            var solutionDir = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            var filePath = Path.Combine(solutionDir, @"Testdata\" + fileName);
            
            var lines = File.ReadAllLines(filePath);
            
            var headers = lines[0].Split(',').Select(header => header.Trim()).ToList();
            return lines.Skip(1)
                .Select(line =>
                {
                    var values = line.Split(',')
                        .Select(value => value.Trim())
                        .ToList();
                    return headers.Zip(values, (header, value) => new { header, value })
                        .ToDictionary(input => input.header, input => input.value);
                });
        }
    }
}
