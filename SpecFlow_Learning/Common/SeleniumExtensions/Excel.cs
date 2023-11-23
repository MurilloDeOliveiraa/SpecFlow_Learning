using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.Office.Interop.Excel;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlow_Learning.Common.SeleniumExtensions
{
    public class Excel
    {
        public void AccessTemplate(string templateName, Table infos)
        {
            try
            {

                Random rd = new Random();
                string fileNameRoot = Path.GetFileNameWithoutExtension(templateName);
                string fileExtension = Path.GetExtension(templateName);
                //renomeando o arquivo, adicionando o horário atual
                string newFile = fileNameRoot+"_"+DateTime.UtcNow.Day+DateTime.UtcNow.Month+DateTime.UtcNow.Year+"_"+rd.Next(Int32.MaxValue)+fileExtension;                

                string fullPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                string solutionPath = Directory.GetParent(fullPath).Parent.FullName;
                string templatesPath = solutionPath + "\\Templates\\";
                string currentTemplatePath = solutionPath + "\\Templates\\" + templateName;

                //Comandos Excel
                Application excel = new Application();
                Workbook wb;
                Worksheet ws;
                
                wb = excel.Workbooks.Open(currentTemplatePath);
                ws = excel.Worksheets[1];

                Range cellRange = ws.Range["A2:A2"];
                cellRange.Value = infos.Rows.ElementAt(0).Value();
                Range cellRange2 = ws.Range["B2:B2"];
                cellRange2.Value = infos.Rows.ElementAt(1).Value();
                Range cellRange3 = ws.Range["C2:C2"];
                cellRange3.Value = infos.Rows.ElementAt(2).Value();

                string newFileLocal = Path.Combine(templatesPath, newFile);
                wb.SaveAs(newFileLocal);               
                wb.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
       
    }
}
