using ClosedXML.Excel;
using Finalproject.Data;
using Finalproject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Finalproject.Areas.admin.Controllers
{
    [Area("admin")]
    [Authorize]
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            List<Contact> model = _context.Contacts.ToList();



            HttpContext.Session.SetString("Contact", JsonConvert.SerializeObject(model));
            return View(model);
        }
        public IActionResult Message()
        {
            return View(_context.Contacts.ToList());
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contacts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contact == null)
            {
                return NotFound();
            }

            return View(contact);
        }

        public IActionResult Delete(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            Contact message = _context.Contacts.Find(id);


            if (message == null)
            {
                return NotFound();
            }
            _context.Contacts.Remove(message);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult DownloadToExcel()
        {
            string modelString = HttpContext.Session.GetString("Contact");
            List<Contact> model = JsonConvert.DeserializeObject<List<Contact>>(modelString);

            var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("Contact List");

            ws.Row(1).Height = 4;
            ws.Row(2).Height = 30;
            ws.Row(3).Height = 25;

            ws.Column("A").Width = 0.4;
            ws.Column("B").Width = 6;
            ws.Column("C").Width = 20;
            ws.Column("D").Width = 25;
            ws.Column("E").Width = 70;
            ws.Column("F").Width = 20;

            ws.Column("E").Style.Alignment.WrapText = true;

            ws.Range("B2:F2").Merge().Value = "Contact list";
            ws.Range("B2:F2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            ws.Range("B2:F2").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            ws.Range("B2:F2").Style.Font.FontSize = 14;
            ws.Range("B2:F2").Style.Font.SetBold();

            //ws.Range("B2:F2").Value = "Message list";

            ws.Range("B3:F3").Style.Fill.BackgroundColor = XLColor.FromArgb(0, 120, 120);
            ws.Range("B3:F3").Style.Font.FontColor = XLColor.White;
            ws.Range("B3:F3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            ws.Range("B3:F3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            ws.Range("B3:F3").Style.Font.FontSize = 14;

            ws.Cell("B3").Value = "#";
            ws.Cell("B3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("B3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("B3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("B3").Style.Border.RightBorder = XLBorderStyleValues.Thin;

            ws.Cell("C3").Value = "Email";
            ws.Cell("C3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("C3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("C3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("C3").Style.Border.RightBorder = XLBorderStyleValues.Thin;

            ws.Cell("D3").Value = "Name";
            ws.Cell("D3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("D3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("D3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("D3").Style.Border.RightBorder = XLBorderStyleValues.Thin;

            ws.Cell("E3").Value = "Content";
            ws.Cell("E3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("E3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("E3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("E3").Style.Border.RightBorder = XLBorderStyleValues.Thin;

            ws.Cell("F3").Value = "Date";
            ws.Cell("F3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Cell("F3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("F3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("F3").Style.Border.RightBorder = XLBorderStyleValues.Thin;

            for (int i = 0; i < model.Count; i++)
            {

                ws.Range($"B{i + 4}:F{i + 4}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                ws.Range($"B{i + 4}:F{i + 4}").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

                ws.Cell($"B{i + 4}").Value = (i + 1);
                ws.Cell($"B{i + 4}").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell($"B{i + 4}").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell($"B{i + 4}").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell($"B{i + 4}").Style.Border.RightBorder = XLBorderStyleValues.Thin;

                ws.Cell($"C{i + 4}").Value = model[i].Email;
                ws.Cell($"C{i + 4}").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell($"C{i + 4}").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell($"C{i + 4}").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell($"C{i + 4}").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell($"C{i + 4}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;

                ws.Cell($"D{i + 4}").Value = model[i].Name;
                ws.Cell($"D{i + 4}").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell($"D{i + 4}").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell($"D{i + 4}").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell($"D{i + 4}").Style.Border.RightBorder = XLBorderStyleValues.Thin;

                ws.Cell($"E{i + 4}").Value = model[i].Destiraction;
                ws.Cell($"E{i + 4}").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell($"E{i + 4}").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell($"E{i + 4}").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell($"E{i + 4}").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell($"E{i + 4}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;

                ws.Cell($"F{i + 4}").Value = model[i].CreatedDate;
                ws.Cell($"F{i + 4}").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell($"F{i + 4}").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell($"F{i + 4}").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell($"F{i + 4}").Style.Border.RightBorder = XLBorderStyleValues.Thin;
            }

            using (var stream = new MemoryStream())
            {
                wb.SaveAs(stream);
                var content = stream.ToArray();

                return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Contact List.xlsx");
            }
        }

    }
}