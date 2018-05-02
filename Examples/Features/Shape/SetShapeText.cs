﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GrapeCity.Documents.Excel.Examples.Features.Shape
{
    public class SetShapeText : ExampleBase
    {
        public override void Execute(GrapeCity.Documents.Excel.Workbook workbook)
        {
            IWorksheet worksheet = workbook.Worksheets[0];
            GrapeCity.Documents.Excel.Drawing.IShape shape = worksheet.Shapes.AddShape(GrapeCity.Documents.Excel.Drawing.AutoShapeType.Heart, 1, 1, 100, 100);
            shape.Width = 300;
            shape.Height = 200;

            shape.TextFrame.TextRange.Font.Color.RGB = GrapeCity.Documents.Excel.Color.FromRGB(0, 255, 0);
            shape.TextFrame.TextRange.Font.Bold = true;
            shape.TextFrame.TextRange.Font.Italic = true;
            shape.TextFrame.TextRange.Font.Size = 20;
            shape.TextFrame.TextRange.Font.Strikethrough = true;

            shape.TextFrame.TextRange.Paragraphs.Add("This is a heart shape.");
            shape.TextFrame.TextRange.Paragraphs.Add("My name is XXX");
            shape.TextFrame.TextRange.Paragraphs[1].Runs.Add("Hello World!");

            shape.TextFrame.TextRange.Paragraphs[1].Runs[0].Font.Strikethrough = false;
            shape.TextFrame.TextRange.Paragraphs[1].Runs[0].Font.Size = 35;
        }

        public override bool ShowViewer
        {
            get
            {
                return false;
            }
        }

        public override bool ShowScreenshot
        {
            get
            {
                return true;
            }
        }
    }
}
