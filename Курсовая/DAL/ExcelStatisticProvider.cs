using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;

namespace DAL
{
    public class ExcelStatisticProvider
    {
        public static bool CopySub()
        {
            try
            {
                var package = new ExcelPackage();
                string path = "Print.xlsx";
                Base b = new Base();
                    var table = package.Workbook.Worksheets.Add("Sheet1");
                    for (int i = 0; i < b.num; i++)
                    {
                        table.Cells[i + 1, 1].Value = b.BName(i);
                        table.Cells[i + 1, 2].Value = b.BPage(i);
                    }
                    table.Column(1).AutoFit();
                    table.Column(2).AutoFit();
                    package.SaveAs(new FileInfo(path));
                return true;
            }
            catch 
            {
                return false;
            }
        }
    }
}
