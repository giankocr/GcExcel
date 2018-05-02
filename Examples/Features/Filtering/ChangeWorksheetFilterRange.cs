﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GrapeCity.Documents.Excel.Examples.Features.Filtering
{
    public class ChangeWorksheetFilterRange : ExampleBase
    {
        public override void Execute(GrapeCity.Documents.Excel.Workbook workbook)
        {
            IWorksheet worksheet = workbook.Worksheets[0];

            worksheet.Range["D3"].Value = "Numbers";
            worksheet.Range["D4"].Value = 1;
            worksheet.Range["D5"].Value = 2;
            worksheet.Range["D6"].Value = 3;

            //first time invoke. worksheet's filter range will be D3:D6.
            worksheet.Range["D3:D6"].AutoFilter(0, "<>2");

            //set AutoFilterMode to false. must set this property before, otherwise, subsequent code can not take effort.
            worksheet.AutoFilterMode = false;

            worksheet.Range["A5"].Value = "Numbers";
            worksheet.Range["A6"].Value = 1;
            worksheet.Range["A7"].Value = 2;
            worksheet.Range["A8"].Value = 3;

            //second time invoke. worksheet's filter range will change to A5:A8.
            worksheet.Range["A5:A8"].AutoFilter(0, "<>2");
        }
    }
}
