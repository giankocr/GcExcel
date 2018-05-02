﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GrapeCity.Documents.Excel.Examples.Features.Tables
{
    public class RemoveTable : ExampleBase
    {
            public override void Execute(GrapeCity.Documents.Excel.Workbook workbook)
            {
                object[,] data = new object[,]{
                    {"Name", "City", "Birthday", "Sex", "Weight", "Height"},
                    {"Bob", "NewYork", new DateTime(1968, 6, 8), "male", 80, 180},
                    {"Betty", "NewYork", new DateTime(1972, 7, 3), "female", 72, 168},
                    {"Gary", "NewYork", new DateTime(1964, 3, 2), "male", 71, 179},
                    {"Hunk", "Washington", new DateTime(1972, 8, 8), "male", 80, 171},
                    {"Cherry", "Washington", new DateTime(1986, 2, 2), "female", 58, 161},
                    { "Eva", "Washington", new DateTime(1993, 2, 15), "female", 71, 180}
                };

                IWorksheet worksheet = workbook.Worksheets[0];
                worksheet.Range["A1:F7"].Value = data;

                //add table.
                ITable table = worksheet.Tables.Add(worksheet.Range["A1:F7"], true);

                //remove table
                table.Delete();

            }
    }
}
